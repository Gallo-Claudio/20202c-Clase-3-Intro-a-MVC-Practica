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

        public static void Borrar(int Id)
        {
            ListaAlimento.RemoveAt(Id-1);
        }
    }
}
