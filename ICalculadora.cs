public interface ICalculadora {
    List<string> historicoCalculo { get; set; }
    double operacao(double operando1, char operador, double operando2);
    List<string> imprimirHistorico();
}