using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FIAP_MVC.Models;

public class Avaliacao
{
    [Key]
    public int Id { get; set; }
    [ForeignKey("User")]
    
    public int UserId { get; set; }
    
    public string TituloDaAvaliacao { get; set; }
    
    public string Comentario { get; set; }
    
    public Aval UserAvaliacao { get; set; }
}