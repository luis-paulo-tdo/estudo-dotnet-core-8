namespace Projeto_06_ApiCatalogo.Models;

public class Categoria
{
    public int CategoriaId { get; set; }
    public string? Nome { get; set; }
    public string? ImageUrl { get; set; }
    public ICollection<Produto>? Produtos { get; set; }
}
