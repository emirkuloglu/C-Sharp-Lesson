Console.WriteLine("Hello World!");

// Nullable types
int? maas = null;
bool? isActive = null;

Console.WriteLine(maas.HasValue);
Console.WriteLine(maas.GetValueOrDefault());
Console.WriteLine(isActive.GetValueOrDefault());


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