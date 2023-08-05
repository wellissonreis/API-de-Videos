using Alura_Challenge_Backend_Semana_1.Data;
using Alura_Challenge_Backend_Semana_1.Data.Dtos.Categoria;
using Alura_Challenge_Backend_Semana_1.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace Alura_Challenge_Backend_Semana_1.Controllers;

[ApiController]
[Route("[controller]")]
public class CategoriaController : ControllerBase
{
    private VideoContext _context;
    private IMapper _mapper;

    public CategoriaController(VideoContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult AdicionaCategoria([FromBody] CreateCategoriaDto dto)
    {
        Categorias categoria = _mapper.Map<Categorias>(dto);
        _context.categorias.Add(categoria);
        _context.SaveChanges();
        return CreatedAtAction(nameof(categoria), new { id = categoria.Id }, categoria);
    }
    [HttpGet]
    public IEnumerable<ReadCategoriaDto> Recupera()
    {
        return _mapper.Map<List<ReadCategoriaDto>>(_context.categorias);
    }

    [HttpGet("{id}")]
    public IActionResult recuperaPorID(int id)
    {
        Categorias categoria = _context.categorias.FirstOrDefault(c => c.Id == id);
        if (categoria != null)
        {
            Categorias dto = _mapper.Map<Categorias>(categoria);
            return Ok(dto);
        }
        return NotFound();
    }

    [HttpPut("{id}")]
    public IActionResult Atualiza(int id, [FromBody] UpdateCategoriaDto dto)
    {
        Categorias categoria = _context.categorias.FirstOrDefault(c => c.Id == id);
        if (categoria != null)
        {
            _mapper.Map(dto, categoria);
            _context.SaveChanges();
        }
        return NotFound();
    }

    [HttpDelete("{id}")]
    public IActionResult DeletarVideo(int id)
    {
        Categorias categoria = _context.categorias.FirstOrDefault(c => c.Id == id);
        if (categoria != null)
        {
            _context.Remove(categoria);
            _context.SaveChanges();
        }
        return NotFound();

    }

    [HttpGet]
    public IActionResult recuperaPorBusca(string search)
    {
        Categorias categoria = _context.categorias.FirstOrDefault(c => c.Titulo == search);
        if (categoria != null)
        {
            Categorias dto = _mapper.Map<Categorias>(categoria);
            return Ok(dto);
        }
        return NotFound();
    }

}
