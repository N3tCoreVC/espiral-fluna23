using System;

namespace ejercicios
{
    class Program
    {
        static int num;
        static void Main(string[] args)
        {
            Console.WriteLine("Dame número para espiral: ");

            if (int.TryParse(Console.ReadLine(), out num))
            {
                esp(num+1);
            }
            else
                Console.WriteLine("Número inválido.");
        }

        static void esp(int val)
        {
            String[,] arre = new String[val, val];
            int dir = 3, o = val, fija = 0, pos = 0, aux = 0;
            for (int i = 0; i < val; i++)
            {
                for (int j = 0; j < val; j++)
                {
                    arre[i, j] = " ";

                }
            }
            for (int i = 0; i < val + 1; i++)
            {
                if (dir == 1)
                {
                    for (int j = pos; j < o; j++)
                    {
                        arre[fija, j] = "|";
                        aux = j;
                    }
                    pos = fija + 1;
                    fija = aux;
                    dir = 2;
                    if(i != 0)
                        o--;
                }
                else if (dir == 2)
                {
                    for (int j = pos; j < o; j++)
                    {
                        arre[j, fija] = "|";
                        aux = j;
                    }
                    pos = fija;
                    fija = aux;
                    dir = 3;
                    o--;
                }
                else if (dir == 3)
                {
                    for (int j = val - o; j < pos; j++)
                    {
                        arre[fija, j] = "|";
                        aux = j;
                    }
                    pos = fija;
                    fija = val - o;
                    dir = 4;
                }
                else if (dir == 4)
                {
                    for (int j = val - o; j < pos; j++)
                    {
                        arre[j, fija] = "|";
                        aux = j;
                    }
                    pos = fija + 1;
                    fija = val - o;
                    dir = 1;
                }
            }
            for (int i = 0; i < val; i++)
            {
                for (int j = 0; j < val; j++)
                {
                    Console.Write(arre[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
