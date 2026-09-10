using System;

class Stringler
{
    public static void Run()
    {
        string kurs_adi = ".NET Core ve C# Programlama";

        // int sonuc = kurs_adi.Length;
        // string sonuc = kurs_adi.ToLower();
        // bool sonuc = kurs_adi.StartsWith(".");
        // int sonuc = kurs_adi.IndexOf("C#");
        // bool sonuc = kurs_adi.Contains("C#");
        string sonuc = kurs_adi.Replace("C#", "C Sharp");

        Console.WriteLine($"Sonuç: {sonuc}");
    }
}