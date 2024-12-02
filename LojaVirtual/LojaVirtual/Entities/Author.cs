

namespace LojaVirtual.Entities;

public class Author : IEntity
{
    public Guid Id { get; set; }
    public DateTimeOffset CreateDate { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Description { get; set; }

    
}