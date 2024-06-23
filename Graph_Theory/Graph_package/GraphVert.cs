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

        public bool CanVisitAllRooms(IList<IList<int>> rooms)
        {
            bool res = false;
            bool[] ArrOfStatus = new bool[rooms.Count];
            for (int i = 0; i < rooms.Count; i++) { ArrOfStatus[i] = false; }
            ArrOfStatus[0] = true;
            ArrOfStatus = BFSfromNode(rooms, ArrOfStatus, 0);



            return res;
        }

        private bool[] BFSfromNode(IList<IList<int>> rooms, bool[] currentStatus, int node)
        {
            bool[] res = currentStatus;

            for(int i = 0; i < rooms[node].Count; i++)
            {
                if (res[rooms[node][i]])
                {
                    continue;
                }
                else
                {
                    res[rooms[node][i]] = true;
                    res = BFSfromNode(rooms, res, node);
                }
            }

            return res;
        }

        private bool checkForStat(bool[] stat)
        {
            bool res = true;
            for(int i = 0; i < stat.Length; i++)
            {
                if (stat[i])
                {
                    continue;
                }
                else
                {
                    res = false;
                    break;
                }
            }
            return res;
        }

    }
}
