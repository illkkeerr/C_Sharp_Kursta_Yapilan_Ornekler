using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Generic_Listeler
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Ogrenci<int> ogr = new Ogrenci<int>();

            //ogr.Temsilitip = 0;

            Ogrenci<string, int, char> ogrenci = new Ogrenci<string, int, char>();
            ogrenci.Temsilitip = "aa";
            ogrenci.Sinif = 'L';
            ogrenci.OkulNo = 1;

            Ogrenci<Ders<string>, int, decimal> ogr2 = new Ogrenci<Ders<string>, int, decimal>();


            // Ogrenci<int, string, double> ogr3 = new Ogrenci<int, string, double>();

            List<int> list = new List<int>();
            list.Add(1);
            MetotGeneric mtr = new MetotGeneric();
            mtr.Ekle<string>("Badem");

        }
    }

    class Ogrenci<T, H, Y> where T : class where Y : struct where H : struct
    {
        //Generic : Dışarıdan bir tip alarak çalışmayı sağlayan yapı 
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public Y Sinif { get; set; }
        public H OkulNo { get; set; }
        public T Temsilitip { get; set; }
    }

    class Ders<T>
    {
        public int DersId { get; set; }
        public string DersAdi { get; set; }
        public T Kitabi { get; set; }
    }
    class MetotGeneric
    {
        public void Ekle<T>(T prm)
        {

        }
    }
}
