public class CalculadoraSimples : ICalculadora {
    public List<string> historicoCalculo { get; set; }

    public CalculadoraSimples() {
        historicoCalculo = new List<string>();
    }
    public double operacao(double operando1, char operador, double operando2) {
        switch(operador) {
            case '+':
                return operando1 + operando2;
            case '-':
                return operando1 - operando2;
            case '*':
                return operando1 * operando2;
            case '/':
                try {
                    return operando1 / operando2;
                } catch (DivideByZeroException) {
                    return Double.PositiveInfinity;
                }
        }
        return 0.0d;
    }
    public List<string> imprimirHistorico() {
        return new List<string>();
    }
}