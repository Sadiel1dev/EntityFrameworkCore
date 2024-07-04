using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entidades
{
    public class Estudiante
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public DateTime FechadeNacimiento { get; set; }
        public DateTime FechadeAlta { get; set; }

        //Foreing Key
        public int EstatusId { get; set; }
        public Estatus Estatus { get; set; }

        public IEnumerable<CursoEstudiante> CursosEstudiantes { get; set; }
    }
}