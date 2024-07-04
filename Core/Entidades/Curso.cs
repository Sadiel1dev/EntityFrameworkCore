using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entidades
{
    public class Curso
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Objetivo { get; set; }
        public DateTime FechadeAlta { get; set; }


        //Foreing Key
        public int EstatusId { get; set; }
        public Estatus Estatus { get; set; }

        //Foreing Key
        public int ProfesorId { get; set; }
        public Profesor Profesor { get; set; }

        public IEnumerable<CursoEstudiante> CursosEstudiantes { get; set; }
    }
}