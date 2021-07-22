using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Program
    {
        const int V = 6;
        /// <summary>
        /// try to release diicstra alhorithms
        /// </summary>
        /// <param name="args"></param>
       static void Dikstra(int[,] G,int st)
        {
            int[] distant = new int[V];
            int count, index=0, i, u, m = st + 1;
            bool[] visided = new bool[V];
            for ( i = 0; i < V; i++)
            {
                distant[i] = int.MaxValue;
                visided[i] = false;
            }
            for (count = 0; count < V-1; count++)
            {
                int min = int.MaxValue;
                for (i = 0; i < V; i++)
                {
                    if (!visided[i] && distant[i]<=min)
                    {
                        min = distant[i];
                        index = i;
                    }
                    u = index;
                    visided[u] = true;
                    for ( i = 0; i < V; i++)
                    {
                        if (!visided[i] && G[u,i] && distant[u] != int.MaxValue &&
distant[u] + G[u,i] < distant[i])
                            distant[i] = distant[u] + G[u,i];
                    }
                    Console.WriteLine("Стоимость пути из начальной вершины до остальных:");
                        for ( i = 0; i < V; i++)
                            if (distant[i]!=int.MaxValue)
                            {
                                Console.WriteLine(m+" > "+(i+1)+" = "+distant[i]);
                            }
                            else
                            {
                                Console.WriteLine(m + " > " + (i + 1)+" = маршрут недоступен");
                            }
                        
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int start;
            int[,] GR = new int[V, V] {{ 0, 0, 4, 0, 2, 0 },
                                       { 0, 0, 0, 9, 0, 0 },
                                       {4, 0, 0, 7, 0, 0 },
                                       {0, 9, 7, 0, 0, 0 },
                                       { 0, 0, 0, 0, 0, 8 },
                                       { 0, 0, 0, 0, 0, 0}};
            Console.WriteLine("Начальная вершина:{0} ",start=int.Parse(Console.ReadLine()));
            Dikstra(GR, start);
            Console.ReadKey();
        }
    }
}
