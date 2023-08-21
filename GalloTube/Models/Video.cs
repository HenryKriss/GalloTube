using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GalloTube.Models;

[Table("Video")]
public class Video
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Display(Name = "Nome")]
    [Required(ErrorMessage = "O Nome é obrigatório")]
    [StringLength(100, ErrorMessage = "O Nome deve possuir no máximo 100 caracteres")]
    public string Name { get; set; }

    [Display(Name = "Descrição")]
    [Required(ErrorMessage = "A Descrição é obrigatória")]
    [StringLength(8000, ErrorMessage = "A Descrição deve possuir no máximo 5000 caracteres")]
    public string Description { get; set; }

    [Column(TypeName = "Data")]
    [Display(Name = "Data de Upload")]
    [Required(ErrorMessage = "A Data de Upload é obrigatória")]
    public DateTime UploadDate { get; set; }

    [Display(Name = "Duração (em minutos)")]
    [Required(ErrorMessage = "A Duração é obrigatória")]
    public Int16 Duration { get; set; }

    [StringLength(200)]
    [Display(Name = "Foto")]
    public string Thumbnail { get; set; }

    [Display(Name = "Arquivo do Video")]
    [Required(ErrorMessage = "O Arquivo do Vídeo é obrigatório")]
    public string VideoFile { get; set; }

    public ICollection<VideoTag> Videos { get; set; }
}
