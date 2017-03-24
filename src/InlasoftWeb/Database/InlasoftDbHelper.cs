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
                        MateriaId = "0",
                        MateriaNombre = "Materia de prueba 1"
                    }).Entity;

                var materia2 =
                    context.Materias.Add(new Materia
                    {
                        MateriaId = "1",
                        MateriaNombre = "Materia de prueba 2"
                    }).Entity;

                var servicio1 = context.Servicios.Add(new Servicio
                {
                    Materia = materia1,
                    ServicioNombre = "Servicio de Prueba 1"
                }).Entity;

                var servicio2 = context.Servicios.Add(new Servicio
                {
                    Materia = materia1,
                    ServicioNombre = "Servicio de Prueba 2"
                }).Entity;

                var servicio3 = context.Servicios.Add(new Servicio
                {
                    Materia = materia2,
                    ServicioNombre = "Servicio de Prueba 3"
                }).Entity;

                var cliente1 = context.Clientes.Add(new Cliente
                {
                    ClienteNombre = "Cliente de Prueba 1",
                    Direccion = "Direccion de prueba"
                }).Entity;

                var sucursal1 = context.Sucursales.Add(new Sucursal
                {
                    Direccion = "Direccion de Sucursal de Prueba",
                    Cliente = cliente1
                }).Entity;

                context.SaveChanges();

            }
        }
    }
}
