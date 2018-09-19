using System;

namespace ejercicios
{
    class Program
    {
        static int num, resu = 0;
        static void Main(string[] args)
        {
            int res = 1;
            Console.WriteLine("Dame número: ");

            if (int.TryParse(Console.ReadLine(), out num))
            {
                for (int i = 1; i <= num; i++)
                    res = res * i;
                Console.WriteLine($"El factorial de {num} es {res}.");
                sumaR(1);

                res = suma(num);
                Console.WriteLine($"La suma de {num} con return es {res}.");

                tri(num);
                esp(num);
            }
            else
                Console.WriteLine("Número inválido.");
        }

        static int suma(int nume)
        {
            int resl = 0;
            for (int i = 1; i <= nume; i++)
            {
                if (i % 2 == 0)
                    resl = resl + i;
            }
            return resl;
        }

        static void sumaR(int nume)
        {
            if (nume <= num)
            {
                if (nume % 2 == 0)
                    resu = resu + nume;
                sumaR(nume + 1);
            }
            else
            {
                Console.WriteLine($"La suma de {num} es {resu}.");
            }
        }

        static void tri(int val)
        {
            String cade = "";
            int lim = val, aux = 1;
            for (int i = 0; i < val; i++)
            {
                for (int j = 0; j < lim; j++)
                {
                    cade += " ";
                }
                for (int j = 0; j < aux; j++)
                {
                    cade += "1 ";
                }
                Console.WriteLine($"{cade}");
                cade = "";
                aux++;
                lim--;
            }
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
                Console.WriteLine("hola");
            }
        }
    }
}