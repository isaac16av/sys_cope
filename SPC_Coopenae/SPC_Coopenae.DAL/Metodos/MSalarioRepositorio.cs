using SPC_Coopenae.DAL.Interfaces;
using SPC_Coopenae.DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPC_Coopenae.DAL.Metodos
{
    public class MSalarioRepositorio : ISalarioRepositorio
    {
        public void ActualizarSalario(Salario sal)
        {
            using (var dbc = new SPC_BD())
            {
                dbc.Entry(sal).State = EntityState.Modified;
                dbc.SaveChanges();
            }
        }

        public Salario BuscarSalario(int id)
        {
            using (var dbc = new SPC_BD())
            {
                return dbc.Salario.Find(id);
            }
        }

        public void EliminarSalario(int id)
        {
            using (var dbc = new SPC_BD())
            {
                var eSalario = dbc.Salario.Find(id);
                eSalario.Estado = false;
                dbc.SaveChanges();
            
            }
        }

        public void InsertarSalario(Salario sal)
        {
            using (var dbc = new SPC_BD())
            {
                dbc.Salario.Add(sal);
                dbc.SaveChanges();
            }
        }

        public List<Salario> ListarSalario()
        {
            using (var dbc = new SPC_BD())
            {
                return dbc.Salario.Where(x => x.Estado == true).ToList();
            }
        }
    }
}
