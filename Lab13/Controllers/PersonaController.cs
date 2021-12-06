using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab13.Models;

namespace Lab13.Controllers
{
    public class PersonaController : Controller
    {
        // GET: Persona
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Listar(string search, string campo)
        {
            List<Persona> personas = new List<Persona>();
            personas.Add(new Persona
            {
                PersonaID = 1,
                Nombre = "Juan",
                Apellido = "Perez",
                Direccion = "Av. Evergreen 123",
                FechaNac = Convert.ToDateTime("1997-11-07"),
                Email = "juan@mail.com"
            });
            personas.Add(new Persona
            {
                PersonaID = 2,
                Nombre = "Maria",
                Apellido = "Salas",
                Direccion = "Av. Progreso 325",
                FechaNac = Convert.ToDateTime("1995-10-28"),
                Email = "maria@mail.com"
            });
            personas.Add(new Persona
            {
                PersonaID = 3,
                Nombre = "Carlos",
                Apellido = "Martinez",
                Direccion = "Av. Los manzamos 101",
                FechaNac = Convert.ToDateTime("1982-02-14"),
                Email = "carlos@mail.com"
            });
            if (search == "Apellido")
            {
                return View(personas.Where(x => x.Apellido.StartsWith(campo) || campo == null).ToList());
            }
            else
            {
                return View(personas);
            }
        }
        public ActionResult Mostrar(int id)
        {
            List<Persona> personas = new List<Persona>();
            personas.Add(new Persona
            {
                PersonaID = 1,
                Nombre = "Juan",
                Apellido = "Perez",
                Direccion = "Av. Evergreen 123",
                FechaNac = Convert.ToDateTime("1997-11-07"),
                Email = "juan@mail.com"
            });
            personas.Add(new Persona
            {
                PersonaID = 2,
                Nombre = "Maria",
                Apellido = "Salas",
                Direccion = "Av. Progreso 325",
                FechaNac = Convert.ToDateTime("1995-10-28"),
                Email = "maria@mail.com"
            });
            personas.Add(new Persona
            {
                PersonaID = 3,
                Nombre = "Carlos",
                Apellido = "Martinez",
                Direccion = "Av. Los manzamos 101",
                FechaNac = Convert.ToDateTime("1982-02-14"),
                Email = "carlos@mail.com"
            });

            Persona persona = (from p in personas
                               where p.PersonaID == id
                               select p).FirstOrDefault();
            return View(persona);
        }
    }
}