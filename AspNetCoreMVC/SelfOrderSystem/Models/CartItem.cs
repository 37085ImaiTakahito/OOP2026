using System.ComponentModel.DataAnnotations;

namespace SelfOrderSystem.Models;

public class CartItem {
    public int ProductId { get; set; }

    [Required]
    public string ProductName { get; set; } = string.Empty;

    [Range(typeof(decimal), "0.01", "999999.99")]
    public decimal UnitPrice { get; set; }

    [Range(1, 99)]
    public int Quantity { get; set; }

    public decimal LineTotal => UnitPrice * Quantity;
}