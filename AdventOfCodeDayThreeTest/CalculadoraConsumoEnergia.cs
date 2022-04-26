using System;
using System.Collections.Generic;

namespace AdventOfCodeDayThreeTest
{
  internal class CalculadoraConsumoEnergia
  {
    private IList<string> elementos;
    private Gama gama;
    private Epsilon epsilon;

    public Gama Gama
    {
      get { return gama; }
    }

    public Epsilon Epsilon
    {
      get { return epsilon; }
      set { epsilon = value; }
    }

    public CalculadoraConsumoEnergia(IList<string> elementos)
    {
      this.elementos = elementos;
      this.gama = new Gama(elementos);
      this.epsilon = new Epsilon(elementos);
    }

    public int Calcular()
    {
      return gama.Calcular() * epsilon.Calcular();
    }
  }
}