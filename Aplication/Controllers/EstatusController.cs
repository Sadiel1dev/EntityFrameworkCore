using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Core.Entidades;
using Infraestructura.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Aplication.Controllers
{
    
    public class EstatusController : Controller
    {
        private readonly Contexto contexto;
        public EstatusController(Contexto contexto)
        {
            this.contexto = contexto;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var estatus= await contexto.Estatus.ToListAsync();
            return View(estatus);
        }
        [HttpGet]
        public async Task<IActionResult> Detail()
        {
            //var estatusModel= await contexto.Estatus.FindAsync(2);
            var estatusModel= await contexto.Estatus.FirstAsync(e=>e.Nombre=="Bueno");
            return View(estatusModel);
        }
        [HttpGet]
        public IActionResult Crear()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Crear(Estatus estatus)
        {
            if (ModelState.IsValid)
            {
                estatus.FechadeAlta=DateTime.Now;
                await contexto.AddAsync(estatus);
                await contexto.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var estatus=await contexto.Estatus.FindAsync(id);
            if (estatus==null)
            {
                return NotFound();
            }
            return View(estatus);
        }
        [HttpPost]
        public async Task<IActionResult> Update(int id,Estatus estatus)
        {
            if (ModelState.IsValid)
            {
                contexto.Update(estatus);
                await contexto.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            

            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var estatus=await contexto.Estatus.FindAsync(id);
            if (estatus==null)
            {
                return NotFound();
            }
            return View(estatus);
        }
        [HttpPost]
        public async Task<IActionResult> Delete(int id,Estatus estatus)
        {
            if (ModelState.IsValid)
            {
                contexto.Remove(estatus);
                await contexto.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            

            return View();
        }
     
    }
    

    
}