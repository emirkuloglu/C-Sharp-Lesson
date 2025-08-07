Console.WriteLine("Hello World!");

// Nullable types
int? maas = null;
bool? isActive = null;

Console.WriteLine(maas.HasValue);
Console.WriteLine(maas.GetValueOrDefault());
Console.WriteLine(isActive.GetValueOrDefault());