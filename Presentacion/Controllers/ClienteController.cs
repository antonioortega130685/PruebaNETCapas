using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

using Entidad;
using Negocios;

namespace Presentacion.Controllers
{
    public class ClienteController : Controller
    {

        Logica logica = new Logica();

        // GET: Cliente
        public ActionResult Index()
        {
            return View(logica.GetCliente());
        }

        
        // GET: Cliente/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cliente/Create
        [HttpPost]
        public ActionResult Create(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                logica.InsertCliente(cliente);
                return RedirectToAction("Index");
            }
            return View(cliente);
        }

        // GET: Cliente/Edit/5
        public ActionResult Edit(int id)
        {
            
            return View(logica.ConseguirCliente(id));
        }

        // POST: Cliente/Edit/5
        [HttpPost]
        public ActionResult Edit(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                logica.EditCliente(cliente);
                return RedirectToAction("Index");
            }

            return View(cliente);
        }

        // GET: Cliente/Delete/5
        public ActionResult Delete(int id)
        {
            return View(logica.ConseguirCliente(id));
        }

        // POST: Cliente/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            logica.ConseguirCliente(id);
            logica.DeleteCliente(id);
            return RedirectToAction("Index");
        }
        
    }
}
