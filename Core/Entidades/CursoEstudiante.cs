using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entidades
{
    public class CursoEstudiante
    {
        //public int Id { get; set; }
        public int CursoId { get; set; }
        public Curso Curso { get; set; }
        public int EstudianteId { get; set; }
        public Estudiante Estudiante { get; set; }

    }
}