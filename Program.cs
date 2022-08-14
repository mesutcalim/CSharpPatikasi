using System;
using System.Collections.Generic;

namespace ToDo{
    class Program{
        static void Main(string[] args){
            string choice= "";
            do{
                Console.WriteLine("Lütfen Yapmak İstediğiniz İşlemi Seçiniz :)");
                Console.WriteLine("*********************************************************");
                Console.WriteLine("(1) Board Listelemek");
                Console.WriteLine("(2) Board'a Kart Eklemek");
                Console.WriteLine("(3) Board'dan Kart Silmek");
                Console.WriteLine("(4) Kart Taşımak");
                Console.WriteLine("(5) Çıkış");
                choice=Console.ReadLine();

                switch(choice){
                    case "1":
                    Board.boardList();
                    break;
                    case "2":
                    Board.kartOlustur();
                    break;
                    case "3":
                    Board.cardDelete();
                    break;
                    case "4":
                    Board.cardMove();
                    break;
                    case "5":
                    continue;
                    default:
                    Console.WriteLine("Yanlış Değer girdiniz..");
                    break;
                }
        
            }while(choice!="5");

            Console.WriteLine("Çıkış Yapılıyor....");
            Console.ReadKey();

    }
}
}