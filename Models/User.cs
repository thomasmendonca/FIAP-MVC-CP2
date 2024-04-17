using System.ComponentModel.DataAnnotations;

namespace FIAP_MVC.Models;

public class User
{
    [Key]
    public int id { get; set; }
    public string UserEmail { get; set; } = string.Empty;
    public string UserPassword { get; set; } = string.Empty;
    public string UserPhone { get; set; } = string.Empty;
}