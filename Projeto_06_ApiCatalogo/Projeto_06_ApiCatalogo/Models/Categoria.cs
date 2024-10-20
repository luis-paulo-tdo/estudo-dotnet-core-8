﻿using System.Collections.ObjectModel;

namespace Projeto_06_ApiCatalogo.Models;

public class Categoria
{
    public Categoria()
    {
        Produtos = new Collection<Produto>();
    }

    public int CategoriaId { get; set; }
    public string? Nome { get; set; }
    public string? ImageUrl { get; set; }
    public ICollection<Produto>? Produtos { get; set; }
}
