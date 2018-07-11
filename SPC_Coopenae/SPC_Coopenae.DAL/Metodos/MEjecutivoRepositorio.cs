using SPC_Coopenae.DAL.Interfaces;
using SPC_Coopenae.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPC_Coopenae.DAL.Metodos
{
    public class MEjecutivoRepositorio : IEjectutivoRepositorio
    {
        public void ActualizarEjecutivo(Ejecutivos ejecutivoP)
        {
            using (var dbc = new ConexionBD())
            {
                var aActualizar = dbc.Ejecutivos.Find(ejecutivoP.Cedula);
                aActualizar.Nombre = ejecutivoP.Nombre;
                aActualizar.Apellidos = ejecutivoP.Apellidos;
                aActualizar.Correo = ejecutivoP.Correo;
                aActualizar.Sexo = ejecutivoP.Sexo;
                aActualizar.Telefono = ejecutivoP.Telefono;
                aActualizar.Residencia = ejecutivoP.Residencia;
                aActualizar.CodigoVendedor = ejecutivoP.CodigoVendedor;
                aActualizar.Sucursal = ejecutivoP.Sucursal;
                
                dbc.SaveChanges();

            }
        }

        public Ejecutivos BuscarEjecutivo(int cedula)
        {
            using (var dbc = new ConexionBD())
            {
                return dbc.Ejecutivos.Find(cedula);
            }
        }

        public void EliminarEjecutivo(int cedula)
        {
            using (var dbc = new ConexionBD())
            {
                var aEliminar = dbc.Ejecutivos.Find(cedula);
                aEliminar.Estado = 0;
                dbc.SaveChanges();
            }
        }

        public void InsertarEjecutivo(Ejecutivos ejecutivo)
        {
            using (var dbc = new ConexionBD())
            {
                dbc.Ejecutivos.Add(ejecutivo);
                dbc.SaveChanges();
            }
        }

        public List<Ejecutivos> ListarEjecutivos()
        {
            using (var dbc  = new ConexionBD())
            {
                return dbc.Ejecutivos.Where(x => x.Estado == 1).ToList();
            }
        }
    }
}
