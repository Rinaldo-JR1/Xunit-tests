using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.classes
{
    public class Calculadora
    {
        public int Somar(int a, int b)
        {
            return a + b;
        }
        public int Subtrair(int a, int b)
        {
            return a - b;
        }
        public int Multiplicar(int a, int b)
        {
            return a * b;
        }
        public int Dividir(int a, int b)
        {
            return a / b;
        }
        public List<string> Historico(){
            return new List<string>();
        }
    }
}