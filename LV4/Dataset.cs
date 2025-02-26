﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV4
{
    class Dataset
    {
        private List<List<double>> data;
        public Dataset()
        {
            this.data = new List<List<double>>();
        }
        public Dataset(string filePath) : this()
        {
            this.LoadDataFromCSV(filePath);
        }
        public void LoadDataFromCSV(string filePath)
        {
            string[] lines = System.IO.File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                List<double> row =
               new List<double>(Array.ConvertAll(line.Split(';'), double.Parse));
                this.data.Add(row);
            }
        }
        public IList<List<double>> GetData()
        {
            return new System.Collections.ObjectModel.ReadOnlyCollection<List<double>>(this.data);
        }
    }
}
