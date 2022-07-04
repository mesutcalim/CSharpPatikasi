internal class Program
{
    private static void Main(string[] args)
    {
        //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). 
        //Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
        //Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
        Console.WriteLine("Kaç adet Sayıyı kontrol etmek istiyorsunuz:  ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] dizi1 = new int[n];
        Console.WriteLine("Kontrol etmek istediğiniz sayıları alt alta giriniz:  ");
        for (int i = 0; i < n; i++)
        {
            dizi1[i] = Convert.ToInt32(Console.ReadLine());
        }
        foreach (int sayilar in dizi1)
        {
            if (sayilar % 2 == 0)
            {
                Console.WriteLine(sayilar + "   bir çift sayidir.  ");
            }
            else
            {
                Console.WriteLine(sayilar + "   bir tek sayidir.  ");
            }

        }

        //Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). 
        //Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
        //Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.

        Console.WriteLine("\n\nİki sayı giriniz:  ");
        int k = Convert.ToInt32(Console.ReadLine());
        int l = Convert.ToInt32(Console.ReadLine());
        long[] dizi2 = new long[k];
        Console.WriteLine(k + "  sayısı kadar sayıları alt alta giriniz:  ");
        for (int i = 0; i < k; i++)
        {
            dizi2[i] = Convert.ToInt32(Console.ReadLine().Trim());
        }
            foreach (int sayilar in dizi2)
            {
                
                if (sayilar % l == 0)
                {
                    Console.WriteLine(sayilar + " sayısı " + l + " sayısı ile kalansız bölünür.");
                }
                else
                {
                    Console.WriteLine(sayilar + " sayısı " + l + " sayısı ile kalansız bölünmez." + sayilar % l + " kalır.");
                }
            }

        //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). 
        //Sonrasında kullanıcıdan n adet kelime girmesi isteyin. 
        //Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.


        Console.WriteLine("Kaç adet kelimeyi ters çevirmek istiyorsunuz:  ");
        int p = Convert.ToInt32(Console.ReadLine());
        string[] dizi3 = new string[p];
        Console.WriteLine("Ters çevirmek istediğiniz kelimeleri alt alta giriniz:  ");
        for (int i = 0; i < p; i++)
        {
            dizi3[i] = Console.ReadLine().Trim();
        }
        foreach (string words in dizi3)
        {
            for (int t = words.Length - 1; t >= 0; t--)
            {
                Console.Write(words[t]);
            }
            Console.WriteLine("");

        }

        //Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. 
        //Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

        int s = 0;
       
        Console.WriteLine("Uzunluğunu hesaplamak istediğiniz cümleyi giriniz:  ");
        string metin = Console.ReadLine().Trim();
        for (int y = metin.ToCharArray().Length-1; y >= 0; y--)
        {
            if (metin.ToCharArray()[y].ToString()!=" ") { 
                ++s;
            }
        }
        Console.Write(s);
    }
}
