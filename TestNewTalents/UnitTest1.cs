using NewTalents;

namespace TestNewTalents
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 9)]
        public void Somar_InformoDoisNumeros_Sucesso(int val1, int val2, int resultadoEsperado)
        {
            Calculadora calc = new Calculadora();

            int resultado = calc.Somar(val1,val2);

            Assert.Equal(resultadoEsperado, resultado);
        }

        [Theory]
        [InlineData(1, 2, -1)]
        [InlineData(4, 5, -1)]
        public void Subtrair_InformoDoisNumeros_Sucesso(int val1, int val2, int resultadoEsperado)
        {
            Calculadora calc = new Calculadora();

            int resultado = calc.Subtrair(val1, val2);

            Assert.Equal(resultadoEsperado, resultado);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        public void Multiplicar_InformoDoisNumeros_Sucesso(int val1, int val2, int resultadoEsperado)
        {
            Calculadora calc = new Calculadora();

            int resultado = calc.Multiplicar(val1, val2);

            Assert.Equal(resultadoEsperado, resultado);
        }

        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(5, 5, 1)]
        public void Dividir_InformoDoisNumeros_Sucesso(int val1, int val2, int resultadoEsperado)
        {
            Calculadora calc = new Calculadora();

            int resultado = calc.Dividir(val1, val2);

            Assert.Equal(resultadoEsperado, resultado);
        }

        [Fact]
        public void Dividir_InformoDivisaoPorZero_Falha()
        {
            Calculadora calc = new Calculadora();

            Assert.Throws<DivideByZeroException>(() => calc.Dividir(3,0));
        }

        [Fact]
        public void ListarHistorico_NaoInformoNada_ListaCheiaSucesso()
        {
            Calculadora calc = new Calculadora();

            calc.Somar(1, 1);
            calc.Somar(2, 1);
            calc.Somar(1, 3);
            calc.Somar(1, 4);

            var lista = calc.ListarHistorico();

            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);
        }
    }
}