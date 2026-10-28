using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace PropertyDemo.Models;

public class Property
{
    public int Id { get; set; }

    [Required]
    [StringLength(150)]
    public string Name { get; set; } = string.Empty;

    [Required]
    [StringLength(100)]
    public string Location { get; set; } = string.Empty;

    [Range(0, 1000000000)]
    [Precision(18, 2)]
    public decimal Price { get; set; }
}
