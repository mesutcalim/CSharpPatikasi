using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        //Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. 
        //(ArrayList sınıfını kullanara yazınız.)
        ArrayList sayilar= new ArrayList();
        ArrayList asalSayilar = new ArrayList();
        ArrayList asalOlmayanSayilar = new ArrayList();
        uint toplam1 = 0;
        uint toplam2 = 0;
        double ort=0;
        Console.WriteLine("20 adet sayı giriniz: ");
        for(int a=1;a<=20; ++a){
            try{
            uint t= Convert.ToUInt32(Console.ReadLine());
            sayilar.Add(t);
            }
            catch(Exception ex){
                Console.WriteLine("Hatalı işlem yaptınız. \nHata Mesajı: "+ ex.Message);
                a--;
            }
        }
        foreach(uint eleman in sayilar){
        if(Asalmi(eleman)){
            asalSayilar.Add(eleman);
        }
        else{
            asalOlmayanSayilar.Add(eleman);
        }
        }
        Console.WriteLine("\n**********asal sayılar********\n");
        asalSayilar.Sort();
        asalSayilar.Reverse();
        foreach(uint y in asalSayilar)
        {
            toplam1 += y;
            Console.Write(y + " ");
        }
        ort = (toplam1)/asalSayilar.Count;
        Console.WriteLine("\nDizinin eleman sayısı: "   + asalSayilar.Count);
        Console.WriteLine("Dizinin ortalaması: "+ ort);
        Console.WriteLine("\n**********asal olmayan sayılar********\n");
        asalOlmayanSayilar.Sort();
        asalOlmayanSayilar.Reverse();
        foreach(uint a in asalOlmayanSayilar)
        {
            toplam2 += a;
            Console.Write(a + " ");
        }
        ort = (toplam2)/asalOlmayanSayilar.Count;
        Console.WriteLine("\nDizinin eleman sayısı: "   + asalOlmayanSayilar.Count);
        Console.WriteLine("Dizinin ortalaması: "+ ort );
    }
    
    private static bool Asalmi(uint sayi){
        int kontrol = 0;
        bool durum;
        for (int i = 2; i < sayi; i++)
        {
            if (sayi % i == 0)
        kontrol++;
        }

        if (kontrol != 0){
        durum = false;
        }
        else{
        durum = true;
        }


        return durum;
    }
}
