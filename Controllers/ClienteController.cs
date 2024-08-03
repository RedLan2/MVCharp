using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Logging;
using ProjetoMVC.Context;
using ProjetoMVC.Models;

namespace ProjetoMVC.Controllers
{
    [Route("[controller]")]
    public class ClienteController : Controller
    {
        private readonly MVContext _context;
        public ClienteController(MVContext context){
            _context=context;
        }
      
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                _context.Cliente.Add(cliente);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(cliente);
        }
        
        [Route("Cliente/Listagem")]
        public IActionResult Listagem(){
            var cliente =_context.Cliente.ToList();
            return View(cliente);
        }

    
    }
}