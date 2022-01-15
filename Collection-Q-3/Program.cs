// See https://aka.ms/new-console-template for more information

using System.Globalization;

Console.WriteLine("Cümle giriniz:");

string? message = Console.ReadLine()?.ToLower(new CultureInfo("tr-TR", false));

char[] vowels = { 'a', 'e', 'i', 'o', 'u','ı', 'ö', 'ü' };
List<char> list = new();
foreach (var item in message)
{
    if (vowels.Contains(item))
        if(!list.Contains(item))
            list.Add(item);
}

list.Sort();
foreach(var item in list)
    Console.WriteLine(item);