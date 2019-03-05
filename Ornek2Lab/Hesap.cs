using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek2Lab
{
    class Hesap
    {

        public static void MerkezKoordinatDikdortgen(Dikdortgen t)
        {
            Console.WriteLine("Merkez coord: x: " + t.coordDikdortgen.xkoordinati * 1 / 2 + "\nMerkez coord: y: " + t.coordDikdortgen.ykoordinati * 1 / 2);
        }

        public static void MerkezKoordinatDaire(Daire d)
        {
            Console.WriteLine("Merkez coord: x: " + d.coordDaire.xkoordinati + d.yCap + "\nMerkez coord: y: " + d.coordDaire.ykoordinati + d.yCap);
        }

        public static double CevreHesaplaDikdortgen(Dikdortgen t)
        {
            return 2 * (t.genislik + t.yukseklik);
        }

        public static double CevreHesaplaDaire(Daire d)
        {
            return 2 * Math.PI * d.yCap;
        }

        public static double AlanHesaplaDikdortgen(Dikdortgen t)
        {
            return t.yukseklik * t.genislik;
        }

        public static double AlanHesaplaDaire(Daire d)
        {
            return Math.PI * Math.Pow(d.yCap, 2);
        }
    }

    public struct Koordinat
    {
        public int xkoordinati, ykoordinati;
    }

    public struct Daire
    {
        public int yCap;
        public Koordinat coordDaire;
    }

    public struct Dikdortgen
    {
        public int yukseklik, genislik;
        public Koordinat coordDikdortgen;

    }
}
