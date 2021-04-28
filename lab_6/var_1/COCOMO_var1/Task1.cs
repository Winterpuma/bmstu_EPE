using System;
using System.Collections.Generic;
using System.Text;
using COCOMO.Attributes;

namespace COCOMO_var1
{
	class Task1
	{
        // Исследуем влияние ACAP, AEXP, PCAP, LEXP

        public double c1, c2, p1, p2;


        private void Main()
		{
            for (int paramN = 0; paramN < 4; paramN++)
			{
                var levels = new int[4]; // acap, aexp, pcap, lexp

                for (int kloc = 25; kloc < 900; kloc += 400) // Проходим по трем уровням проекта
			    {
                    for (int value = -1; value <= 1; value++)
				    {
                        levels[paramN] = value; // Варьируем значение текущего параметра

                        double EAF = 
                            Personnel.ACAP(levels[0]) * 
                            Personnel.AEXP(levels[1]) *
                            Personnel.PCAP(levels[2]) *
                            Personnel.LEXP(levels[3]);

                        SetConst(kloc);

                        var work = c1 * EAF * Math.Pow(kloc, p1);
                        var time = c2 * Math.Pow(work, p2);
                    }
			    }
			}
		}


        void SetConst(int kloc)
        {
            // Обычный
            if (kloc < 50)
            {
                c1 = 3.2;
                p1 = 1.05;
                c2 = 2.5;
                p2 = 0.38;
            }
            // Промежуточный
            else if (kloc <= 500)
            {
                c1 = 3;
                p1 = 1.12;
                c2 = 2.5;
                p2 = 0.35;
            }
            // Встроенный
            else
            {
                c1 = 2.8;
                p1 = 1.2;
                c2 = 2.5;
                p2 = 0.32;
            }
        }
    }
}
