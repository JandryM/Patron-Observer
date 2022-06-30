using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema2
{
     class Restaurante: IRestaurante
    {
        string _nombre;     
        double _valoragregado;

        public Restaurante(string nombre, double valoragregado)
        {
            _nombre = nombre;
            _valoragregado = valoragregado;
        }

        public void Actualizar(Vegetarianos vegetarianos)
        {
            Console.WriteLine("Notificado a: {0} de {1} " + " Cambio de precio a {2:C} por libra.",
                _nombre, vegetarianos.GetType().Name, vegetarianos.PrecioxLibra);
            if (vegetarianos.PrecioxLibra < _valoragregado)
            {
                Console.WriteLine(_nombre + " Quiere comprar algunas Zanahorias!");
            }
        }
    }
}
