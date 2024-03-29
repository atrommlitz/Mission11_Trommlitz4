using Microsoft.EntityFrameworkCore;

namespace Mission11_Trommlitz.Models;

public class EFBookRepository : IBookRepository
{
    private BookstoreContext _context;

    public EFBookRepository(BookstoreContext temp)
    {
        _context = temp;
    }

    public IQueryable<Book> Books => _context.Books;
    
    public async Task<(IEnumerable<Book> Books, int TotalCount)> GetBooksPageAsync(int pageIndex, int pageSize)
    {
        var query = Books; // Use the existing IQueryable<Book>
        int totalCount = await query.CountAsync();
        var booksPage = await query.OrderBy(b => b.Title) // Make sure to order
            .Skip((pageIndex - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
        
        return (booksPage, totalCount);
    }
}