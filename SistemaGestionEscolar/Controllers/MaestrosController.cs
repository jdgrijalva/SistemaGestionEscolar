
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaGestionEscolar.Models;

public class MaestrosController : Controller
{
    private readonly SistemaGestionEscolarContext _context;

    public MaestrosController(SistemaGestionEscolarContext context)
    {
        _context = context;
    }

    // GET: Maestros
    public async Task<IActionResult> Index()
    {
        return View(await _context.Maestro.ToListAsync());
    }

    // GET: Maestros/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var maestro = await _context.Maestro
            .FirstOrDefaultAsync(m => m.maestroId == id);

        if (maestro == null)
        {
            return NotFound();
        }

        return View(maestro);
    }

    // GET: Maestros/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: Maestros/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("maestroId,maestroNombre,maestroApellido,maestroEspecialidad")] Maestro maestro)
    {
        if (ModelState.IsValid)
        {
            _context.Add(maestro);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        return View(maestro);
    }

    // GET: Maestros/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var maestro = await _context.Maestro.FindAsync(id);

        if (maestro == null)
        {
            return NotFound();
        }

        return View(maestro);
    }

    // POST: Maestros/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? id, [Bind("maestroId,maestroNombre,maestroApellido,maestroEspecialidad")] Maestro maestro)
    {
        if (id != maestro.maestroId)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(maestro);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MaestroExists(maestro.maestroId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToAction(nameof(Index));
        }

        return View(maestro);
    }

    // GET: Maestros/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var maestro = await _context.Maestro
            .FirstOrDefaultAsync(m => m.maestroId == id);

        if (maestro == null)
        {
            return NotFound();
        }

        return View(maestro);
    }

    // POST: Maestros/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var maestro = await _context.Maestro.FindAsync(id);

        if (maestro != null)
        {
            _context.Maestro.Remove(maestro);
            await _context.SaveChangesAsync();
        }

        return RedirectToAction(nameof(Index));
    }

    private bool MaestroExists(int? id)
    {
        return _context.Maestro.Any(e => e.maestroId == id);
    }
}
