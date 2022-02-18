// Kullanıcıdan 5 adet benzersiz sayı alalım..
// bu sayıların;
// en büyüğünü
// en küçüküğünü
// ortalamasını ekrana yazdıralım..

// Ödev: bu örneğin aynısını for döngüsü ile yapınız.. Not : for'un yapısını bozmadan...

int[] sayis = new int[5];

for (int i = 0; i < 5;)
{
    Console.WriteLine($"Lütfen ({i + 1}). sayı giriniz");
    int sayi = Convert.ToInt32(Console.ReadLine());

    if (i == 0)
    {
        sayis[i] = sayi;
    }
    for (int j = 0; j < i; j++)
    {
        if (sayis[j] == sayi)
        {
            i--;
            break;
        }
        else
        {
            sayis[i] = sayi;
        }
    }
    i++;
}

Console.WriteLine($"En büyük sayı {sayis.Max()}");
Console.WriteLine($"En küçük sayı {sayis.Min()}");
Console.WriteLine($"Sayı ortalaması {sayis.Average()}");
Console.WriteLine();

Console.WriteLine("*************************************************");

// beklediğim çıktıyı 3. bir değişken kullanmadan yapınız...
int a = 3;
int b = 2;

a = a + b;
b = a - b;
a = a - b;

Console.WriteLine($"a'nın değeri {a}"); // 2
Console.WriteLine($"b'nin değeri {b}"); // 3