using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph_package
{
    public class GraphVert
    {
        public GraphVert()
        {

        }

        protected IList<int> EventualSafeNodes(int[][] graph)
        {
            IList<int> result = new List<int>();
            bool[] NoEnterStat = new bool[graph.Length];

            for(int num = 0; num < graph.Length; num++){
                if (graph[num].Length == 0) { NoEnterStat[num] = true; }
            }

            for(int num = 0; num < graph.Length; num++)
            {
                if (NoEnterStat[num]){ result.Add(num); }
                else
                {
                    if (CheckForNode(graph, NoEnterStat, num)) { result.Add(num);  }
                }
            }

            return result;
        }

        private bool CheckForNode(int[][] graph, bool[] EnterWay, int num)
        {
            bool status = true;

            for(int i = 0; i < graph[num].Length; i++)
            {
                if (!EnterWay[graph[num][i]])
                {
                    status = false;
                    break;
                }
            }

            return status;
        }
    }
}
