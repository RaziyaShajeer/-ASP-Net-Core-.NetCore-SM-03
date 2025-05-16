using LibraryManagement.Data;
using LibraryManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagement.Controllers
{
    public class BooksController : Controller
    {
        private readonly AppDbContext _context;
        public BooksController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Books.ToListAsync());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Book book)
        {
            if (ModelState.IsValid)
            {
                _context.Books.Add(book);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(book);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var book = await _context.Books.FindAsync(id);
            if (book == null) return NotFound();
            return View(book);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Book book)
        {
            if (ModelState.IsValid)
            {
                _context.Update(book);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(book);
        }

        public async Task<IActionResult> Details(int id)
        {
            var book = await _context.Books.FirstOrDefaultAsync(b => b.Id == id);
            if (book == null) return NotFound();
            return View(book);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var book = await _context.Books.FindAsync(id);
            if (book == null) return NotFound();
            return View(book);
        }

        [HttpPost]
        public async Task<IActionResult> Deletee(int id)
        {
            var book = await _context.Books.FindAsync(id);
            _context.Books.Remove(book);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
