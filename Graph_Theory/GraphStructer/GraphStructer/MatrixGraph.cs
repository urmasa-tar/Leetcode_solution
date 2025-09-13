using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphStructer
{
    // Saving graph as a Matrix of n*n size 
    public class MatrixGraph
    {
        // Atributes for graph
        private bool isDirected;
        private int vertexCount;
        private int[,] matrix;
        //Class constructer
        public MatrixGraph(int count, bool directed = false)
        {
            this.isDirected = directed;
            this.vertexCount = count;
            this.matrix = new int[count, count];
            for (int i = 0; i < count; i++) { for (int j = 0; j < count; j++) { matrix[i, j] = 0; } }
        }

        public bool HasVertex(int vert_num) { return (vertexCount > vert_num); }
        public bool HasEdge(int from, int to) { return (this.matrix[from, to] != 0); }
        public void AddEdge(int from, int to, int weight = 1)
        {
            if ((weight < this.matrix[from, to]) || (matrix[from, to] == 0))
            {
                this.matrix[from, to] = weight;
                if (!this.isDirected)
                {
                    this.matrix[to, from] = weight;
                }
            }

        }

        public void RemoveEdge(int from, int to)
        {
            this.matrix[from, to] = 0;
            if (!this.isDirected) { this.matrix[to, from] = 0; }
        }


    }
}
