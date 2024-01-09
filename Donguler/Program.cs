
//Döngüler bir kod bloğunu birden çok kez çalıştırmaya yarayan mekanizmalardır.



#region Tanım
// For Döngüsü
//for(int i = 0; i < 20; i++)
//{

//    Console.WriteLine(i);

//}


// ikişer ikişer artırma

//for (int i = 0; i < 20; i+=2)
//{
//    Console.WriteLine(i);
//}



// i değerini 0dan başka değer ile başlatmak

//for (int i = 20; i < 50; i++)
//{
//    Console.WriteLine(i);
//}



// Ter çevirebiliriz

//for (int i = 50; i >= 0; i--)
//{
//    Console.WriteLine(i);
//}
#endregion


#region örnek1
// 1'den 100 e kadar çift sayıların toplamı nedir ?


// Version 1
//int sonuc = 0;
//for (int i = 0; i <= 100; i++)
//{

//    if (i % 2 == 0)
//    {

//        sonuc += i;
//    }
//}

//Console.WriteLine(sonuc);

//Version 2
//int sonuc = 0;
//for (int i = 0; i <= 100; i += 2)
//{
//    sonuc += i;
//}

//Console.WriteLine(sonuc);

#endregion




#region Örnek 2
//// bana 100 adet 1 ile 10 arasında random sayı üretiniz


//Random rnd = new Random();

//for (int i = 0; i < 100; i++)
//{
//    Console.WriteLine(rnd.Next(1,11));  
//}

#endregion



//Uygulama ilk açıldığında kaç sayıyının ortalamasını alacaksın mesajı görünecek.
//Buradan aldığımız değer ile for döngüsünün kaç kere döneceğini ayarlayacağız
// girilen sayı adedi kadar rakam girip bu rakamların ortalamasını alacak uygulama



#region örnek3
//Console.WriteLine("Bir sayı gir");
//int sayi = Convert.ToInt32(Console.ReadLine());



//int toplam = 0;
//for (int i = 0; i < sayi; i++)
//{

//    Console.WriteLine("{0} . sayıyı giriniz", i);

//    toplam += Convert.ToInt32(Console.ReadLine());
//}
//Console.WriteLine(toplam / sayi);
#endregion


#region Örnek 4
// girilen iki sayı arasındaki sayıların toplamını bulan kodu yazınız



//Console.WriteLine("1 sayıyı gir");
//int sayi1 = Convert.ToInt32(Console.ReadLine());


//Console.WriteLine("2 sayıyı gir");
//int sayi2 = Convert.ToInt32(Console.ReadLine());

//if (sayi1 < sayi2)
//{

//    int toplam = 0;
//    for (int i = sayi1; i <= sayi2; i++)
//    {
//        toplam += i;
//    }
//    Console.WriteLine(toplam);


//}
//else
//{

//    Console.WriteLine("ilk sayı her zaman küçük olmalıdır");
//}

#endregion

#region Örnek5
// Tahmin oyunu : 

//Random rnd = new Random();
//int random = rnd.Next(1, 50);
//for (int i = 0; i < 1000; i++)
//{
//    Console.WriteLine("Tahmin {0} : ", i);
//    int tahmin = Convert.ToInt32(Console.ReadLine());
//    if (tahmin > random)
//        Console.WriteLine("Aşağı");
//    else if (tahmin < random)
//        Console.WriteLine("yukarı");
//    else if (tahmin == random)
//    {
//        Console.WriteLine("Süper tahmin");

//        // döngünün sonlanması için i değerini döngünün maximumuna getirdik
//        i = 1000;
//    }
//}


#endregion

#region Sonsuz döngü
// sonsuz döngü
//for (; ;)
//{

//}

#endregion

// For döngüsü istisna olarak char ile kullanılabilir: Char harflerinin birer ascii numaraya denk geldiği için bu mümkündür

//for (char i='a'; i < 'z'; i++)
//{
//    Console.WriteLine(i);
//}


// İç içe for

//for (int i = 1; i <= 10; i++)
//{
//	Console.WriteLine("Dış for {0}",i);
//	for (int j = 1; j <= 10; j++)
//	{
//		Console.WriteLine("İç for {0}",j);

//	}
//}



//Hesap Makinası
//for (int i = 1; i <= 10; i++)
//{


//	Console.WriteLine("***************************");
//	for (int j = 1; j <= 10; j++)
//	{
//		Console.WriteLine("{0}x{1}={2}", i, j, i * j);
//	}
//}




// Ekrandan aldığı değerler ile ekrana kare çizdiren uygulama

//Console.WriteLine("Genişlik giriniz");
//int sayi1 = Convert.ToInt32(Console.ReadLine());


//Console.WriteLine("Yüksellik  giriniz");
//int sayi2 = Convert.ToInt32(Console.ReadLine());



//for (int i = 0; i < sayi2; i++)
//{

//	for (int k = 0; k < sayi1; k++)
//	{
//		Console.Write("x");
//	}
//	Console.WriteLine();
//}





// Ekrana 3gen cizdiren uygulama



//int sayi1 = 100;

//for (int i = 0; i < sayi1; i++)
//{
//	for (int k = 0; k < i; k++)
//	{
//		Console.Write("*");
//	}

//	Console.WriteLine();	
//}




// .tek for : klavyeden girilen 10 adet sayının en küçük ve en büyüğünü ekrana yazdıran uygulama


//int enbuyuk = 1;
//int enkucuk = int.MaxValue;


//for (int i = 1; i <= 10; i++)
//{
//	Console.WriteLine("sayi giriniz");
//	int sayi = Convert.ToInt32(Console.ReadLine());
//	if(enkucuk>sayi) enkucuk = sayi;
//	if(enbuyuk<sayi) enbuyuk = sayi;	
//}


//Console.WriteLine("En küçük {0}", enkucuk);

//Console.WriteLine("En büyük {0}", enbuyuk);



// ekrandan sayi alacaksınız
// 1-1000 arasındaki asal sayıları ekrana yazdıran uygulama



//// Asal Sayıları bulan kod örneği
///
//int sayac;
//for (int i = 2; i < 1000; i++)
//{
//	sayac = 0;
//	for (int k = 2; k < i; k++)
//	{

//		if (i % k == 0)
//		{
//			sayac++;
//		}

//	}
//	if (sayac == 0) {

//		Console.WriteLine("Asal Sayı : {0}", i);

//	}

//}


//


// Finonacci sayılarını bulma
//long sayi1 = 0;
//long sayi2 = 1;

//for (int i = 3; i < 100; i++)
//{

//    long fibo = sayi1 + sayi2;

//    Console.WriteLine(fibo);
//    sayi1 = sayi2;
//    sayi2 = fibo;

//}

// 1 ile 49 arasında 6 adet sayı alınız
// 1 ile 49 arasında 6 adet random sayı oluşturacaksınız



// While Döngüsü


//int i = 0;

//while (i<10)
//{
//    Console.WriteLine(i);
//    i++;
//}


// while ile çarpım tablosu

int i = 0;

while (i<=10)
{
   
    int k = 1;
    Console.WriteLine("-------------------");
    while (k<=10)
	{
		Console.WriteLine("{0}x {1}={2}", i, k, i * k);
		k++;
	}

    i++;

}