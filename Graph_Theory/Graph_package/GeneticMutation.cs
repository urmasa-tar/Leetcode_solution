using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Graph_package
{
    public class GeneticMutation
    {
        public GeneticMutation() { }

        public int MinMutation(string startGene, string endGene, string[] bank)
        {
            int res = 0;
            int[][] matrixOfLength = new int[bank.Length + 2][];
            for(int i = 0; i < bank.Length + 2; i++)
            {
                if(i == 0)
                {
                    matrixOfLength[i] = new int[bank.Length + 2];
                    for(int anotherStr = 0; anotherStr < bank.Length + 2; anotherStr++)
                    {
                        if((anotherStr != i) &(anotherStr != bank.Length + 1))
                        {
                            matrixOfLength[i][anotherStr] = DifBetwenStr(startGene, bank[anotherStr - 1]);
                        }
                        else
                        {
                            matrixOfLength[i][anotherStr] = 0;
                        }
                    }
                }else if(i == bank.Length - 1)
                {

                }
                else
                {

                }
            }
            return res;
        }

        public int DifBetwenStr(string str1, string str2)
        {
            int res = -1;

            return res;
        }
    }

}
