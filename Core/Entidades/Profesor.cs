using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entidades
{
    public class Profesor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechadeAlta { get; set; }

        //Foreing Key
        public int EstatusId { get; set; }
        public Estatus Estatus { get; set; }

        public IEnumerable<Curso> Cursos { get; set; }
    }
}