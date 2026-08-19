using Microsoft.AspNetCore.Mvc;
using Backend.Data;
using Microsoft.EntityFrameworkCore;

namespace Backend.Controllers;


[ApiController]
[Route("[controller]")]
public class MaxExposureController : ControllerBase
{
    private readonly AppDbContext _context;

    public MaxExposureController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet("{skinType}/{uvIndex}")]
    public async Task<ActionResult<IEnumerable<MaxExposure>>> GetMaxExposures(int skinType, int uvIndex)
    {
        return await _context.MaxExposures.Where(x => x.SkinType == skinType && x.UvIndex == uvIndex).ToListAsync();
    }
}