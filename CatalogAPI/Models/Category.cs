﻿using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace CatalogAPI.Models;

public class Category
{
    public Category()
    {
        Products = new Collection<Product>();
    }
    [Key]
    public int Id { get; set; }
    [Required]
    [StringLength(80)]
    public string? Name { get; set; }
    [Required]
    [StringLength(300)]
    public string? Description { get; set; }
    [Required]
    [StringLength(300)]
    public string? ImageUrl { get; set; }
    public ICollection<Product>? Products { get; set; }
}

