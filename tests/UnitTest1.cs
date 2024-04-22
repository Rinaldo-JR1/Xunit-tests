using System.Runtime.CompilerServices;
using app.classes;

namespace tests;

public class UnitTest1
{
    Calculadora calc = new Calculadora();

    [Theory]
    [InlineData(1, 2, 3)]
    public void TesteSoma(int val1, int val2, int resultadoEsperado)
    {

        int resultadoSoma = calc.Somar(val1, val2);
        Assert.Equal(resultadoEsperado, resultadoSoma);
    }
    [Theory]
    [InlineData(4, 2, 2)]
    public void TesteSubtracao(int val1, int val2, int resultadoEsperado)
    {

        int resultadoSubtracao = calc.Subtrair(val1, val2);
        Assert.Equal(resultadoEsperado, resultadoSubtracao);
    }
    [Theory]
    [InlineData(2, 2, 4)]
    public void TesteMultiplicacao(int val1, int val2, int resultadoEsperado)
    {

        int resultadoMultiplicacao = calc.Multiplicar(val1, val2);
        Assert.Equal(resultadoEsperado, resultadoMultiplicacao);
    }
    [Theory]
    [InlineData(4, 2, 2)]
    public void TesteDivisao(int val1, int val2, int resultadoEsperado)
    {
        int resultadoDivisao = calc.Dividir(val1, val2);
        Assert.Equal(resultadoEsperado, resultadoDivisao);
    }
    [Fact]
    public void TesteDivisaPor0()
    {
        Assert.Throws<DivideByZeroException>(() => calc.Dividir(4, 0));
    }
    [Fact]
    public void TestarHistorico()
    {
        calc.Somar(1, 2);
        calc.Somar(2, 2);
        calc.Somar(3, 3);
        calc.Somar(4, 4);
        List<string> historico = calc.Historico();
        Assert.NotEmpty(historico);
        Assert.Equal(4, historico.Count);
    }
}