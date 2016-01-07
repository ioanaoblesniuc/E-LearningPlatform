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
    class SQLHelper
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public void selectStudenti()
        {
            var query = from s in db.Studentis where s.ID_stud != 1 select s.Nume;
            foreach (var s in query)
                Console.WriteLine(s);
        }

        public void selectStudentifromGrupa(string grupa)
        {
            var query = from c in db.Studentis join e in db.Grupes on c.Grupa equals e.ID_grupa where e.NumeGrupa==grupa select new {Nume=c.Nume, Grupa=e.NumeGrupa, Grad = c.Grad };
            foreach (var g in query)
                Console.WriteLine(g);
        }
        public void selectStdCivil()
        {
            var query = from c in db.Studentis where c.Grad != "StdSg" select c.Nume;
            foreach (var c in query)
                Console.WriteLine(c);
        }

    }
}
