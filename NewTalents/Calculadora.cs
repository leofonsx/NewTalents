namespace NewTalents
{
    public class Calculadora
    {
        private List<string> listaHistorico;
        public Calculadora() 
        { 
            listaHistorico = new List<string>();
        }
        public int Somar(int val1, int val2) 
        {
            int resultado = val1 + val2;
            IncluirHistorico(nameof(Somar), val1, val2, resultado);
            return resultado;
        }

        public int Subtrair(int val1, int val2)
        {
            int resultado = val1 - val2;
            IncluirHistorico(nameof(Subtrair), val1, val2, resultado);
            return resultado;
        }

        public int Multiplicar(int val1, int val2)
        {
            int resultado = val1 * val2;
            IncluirHistorico(nameof(Multiplicar), val1, val2, resultado);
            return resultado;
        }

        public int Dividir(int val1, int val2)
        {
            int resultado = val1 / val2;
            IncluirHistorico(nameof(Dividir), val1, val2, resultado);
            return resultado;
        }

        public List<string> ListarHistorico()
        {
            return listaHistorico.TakeLast(3).ToList();
        }

        private void IncluirHistorico(string acao, int val1, int val2, int resultado)
        {
            listaHistorico.Add($"Ação: {acao}, Val1: {val1}, Val2: {val2}, Resultado: {resultado}");
        }
    }
}
