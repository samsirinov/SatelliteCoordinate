int[] bi = new[] { 10, 12, 13, 15, 17, 19, 20, 22, 24, 26, 28, 30, 32, 34, 35, 37, 39, 41, 43, 45, 47, 49, 51, 53, 55, 57, 59, 61, 63, 65, 66, 68, 70, 72, 74, 76, 78, 80, 82, 84 };
int[] bj = new[] { 9, 11, 12, 14, 15, 18, 19, 21, 22, 25, 26, 29, 30, 33, 34, 36, 37, 40, 41, 44, 45, 48, 49, 52, 53, 56, 57, 60, 61, 64, 65, 67, 68, 71, 72, 75, 76, 79, 80, 83, 84 };
int[] bk = new[] { 10, 11, 12, 16, 17, 18, 19, 23, 24, 25, 26, 31, 32, 33, 34, 38, 39, 40, 41, 46, 47, 48, 49, 54, 55, 56, 57, 62, 63, 64, 65, 69, 70, 71, 72, 77, 78, 79, 80, 85 };
int[] bl = new[] { 13, 14, 15, 16, 17, 18, 19, 27, 28, 29, 30, 31, 32, 33, 34, 42, 43, 44, 45, 46, 47, 48, 49, 58, 65, 73, 74, 75, 76, 77, 78, 79, 80 };
int[] bm = new[] { 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 81, 82, 83, 84, 85 };
int[] bn = new[] { 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65 };
int[] bp = new[] { 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85 };
int[] array = new int[85];
Random random = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(2); // 0 veya 1 değeri atanır
}
string Calculate(int[] massiv, int betta)
{
    int sum = 0;
    foreach (int index in massiv)
    {
        int binaryValue = array[index-1];
        sum += binaryValue;
    }
    return ""+(Int32.Parse(Convert.ToString(sum, 2)) * array[betta]);
}
string Cem()
{
    int betta = 0;
    for (int i = 0; i < 8; i++)
    {
        betta += array[i];
    }
    int bku = 0;
    for (int i = 8; i < 85; i++)
    {
        bku += array[i];
    }
   return Convert.ToString(betta * bku,2);
}
Console.WriteLine("C1 : " + Calculate(bi,0));
Console.WriteLine("C2 : " + Calculate(bj,1));
Console.WriteLine("C3 : " + Calculate(bk,2));
Console.WriteLine("C4 : " + Calculate(bl,3));
Console.WriteLine("C5 : " + Calculate(bm,4));
Console.WriteLine("C6 : " + Calculate(bn,5));
Console.WriteLine("C7 : " + Calculate(bp,6));
int adsiz = Convert.ToInt32(Calculate(bi, 0), 2) +
    Convert.ToInt32(Calculate(bj, 1), 2) +
    Convert.ToInt32(Calculate(bk, 2), 2) +
    Convert.ToInt32(Calculate(bl, 3), 2) +
    Convert.ToInt32(Calculate(bm, 4), 2) +
    Convert.ToInt32(Calculate(bn, 5), 2) +
    Convert.ToInt32(Calculate(bp, 6), 2);
Console.WriteLine("CCEM : " + Cem());
Console.WriteLine("C1-C7 : " + Int64.Parse(Convert.ToString(adsiz, 2)));

string cem = Cem();
string adsizinki = Convert.ToString(adsiz, 2);
if (cem[cem.Length-1] == adsizinki[adsizinki.Length - 1])
{
    Console.WriteLine("Duzdu");
}
else
{
    Console.WriteLine("Cemnen C1-C7 Sefdir");
    for (int i = adsizinki.Length-1; i > 0; i--)
    {
        if (adsizinki[i] == '1')
        {
            var mentiq = adsizinki.Substring(0, i) + "0";
            int sifir = adsizinki.Length - mentiq.Length;
            for (int j = 0; j < sifir; j++)
            {
                mentiq += "0";
            }
            Console.WriteLine(mentiq);
            if (mentiq[mentiq.Length - 1] == cem[cem.Length - 1])
            {
                Console.WriteLine("Korreksiya Duzdur");
            }
            else
            {
                Console.WriteLine("Korreksiya Sefdir");
            }
            break;
        }
    }
    
}
