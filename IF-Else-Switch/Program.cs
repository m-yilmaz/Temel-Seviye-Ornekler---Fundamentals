using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IF_Else_Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = new CultureInfo("en-US");
            Console.OutputEncoding = Encoding.UTF8;

        start:
            Console.Clear();
            Console.WriteLine("| " + new string('*', 45) + " IF-ELSE / SWITCH " + new string('*', 45) + " |\r\n");
            Console.WriteLine(new string(' ', 10) + "[ 1] İki sayıdan büyük olan sayıyı bulduran bir program");
            Console.WriteLine(new string(' ', 10) + "[ 2] Üç sayıdan büyük olan sayıyı bulduran bir program");
            Console.WriteLine(new string(' ', 10) + "[ 3] Sayının tek mi çift mi olduğuna karar veren program");
            Console.WriteLine(new string(' ', 10) + "[ 4] Yılın artık yıl mı değil mi olduğuna karar veren program");
            Console.WriteLine(new string(' ', 10) + "[ 5] Sayı pozitif mi negatif mi sıfır mı olduğuna karar veren bir program");
            Console.WriteLine(new string(' ', 10) + "[ 6] Sayıların toplamını veren program");
            Console.WriteLine(new string(' ', 10) + "[ 7] Karakterin harf olup olmadığına karar veren program");
            Console.WriteLine(new string(' ', 10) + "[ 8] Harfin ünlü mü ünsüz mü olduğuna karar veren program");
            Console.WriteLine(new string(' ', 10) + "[ 9] Karakterin sayı olup olmadığına karar veren program");
            Console.WriteLine(new string(' ', 10) + "[10] Karakterin büyük mü küçük mü olduğuna karar veren program");
            Console.WriteLine(new string(' ', 10) + "[11] Sayının (1-7) gün karşılığını (Pazartesi-Pazar) yazan program");
            Console.WriteLine(new string(' ', 10) + "[12] Ay numarasına (1-12) ait ayın kaç gün içerdiğiniz yazan program");
            Console.WriteLine(new string(' ', 10) + "[13] Girilen 3 açıdan üçgenin geçerli bir üçgen olup olmadığına karar veren program");
            Console.WriteLine(new string(' ', 10) + "[14] Üç kenar uzunluğundan geçerli bir üçgen olup olmadığına karar veren program");
            Console.WriteLine(new string(' ', 10) + "[15] Üçgenin eş kenar mı, ikiz kenar mı yoksa çeşit kenar mı olduğuna karar veren program");
            Console.WriteLine(new string(' ', 10) + "[16] Maliyet ve satış fiyatı girilen bir ürünün kar/zarar miktarını söyleyen program");
            Console.WriteLine(new string(' ', 10) + "[17] Alınan notun harf karşılığını gösteren prıgram\r\n");
            Console.WriteLine();
            Console.WriteLine(new string(' ', 10) + "[18] Çıkış");

            Console.WriteLine("| " + new string('*', 40) + " Created By Mustafa Yilmaz " + new string('*', 40) + " |");
            Console.Write("\r\nÇalıştırmak istediğiniz program numarasını yazınız: ");
            try
            {

                int secim = Convert.ToInt32(Console.ReadLine());
                switch (secim)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Girilen 2 sayıdan büyük olan sayıyı bulduran bir program çalışıyor..");
                        GirilenIkiSayidanBuyuk();
                        goto start;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("Girilen 3 sayıdan büyük olan sayıyı bulduran bir program çalışıyor..");
                        GirilenUcSayidanBuyuk();
                        goto start;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Girilen sayının tek mi çift mi olduğuna karar veren program çalışıyor..");
                        TekMiCiftMi();
                        goto start;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Girilen yılın artık yıl mı değil mi olduğuna karar veren program çalışıyor..");
                        ArtikYil();
                        goto start;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Girilen sayı pozitif mi negatif mi sıfır mı olduğuna karar veren bir program çalışıyor..");
                        PozitifNegatifSifir();
                        goto start;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("Girilen sayıların toplamını veren program çalışıyor..");
                        GirilenSayilarinToplami();
                        goto start;
                    case 7:
                        Console.Clear();
                        Console.WriteLine("Girilen karakterin harf olup olmadığına karar veren program çalışıyor..");
                        HarfMiDegilMi();
                        goto start;
                    case 8:
                        Console.Clear();
                        Console.WriteLine("Girilen harfin ünlü mü ünsüz mü olduğuna karar veren program çalışıyor..");
                        UnluMuUnsuzMu();
                        goto start;
                    case 9:
                        Console.Clear();
                        Console.WriteLine("Girilen karakterin sayı olup olmadığına karar veren program çalışıyor..");
                        SayiMiDegilMi();
                        goto start;
                    case 10:
                        Console.Clear();
                        Console.WriteLine("Girilen karakterin büyük mü küçük mü olduğuna karar veren program çalışıyor..");
                        BuyukMuKucukMu();
                        goto start;
                    case 11:
                        Console.Clear();
                        Console.WriteLine("Girilen sayının (1-7) gün karşılığını (Pazartesi-Pazar) yazan program çalışıyor..");
                        GirilenGun();
                        goto start;
                    case 12:
                        Console.Clear();
                        Console.WriteLine("Girilen ay numarasına (1-12) ait ayın kaç gün içerdiğiniz yazan program çalışıyor..");
                        AyGunu();
                        goto start;
                    case 13:
                        Console.Clear();
                        Console.WriteLine("Bir üçgene ait tam sayı girilen 3 açıdan üçgenin geçerli bir üçgen olup olmadığına karar veren program çalışıyor..");
                        UcgenAcilari();
                        goto start;
                    case 14:
                        Console.Clear();
                        Console.WriteLine("Bir üçgene ait tam sayı olarak girilen 3 kenar uzunluğundan geçerli bir üçgen olup olmadığına karar veren program çalışıyor..");
                        UcgenKenarlari();
                        goto start;
                    case 15:
                        Console.Clear();
                        Console.WriteLine("Kenar uzunlukları tam sayı olarak girilen bir üçgenin eş kenar mı, ikiz kenar mı yoksa çeşit kenar mı olduğuna karar veren program çalışıyor..");
                        UcgenDurumu();
                        goto start;
                    case 16:
                        Console.Clear();
                        Console.WriteLine("Maliyet ve satış fiyatı girilen bir ürünün kar/zarar miktarını söyleyen program çalışıyor..");
                        KarZarar();
                        goto start;
                    case 17:
                        Console.Clear();
                        Console.WriteLine("Alınan notun harf karşılığını gösteren prıgram çalışıyor.");
                        HarfNotu();
                        goto start;
                    case 18:
                        Console.Clear();
                        Console.Write("Çıkış yapılıyor.");
                        for (int i = 0; i < 4; i++)
                        {
                            Console.Write(".");
                            Thread.Sleep(500);
                        }
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Clear();
                        goto start;
                }

            }
            catch (Exception)
            {

                Console.WriteLine("Geçersiz giriş");
                goto start;
            }



            // 1. Girilen iki sayıdan büyük olan sayıyı bulduran bir program yazınız. 
            void GirilenIkiSayidanBuyuk()
            {
                Console.WriteLine("\r\n2 Adet sayı giriniz: ");
            input:
                Console.Write("1. Sayı: ");
                try
                {
                    double sayi1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("2. Sayı: ");
                    double sayi2 = Convert.ToDouble(Console.ReadLine());
                    if (sayi1 > sayi2)
                        Console.WriteLine("Büyük sayı: " + sayi1);
                    else if (sayi2 > sayi1)
                        Console.WriteLine("Büyük sayı: " + sayi2);
                    else
                        Console.WriteLine("Sayılar eşittir.");
                }
                catch (Exception)
                {
                    Console.WriteLine("Sadece sayı girişi yapınız.");
                    goto input;
                }
                Console.WriteLine("\r\nÇıkış için space, Bir üst menü için ESC, Yeniden hesaplama yapmak için Enter'a basınız...");
                var response = Console.ReadKey(true).Key;
                if (response != ConsoleKey.Escape)
                {
                    if (response == ConsoleKey.Spacebar)
                        Environment.Exit(0);
                    goto input;
                }
            }

            // 2.Girilen 3 sayıdan büyük olan sayıyı bulduran bir program yazınız. 
            void GirilenUcSayidanBuyuk()
            {

                Console.WriteLine("\r\n3 Adet sayı giriniz: ");
            input:
                Console.Write("1. Sayı: ");
                try
                {
                    double sayi1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("2. Sayı: ");
                    double sayi2 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("3. Sayı: ");
                    double sayi3 = Convert.ToDouble(Console.ReadLine());
                    if (sayi1 >= sayi2 && sayi1 >= sayi3)
                        Console.WriteLine("Büyük sayı: " + sayi1);
                    else if (sayi2 >= sayi1 && sayi2 >= sayi3)
                        Console.WriteLine("Büyük sayı: " + sayi2);
                    else
                        Console.WriteLine("Büyük sayı: " + sayi3);
                }
                catch (Exception)
                {
                    Console.WriteLine("Sadece sayı girişi yapınız.");
                    goto input;
                }
                Console.WriteLine("\r\nÇıkış için space, Bir üst menü için ESC, Yeniden hesaplama yapmak için Enter'a basınız...");
                var response = Console.ReadKey(true).Key;
                if (response != ConsoleKey.Escape)
                {
                    if (response == ConsoleKey.Spacebar)
                        Environment.Exit(0);
                    goto input;
                }
            }

            // 3.Girilen sayının tek mi çift mi olduğuna karar veren programı yazınız. 
            void TekMiCiftMi()
            {
            input:
                Console.Write("\r\nSayı giriniz: ");
                try
                {
                    int input = Convert.ToInt32(Console.ReadLine());
                    if (input % 2 == 0)
                        Console.WriteLine("Çift");
                    else
                        Console.WriteLine("Tek");
                    Console.WriteLine("\r\nÇıkış için space, Bir üst menü için ESC, Yeniden hesaplama yapmak için Enter'a basınız...");
                    var response = Console.ReadKey(true).Key;
                    if (response != ConsoleKey.Escape)
                    {
                        if (response == ConsoleKey.Spacebar)
                            Environment.Exit(0);
                        goto input;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("\r\nSayı girişi yapınız demiştim ama anlamadınız sanırm !");
                    goto input;
                }

            }

            // 4. Girilen yılın artık yıl mı değil mi olduğuna karar veren programı yazınız.
            void ArtikYil()
            {
            input:
                try
                {
                    Console.WriteLine("\r\nYıl giriniz, artık yıl mı değil mi söyleyelim");
                    int yil = Convert.ToInt32(Console.ReadLine());
                    if (yil % 4 == 0 && (yil % 400 == 0 || yil % 100 != 0))
                        Console.WriteLine("Artik Yıl");
                    else
                        Console.WriteLine("Artık Yıl değil.");
                }
                catch (Exception)
                {

                    Console.WriteLine("Sadece Yıl giriniz.");
                    goto input;
                }

                Console.WriteLine("\r\nÇıkış için space, Bir üst menü için ESC, Yeniden hesaplama yapmak için Enter'a basınız...");
                var response = Console.ReadKey(true).Key;
                if (response != ConsoleKey.Escape)
                {
                    if (response == ConsoleKey.Spacebar)
                        Environment.Exit(0);
                    goto input;
                }

            }

            // 5. Girilen sayı pozitif mi negatif mi sıfır mı olduğuna karar veren bir program yazınız.
            void PozitifNegatifSifir()
            {
            input:
                try
                {
                    Console.Write("\r\nSayı giriniz: ");
                    int sayi = Convert.ToInt32(Console.ReadLine());
                    if (sayi > 0)
                        Console.WriteLine("Pozitif sayıdır.");
                    else if (sayi < 0)
                        Console.WriteLine("Negatif sayıdır.");
                    else
                        Console.WriteLine("Sayı sıfırdır.");
                    Console.WriteLine("\r\nÇıkış için space, Bir üst menü için ESC, Yeniden hesaplama yapmak için Enter'a basınız...");
                    var response = Console.ReadKey(true).Key;
                    if (response != ConsoleKey.Escape)
                    {
                        if (response == ConsoleKey.Spacebar)
                            Environment.Exit(0);
                        goto input;
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("Lütfen sayı giriniz ! ");
                    goto input;
                }
            }

            // 6.Girilen sayıların toplamını veren programı yazınız.
            void GirilenSayilarinToplami()
            {
            input:
                try
                {
                    int toplam = 0, n, x;
                    Console.Write("Kaç adet sayı girmek istiyorsunuz ? : ");
                    n = Convert.ToInt32(Console.ReadLine());
                dongu:
                    if (n > 0)
                    {
                        Console.Write("Sayı giriniz: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        toplam += x;
                        n--;
                        goto dongu;
                    }
                    Console.WriteLine("Girilen sayıların toplamı = " + toplam);
                    Console.WriteLine("\r\nÇıkış için space, Bir üst menü için ESC, Yeniden hesaplama yapmak için Enter'a basınız...");
                    var response = Console.ReadKey(true).Key;
                    if (response != ConsoleKey.Escape)
                    {
                        if (response == ConsoleKey.Spacebar)
                            Environment.Exit(0);
                        goto input;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("\r\nHatalı giriş, lütfen sayı giriniz. !");
                    goto input;
                }


            }

            // 7. Girilen karakterin harf olup olmadığına karar veren programı yazınız[2].
            void HarfMiDegilMi()
            {
            input:
                Console.WriteLine("\r\nGirdiğiniz parametrenin harf mi karakter mi olduğunu kontrol eder.");
                Console.Write("Parametre giriniz: ");


                Console.WriteLine((Char.IsLetter(Convert.ToChar(Console.ReadLine())) ? "Harftir" : "Harf Değildir"));
                Console.WriteLine("\r\nÇıkış için space, Bir üst menü için ESC, Yeniden hesaplama yapmak için Enter'a basınız...");
                var response = Console.ReadKey(true).Key;
                if (response != ConsoleKey.Escape)
                {
                    if (response == ConsoleKey.Spacebar)
                        Environment.Exit(0);
                    goto input;
                }
            }

            // 8. Girilen harfin ünlü mü ünsüz mü olduğuna karar veren programı yazınız.
            void UnluMuUnsuzMu()
            {
            input:
                Console.Write("\r\nHarf giriniz: ");
                char harf = Convert.ToChar((Console.ReadLine().ToLower()));
                switch (harf)
                {
                    case 'a':
                    case 'e':
                    case 'ı':
                    case 'i':
                    case 'o':
                    case 'ö':
                    case 'u':
                    case 'ü':
                        Console.WriteLine("Ünlü harftir.");
                        break;
                    default:
                        Console.WriteLine("Ünsüz harftir.");
                        break;
                }
                Console.WriteLine("\r\nÇıkış için space, Bir üst menü için ESC, Yeniden hesaplama yapmak için Enter'a basınız...");
                var response = Console.ReadKey(true).Key;
                if (response != ConsoleKey.Escape)
                {
                    if (response == ConsoleKey.Spacebar)
                        Environment.Exit(0);
                    goto input;
                }
            }

            // 9. Girilen karakterin sayı olup olmadığına karar veren programı yazınız[2].
            void SayiMiDegilMi()
            {
            input:
                try
                {
                    Console.WriteLine("\r\nGirdiğiniz parametrenin sayı mi karakter mi olduğunu kontrol eder.");
                    Console.WriteLine("(NumPad tuşlarını okumuyor.)");
                    Console.Write("Parametre giriniz: ");
                    Console.WriteLine((Char.IsNumber(Convert.ToChar(Console.ReadKey().Key)) ? "\r\nSayıdır" : "\r\nSayı Değildir"));
                    Console.WriteLine("\r\nÇıkış için space, Bir üst menü için ESC, Yeniden hesaplama yapmak için Enter'a basınız...");
                    var response = Console.ReadKey(true).Key;
                    if (response != ConsoleKey.Escape)
                    {
                        if (response == ConsoleKey.Spacebar)
                            Environment.Exit(0);
                        goto input;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Lütfen tek parametre giriniz.! ");
                    goto input;
                }
            }

            // 10. Girilen karakterin büyük mü küçük mü olduğuna karar veren programı yazınız[2]. 
            void BuyukMuKucukMu()
            {
            input:
                try
                {
                    Console.Write("\r\nParametre giriniz: ");
                    char input = Convert.ToChar(Console.ReadLine());
                    if (!Char.IsNumber(input) && Char.IsLower(input))
                    {
                        Console.WriteLine("Küçük harfitr.");
                    }
                    else if (!Char.IsNumber(input) && !Char.IsLower(input))
                    {
                        Console.WriteLine("Büyük harftir.");
                    }
                    else
                    {
                        Console.WriteLine("\r\nLütfen sadece harf giriniz.!");
                        goto input;
                    }

                    Console.WriteLine("\r\nÇıkış için space, Bir üst menü için ESC, Yeniden hesaplama yapmak için Enter'a basınız...");
                    var response = Console.ReadKey(true).Key;
                    if (response != ConsoleKey.Escape)
                    {
                        if (response == ConsoleKey.Spacebar)
                            Environment.Exit(0);
                        goto input;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Lütfen tek parametre giriniz.! ");
                    goto input;
                }
            }

            // 11. Girilen sayının (1-7) gün karşılığını (Pazartesi-Pazar) yazan programı yazınız.
            void GirilenGun()
            {
            input:
                try
                {
                    Console.Write("Gün No: ");
                    int no = Convert.ToInt32(Console.ReadLine());
                    string gun;
                    switch (no)
                    {
                        case 1:
                            gun = "Pazartesi";
                            break;
                        case 2:
                            gun = "Salı";
                            break;
                        case 3:
                            gun = "Çarşamba";
                            break;
                        case 4:
                            gun = "Perşembe";
                            break;
                        case 5:
                            gun = "Cuma";
                            break;
                        case 6:
                            gun = "Cumartesi";
                            break;
                        case 7:
                            gun = "Pazar";
                            break;
                        default:
                            gun = "Geçersiz";
                            break;
                    }
                    Console.WriteLine("Gun Adı: " + gun);
                }
                catch (Exception)
                {

                    Console.WriteLine("Geçersiz giriş");
                    goto input;
                }

                Console.WriteLine("\r\nÇıkış için space, Bir üst menü için ESC, Yeniden hesaplama yapmak için Enter'a basınız...");
                var response = Console.ReadKey(true).Key;
                if (response != ConsoleKey.Escape)
                {
                    if (response == ConsoleKey.Spacebar)
                        Environment.Exit(0);
                    goto input;
                }
            }

            // 12. Girilen ay numarasına (1-12) ait ayın kaç gün içerdiğiniz yazan programı yazınız. 
            void AyGunu()
            {
            input:
                try
                {
                    Console.Write("Ay No: ");
                    int no = Convert.ToInt32(Console.ReadLine());
                    string gun, ay;
                    switch (no)
                    {
                        case 1:
                            ay = "Ocak";
                            gun = "31";
                            break;
                        case 2:
                            ay = "Şubat";
                            gun = "28";
                            break;
                        case 3:
                            ay = "Mart";
                            gun = "31";
                            break;
                        case 4:
                            ay = "Nisan";
                            gun = "30";
                            break;
                        case 5:
                            ay = "Mayıs";
                            gun = "31";
                            break;
                        case 6:
                            ay = "Haziran";
                            gun = "30";
                            break;
                        case 7:
                            ay = "Temmuz";
                            gun = "31";
                            break;
                        case 8:
                            ay = "Ağustos";
                            gun = "31";
                            break;
                        case 9:
                            ay = "Eylül";
                            gun = "30";
                            break;
                        case 10:
                            ay = "Ekim";
                            gun = "31";
                            break;
                        case 11:
                            ay = "Kasım";
                            gun = "30";
                            break;
                        case 12:
                            ay = "Aralık";
                            gun = "31";
                            break;

                        default:
                            gun = "Geçersiz";
                            ay = "Geçersiz";
                            break;
                    }
                    Console.WriteLine(ay + " ayında " + gun + " gün vardır.");
                }
                catch (Exception)
                {
                    Console.WriteLine("Geçersiz giriş");
                    goto input;
                }
                Console.WriteLine("\r\nÇıkış için space, Bir üst menü için ESC, Yeniden hesaplama yapmak için Enter'a basınız...");
                var response = Console.ReadKey(true).Key;
                if (response != ConsoleKey.Escape)
                {
                    if (response == ConsoleKey.Spacebar)
                        Environment.Exit(0);
                    goto input;
                }
            }

            // 13. Bir üçgene ait tam sayı girilen 3 açıdan üçgenin geçerli bir üçgen olup olmadığına karar veren programı yazınız.
            void UcgenAcilari()
            {
            input:
                int aci1, aci2, aci3;
                Console.Write("\r\n1. Açı: ");
                aci1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("2. Açı: ");
                aci2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("3. Açı: ");
                aci3 = Convert.ToInt32(Console.ReadLine());
                if (aci1 <= 0 || aci2 <= 0 || aci3 <= 0 || aci1 == 180 || aci2 == 180 || aci3 == 180 || aci1 + aci2 + aci3 != 180)
                {
                    Console.WriteLine("Üçgenin herhangi bir açısı 0, 180 veya negarif değer olamaz. \r\nAçıların toplamı 180 derece olmak zorundadır.");
                    Console.WriteLine("Girilen değerler bir üçgen belirtemez ! ");
                    goto son;
                }
                Console.WriteLine("Bir üçgen belirtir.");
            son:
                Console.WriteLine("\r\nÇıkış için space, Bir üst menü için ESC, Yeniden hesaplama yapmak için Enter'a basınız...");
                var response = Console.ReadKey(true).Key;
                if (response != ConsoleKey.Escape)
                {
                    if (response == ConsoleKey.Spacebar)
                        Environment.Exit(0);
                    goto input;
                }
            }

            // 14. Bir üçgene ait tam sayı olarak girilen 3 kenar uzunluğundan geçerli bir üçgen olup olmadığına karar veren programı yazınız.
            void UcgenKenarlari()
            {
            input:
                int a, b, c;
                Console.Write("\r\n1. Kenar: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("2. Kenar: ");
                b = Convert.ToInt32(Console.ReadLine());
                Console.Write("3. Kenar: ");
                c = Convert.ToInt32(Console.ReadLine());

                if ((a < b + c && a > Math.Abs(b - c)) && (b < a + c && b > Math.Abs(a - c)) && (c < b + a && c > Math.Abs(b - a)))
                {
                    Console.WriteLine("Üçgen belirtir.");
                    goto son;
                }
                Console.WriteLine("\r\n Üçgen belirtmez.");
            son:
                Console.WriteLine("\r\nÇıkış için space, Bir üst menü için ESC, Yeniden hesaplama yapmak için Enter'a basınız...");
                var response = Console.ReadKey(true).Key;
                if (response != ConsoleKey.Escape)
                {
                    if (response == ConsoleKey.Spacebar)
                        Environment.Exit(0);
                    goto input;
                }
            }

            // 15. Kenar uzunlukları tam sayı olarak girilen bir üçgenin eş kenar mı, ikiz kenar mı yoksa çeşit kenar mı olduğuna karar veren programı yazınız
            void UcgenDurumu()
            {
            input:
                int a, b, c;
                Console.Write("\r\n1. Kenar: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("2. Kenar: ");
                b = Convert.ToInt32(Console.ReadLine());
                Console.Write("3. Kenar: ");
                c = Convert.ToInt32(Console.ReadLine());
                bool status = false;

                if ((a < b + c && a > b - c) && (b < a + c && b > a - c) && (c < b + a && c > b - a))
                {
                    status = true;
                    if ((a == b && a == c && b == c))
                        Console.WriteLine("Eş kenar üçgendir");
                    else if (a == b || a == c || c == b)
                        Console.WriteLine("İkizkenar üçgendir.");
                    else
                        Console.WriteLine("Çeşit kenar üçgendir.");
                }
                if (status == false)
                    Console.WriteLine("\r\n Girilen kenarlar üçgen olma koşulunu sağlamamaktadır...");

                Console.WriteLine("\r\nÇıkış için space, Bir üst menü için ESC, Yeniden hesaplama yapmak için Enter'a basınız...");
                var response = Console.ReadKey(true).Key;
                if (response != ConsoleKey.Escape)
                {
                    if (response == ConsoleKey.Spacebar)
                        Environment.Exit(0);
                    goto input;
                }
            }

            // 16. Maliyet ve satış fiyatı girilen bir ürünün kar/zarar miktarını söyleyen programı yazınız. (Örnek çıktı => Kâr: 1000TL ya da Zarar: 399TL)
            void KarZarar()
            {
            input:
                double maliyet, satis, durum;
                Console.Write("Maliyet fiyatı : ");
                maliyet = Convert.ToDouble(Console.ReadLine());
                Console.Write("Satış fiyatı : ");
                satis = Convert.ToDouble(Console.ReadLine());
                durum = satis - maliyet;
                if (durum > 0)
                    Console.WriteLine("Kar: " + durum + " TL");
                else
                    Console.WriteLine("Zarar " + Math.Abs(durum) + " TL");

                Console.WriteLine("\r\nÇıkış için space, Bir üst menü için ESC, Yeniden hesaplama yapmak için Enter'a basınız...");
                var response = Console.ReadKey(true).Key;
                if (response != ConsoleKey.Escape)
                {
                    if (response == ConsoleKey.Spacebar)
                        Environment.Exit(0);
                    goto input;
                }
            }

            // 17. Kişiye aldığı notun harf karşılığını aşağıdaki tabloya göre söyleyiniz.
            //Not < 40 => F
            //Not < 65 => D
            //Not < 80 => C
            //Not < 90 => B
            //Not =< 100 => A
            void HarfNotu()
            {
            input:
                double not;
                Console.Write("Ders notunuzu giriniz: ");
                not = Convert.ToDouble(Console.ReadLine());
                if (not < 40 && not >= 0)
                    Console.WriteLine("Harf Notunuz: F");
                else if (not < 65)
                    Console.WriteLine("Harf Notunuz: D");
                else if (not < 80)
                    Console.WriteLine("Harf Notunuz: C");
                else if (not < 90)
                    Console.WriteLine("Harf Notunuz: B");
                else if (not <= 100)
                    Console.WriteLine("Harf Notunuz: A");
                else
                    Console.WriteLine("Geçersiz not");

                Console.WriteLine("\r\nÇıkış için space, Bir üst menü için ESC, Yeniden hesaplama yapmak için Enter'a basınız...");
                var response = Console.ReadKey(true).Key;
                if (response != ConsoleKey.Escape)
                {
                    if (response == ConsoleKey.Spacebar)
                        Environment.Exit(0);
                    goto input;
                }
            }

        }
    }
}
