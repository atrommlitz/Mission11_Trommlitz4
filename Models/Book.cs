using System;
using System.Collections.Generic;

namespace Mission11_Trommlitz.Models;

public partial class Book
{
    public int BookId { get; set; }

    public required string Title { get; set; } = null!;

    public required string Author { get; set; } = null!;

    public required string Publisher { get; set; } = null!;

    public required string Isbn { get; set; } = null!;

    public required string Classification { get; set; } = null!;

    public required string Category { get; set; } = null!;

    public required int PageCount { get; set; }

    public required double Price { get; set; }
}
