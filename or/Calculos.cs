using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Festival.or
{
    class Calculos
    {
        public Calculos()
        {

        }

        public double mediaNota(double n1, double n2, double n3, double n4)
        {
            // Descontar maior e menor nota
            double max = n1;
            double min = n1;
            double soma = 0;
            int indiceMax = 0;
            int indiceMin = 0;

            List<double> valores = new List<double>();
            valores.Add(n1);
            valores.Add(n2);
            valores.Add(n3);
            valores.Add(n4);

            // Encontra minimo e deixa igual a 0
            for(int cont = 0; cont < 4; cont++)
            {
                if(valores[cont] < min)
                {
                    indiceMin = cont;
                    min = valores[cont];
                }
            }
            valores[indiceMin] = 0;

            // Encontra maximo e muda para 0
            for (int cont = 0; cont < 4; cont++)
            {
                if (valores[cont] > max)
                {
                    indiceMax = cont;
                    max = valores[cont];
                }
            }
            valores[indiceMax] = 0;

            // Soma todos os valores restantes
            for (int cont = 0; cont < 4; cont++)
            {
                soma += valores[cont];                
            }

            return soma / 2;
        }
    }
}
