using TastyEatsBD.Core.Interfaces;

namespace TastyEatsBD.WebApp.Services.Storage;

public class LocalDriveStorageService : IFileService
{
    private readonly string _baseDirectory;

    public LocalDriveStorageService(IConfiguration configuration)
    {
        _baseDirectory = configuration.GetValue<string>("FileStorage:LocalDrivePath");
    }

    public async Task<string> UploadFileAsync(Stream fileStream, string fileName)
    {
        // Create a folder path based on the current date
        var dateFolder = DateTime.UtcNow.ToString("MM-dd-yyyy");
        var folderPath = Path.Combine(_baseDirectory, dateFolder);

        // Ensure the datewise folder exists
        if (!Directory.Exists(folderPath))
        {
            Directory.CreateDirectory(folderPath);
        }

        // Create a unique file name to avoid overwriting
        var uniqueFileName = Guid.NewGuid().ToString() + Path.GetExtension(fileName);
        var filePath = Path.Combine(folderPath, uniqueFileName);

        // Save the file to the specified path
        using (var stream = new FileStream(filePath, FileMode.Create))
        {
            await fileStream.CopyToAsync(stream);
        }

        return filePath; // Return the path where the file is saved
    }

    public async Task<bool> DeleteFileAsync(string filePath)
    {
        if (File.Exists(filePath))
        {
            File.Delete(filePath);
            return true;
        }
        return false;
    }

    public async Task<Stream> GetFileStreamAsync(string filePath)
    {
        if (File.Exists(filePath))
        {
            return new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read);
        }
        return null;
    }

    public async Task<byte[]> GetFileAsync(string filePath)
    {
        await Task.Delay(1000);
        if (File.Exists(filePath))
        {
            return await File.ReadAllBytesAsync(filePath);
        }
        return null;
    }

    public async Task<bool> FileExistsAsync(string filePath)
    {
        return File.Exists(filePath);
    }
}
