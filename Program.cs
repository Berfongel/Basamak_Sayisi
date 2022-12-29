// See https://aka.ms/new-console-template for more information


int sayi;
int basamak_sayisi=0;

Console.Write("Bir sayi giriniz: ");
sayi = Convert.ToInt32(Console.ReadLine());


    if (sayi >= 100)
    {

        Console.WriteLine("0-99.999 arasında bir sayı seçiniz ");

    }
    else
    {
        while (sayi > 0 && sayi < 99.999) {
            sayi = sayi / 10;
            basamak_sayisi++;

        }
        Console.WriteLine("Girdiginiz sayi " + basamak_sayisi + " basamaklıdır.");
    }





//while (sayi > 0  && sayi<99.999)
//{//
// sayi =sayi/10;
//basamak_sayisi++;
//}
//Console.WriteLine("Girdiginiz sayi " + basamak_sayisi + " basamaklıdır.");

//Console.ReadLine();
