using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploViewModel
{
    class BaseDatos
    {
        private BaseDatosInformeEntities contexto;        

        public BaseDatos()
        {
            contexto = new BaseDatosInformeEntities();
        }
    
        public ObservableCollection<CLIENTE> CargarClientes()
        {
            contexto.CLIENTES.Load();
            return contexto.CLIENTES.Local;            
        }

        public void Guardar()
        {
            contexto.SaveChanges();
        }
    }
}
