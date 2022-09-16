using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[]
        {
            new Evento()
                {
                    Id = 1,
                    Tema = "Angular 12 e .net 5",
                    Local = "Jacareí/SP",
                    Lote = "1° Lote",
                    QuantidadePessoas = 250,
                    DataEvento = DateTime.Now.AddDays(2).ToString(),
                    ImagemURL = "foto.png"
                },
            new Evento()
                {
                    Id = 2,
                    Tema = "Angular e suas novidades",
                    Local = "SJC/SP",
                    Lote = "2° Lote",
                    QuantidadePessoas = 450,
                    DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
                    ImagemURL = "foto3.png"
                }
        };
        public EventoController()
        {
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(evento => evento.Id == id);
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo de Put com id = {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Exemplo de Delete com id = {id}";
        }
    }
}
