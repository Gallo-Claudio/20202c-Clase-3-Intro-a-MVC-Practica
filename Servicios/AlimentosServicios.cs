using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class AlimentosServicios
    {
        private static List<Alimento> ListaAlimento = new List<Alimento>();

        public static void Alta(Alimento alimento)
        {
            ListaAlimento.Add(alimento);
        }

        public static List<Alimento> Listado()
        {
            return ListaAlimento;
        }

        public static List<Alimento> Hardcodeo()
        {
            Alimento alimento = new Alimento();
            alimento.Nombre = "Papa";
            alimento.Peso = 100;
            ListaAlimento.Add(alimento);

            Alimento alimento2 = new Alimento();
            alimento2.Nombre = "Tomate";
            alimento2.Peso = 500;
            ListaAlimento.Add(alimento2);

            Alimento alimento3 = new Alimento();
            alimento3.Nombre = "Porotos";
            alimento3.Peso = 300;
            ListaAlimento.Add(alimento3);

            return ListaAlimento;
        }

        public static int UltimoId()
        {
            if (ListaAlimento.Count == 0)
            {
                int proximoId = 1;
                return proximoId;
            }
            else
            {
                int proximoId = ListaAlimento.Last().Id + 1;
                return proximoId;
            }
        }
    }
}
