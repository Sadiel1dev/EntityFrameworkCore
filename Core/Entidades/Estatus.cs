using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entidades
{
    public class Estatus
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechadeAlta { get; set; }

        public IEnumerable<Profesor> Profesores { get; set; }
        public IEnumerable<Estudiante> Estudiantes { get; set; }
        public IEnumerable<Curso> Cursos { get; set; }
    }
}