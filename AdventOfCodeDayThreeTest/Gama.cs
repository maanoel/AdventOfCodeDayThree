using System;
using System.Collections.Generic;

namespace AdventOfCodeDayThreeTest
{
  public class Gama
  {
    private IList<string> binarios;

    public Gama(IList<string> binarios)
    {
      this.binarios = binarios;
    }

    public int Calcular()
    {
      string binarioFinal = "";
      int contadorBinarioLigado = 0;
      int contadorBinarioDesligado = 0;

      for (int i = 0; i < 5; i++)
      {
        for (int j = 0; j < binarios.Count; j++)
        {
          if (binarios[j].ToCharArray()[i].ToString().Equals("1"))
            contadorBinarioLigado++;
          else
            contadorBinarioDesligado++;
        }

        if (contadorBinarioLigado > contadorBinarioDesligado)
          binarioFinal += "1";
        else
          binarioFinal += "0";

        contadorBinarioLigado = 0;
        contadorBinarioDesligado = 0;
      }

      return Convert.ToInt32(binarioFinal, 2);
    }
  }
}