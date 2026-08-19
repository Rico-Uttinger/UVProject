using Microsoft.AspNetCore.Mvc;
using Backend.Data;
using Microsoft.EntityFrameworkCore;

namespace Backend.Controllers;

[ApiController]
[Route("[controller]")]
public class ExposuresController : ControllerBase
{
    private readonly AppDbContext _context;

    public ExposuresController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Exposure>>> GetExposures()
    {
        return await _context.Exposures.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Exposure>> GetExposure(int id)
    {
        var exposure = await _context.Exposures.FindAsync(id);

        if (exposure == null)
        {
            return NotFound();
        }

        return exposure;
    }

    [HttpPost]
    public async Task<ActionResult<Exposure>> PostExposure(Exposure exposure)
    {
        _context.Exposures.Add(exposure);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetExposures), new { id = exposure.Id }, exposure);
    }
}