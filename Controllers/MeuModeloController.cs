using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

public class MeuModeloController : Controller
{
    private readonly SeuDbContext _context;

    public MeuModeloController(SeuDbContext context)
    {
        _context = context;
    }

    // GET: /MeuModelo/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: /MeuModelo/Create
    [HttpPost]
    public async Task<IActionResult> Create(MeuModel modelo)
    {
        if (ModelState.IsValid)
        {
            _context.MeusModelos.Add(modelo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(modelo);
    }

    // Action para listar os itens (opcional)
    public async Task<IActionResult> Index()
    {
        return View(await _context.MeusModelos.ToListAsync());
    }
}
