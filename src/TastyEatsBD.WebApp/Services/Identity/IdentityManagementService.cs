using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.FluentUI.AspNetCore.Components;
using System.Text;
using System.Text.Encodings.Web;
using TastyEatsBD.Core.Entities;

namespace TastyEatsBD.WebApp.Services.Identity;

internal class IdentityManagementService
{
    private readonly IUserStore<AppIdentityUser> _userStore;
    private readonly UserManager<AppIdentityUser> _userManager;
    private readonly SignInManager<AppIdentityUser> _signInManager;
    private readonly IEmailSender<AppIdentityUser> _emailSender;
    private readonly ILogger<IdentityManagementService> _logger;
    private readonly NavigationManager _navigationManager;
    private readonly IdentityRedirectManager _redirectManager;
    private readonly IMessageService _messageService;
    private readonly IToastService _toastService;

    public IdentityManagementService(
        IUserStore<AppIdentityUser> userStore,
        UserManager<AppIdentityUser> userManager,
        SignInManager<AppIdentityUser> signInManager,
        IEmailSender<AppIdentityUser> emailSender,
        ILogger<IdentityManagementService> logger,
        NavigationManager navigationManager,
        IdentityRedirectManager redirectManager,
        IMessageService messageService,
        IToastService toastService)
    {
        _userStore = userStore;
        _userManager = userManager;
        _signInManager = signInManager;
        _emailSender = emailSender;
        _logger = logger;
        _navigationManager = navigationManager;
        _redirectManager = redirectManager;
        _messageService = messageService;
        _toastService = toastService;
    }

    public async Task CreateIdentityProfileAsync(AppIdentityUser user, string password, string role, string returnURL)
    {
        await _userStore.SetUserNameAsync(user, user.Email, CancellationToken.None);
        
        var emailStore = GetEmailStore();
        await emailStore.SetEmailAsync(user, user.Email, CancellationToken.None);

        var result = await _userManager.CreateAsync(user, password);
        if (!result.Succeeded)
        {
            await ShowIdentityErrorsAsync(result.Errors);
            return;
        }
        _logger.LogInformation("User created a new account with password.");

        result = await _userManager.AddToRoleAsync(user, role);
        if(!result.Succeeded)
        {
            await ShowIdentityErrorsAsync(result.Errors);
            return;
        }

        var userId = await _userManager.GetUserIdAsync(user);
        var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
        code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));

        var callbackUrl = _navigationManager.GetUriWithQueryParameters(
            _navigationManager.ToAbsoluteUri("Account/ConfirmEmail").AbsoluteUri,
            new Dictionary<string, object?> { ["userId"] = userId, ["code"] = code, ["returnUrl"] = returnURL }
        );

        await _emailSender.SendConfirmationLinkAsync(user, user.Email, HtmlEncoder.Default.Encode(callbackUrl));

        if (_userManager.Options.SignIn.RequireConfirmedAccount)
        {
            _redirectManager.RedirectTo(
                "Account/RegisterConfirmation",
                new() { ["email"] = user.Email, ["returnUrl"] = returnURL }
             );
        }

        await _signInManager.SignInAsync(user, isPersistent: false);
        ShowAccountCreatedAsync();
        _redirectManager.RedirectTo(returnURL);
    }

    private IUserEmailStore<AppIdentityUser> GetEmailStore()
    {
        if (!_userManager.SupportsUserEmail)
        {
            throw new NotSupportedException("The default UI requires a user store with email support.");
        }
        return (IUserEmailStore<AppIdentityUser>)_userStore;
    }

    private Task ShowIdentityErrorsAsync(IEnumerable<IdentityError> identityErrors)
    {
        var tasks = new List<Task>();
        foreach (var error in identityErrors)
        {
            tasks.Add(_messageService.ShowMessageBarAsync(options =>
            {
                options.Title = error.Code;
                options.Body = error.Description;
                options.Intent = MessageIntent.Error;
                options.Icon = new Icons.Regular.Size24.PersonCircle();
                options.ClearAfterNavigation = true;
                options.Section = "CreateAccount_Form";
            }));
        }
        return Task.WhenAll(tasks);
    }

    private void ShowAccountCreatedAsync()
    {
        _toastService.ShowSuccess("Account Successfully Created.");
    }

    private async Task CreateTestAccountAsync(AppIdentityUser user, string password, string role)
    {
        await _userStore.SetUserNameAsync(user, user.Email, CancellationToken.None);

        var emailStore = GetEmailStore();
        await emailStore.SetEmailAsync(user, user.Email, CancellationToken.None);

        var result = await _userManager.CreateAsync(user, password);
        if (!result.Succeeded)
        {
            await ShowIdentityErrorsAsync(result.Errors);
            return;
        }
        _logger.LogInformation("User created a new account with password.");

        result = await _userManager.AddToRoleAsync(user, role);
        if (!result.Succeeded)
        {
            await ShowIdentityErrorsAsync(result.Errors);
            return;
        }

        var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
        await _userManager.ConfirmEmailAsync(user, code);
    }
}
