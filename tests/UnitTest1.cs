using System.Runtime.CompilerServices;
using app.classes;

namespace tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Calculadora calc = new Calculadora();
        int resultado = calc.Somar(1, 1);
        Assert.Equal(2, resultado);
    }
}