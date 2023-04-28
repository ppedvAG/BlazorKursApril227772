using System;
using System.Collections.Generic;

namespace BlazorKursApril227772.Models;

public partial class ProductsAboveAveragePrice
{
    public string ProductName { get; set; } = null!;

    public decimal? UnitPrice { get; set; }
}
