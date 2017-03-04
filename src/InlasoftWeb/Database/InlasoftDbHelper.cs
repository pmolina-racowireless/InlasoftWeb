using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InlasoftWeb.Models;

namespace InlasoftWeb.Database
{
    public static class InlasoftDbHelper
    {
        public static void EnsureSeedData(this InlasoftDbContext context)
        {
            if (!context.Casos.Any())
            {
                var materia1 =
                    context.Materias.Add(new Materia
                    {
                        CreatedDate = DateTime.Today,
                        Id = new Guid(),
                        IsActive = true,
                        LastModifiedDate = DateTime.Today,
                        MateriaId = 0,
                        MateriaNombre = "Materia de prueba 1"
                    }).Entity;

                var materia2 =
                    context.Materias.Add(new Materia
                    {
                        CreatedDate = DateTime.Today,
                        Id = new Guid(),
                        IsActive = true,
                        LastModifiedDate = DateTime.Today,
                        MateriaId = 1,
                        MateriaNombre = "Materia de prueba 2"
                    }).Entity;

                var servicio1 = context.Servicios.Add(new Servicio
                {
                    CreatedDate = DateTime.Today,
                    Id = new Guid(),
                    IsActive = true,
                    LastModifiedDate = DateTime.Today,
                    Materia = materia1,
                    ServicioId = 1,
                    ServicioNombre = "Servicio de Prueba 1"
                }).Entity;

                var servicio2 = context.Servicios.Add(new Servicio
                {
                    CreatedDate = DateTime.Today,
                    Id = new Guid(),
                    IsActive = true,
                    LastModifiedDate = DateTime.Today,
                    Materia = materia1,
                    ServicioId = 2,
                    ServicioNombre = "Servicio de Prueba 2"
                }).Entity;

                var servicio3 = context.Servicios.Add(new Servicio
                {
                    CreatedDate = DateTime.Today,
                    Id = new Guid(),
                    IsActive = true,
                    LastModifiedDate = DateTime.Today,
                    Materia = materia2,
                    ServicioId = 3,
                    ServicioNombre = "Servicio de Prueba 3"
                }).Entity;

            }
        }
    }
}
