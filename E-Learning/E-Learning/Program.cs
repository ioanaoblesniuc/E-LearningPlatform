using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace E_Learning
{
    class Program
    {
        static void Main(string[] args)
        {
            SQLHelper sqlHelper = new SQLHelper();
            sqlHelper.selectStudenti();
            Console.ReadKey();
            sqlHelper.selectStudentifromGrupa("E213C");
            Console.ReadKey();
            sqlHelper.selectStdCivil();
            Console.ReadKey();
        }
    }
}