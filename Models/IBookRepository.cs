namespace Mission11_Trommlitz.Models;

public interface IBookRepository
{
    Task<(IEnumerable<Book> Books, int TotalCount)> GetBooksPageAsync(int pageIndex, int pageSize);
}
