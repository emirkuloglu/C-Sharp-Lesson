Console.WriteLine("Hello World!");

/*
    // Nullable types
    int? maas = null;
    bool? isActive = null;

    Console.WriteLine(maas.HasValue);
    Console.WriteLine(maas.GetValueOrDefault());
    Console.WriteLine(isActive.GetValueOrDefault());
*/



/*
    //String Types

    // string? deki soru işareti, bu değişkenin null olabileceğini belirtir.
    // string? = var olarak da tanımlanabilir. ?ne gerek yoktur.

    Console.Write("adı: ");
    string? ad = Console.ReadLine();

    Console.Write("soyadı: ");
    var soyad = Console.ReadLine();

    Console.Write("yaşı: ");
    string? yas = Console.ReadLine();

    //String concat
    // string mesaj = ad + " " + soyad + " isimli kişi " + yas + " yaşındadır.";

    // String interpolation
    string mesaj = $"{ad} {soyad} isimli kişi {yas} yaşındadır.";

    Console.WriteLine(mesaj);
*/



/*
    //String Methods

    string mesaj = "Emir Kuloğlu isimli kişi 22 yaşındadır.";

    // var sonuc = mesaj.Length; // mesajın karakter sayısını alır
    // var sonuc = mesaj.ToLower(); // mesajı küçük harfe çevirir
    // var sonuc = mesaj.ToUpper(); // mesajı büyük harfe çevirir
    // var sonuc = mesaj.Trim(); // mesajın başındaki ve sonundaki boşlukları siler
    // var sonuc = mesaj.Split(" ")[0]; // mesajı boşluk karakterine göre böler ve ilk parçayı alır
    // var sonuc = mesaj[0]; // mesajın ilk karakterini alır
    // var sonuc = mesaj.StartsWith("B"); // mesajın "B" harfi ile başlayıp başlamadığını kontrol eder
    // var sonuc = mesaj.EndsWith(".");  // mesajın "." ile bitip bitmediğini kontrol eder
    // var sonuc = mesaj.Contains("Ali");  // mesajın "Ali" kelimesini içerip içermediğini kontrol eder
    // var sonuc = mesaj.IndexOf("abc");  // mesajda "abc" kelimesinin ilk geçtiği indeksi alır
    // var sonuc = mesaj.Replace("Emir", "Burak"); // mesajdaki "Emir" kelimesini "Burak" ile değiştirir
    var sonuc = mesaj.Substring(5, 7); // 5. indexten başlayarak 7 karakter alır

    Console.WriteLine(sonuc);
*/



/*
    //DateTime

    var simdi = DateTime.Now;

    Console.WriteLine(simdi);
    Console.WriteLine(simdi.Year);
    Console.WriteLine(simdi.Month);
    Console.WriteLine(simdi.Day);
    Console.WriteLine(simdi.DayOfWeek);
    Console.WriteLine(simdi.Hour);
    Console.WriteLine(simdi.Minute);
    Console.WriteLine(simdi.Second);

    DateTime dt = new DateTime(2022, 6, 10, 14, 30, 45); // Yıl, Ay, Gün, Saat, Dakika, Saniye
    DateTime dt2 = dt.AddYears(1); // 1 yıl ekler
    DateTime dt3 = dt.AddHours(2); // 2 saat ekler

    Console.WriteLine(dt2.Year);
    Console.WriteLine(dt3.Hour);

    var fark = simdi - dt;
    Console.WriteLine(fark.TotalDays); // Farkı gün olarak gösterir
    Console.WriteLine(fark.TotalMinutes); // Farkı dakika olarak gösterir
*/




/*
    // Arrays (Diziler)

    var kursAdi = ".net 7 ile c# programlama dersleri".Split(' ');

    // string[] isimler = new string[5];
    // isimler[0] = "Ahmet";
    // isimler[1] = "Ali";
    // isimler[2] = "Canan";
    // isimler[3] = "Çınar";
    // isimler[4] = "Esra";

    // ya da
    string[] isimler = {"Ahmet","Ali","Canan","Çınar","Esra"};



    // int[] numaralar = new int[5];
    // numaralar[0] = 100;
    // numaralar[1] = 200;
    // numaralar[2] = 300;
    // numaralar[3] = 400;
    // numaralar[4] = 500;

    // ya da
    int[] numaralar = {100,200,300,400,500};


    Console.WriteLine($"{numaralar[0]} numaralı öğrencinin adı {isimler[0]}");
    Console.WriteLine($"{numaralar[1]} numaralı öğrencinin adı {isimler[1]}");
    Console.WriteLine($"{numaralar[2]} numaralı öğrencinin adı {isimler[2]}");




    // Dizi Metotları (Array Methods)

    string[] sehirler = {"zonguldak","rize","kocaeli"};
    int[] plakalar = {67,53,41};

    // sehirler[0] = "sakarya";
    // sehirler.SetValue("sakarya",1);

    Console.WriteLine(sehirler[1]);
    // ya da
    Console.WriteLine(sehirler.GetValue(1));

    Console.WriteLine(sehirler.Length);
    Console.WriteLine(Array.IndexOf(sehirler, "rize")); // "rize" kelimesinin indeksini alır

    Array.Sort(sehirler); // sehirler dizisini alfabetik olarak sıralar
    Array.Sort(plakalar); // plakalar dizisini sıralar

    Array.Reverse(plakalar); // plakalar dizisini ters çevirir

    Array.Clear(sehirler);
    Array.Clear(plakalar, 0, 1); // plakalar dizisinin ilk elemanından başlayıp 1 elemanı temizler

    Console.WriteLine(plakalar.GetValue(0));
    Console.WriteLine(plakalar.GetValue(1));
    Console.WriteLine(plakalar.GetValue(2));





    // Array Slicing

    string[] iller = {"zonguldak","rize","kocaeli","istanbul","ankara","çanakkale"};

    foreach(var sehir in iller[2..]) // iller dizisinin 2. indeksinden itibaren tüm elemanları alır
    {
        Console.WriteLine(sehir);
    }

    string il = "Kocaeli";

    Console.WriteLine(il[..5]); // Başlangıçtan 5. indekse kadar olan kısmı alır
*/





/*
    // Çok Boyutlu Diziler

    string[] ogrenciler = {"Ali","Ahmet","Canan"};
    int[,] notlar = new int[3,3];

    // ali
    notlar[0,0] = 50;
    notlar[0,1] = 60;
    notlar[0,2] = 70;

    // ahmet
    notlar[1,0] = 60;
    notlar[1,1] = 80;
    notlar[1,2] = 90;

    // canan
    notlar[2,0] = 50;
    notlar[2,1] = 70;
    notlar[2,2] = 30;

    var ortalama_1 = (notlar[0,0] + notlar[0,1] + notlar[0,2]) / 3;
    var ortalama_2 = (notlar[1,0] + notlar[1,1] + notlar[1,2]) / 3;
    var ortalama_3 = (notlar[2,0] + notlar[2,1] + notlar[2,2]) / 3;

    Console.WriteLine($"{ogrenciler[0]} isimli öğrencinin not ortalaması: {ortalama_1}");
    Console.WriteLine($"{ogrenciler[1]} isimli öğrencinin not ortalaması: {ortalama_2}");
    Console.WriteLine($"{ogrenciler[2]} isimli öğrencinin not ortalaması: {ortalama_3}");
*/






// ORNEK UYGULAMA

string[] ogrenciler = new string[3];
int[] notlar = new int[3];

Console.Write("Öğrenci 1: ");
ogrenciler[0] = Console.ReadLine() ?? "";
Console.Write("Not 1: ");
notlar[0] = Convert.ToInt32(Console.ReadLine());

Console.Write("Öğrenci 2: ");
ogrenciler[1] = Console.ReadLine() ?? "";
Console.Write("Not 2: ");
notlar[1] = Convert.ToInt32(Console.ReadLine());

Console.Write("Öğrenci 3: ");
ogrenciler[2] = Console.ReadLine() ?? "";
Console.Write("Not 3: ");
notlar[2] = Convert.ToInt32(Console.ReadLine());


Console.WriteLine(ogrenciler.Length);
Console.WriteLine(ogrenciler[0] + " : " + notlar[0]);
Console.WriteLine(ogrenciler[1] + " : " + notlar[1]);

int ortalama = (notlar[0] + notlar[1] + notlar[2]) / 3;
Console.WriteLine("Ortalama Not: " + ortalama);
