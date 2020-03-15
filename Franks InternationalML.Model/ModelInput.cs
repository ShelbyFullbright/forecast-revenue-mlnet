// This file was auto-generated by ML.NET Model Builder. 

using Microsoft.ML.Data;

namespace Franks_InternationalML.Model
{
    public class ModelInput
    {
        [ColumnName("Year"), LoadColumn(0)]
        public float Year { get; set; }


        [ColumnName("Month"), LoadColumn(1)]
        public float Month { get; set; }


        [ColumnName("Day"), LoadColumn(2)]
        public float Day { get; set; }


        [ColumnName("Day_Revenue"), LoadColumn(3)]
        public float Day_Revenue { get; set; }


        [ColumnName("Month_Revenue"), LoadColumn(4)]
        public float Month_Revenue { get; set; }


    }
}