using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace EjemploViewModel
{
    class MainWindowVM : INotifyPropertyChanged
    {                
        public ObservableCollection<CLIENTE> Clientes { get; set; }
        public CLIENTE clienteSeleccionado { get; set; }
        private BaseDatos baseDatos;

        public MainWindowVM()
        {
            baseDatos = new BaseDatos();
            Clientes = baseDatos.CargarClientes();
        }

        public void Modificar()
        {
            baseDatos.Guardar();
            clienteSeleccionado = null;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
