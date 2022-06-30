using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema2
{
    abstract class Vegetarianos
    {
        private double _precioxLibra;
        private List<IRestaurante> _restaurantes = new List<IRestaurante>();

        public Vegetarianos(double precioxLibra)
        {
            _precioxLibra = precioxLibra;
        }

        public void Añadir(IRestaurante restaurante)
        {
            _restaurantes.Add(restaurante);
        }
        public void Eliminar(IRestaurante restaurant)
        {
            _restaurantes.Remove(restaurant);
        }
        public void Notificacion()
        {
            foreach (IRestaurante restaurante in _restaurantes)
            {
                restaurante.Actualizar(this);
            }

            Console.WriteLine("");
        }
        public double PrecioxLibra
        {
            get { return _precioxLibra; }
            set
            {
                if (_precioxLibra != value)
                {
                    _precioxLibra = value;
                    Notificacion(); 
                }
            }
        }
    }
}
