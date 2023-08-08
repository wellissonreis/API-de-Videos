using Alura_Challenge_Backend_Semana_1.Data;
using Alura_Challenge_Backend_Semana_1.Data.Dtos.Video;
using Alura_Challenge_Backend_Semana_1.Models;
using Canducci.Pagination;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Alura_Challenge_Backend_Semana_1.Controllers;

[ApiController]
[Route("[controller]")]
public class VideosController : ControllerBase
{
    private VideoContext _context;
    private IMapper _mapper;

    public VideosController(VideoContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult AdicionaVideo([FromBody] CreateVideoDto dto)
    {
        try
        {
            Videos video = _mapper.Map<Videos>(dto);
            _context.videos.Add(video);
            _context.SaveChanges();
            return CreatedAtAction(nameof(recuperaPorID), new
            { id = video.Id }, video);
        }
        catch
        {
            return StatusCode(StatusCodes.Status500InternalServerError,
            "Categoria inexistente");
        }

    }

    [HttpGet]
    public IEnumerable<ReadVideoDto> LerVideo()
    {
        return _mapper.Map<List<ReadVideoDto>>(_context.videos.ToList());

    }

   [HttpGet("id/{id}")]
    public IActionResult recuperaPorID(int id)
    {
        try
        {
            Videos video = _context.videos.FirstOrDefault(video => video.Id == id);
            if (video != null)
            {
                Videos dto = _mapper.Map<Videos>(video);
                return Ok(dto);
            }
            return NotFound(video);
        }
        catch
        {
            return StatusCode(StatusCodes.Status500InternalServerError,
                     "Falha ao recuperar filme por id.");
        }
    }

    [HttpGet("categoria/{id}")]
    public IActionResult recuperaPorCategoriaID(int id)
    {
        try
        {
            Categorias cat = _context.categorias.FirstOrDefault(cat => cat.Id == id);
            if (cat != null)
            {
                Categorias dto = _mapper.Map<Categorias>(cat);
                return Ok(dto);
            }
            return NotFound(cat);
        }
        catch
        {
            return StatusCode(StatusCodes.Status500InternalServerError,
                     "Falha ao recuperar Categoria por id.");
        }
    }

    [HttpPut("{id}")]
    public IActionResult AtualizaVideo(int id,
        [FromBody] UpdateVideoDto dto)
    {
        Videos video = _context.videos.FirstOrDefault(video => video.Id == id);

        if (video == null) return NotFound();
        _mapper.Map(dto, video);
        _context.SaveChanges();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeletarVideo(int id)
    {
        Videos video = _context.videos.FirstOrDefault(video => video.Id == id);
        if (video == null) return NotFound();
        _context.Remove(video);
        _context.SaveChanges();
        return NoContent();
    }

    [HttpGet("{search}")]
    public IActionResult Search(string? titulo)
    {
        try
        {
            List<Videos> video = _context.videos.Where(video => video.Titulo.Contains(titulo)).ToList();

            if (video != null)
            {
                List<Videos> dto = _mapper.Map<List<Videos>>(video);
                return Ok(dto);
            }

            return NotFound(video);
        }
        catch
        {
            return StatusCode(StatusCodes.Status500InternalServerError,
                     "Falha ao recuperar filme por id.");
        }
    }

    [HttpGet("page/{page?}")]
    public async Task<IActionResult> Paginacao([FromBody]int? page)
    {
        page ??= 1;
        if (page <= 0) page = 1;
       
        var result = await _context
            .videos
            .AsNoTracking()
            .OrderBy(video => video.Id)
            .ToPaginatedRestAsync(page.Value, 5);

        return Ok(result);
    }

}
