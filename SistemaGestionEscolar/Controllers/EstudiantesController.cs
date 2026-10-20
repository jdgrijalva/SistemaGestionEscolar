
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaGestionEscolar.Models;

public class EstudiantesController : Controller
{
    private readonly SistemaGestionEscolarContext _context;

    public EstudiantesController(SistemaGestionEscolarContext context)
    {
        _context = context;
    }

    // GET: ESTUDIANTES
    public async Task<IActionResult> Index()    
    {
        return View(await _context.Estudiante.ToListAsync());
    }

    // GET: ESTUDIANTES/Details/5
    public async Task<IActionResult> Details(int? estudianteid)
    {
        if (estudianteid == null)
        {
            return NotFound();
        }

        var estudiante = await _context.Estudiante
            .FirstOrDefaultAsync(m => m.estudianteId == estudianteid);
        if (estudiante == null)
        {
            return NotFound();
        }

        return View(estudiante);
    }

    // GET: ESTUDIANTES/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: ESTUDIANTES/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("estudianteId,estudianteNombre,estudianteApellido,estudianteCurso")] Estudiante estudiante)
    {
        if (ModelState.IsValid)
        {
            _context.Add(estudiante);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(estudiante);
    }

    // GET: ESTUDIANTES/Edit/5
    public async Task<IActionResult> Edit(int? estudianteid)
    {
        if (estudianteid == null)
        {
            return NotFound();
        }

        var estudiante = await _context.Estudiante.FindAsync(estudianteid);
        if (estudiante == null)
        {
            return NotFound();
        }
        return View(estudiante);
    }

    // POST: ESTUDIANTES/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? estudianteid, [Bind("estudianteId,estudianteNombre,estudianteApellido,estudianteCurso")] Estudiante estudiante)
    {
        if (estudianteid != estudiante.estudianteId)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(estudiante);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EstudianteExists(estudiante.estudianteId))
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
        return View(estudiante);
    }

    // GET: ESTUDIANTES/Delete/5
    public async Task<IActionResult> Delete(int? estudianteid)
    {
        if (estudianteid == null)
        {
            return NotFound();
        }

        var estudiante = await _context.Estudiante
            .FirstOrDefaultAsync(m => m.estudianteId == estudianteid);
        if (estudiante == null)
        {
            return NotFound();
        }

        return View(estudiante);
    }

    // POST: ESTUDIANTES/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? estudianteid)
    {
        var estudiante = await _context.Estudiante.FindAsync(estudianteid);
        if (estudiante != null)
        {
            _context.Estudiante.Remove(estudiante);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool EstudianteExists(int? estudianteid)
    {
        return _context.Estudiante.Any(e => e.estudianteId == estudianteid);
    }
}
