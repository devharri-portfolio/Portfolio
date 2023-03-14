namespace PortfolioUI.Models;
using System.ComponentModel.DataAnnotations;

public class ContactFormModel
{
    [Required]
    public string? FirstName { get; set; }
    [Required]
    public string? LastName { get; set; }
    [Required]
    public string? Message { get; set; }
    [Required]
    public string? Token { get; set; }
}