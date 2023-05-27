// See https://aka.ms/new-console-template for more information


// implicit conversion (bilinçli dönüşüm)
using System;

namespace tip_donusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
Console.WriteLine("*********implicit conversion**********");

byte a = 5;
sbyte b = 30;
short c = 10;

int d = a+b+c;
Console.WriteLine("d: " +d);

long h = d;
Console.WriteLine("h: " +h);

float i = h;
Console.WriteLine("h: " +h);

string e = "Enes";
char f = 'e';
object g = e+f+d;
Console.WriteLine("g: "+g);




// explicit converison (bilinçsiz dönüşüm)

Console.WriteLine("*********explicit conversion**********");

int x = 4;
byte y = (byte)x;
Console.WriteLine("y: "+y);

int z = 100;
byte t = (byte)z;
Console.WriteLine("t: "+t);

float w = 10.3f;
byte v = (byte)w;
Console.WriteLine("v: "+v);

//*****ToString methodu******

int xx = 5;
string yy = xx.ToString();
Console.WriteLine("yy: "+yy);

string ee = 12.5f.ToString();
Console.WriteLine("ee: "+ee);

//*****System.Convert******
Console.WriteLine("*********System.Convert sınıfı**********");

string s1="10", s2="21";
int sayi1, sayi2;
int toplam;

 sayi1 = Convert.ToInt32(s1);
 sayi2 = Convert.ToInt32(s2);

toplam = sayi1 + sayi2;

Console.WriteLine("Toplam: "+toplam);

//Parse
Console.WriteLine("*********Parse Methodu**********");
ParseMethod();

     }
        static void ParseMethod()
        {
              string metin1 = "10";
              string metin2 = "10.25";
              int rakam1;
              double d1;

               rakam1 = Int32.Parse(metin1);
               d1 = double.Parse(metin2);

              Console.WriteLine("rakam1: "+ rakam1);
              Console.WriteLine("d1: "+ d1);

        }
    }
}










