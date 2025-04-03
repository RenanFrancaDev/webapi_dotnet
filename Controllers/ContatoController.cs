using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using modulo_api.Context;
using modulo_api.Models;

namespace modulo_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContatoController : ControllerBase
    {
        private readonly AgendaContext _context;
        public ContatoController(AgendaContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var contato = _context.Contatos;

            if (contato == null)
            {
                return NotFound();
            }

            return Ok(contato);
        }

        [HttpPost]
        public IActionResult Create(Contato contato)
        {
            _context.Add(contato);
            _context.SaveChanges();
            return Ok(contato);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var contato = _context.Contatos.Find(id);

            if (contato == null)
            {
                return NotFound();
            }

            return Ok(contato);
        }
        [HttpPut("{id}")]
        public IActionResult Update(int id, Contato contato)
        {
            var newContato = _context.Contatos.Find(id);
            if (newContato == null)
            {
                return NotFound();
            }

            newContato.Nome = contato.Nome;
            newContato.Telefone = contato.Telefone;
            newContato.Ativo = contato.Ativo;

            _context.Contatos.Update(newContato);
            _context.SaveChanges();
            return Ok(contato);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var contatoDb = _context.Contatos.Find(id);
            if (contatoDb == null)
            {
                return NotFound("Contato não encontrado");
            }
            _context.Contatos.Remove(contatoDb);
            _context.SaveChanges();
            return NoContent();
        }
        [HttpGet("name-contacts")]
        public IActionResult GetByName(string name)
        {
            var contatos = _context.Contatos.Where(x => x.Nome.Contains(name));
            return Ok(contatos);
        }
    }
}