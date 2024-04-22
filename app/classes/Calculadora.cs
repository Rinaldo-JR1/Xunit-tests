using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace app.classes
{


    public class Calculadora
    {

        private List<string> ListaHistorico;
        public Calculadora()
        {
            ListaHistorico = new List<string>();
        }

        public int Somar(int a, int b)
        {
            int res = a + b;
            ListaHistorico.Insert(0, $"Res: {res} \n");
            return res;
        }
        public int Subtrair(int a, int b)
        {
            int res = a - b;
            ListaHistorico.Insert(0, $"Res: {res} \n");
            return a - b;
        }
        public int Multiplicar(int a, int b)
        {
            int res = a * b;
            ListaHistorico.Insert(0, $"Res: {res} \n");
            return res;
        }
        public int Dividir(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException();
            }
            int res = a / b;
            ListaHistorico.Insert(0, $"Res: {res} \n");
            return res;
        }
        public List<string> Historico()
        {

            ListaHistorico.RemoveRange(4, ListaHistorico.Count - 4);
            return ListaHistorico;
        }
    }
}