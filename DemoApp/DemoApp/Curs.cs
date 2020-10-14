using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp
{
    public static class Curs
    {
        public static int CursId { get; set; }
        public static string Nume { get; set; }
        public  static int Durata { get; set; }

        //public Curs(int cursId,string nume)
        //{
        //    CursId = cursId;
        //    Nume = nume;
        //}

        //public Curs(string nume, int durata)
        //{
        //    Nume = nume;
        //    Durata = durata;

        //}

        public static void SetareCurs(int id, string name)
        {
            CursId = id;
            Nume = Nume;

        }




    }
}
