using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Models;

public class Filme
{
    [Key]
    [Required]
    public int Id { get; set; }
    [Required(ErrorMessage ="Campo obrigatório")]
    public string Titulo { get; set; }
    
    [Required(ErrorMessage = "Campo obrigatório")]
    [MaxLength(50, ErrorMessage ="O tamanho do gênero não pode exceder 50 caracteres")]
    public string Genero { get; set; }
    
    [Required(ErrorMessage = "Campo obrigatório")]
    [Range(70, 600, ErrorMessage ="A duração deve ser entre 70 e 600 minutos")]
    public int Duracao { get; set; }
}
