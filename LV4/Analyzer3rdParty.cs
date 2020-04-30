using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV4
{
    class Analyzer3rdParty
    {
        public double[] PerRowAverage(double[][] data)
        {
            int rowCount = data.Length;
            double[] results = new double[rowCount];
            for (int i = 0; i < rowCount; i++)
            {
                results[i] = data[i].Average();
            }
            return results;
        }
        public double[] PerColumnAverage(double[][] data)
        {
            int row = data.Length;
            int column = data[0].Length;
            double[] results = new double[column];

            for (int i = 0; i < column; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    results[i] += data[j][i];
                }
    
                results[i] = results[i]/row; 
            }
            return results;
        }
    }
}


