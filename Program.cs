using System;

Console.WriteLine("Bu tanishish maqsadida malumot yiguvchi programma");
Console.WriteLine("Iltimos sovollarga to'liq javob bering");


Console.Write("Ismingiz nima:");
string name = Console.ReadLine() ??"";

Console.Write("Yoshingizni kiriting:");
string age = Console.ReadLine() ??"";

Console.Write("Manzilingizni kiriting:");
string address = Console.ReadLine() ??"";

Console.WriteLine("O'zim haqimda ma'lumot");
Console.Write("Mening ismim: ");
Console.WriteLine(name);
Console.Write("Mening yoshim: ");
Console.WriteLine(age);
Console.Write("Mening manzilim: ");
Console.WriteLine(address);

