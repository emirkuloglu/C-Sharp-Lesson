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