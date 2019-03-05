using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek2Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Daire deneme = new Daire();
            deneme.coordDaire.xkoordinati = 3;
            deneme.coordDaire.ykoordinati = 4;
            deneme.yCap = 3;

            Dikdortgen deneme2 = new Dikdortgen();
            deneme2.coordDikdortgen.xkoordinati = 3;
            deneme2.coordDikdortgen.ykoordinati = 4;
            deneme2.genislik = 3;
            deneme2.yukseklik = 5;

            Console.WriteLine("Daire ornegi" + " yaricap= " + deneme.yCap + " koordinatlar: " + deneme.coordDaire.xkoordinati + " , " + deneme.coordDaire.ykoordinati);
            Console.WriteLine("Daire alan = " + Hesap.AlanHesaplaDaire(deneme));
            Console.WriteLine("Daire cevre = " + Hesap.CevreHesaplaDaire(deneme));
            Hesap.MerkezKoordinatDaire(deneme);

            Console.WriteLine("\nDikdortgen ornegi");
            Console.WriteLine("Daire ornegi" + " genislik = " + deneme2.genislik + " yukseklik =  " + deneme2.yukseklik + " koordinatlar: " + deneme2.coordDikdortgen.xkoordinati + " , " + deneme2.coordDikdortgen.xkoordinati);
            Console.WriteLine("Dikdortgen alan = " + Hesap.AlanHesaplaDikdortgen(deneme2));
            Console.WriteLine("Dikdortgen cevre = " + Hesap.CevreHesaplaDikdortgen(deneme2));
            Hesap.MerkezKoordinatDikdortgen(deneme2);

            Console.ReadKey();
        }
    }
}
