// See https://aka.ms/new-console-template for more information
//Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan,  
//her iki grubun kendi içerisinde ortalamalarını alan ve 
//bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. 
//(Array sınıfını kullanarak yazınız.)

using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
    int[] sayilar= new int[20];
    int[] minsayilar= new int[3];
    int[] maxsayilar= new int[3];
    Console.WriteLine("20 adet sayı giriniz: ");
    for(int i=0;i<20;++i){
    int a=Convert.ToInt32(Console.ReadLine());
    sayilar[i]=a;
    }
    Array.Sort(sayilar);
    for(int j=0;j<3;++j)
    {
    minsayilar[j]=sayilar[j];
    }
    Array.Reverse(sayilar);
    for(int j=0;j<3;++j)
    {
    maxsayilar[j]=sayilar[j];
    }
double z= minsayilar.Average();
double y= maxsayilar.Average();
Console.WriteLine("Ortalamalar: \nMin sayilar ortalaması: "+ z +"\nMax sayilar ortalaması:  " + y + " \nToplamları: " + (z+y));
}
}
