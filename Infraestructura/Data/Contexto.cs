using System.Collections.Immutable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Core.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Infraestructura.Data
{
    public class Contexto: DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }
        public DbSet<Estatus> Estatus { get; set; }
        public DbSet<Profesor> Profesores { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<CursoEstudiante> CursosEstudiantes { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder){
           modelBuilder.Entity<CursoEstudiante>().HasKey(e => new{e.EstudianteId,e.CursoId});
           
           modelBuilder.Entity<CursoEstudiante>()
           .HasOne<Curso>(ce=>ce.Curso)
           .WithMany(c=>c.CursosEstudiantes)
           .HasForeignKey(c=>c.CursoId);

           modelBuilder.Entity<CursoEstudiante>()
           .HasOne<Estudiante>(ce=>ce.Estudiante)
           .WithMany(c=>c.CursosEstudiantes)
           .HasForeignKey(c=>c.EstudianteId);
        }

    }
}