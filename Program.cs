using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema2
{
    class Program
    {
        static void Main(string[] args)
        {
            Zanahorias zanahorias = new Zanahorias(70.00);
            zanahorias.Añadir(new Restaurante("Restaurante Doña Rosa", 0.60));
            zanahorias.Añadir(new Restaurante("Bar deportivo de Johnny", 0.55));
            zanahorias.Añadir(new Restaurante("Restaurante Delicius", 0.65));

            zanahorias.PrecioxLibra = 0.60;
            zanahorias.PrecioxLibra = 0.55;
            zanahorias.PrecioxLibra = 0.65;
            zanahorias.PrecioxLibra = 0.75;
        }
    }
}