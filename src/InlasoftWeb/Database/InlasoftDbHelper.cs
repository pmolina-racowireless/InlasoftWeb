using System.Linq;
using InlasoftWeb.Models;

namespace InlasoftWeb.Database
{
    public static class InlasoftDbHelper
    {
        public static void EnsureSeedData(this InlasoftDbContext context)
        {
            //truncate all the things
            if (!context.Materias.Any())
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
            }

            if (!context.Servicios.Any())
            {
                var servicio1 = context.Servicios.Add(new Servicio
                {
                    Materia = context.Materias.FirstOrDefault(),
                    ServicioNombre = "Servicio de Prueba 1"
                }).Entity;

                var servicio2 = context.Servicios.Add(new Servicio
                {
                    Materia = context.Materias.FirstOrDefault(),
                    ServicioNombre = "Servicio de Prueba 2"
                }).Entity;

                var servicio3 = context.Servicios.Add(new Servicio
                {
                    Materia = context.Materias.Where(m => m.MateriaId == "2").FirstOrDefault(),
                    ServicioNombre = "Servicio de Prueba 3"
                }).Entity;
            }

            if (!context.Clientes.Any())
            {
                var cliente1 = context.Clientes.Add(new Cliente
                {
                    ClienteNombre = "Cliente de Prueba 1",
                    Direccion = "Direccion de prueba"
                }).Entity;
            }

            if (!context.Sucursales.Any())
            {
                var sucursal1 = context.Sucursales.Add(new Sucursal
                {
                    Direccion = "Direccion de Sucursal de Prueba",
                    SucursalNombre = "Sucursal de Prueba 1",
                    Cliente = context.Clientes.FirstOrDefault()
                }).Entity;
            }

            if (!context.Firma.Any())
            {
                context.Firma.Add(new Firma
                {
                    FirmaNombre = "Firma de Prueba 1"
                });
            }

            if (!context.Casos.Any())
            {
                var caso1 = context.Casos.Add(new Caso
                {
                    Cliente = context.Clientes.FirstOrDefault(),
                    Catastro = "Catastro 1",
                    Contraparte = "Juan Perez",
                    Descripcion = "Caso de Prueba",
                    Firma = context.Firma.FirstOrDefault(),
                    Servicio = context.Servicios.FirstOrDefault(),
                    Sucursal = context.Sucursales.FirstOrDefault()
                    
                }).Entity;

            }

            context.SaveChanges();
        }
    }
}
