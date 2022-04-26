using System.Collections.Generic;
using Xunit;

namespace AdventOfCodeDayThreeTest
{
  public class UnitTest
  {
    [Fact]
    public void Test1()
    {
      IList<string> elementos = new List<string>();

      elementos.Add("00100");
      elementos.Add("11110");
      elementos.Add("10110");
      elementos.Add("10111");
      elementos.Add("10101");
      elementos.Add("01111");
      elementos.Add("00111");
      elementos.Add("11100");
      elementos.Add("10000");
      elementos.Add("11001");
      elementos.Add("00010");
      elementos.Add("01010");

      CalculadoraConsumoEnergia calculadora = new CalculadoraConsumoEnergia(elementos);

      Assert.Equal(198, calculadora.Calcular());
    }
  }
}
