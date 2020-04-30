using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV4
{
    class Adapter : IAnalytics
    {
        private Analyzer3rdParty analyticsService;
        public Adapter(Analyzer3rdParty service)
        {
            this.analyticsService = service;
        }
        private double[][] ConvertData(Dataset dataset)
        {
            IList<List<double>> data = dataset.GetData();
            int row = data.Count;
            int column = data[0].Count;
            double[][] matrix = new double[row][];
            for(int i = 0; i<row; i++)
            {
                matrix[i] = new double[column];
            }

            for(int i = 0; i<row; i++)
            {
                for(int j = 0; j<column; j++)
                {
                    matrix[i][j] = data[i][j];
                }
            }
            return matrix;
        }
        public double[] CalculateAveragePerColumn(Dataset dataset)
        {
            double[][] data = this.ConvertData(dataset);
            return this.analyticsService.PerColumnAverage(data);
        }
        public double[] CalculateAveragePerRow(Dataset dataset)
        {
            double[][] data = this.ConvertData(dataset);
            return this.analyticsService.PerRowAverage(data);
        }
    }
}
