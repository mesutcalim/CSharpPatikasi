namespace ToDo{
    class Board{
        private static List<Card> todo = new List<Card>();
        private static List<Card> progress = new List<Card>();
        private static List<Card> done = new List<Card>();

        public static void kartOlustur(){
            Console.WriteLine("Başlık Giriniz :");
            string baslik = Console.ReadLine();
            Console.WriteLine("İçerik Giriniz :");
            string icerik = Console.ReadLine();
            Console.WriteLine("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)  :");
            int boyut =Convert.ToInt32(Console.ReadLine());

            buyuk buyukluk=(buyuk)boyut;
              
            Console.WriteLine("Kişi Giriniz :");
            string atananKisi = Console.ReadLine();

            todo.Add(new Card(){Baslik = baslik,Icerik=icerik,Buyukluk=buyukluk.ToString(),AtananKisi=atananKisi });
            
        }

        public static void boardList()
        {   
            Console.WriteLine("todo Line");
            Console.WriteLine("---------------------------------------------------------");
            foreach(var items in todo){
                
                Console.WriteLine(" Başlık      : {0}", items.Baslik);
                Console.WriteLine(" İçerik      : {0}", items.Icerik);
                Console.WriteLine(" Atanan Kişi : {0}", items.AtananKisi);
                Console.WriteLine(" Büyüklük    : {0}", items.Buyukluk);
                Console.WriteLine("-");
            }
             Console.WriteLine("progress Line");
            Console.WriteLine("---------------------------------------------------------");
            foreach(var items in progress){
                Console.WriteLine(" Başlık      : {0}", items.Baslik);
                Console.WriteLine(" İçerik      : {0}", items.Icerik);
                Console.WriteLine(" Atanan Kişi : {0}", items.AtananKisi);
                Console.WriteLine(" Büyüklük    : {0}", items.Buyukluk);
                Console.WriteLine("-");
            }
             Console.WriteLine("done Line");
            Console.WriteLine("---------------------------------------------------------");
            foreach(var items in done){
                Console.WriteLine(" Başlık      : {0}", items.Baslik);
                Console.WriteLine(" İçerik      : {0}", items.Icerik);
                Console.WriteLine(" Atanan Kişi : {0}", items.AtananKisi);
                Console.WriteLine(" Büyüklük    : {0}", items.Buyukluk);
                Console.WriteLine("-");
            }

        }
       
        public static void cardDelete(){
            Console.WriteLine("Silmek istediğiniz kartı seçmeniz gerekiyor.");
            Console.WriteLine("Lütfen kart başlığını giriniz: ");
            string baslikDelete = Console.ReadLine();
            int counter=0;
            foreach(var items in todo.ToList()){
                if(items.Baslik==baslikDelete){
                    todo.Remove(items);
                    counter++;
                }
            }
            if(counter==0){
                foreach(var items in progress.ToList()){
                    if(items.Baslik==baslikDelete){
                    progress.Remove(items);
                    counter++;
                    }
                }
            }
            if(counter==0){
                foreach(var items in done.ToList()){
                    if(items.Baslik==baslikDelete){
                    done.Remove(items);
                    counter++;
                    }
                }
            }
            if(counter==0){
                Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("Silmeyi sonlandırmak için : (1)");
                Console.WriteLine("Yeniden Denemek için : (2)");
                string deleteTry=Console.ReadLine();
                if(deleteTry=="1"){return;}
                else if(deleteTry=="2"){cardDelete();}
                else{Console.WriteLine("Hatali giriş yaptınız ana menüye yönlendiriliyorsunuz.");Console.ReadKey();return;}
            }
            
        }
        public static void cardMove(){
            Console.WriteLine("Silmek istediğiniz kartı seçmeniz gerekiyor.");
            Console.WriteLine("Lütfen kart başlığını giriniz: ");
            string baslikMove = Console.ReadLine();
            string moveChoice ;
            int counter=0;
            foreach(var items in todo.ToList()){
                if(items.Baslik==baslikMove){
                    Console.WriteLine(" Başlık      : {0}", items.Baslik);
                    Console.WriteLine(" İçerik      : {0}", items.Icerik);
                    Console.WriteLine(" Atanan Kişi : {0}", items.AtananKisi);
                    Console.WriteLine(" Büyüklük    : {0}", items.Buyukluk);
                    Console.WriteLine("Line : TODO");
                    todo.Remove(items);
                    Console.WriteLine("Taşımak istediğiniz Line'ı seçiniz:");

                    Console.WriteLine("(1) TODO \n(2) IN PROGRESS \n(3) DONE");
                    moveChoice=Console.ReadLine();
                    if(moveChoice=="1"){todo.Add(items);}
                    else if(moveChoice=="2"){progress.Add(items);}
                    else if(moveChoice=="3"){done.Add(items);}
                    else{Console.WriteLine("Hatali giriş yaptınız ana menüye yönlendiriliyorsunuz.."); Console.ReadKey();return;}
                    
                    counter++;
                }
            }
            if(counter==0){
                foreach(var items in progress.ToList()){
                    if(items.Baslik==baslikMove){
                        Console.WriteLine(" Başlık      : {0}", items.Baslik);
                    Console.WriteLine(" İçerik      : {0}", items.Icerik);
                    Console.WriteLine(" Atanan Kişi : {0}", items.AtananKisi);
                    Console.WriteLine(" Büyüklük    : {0}", items.Buyukluk);
                    Console.WriteLine("Line : IN PROGRESS");
                    
                    Console.WriteLine("Taşımak istediğiniz Line'ı seçiniz:");

                    Console.WriteLine("(1) TODO \n(2) IN PROGRESS \n(3) DONE");
                    moveChoice=Console.ReadLine();
                    progress.Remove(items);
                    if(moveChoice=="1"){todo.Add(items);}
                    else if(moveChoice=="2"){progress.Add(items);}
                    else if(moveChoice=="3"){done.Add(items);}
                    else{Console.WriteLine("Hatali giriş yaptınız ana menüye yönlendiriliyorsunuz.."); Console.ReadKey();return;}
                    
                    counter++;
                    
                    }
                }
            }
            if(counter==0){
                foreach(var items in done.ToList()){
                    if(items.Baslik==baslikMove){
                        Console.WriteLine(" Başlık      : {0}", items.Baslik);
                    Console.WriteLine(" İçerik      : {0}", items.Icerik);
                    Console.WriteLine(" Atanan Kişi : {0}", items.AtananKisi);
                    Console.WriteLine(" Büyüklük    : {0}", items.Buyukluk);
                    Console.WriteLine("Line : DONE");
                    
                    Console.WriteLine("Taşımak istediğiniz Line'ı seçiniz:");

                    Console.WriteLine("(1) TODO \n(2) IN PROGRESS \n(3) DONE");
                    moveChoice=Console.ReadLine();
                    done.Remove(items);
                    if(moveChoice=="1"){todo.Add(items);}
                    else if(moveChoice=="2"){progress.Add(items);}
                    else if(moveChoice=="3"){done.Add(items);}
                    else{Console.WriteLine("Hatali giriş yaptınız ana menüye yönlendiriliyorsunuz.."); Console.ReadKey();return;}
                    counter++;
                    }
                }
            }
            if(counter==0){
                Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("Silmeyi sonlandırmak için : (1)");
                Console.WriteLine("Yeniden Denemek için : (2)");
                string deleteTry=Console.ReadLine();
                if(deleteTry=="1"){return;}
                else if(deleteTry=="2"){cardDelete();}
                else{Console.WriteLine("Hatali giriş yaptınız ana menüye yönlendiriliyorsunuz.");Console.ReadKey();return;}
            }
            
        }
        public enum buyuk{
            XS=1,S,M,L,XL
        }

    }
}