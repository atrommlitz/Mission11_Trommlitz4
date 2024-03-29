using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission11_Trommlitz.Models;

namespace Mission11_Trommlitz.Controllers;

public class HomeController : Controller
{
    private IBookRepository _repo;
    private const int PageSize = 10;

    public HomeController(IBookRepository temp)
    {
        _repo = temp;
    }

    public async Task<IActionResult> Index(int page = 1)
    {
        var (books, totalCount) = await _repo.GetBooksPageAsync(page, PageSize);

        var viewModel = new BookListViewModel()
        {
            Books = books,
            CurrentPage = page,
            TotalPages = (int)Math.Ceiling((double)totalCount / PageSize)
        };

        return View(viewModel);
    }
}