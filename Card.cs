namespace ToDo{
    class Card{
        public string Baslik{get; set;}
        public string Icerik{get; set;}
        public string AtananKisi{get; set;}
        public string Buyukluk{get; set;}

        public Card(string baslik,string icerik,string atananKisi,string buyukluk)
        {
            Baslik =baslik;
            Icerik= icerik;
            AtananKisi= atananKisi;
            Buyukluk = buyukluk;
        }
        public Card(){
            
        }
    }
}