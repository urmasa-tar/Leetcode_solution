using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Graph_package
{
    public class GraphByBinaryMatrix
    {
        public GraphByBinaryMatrix()
        {

        }

        public int FindCircleNum(int[][] isConnected)
        {
            int[] province_stat = new int[isConnected[0].Length];
            for (int i = 0; i < province_stat.Length; i++) { province_stat[i] = 0; }
            int current_group = 0;
            // Count number of groups
            // Обход из вершины, ели для неё ещё нету группы
            for(int node = 0; node < isConnected[0].Length; node++)
            {
                if (province_stat[node] == 0)
                {
                    bool[] connection = fromNodeDFS(isConnected, node);
                    for(int num_nd = 0; num_nd < isConnected[0].Length; num_nd++)
                    {
                        if (connection[num_nd]) { province_stat[num_nd] = 1;}
                    }

                    current_group += 1;
                }
                else
                {
                    continue;
                }
            }

            return current_group;
        }

        //Обход графа
        // DFS - поиск в глубину

        public bool[] fromNodeDFS(int[][] Connection, int rootNode)
        {
            bool[] result = new bool[Connection[0].Length];
            for (int i = 0; i < result.Length; i++){ result[i] = false; }

            result = recDFS(Connection, rootNode, result);

            return result;
        }
        
        public bool[] recDFS(int[][] Connaction, int rootNode, bool[] previos)
        {
            bool[] res = previos;

            if (res[rootNode] == false)
            {
                res[rootNode] = true;
                for (int i = 0; i < Connaction[rootNode].Length; i++)
                {
                    if (Connaction[rootNode][i] == 1)
                    {
                        res = recDFS(Connaction, i, res);
                    }
                }
            }

            return res;
        }
    }
}
