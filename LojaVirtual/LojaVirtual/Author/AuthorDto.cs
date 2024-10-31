using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace LojaVirtual.Author;

public class AuthorDto
{
    [Required]
    public string Name { get; set; }
    [Required]
    public string Email { get; set; }
    [Required]
    [MaxLength(400)]
    public string Description { get; set; }
    public DateTimeOffset CreatedAt => DateTimeOffset.Now;
}