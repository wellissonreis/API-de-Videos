using Alura_Challenge_Backend_Semana_1.Data;
using Alura_Challenge_Backend_Semana_1.Data.Dtos.Video;
using Alura_Challenge_Backend_Semana_1.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

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
        Videos video = _mapper.Map<Videos>(dto);
        _context.videos.Add(video);
        _context.SaveChanges();
        return CreatedAtAction(nameof(recuperaPorID), new
        { id = video.Id }, video);
    }

    [HttpGet]
    public IEnumerable<ReadVideoDto> LerVideo()
    {
        return _mapper.Map<List<ReadVideoDto>>(_context.videos);

    }

    [HttpGet("{id}")]
    public IActionResult recuperaPorID(int id)
    {
        Videos video = _context.videos.FirstOrDefault(video => video.Id == id);
        if (video != null)
        {
            Videos dto = _mapper.Map<Videos>(video);
            return Ok(dto);
        }
        return NotFound(video);
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
        Videos video = _context.videos.FirstOrDefault(
            video => video.Id == id);
        if (video == null) return NotFound();
        _context.Remove(video);
        _context.SaveChanges();
        return NoContent();
    }


    [Route("search")]
    public IActionResult BuscaFilmes(string titulo)
    {
        Videos video = _context.videos.FirstOrDefault(video => video.Titulo == titulo);
        if (video != null)
        {
            Videos dto = _mapper.Map<Videos>(video);
            return Ok(dto);
        }
        return NotFound(video);
    }
}
