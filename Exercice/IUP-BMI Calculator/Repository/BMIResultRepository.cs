using IUP_BMI_Calculator.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SQLite.SQLite3;

namespace IUP_BMI_Calculator.Repository
{
    public class BMIResultRepository
    {
        string _dbPath;
        public string StatusMessage { get; set; }

        SQLiteConnection conn;

        private void Init()
        {
            if (conn != null)
                return;

            conn = new SQLiteConnection(_dbPath);
            conn.CreateTable<BMIResult>();
        }

        public BMIResultRepository(string dbPath)
        {
            _dbPath = dbPath;
        }

        public void AddNewBMIResult(string name, double height, double weight, double BMIScore, string BMIResult)
        {
            Init();
            int result = conn.Insert(new BMIResult { Name = name, Heigh = height, Weight = weight, BMIScore = BMIScore, Result = BMIResult });
            StatusMessage = string.Format("{0} record(s) added (Name: {1})", result, name);
        }
    }
}
