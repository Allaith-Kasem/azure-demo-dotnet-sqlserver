using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PropertyDemo.Data;
using PropertyDemo.Models;

namespace PropertyDemo.Controllers;

public class PropertiesController : Controller
{
    private readonly PropertyDbContext _context;

    public PropertiesController(PropertyDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var properties = await _context.Properties
            .AsNoTracking()
            .ToListAsync();

        return View(properties);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(Property property)
    {
        if (!ModelState.IsValid)
            return View(property);

        _context.Properties.Add(property);
        await _context.SaveChangesAsync();

        return RedirectToAction(nameof(Index));
    }
}
