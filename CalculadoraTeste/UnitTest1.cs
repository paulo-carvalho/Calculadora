namespace CalculadoraTeste;
public class UnitTest1
{
    private CalculadoraSimples _calculadoraValidadora = new CalculadoraSimples();
    [Theory]
    [InlineData(1d, '+', 3, 4)]
    [InlineData(1d, '-', 3, -2)]
    [InlineData(1d, '*', 3, 3)]
    [InlineData(1d, '/', 3, 0.33333)]
    [InlineData(0d, '/', 3, 0)]
    [InlineData(1d, '/', 0, Double.PositiveInfinity)]
    public void CalcularOperacoes(double operando1, char operador, double operando2, double resultadoAdequado)
    {
        // Given
        double resultado = _calculadoraValidadora.operacao(operando1, operador, operando2);
        // When
        if(operador == '/') resultado = Math.Round(resultado, 5);
        // Then
        Assert.Equal(resultado, resultadoAdequado);
    }
}