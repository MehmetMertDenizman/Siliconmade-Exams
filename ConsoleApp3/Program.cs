//for (int i=1; i < 9; i++)
//{
//    if (i < 9) { Console.Write("|"); }
//    for (int j = 1; j <9; j++)
//    {

//        Console.Write("0");
//        if(j == 8) { Console.Write("|"); }
//    }
//    Console.WriteLine();
//}

//Console.WriteLine("----------");

//int toplam = 0; 
//for (int i = 1; i < 101; i++) 
//{
//    Console.Write((i*i) + " + ");
//    toplam += i;
//}

//Console.WriteLine(" = "+toplam);

//int toplam = 0;
//for (int i = 20; i >= 1; i--)
//{
//    Console.Write(i );
//    if(i > 1)
//    Console.Write("-");
//    if(i % 2 == 0)
//    {
//        toplam += i;
//    }

//}
//Console.WriteLine("\n" + toplam);


//Random rnd = new Random();
//int sayı = rnd.Next(1,101);
//int sayac = 1;
//Console.WriteLine(sayı);

//int x;


//do
//{
//    Console.Write(sayac + ".Sayı: ");
//    x = int.Parse(Console.ReadLine());
//   if (sayac == 7)
//    {
//        Console.WriteLine("Deneme hakkın bitti"); 
//    }
//    if (x < sayı && sayac < 7)
//    {
//        Console.WriteLine("Daha büyük bir sayı giriniz");
//    }

//    else if (x > sayı && sayac < 7) 
//    { 
//        Console.WriteLine("Daha küçük bir sayı giriniz");
//    }


//    sayac++;



//}
//while (x != sayı && sayac <= 7);
//if (x == sayı) { Console.WriteLine("Bildin"); }


//Console.WriteLine("Deneme sayısı: " + (sayac - 1));


// static string FirstReverse(string str)
//{

//    // code goes here  
//    return str;

//}
//string a =  FirstReverse(Console.ReadLine());
//char[] charArray =  FirstReverse(a).ToCharArray();
//Array.Reverse(charArray);
//Console.WriteLine(charArray);

//Console.Write("1.Ürünün fiyatı:");

//int fiyat1 = int.Parse(Console.ReadLine());
//Console.Write("2.Ürünün fiyatı:");
//int fiyat2 = int.Parse(Console.ReadLine());

//var result = fiyat1 + fiyat2 >= 200 ? fiyat1 + (fiyat2-(fiyat2 * 25 / 100)) : fiyat1+fiyat2; 
//Console.WriteLine("Toplam ödeme: " + result);

//int toplam = 0;
//for (int i = 1; i<=25; i++) 
//    {
//    toplam += i * i;

//}
//Console.WriteLine(toplam);

//----------------------------------------------------------------------

//Console.Write("Kaç sayı girilecek: ");
//int kacSayi = int.Parse(Console.ReadLine());
//int arraySayi = kacSayi;
//List<int> sayilar = new List<int>(arraySayi) ;
//int tek = 0;
//int cift = 0;
//while (kacSayi > 0)
//{
//    kacSayi--;
//    Console.Write("Sayı: ");
//    int sayiSor = int.Parse(Console.ReadLine());

//    sayilar.Add(sayiSor);


//}
//for (int i = 0; i < sayilar.Count; i++)
//{

//    if(sayilar[i] % 2 == 0){ cift++; }
//    else if(sayilar[i] % 2 == 1){ tek++; }
//}
//Console.WriteLine("Tek sayı adedi: " + tek);
//Console.WriteLine("Çift sayı adedi: " + cift);

//Console.WriteLine("En büyük sayı: " + sayilar.Max());
//Console.WriteLine("En küçük sayı: " + sayilar.Min());

//----------------------------------------------------------------------

//List<int> ikiSayi = new List<int>();
//List<int> ucİleBolunenList = new List<int>();
//List<int> ortalama = new List<int>();



//Console.Write("İlk sayı:");
//ikiSayi.Add(int.Parse(Console.ReadLine()));
//Console.Write("İkinci sayı:");
//ikiSayi.Add(int.Parse(Console.ReadLine()));
//int ucİleBolunen = 0;

//ikiSayi.Sort();
//while (ikiSayi.Min()<ikiSayi.Max())
//{

//    ikiSayi[0]++;
//    Console.WriteLine("küçük sayı şimdi: " + ikiSayi[0]);
//    ortalama.Add(ikiSayi[0]);


//}
//for (int i = 0; i < ortalama.Count; i++) 
//{
//    if(ortalama[i] % 3 == 0)
//    {

//        ucİleBolunenList.Add(ortalama[i]);
//        ucİleBolunen++;
//    }
//}

//Console.WriteLine("Üç ile bölünen sayı adedi: " + ucİleBolunen);
//Console.WriteLine("Üç ile bölünen ortalaması: " + ucİleBolunenList.Average());

//----------------------------------------------------------------------

//int sayac = 1; 
//int toplam = 10;
//while(toplam <= 1000) 
//{ 
//    toplam += toplam +   5 ;
//    sayac++;

//}

//Console.WriteLine(sayac + " günde okumuştur.");

//Console.Write("Asal sayı girin: ");
//int kontrol = int.Parse(Console.ReadLine());


//if (kontrol % kontrol == 0 && kontrol / 1 == kontrol && kontrol % 2 != 0 && kontrol % 3 != 0 && kontrol % 4 != 0 && kontrol % 5 != 0 && kontrol % 6 != 0 && kontrol % 7 != 0 &&   kontrol % 8 != 0 && kontrol % 9 != 0)
//{ Console.WriteLine("Sayı asal"); }
//else 
//{ 
//    Console.WriteLine("DEĞİL"); 
//}



Console.Write("Lütfen para miktarını giriniz: ");
int paraCek = int.Parse(Console.ReadLine());
int sayac_100 = 0;
int sayac_10 = 0;
int sayac_20 = 0;
int sayac_50 = 0;
int yuzdenKalan = 0;
int ondanKalan = 0;
int yirmidenKalan = 0;
int ellidenKalan = 0;
int sayac= 0;
while (sayac < 1) 
{
    sayac++;
    if (paraCek % 10 != 0)

    {
        Console.WriteLine("En küçük 10 TL’ lik banknot mevcut..!  10'un katı bir değer girin.");
    }
    else if(paraCek % 10 == 0) 
    {
        sayac_100 = paraCek / 100;
        yuzdenKalan = paraCek - (sayac_100 * 100);  //2480- 2400 = 80
        sayac_50 = yuzdenKalan / 50;
        ellidenKalan = yuzdenKalan - (sayac_50 * 50) ;//if ekle 20 için
        sayac_20 = ellidenKalan / 20;
        yirmidenKalan = ellidenKalan - (sayac_20 * 20);
        sayac_10 = yirmidenKalan / 10 ;
        ondanKalan = yirmidenKalan - (sayac_10 * 10);
    }
}
Console.WriteLine("100: " + sayac_100 + " 50: " + sayac_50 + " 20: " + sayac_20 + " 10: " + sayac_10);
Console.WriteLine(paraCek);