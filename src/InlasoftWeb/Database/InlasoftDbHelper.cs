using System.Linq;
using InlasoftWeb.Models;
using System;

namespace InlasoftWeb.Database
{
    public static class InlasoftDbHelper
    {
        public static void EnsureSeedData(this InlasoftDbContext context)
        {
            //truncate all the things
            #region Materias
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

                context.SaveChanges();
            }
            #endregion

            #region Servicios
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
                    Materia = context.Materias.Where(m => m.MateriaNombre.Contains("2")).FirstOrDefault(),
                    ServicioNombre = "Servicio de Prueba 3"
                }).Entity;
                context.SaveChanges();
            }
            #endregion

            #region Clientes
            if (!context.Clientes.Any())
            {
                var cliente1 = context.Clientes.Add(new Cliente
                {
                    ClienteNombre = "Cliente de Prueba 1",
                    Direccion = "Direccion de prueba"
                }).Entity;
                context.SaveChanges();
            }
            #endregion

            #region Sucursales
            if (!context.Sucursales.Any())
            {
                var sucursal1 = context.Sucursales.Add(new Sucursal
                {
                    Direccion = "Direccion de Sucursal de Prueba",
                    SucursalNombre = "Sucursal de Prueba 1",
                    Cliente = context.Clientes.FirstOrDefault()
                }).Entity;
                context.SaveChanges();
            }
            #endregion

            #region Firmas
            if (!context.Firmas.Any())
            {
                context.Firmas.Add(new Firma
                {
                    FirmaNombre = "Firma de Prueba 1"
                });
                context.SaveChanges();
            }
            #endregion

            #region Casos
            if (!context.Casos.Any())
            {
                context.Casos.Add(new Caso
                {
                    Cliente = context.Clientes.FirstOrDefault(),
                    Catastro = "Catastro 1",
                    Contraparte = "Juan Perez",
                    Descripcion = "Caso de Prueba",
                    Firma = context.Firmas.FirstOrDefault(),
                    Servicio = context.Servicios.FirstOrDefault(),
                    Sucursal = context.Sucursales.FirstOrDefault(),

                });

                context.Casos.Add(new Caso
                {
                    Cliente = context.Clientes.FirstOrDefault(),
                    Catastro = "Catastro 2",
                    Contraparte = "Pedro Perez",
                    Descripcion = "Caso de Prueba 2",
                    Firma = context.Firmas.FirstOrDefault(),
                    Servicio = context.Servicios.LastOrDefault(),
                    Sucursal = context.Sucursales.LastOrDefault(),

                });

                context.SaveChanges();
            }
            #endregion

            #region Abogados
            if (!context.Abogados.Any())
            {
                context.Abogados.Add(new Abogado
                {
                    AbogadoNombre = "Bruce Wayne"
                });

                context.Abogados.Add(new Abogado
                {
                    AbogadoNombre = "Clark Kent"
                });
                context.SaveChanges();
            }
            #endregion

            #region Audiencias
            if (!context.Audiencias.Any())
            {
                context.Audiencias.Add(new Audiencia
                {
                    Abogado = context.Abogados.FirstOrDefault(),
                    Caso = context.Casos.FirstOrDefault(),
                    Comentario = "Comentario de Prueba de Audiencia 1",
                    Motivo = "Motivo de Prueba de Audiencia 1",
                    Fecha = DateTime.Now,
                    Hora = DateTime.Now.TimeOfDay.ToString(),
                    Trabajo = 1,
                    Transferido = true
                });
                context.Audiencias.Add(new Audiencia
                {
                    Abogado = context.Abogados.LastOrDefault(),
                    Caso = context.Casos.FirstOrDefault(),
                    Comentario = "Comentario de Prueba de Audiencia 2",
                    Motivo = "Motivo de Prueba de Audiencia 2",
                    Fecha = DateTime.Now,
                    Hora = DateTime.Now.TimeOfDay.ToString(),
                    Trabajo = 1,
                    Transferido = true
                });
                context.Audiencias.Add(new Audiencia
                {
                    Abogado = context.Abogados.FirstOrDefault(),
                    Caso = context.Casos.FirstOrDefault(),
                    Comentario = "Comentario de Prueba de Audiencia 3",
                    Motivo = "Motivo de Prueba de Audiencia 3",
                    Fecha = DateTime.Now,
                    Hora = DateTime.Now.TimeOfDay.ToString(),
                    Trabajo = 1,
                    Transferido = false
                });
                context.Audiencias.Add(new Audiencia
                {
                    Abogado = context.Abogados.FirstOrDefault(),
                    Caso = context.Casos.SingleOrDefault(c => c.Descripcion.Contains("2")),
                    Comentario = "Comentario de Prueba de Audiencia 4",
                    Motivo = "Motivo de Prueba de Audiencia 4",
                    Fecha = DateTime.Now,
                    Hora = DateTime.Now.TimeOfDay.ToString(),
                    Trabajo = 1,
                    Transferido = false
                });
                context.SaveChanges();
            }
            #endregion

            #region Gestiones
            if (!context.Gestiones.Any())
            {
                context.Gestiones.Add(new Gestion
                {
                    Abogado = context.Abogados.LastOrDefault(),
                    Caso = context.Casos.FirstOrDefault(),
                    Comentario = "Comentario de Prueba de Gestion 1",
                    Motivo = "Motivo de Prueba de Gestion 1",
                    Fecha = DateTime.Now,
                    Hora = DateTime.Now.TimeOfDay.ToString(),
                    Trabajo = 1,
                    Transferido = true
                });

                context.Gestiones.Add(new Gestion
                {
                    Abogado = context.Abogados.FirstOrDefault(),
                    Caso = context.Casos.FirstOrDefault(),
                    Comentario = "Comentario de Prueba de Gestion 2",
                    Motivo = "Motivo de Prueba de Gestion 2",
                    Fecha = DateTime.Now,
                    Hora = DateTime.Now.TimeOfDay.ToString(),
                    Trabajo = 1,
                    Transferido = false
                });

                context.Gestiones.Add(new Gestion
                {
                    Abogado = context.Abogados.FirstOrDefault(),
                    Caso = context.Casos.FirstOrDefault(),
                    Comentario = "Comentario de Prueba de Gestion 3",
                    Motivo = "Motivo de Prueba de Gestion 3",
                    Fecha = DateTime.Now,
                    Hora = DateTime.Now.TimeOfDay.ToString(),
                    Trabajo = 1,
                    Transferido = true
                });

                context.Gestiones.Add(new Gestion
                {
                    Abogado = context.Abogados.FirstOrDefault(),
                    Caso = context.Casos.FirstOrDefault(),
                    Comentario = "Comentario de Prueba de Gestion 4",
                    Motivo = "Motivo de Prueba de Gestion 4",
                    Fecha = DateTime.Now,
                    Hora = DateTime.Now.TimeOfDay.ToString(),
                    Trabajo = 1.5,
                    Transferido = true
                });

                context.Gestiones.Add(new Gestion
                {
                    Abogado = context.Abogados.FirstOrDefault(),
                    Caso = context.Casos.SingleOrDefault(c => c.Descripcion.Contains("2")),
                    Comentario = "Comentario de Prueba de Gestion 5",
                    Motivo = "Motivo de Prueba de Gestion 5",
                    Fecha = DateTime.Now,
                    Hora = DateTime.Now.TimeOfDay.ToString(),
                    Trabajo = 1,
                    Transferido = true
                });

                context.SaveChanges();
            }
            #endregion

            #region Documentos
            if (!context.Documentos.Any())
            {
                context.Documentos.Add(new Documento
                {
                    Abogado = context.Abogados.LastOrDefault(),
                    Caso = context.Casos.FirstOrDefault(),
                    Descripcion = "Documento de Prueba 1",
                    Comentario = "Comentario de Documento 1",
                    Fecha = DateTime.Now,
                    Hora = DateTime.Now.TimeOfDay.ToString(),
                    DocumentoTipo = "Tipo 1",
                    Path = "/docs/Doc1.txt"
                });

                context.Documentos.Add(new Documento
                {
                    Abogado = context.Abogados.LastOrDefault(),
                    Caso = context.Casos.FirstOrDefault(),
                    Descripcion = "Documento de Prueba 2",
                    Comentario = "Comentario de Documento 2",
                    Fecha = DateTime.Now,
                    Hora = DateTime.Now.TimeOfDay.ToString(),
                    DocumentoTipo = "Tipo 1",
                    Path = "/docs/Doc2.txt"
                });

                context.Documentos.Add(new Documento
                {
                    Abogado = context.Abogados.FirstOrDefault(),
                    Caso = context.Casos.FirstOrDefault(),
                    Descripcion = "Documento de Prueba 3",
                    Comentario = "Comentario de Documento 3",
                    Fecha = DateTime.Now,
                    Hora = DateTime.Now.TimeOfDay.ToString(),
                    DocumentoTipo = "Tipo 2",
                    Path = "/docs/Doc3.txt"
                });

                context.Documentos.Add(new Documento
                {
                    Abogado = context.Abogados.FirstOrDefault(),
                    Caso = context.Casos.SingleOrDefault(c => c.Descripcion.Contains("2")),
                    Descripcion = "Documento de Prueba 4",
                    Comentario = "Comentario de Documento 4",
                    Fecha = DateTime.Now,
                    Hora = DateTime.Now.TimeOfDay.ToString(),
                    DocumentoTipo = "Tipo 1",
                    Path = "/docs/Doc4.txt"
                });
                context.SaveChanges();
            }
            #endregion
        }
    }
}
