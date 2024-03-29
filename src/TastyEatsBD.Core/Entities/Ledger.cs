﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TastyEatsBD.Core.Entities;

public class Ledger : EntityBase
{
    [Required(ErrorMessage = "Account Id is required")]
    [Display(Name = "Account Id")]
    public int AccountId { get; set; }

    [DeleteBehavior(DeleteBehavior.NoAction)]
    public virtual Account? Account { get; set; }

    [Required(ErrorMessage = "Amount is required")]
    [DataType(DataType.Currency)]
    [Column(TypeName = "decimal(19, 4)")]
    [Display(Name = "Amount")]
    public decimal Amount { get; set; }

    [StringLength(20, ErrorMessage = "Transaction type must be less than {1} characters")]
    [Display(Name = "Transaction Type")]
    public string TransactionType { get; set; }

    [StringLength(50, ErrorMessage = "Reference Id must be less than {1} characters")]
    [Display(Name = "Reference Id")]
    public string ReferenceId { get; set; }

    [StringLength(100, ErrorMessage = "Description must be less than {1} characters")]
    [Display(Name = "Description")]
    public string? Description { get; set; }
}
