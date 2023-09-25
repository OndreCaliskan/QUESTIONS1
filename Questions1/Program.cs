using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Klavyeden 3 farklı tam sayı girişi yaptıran, daha sonra bu sayıların toplamını, ortalamasını,
            //çarpımını, en küçüğünü ve en büyüğünü hesaplayan bir program yazın.

            /* int[] number = new int[3];
             for (int i = 0; i < number.Length; i++) 
             {
                 Console.WriteLine("{0}. Sayıyı Giriniz:",i+1);
                 number[i] = Convert.ToInt32(Console.ReadLine());
             }

             int sum = number.Sum();
             double average = sum / 3.0; //3.0 yazmaz isen virgüllü vermiyor işlemi yuvarlıyor!
             int multiplication = number.Aggregate((x, y) => x * y);
             int BiggestNum = number.Max();
             int SmallestNum = number.Min();

             Console.WriteLine("**********************");
             Console.WriteLine("Sum of Number: {0}", sum);
             Console.WriteLine("average of number: {0:F2}", average);
             Console.WriteLine("Multiplication of numbers:{0}", multiplication);
             Console.WriteLine("Biggest of Numbers : {0}", BiggestNum);
             Console.WriteLine("smallest of Numbers : {0}", SmallestNum); */

            //******************************************************************************************************//
            //0‘dan 10‘a kadar olan sayıların karelerini ve küplerini hesaplayıp, sonuçları ekrana
            //aşağıda göründüğü biçimde yazdıran bir program yazınız.

            /* Console.WriteLine("1'den 10'a kadar olan sayıların karesini,küpünü hesaplayan program");
             Console.WriteLine("********************************");
             Console.WriteLine("number\t Square\t Cube\n   ");
             for (int i = 0; i <= 10; i++)
             {
                 int square = i * i;
                 int cube = square * i;
                 Console.WriteLine($"{i}\t {square}\t {cube}");
             }
            */
            //***************************************************************************************************//

            //Bir sürücü, kaç kilometre yol yaptığını ve kaç lt benzin harcadığını hesaplamaya başladı.
            //Kaç kilometre yol yaptığını ve kaç lt benzin harcandığını kullanıcıdan alan bir C# programı
            //yazınız. Programınız, her lt için kaç kilometre yol alındığını hesaplasın. Bütün giriş bilgileri
            //alındıktan sonra programınız, gidilen toplam kilometre için harcanan benzin miktarını bulmalı.


            /* double distance = 0;
             double gas = 0;
             double totalDistance = 0;
             double totalGas = 0;

             do
             {
                 Console.WriteLine("Kaç km Yol yaptı(cıkış için -1:):");
                 distance = Convert.ToInt32(Console.ReadLine());

                 if (distance != -1) 
                 {
                     totalDistance += distance;
                     Console.WriteLine("Kaç litre benzin harcadı");
                     gas = Convert.ToInt32(Console.ReadLine());
                     totalGas += gas;
                     if (gas != 0)
                     {
                         Console.WriteLine("Kilometre/Litre: {0:F2}", (double)distance / gas);
                     }
                     else 
                     {
                         Console.WriteLine("Benzin harcaması 0 olamaz.Lütfen geçerli bir değere giriniz");
                     }                 
                 }

                 Console.WriteLine("");

             } while (distance != -1);
             if (totalGas != 0) 
             {
                 Console.WriteLine("Toplam ortalama kilometre/Litre{0:F2}",(double)totalDistance/totalGas);
             }
             else 
             { 
                 Console.WriteLine("Toplam benzin harcaması 0 oldu.Ortalama hesaplanamıyor");
             }

             Console.WriteLine("");*/

            //Bir ilaç şirketi, satış elemanlarına ücretlerini komisyon şeklinde ödemektedir. Bir satış elemanı haftalık 200$ ve haftalık brüt satışından % 9 almaktadır.Örneğin, 5000$
            //tutarında bir haftalık satış yapan satış elemanı 200$ ve 5000$ ‘in % 9 ‘unu kazanmaktadır, yani 650$. Son haftadaki satış elemanlarının satışlarını kullanıcıya
            //girdiren ve bu satış elemanlarının ne kadar kazandıklarını hesaplayıp ekrana yazdıran bir program yazınız. Her seferinde bir satış elemanın işlemlerini yapınız.

            /*  double salary = 0;
              do
              {
                  Console.WriteLine("Çalışanın Dolar cinsinden satış tutarını giriniz;");
                  salary = Convert.ToInt32(Console.ReadLine());

                  if (salary != -1) 
                  {
                      double badge = 200 + ((salary * 9) / 100);
                      Console.WriteLine($"Çalışanın Maaş:{badge:F2}");
                      Console.WriteLine("");
                  }

              } while (salary != -1);
              Console.WriteLine($"Program sonu");*/

            //Kullanıcının girdiği beş basamaklı bir sayının palindrome olup olmadığına
            //karar verip ekrana yazdıranbir program yazdınız.

            /* int num, rev, sum = 0, temp;
             Console.WriteLine("Enter the Number");
             num = int.Parse(Console.ReadLine());
             temp = num;

             while (num > 0)
             {
                 rev = num % 10;
                 Console.WriteLine("REV:" + rev);
                 sum = (sum * 10) + rev;
                 Console.WriteLine("SUM" + sum);
                 num = num / 10;
                 Console.WriteLine("Num" + num);
                 Console.WriteLine("134......");

             }
             if (temp == sum)
             {
                 Console.WriteLine("You found polindrom number");
             }

             else
             {
                 Console.WriteLine("you should try more ");
             }*/

            // Bir park yeri işletmesi, 3 saate kadar yapılan parklar için minimum 2$ almaktadır. 3 saatin
            //geçilmesi halinde her saat için 0,5$ almaktadır.Maksimum alınan para ise 24 saatlik park
            //edilmesi halinde 10$'dır. 24 saatten daha uzun hiç bir aracın park etmediğini kabul ediniz.
            // Dün bu park yerine park etmiş olan üç müşterinin ödemelerini hesaplayan ve yazdıran bir
            // programı yazınız.(Kullanıcı, her müşterinin park saatini girmeli ve çıktı düzgün bir çizelge
            // şeklinde olmalıdır ve dünün toplam gelirini hesaplamalıdır.)

            /* double toplamGelir = 0.0;
             double totalhour = 0.0;
             for (int Client = 1; Client <= 3; Client++)
             {
                 Console.WriteLine($"{Client}. Müşterinin park bilgilerini girin:");
                 Console.Write("Park Süresi (saat cinsinden): ");
                 double parkingTime = Convert.ToDouble(Console.ReadLine());

                 totalhour += parkingTime; 
                 double parkingFee = HesaplaParkUcreti(parkingTime);
                 toplamGelir += parkingFee;

                 Console.WriteLine($"{Client}. Müşterinin Ödemesi: ${parkingFee:F2}");
                 Console.WriteLine();
             }

             Console.WriteLine($"Dünün Toplam Geliri: ${toplamGelir:F2}");
             Console.WriteLine($"Dünün Toplam Saati: {totalhour:F2}");

             double HesaplaParkUcreti(double sure)
             {
                 if (sure <= 3)
                 {
                     return 2.0;
                 }
                 else if (sure <= 24)
                 {
                     return 2.0 + (sure - 3) * 0.5;
                 }
                 else
                 {
                     return 10.0;
                 }

             }*/

            //Kendi bilgisayarınızın ne kadar hızlı çalıştığını nasıl anlayabilirsiniz? 1‘ den 3,000,000 e
            //kadar sayan bir while döngüsü içeren bir program yazınız. Sayacınız 1,000,000’in her
            //katında ekrana bu sayıyı yazdırsın. Saatinizi kullanarak her bir milyonluk döngünün ne
            //kadar zamanda çalıştığını ölçün.

            /*Console.WriteLine("Sayma İşlemine başlamak istiyor iseniz 1'e Basınız.");
            double counter = Convert.ToInt32(Console.ReadLine());

            Stopwatch watch = new Stopwatch();
            watch.Start();
            while (counter < 3000000)
            {
                counter++;


                if (counter == 1000000)
                {
                    Console.WriteLine("1000000'ncı sayıya geldiniz");
                    continue;
                }

                else if (counter == 2000000)
                {
                    Console.WriteLine("2000000'ncı sayıya geldiniz");
                    continue;
                }

                else if (counter == 3000000)
                {
                    Console.WriteLine("3000000'ncı sayıya geldiniz");

                    break;
                }

            }

            watch.Stop();
            Console.WriteLine("Bağlantı  süresi: {0:F2}", watch.Elapsed.Milliseconds + " Milisaniye");*/
            //----------------------------------------------------------------------------------------------------------//

            // Bir şirket bazı verilerini telefon aracılığıyla başka bir yere iletmek istemektedir ama
            //telefonlarının dinlendiğinden kuşkulanmaktadırlar.Bütün veriler dört basamaklı tamsayılar
            //şeklinde iletilecektir.Size verilen görev ise bu verileri daha güvenli bir şekilde iletilmeleri
            //için şifrelemenizdir.Programınız şifrelemeyi şu şekilde yapmalıdır:
            //Her basamağı 7 ile toplamının 10‘luk sistemdeki eşitiyle ve birinci basamağı üçüncü
            //basamak, ikinci basamağı da dördüncü basamak ile yer değiştirmelisiniz.Bu şifrelenmiş
            //sayıları alan ve eski haline getiren başka bir programda yazınız

            /* Console.WriteLine("Gönderilecek verileri 4 haneli basamaklar halinde giriniz");
             int data = Convert.ToInt32(Console.ReadLine());
             int OnesDigit = data % 10;
             int TensDigit = (data - OnesDigit) % 100 / 10;
             int HundredsDigit = (data - (TensDigit * 10 + OnesDigit)) % 1000 / 100;
             int ThousandsDigit = (data - (HundredsDigit * 100 + (TensDigit * 10) + OnesDigit)) % 10000 / 1000;

             Console.WriteLine($"Birinci Sayı: {OnesDigit}");
             Console.WriteLine($"İkinci Sayı: {TensDigit}");
             Console.WriteLine($"Üçüncü Sayı: {HundredsDigit}");             //!! Bu soruyu Tekrar Çöz
             Console.WriteLine($"Dördüncü Sayı: {ThousandsDigit}");
             Console.WriteLine("\n***********************************\n");
             int OnesDigit1 = OnesDigit + 7;
             int TensDigit1 = TensDigit + 7;
             int HundredsDigit1 = HundredsDigit + 7;
             int ThousandsDigit1 = ThousandsDigit + 7;
             int NewNumer = ((TensDigit1 * 1000) + (OnesDigit1 * 100) + (ThousandsDigit1 * 10) + HundredsDigit1);
             Console.WriteLine("\n***********************************\n");
             Console.WriteLine($"Birinci Sayı: {OnesDigit1}");
             Console.WriteLine($"İkinci Sayı: {TensDigit1}");
             Console.WriteLine($"Üçüncü Sayı: {HundredsDigit1}");
             Console.WriteLine($"Dördüncü Sayı: {ThousandsDigit1}");
             Console.WriteLine("\n***********************************\n");
             Console.WriteLine($"Şifrelenmiş Veriniz: {NewNumer}");

             Console.WriteLine("Girilen veriyi Çözmek istermisiniz;");
             string answer = Console.ReadLine();

             if (answer == "Evet")
             {

                 Console.WriteLine($"Verinin Şifrelenmeden önceki hali;{data}");

             }
             else
             {
                 Console.WriteLine($"Verinin Şifrelenmeden önceki hali Gösterilemiyor");

             }*/
            //------------------------------------------------------------------------------//

            //2'den 30'a kadar olan çift tamsayıların toplamını hesaplayan ve ekrana yazdıran bir
            //program yazınız.

            /* int[] numbers = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30 };
             int result = 0;
             foreach (var item in numbers)
             {
                 result = result + item;
             }
             Console.WriteLine($"Belirlenen sayı aralığının toplamı:\n{result}");*/
            //-------------------------------------------------------------------------//

            //Eğer bir sayının kendisi hariç, bütün çarpanlarının toplamı yine o sayıya eşitse bu
            //sayıya MÜKEMMEL SAYI denir. Örneğin, 6 bir mükemmel sayıdır.Çünkü 6 = 1 + 2 +
            //3.mukemmel isminde, sayi parametresinin mükemmel bir sayı olup olmadığını tespit
            //eden bir program yazınız. Bu program 1 - 1000 arasındaki tam sayılardan mükemmel
            //olanlarını bulmak için bir program içinde kullanınız.Program sayının mükemmel
            //olduğunu göstermek için mükemmel sayınının çarpanlarını ekrana yazdırsın. 1000‘den
            //daha büyük sayıları test ederek bilgisayarınızın gücünü deneyebilirsiniz

            /* Console.WriteLine("Bir Sayı giriniz");
             int number = Convert.ToInt32(Console.ReadLine());
             int sum = 0;

             for (int i = 1; i < number; i++)
             {
                 if (number % i == 0)
                 {
                     sum = sum + i;
                     Console.WriteLine(sum);
                 }

             }

             if (sum == number)
             {
                 Console.WriteLine(number + "sayı Mükemmel Sayıdır");
             }
             else
             {
                 Console.WriteLine(number + "sayı Mükemmel Sayı Değildir");
             }*/
            //-----------------------------------------------------------------------------//

            //Bilgisayarların eğitimde sürekli artan bir rolü vardır.Bir ilkokul öğrencisine çarpma
            //işleminde yardımcı olacak bir program yazınız. Kullanıcıdan 2 adet 1 basamaklı sayı
            //isteyin ve ekrana şu şekilde bir soru yazdırın: 4 kere 7 kaçtır? Daha sonra öğrenci cevap
            //versin.Program cevabı kontrol etsin. Eğer cevap doğruysa "Çok güzel" yazdırsın ve yeni
            //bir soru sorsun. Eğer cevap yanlışsa "lütfen tekrar deneyin." yazdırsın ve aynı soruyu
            //öğrenci doğru cevap verene kadar sorsun.

            /*int[] numbers = new int[2];
            do
            {

                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.WriteLine("Sayı {0} Griniz", i + 1);
                    numbers[i] = Convert.ToInt32(Console.ReadLine());
                }

                int multiplication = numbers.Aggregate((x, y) => x * y);
                Console.WriteLine("\n");
                Console.WriteLine($"{numbers[0]} kere {numbers[1]} kac eder? ");
                Console.WriteLine("\n");
                int answer = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\n------------------------------\n");
                if (multiplication == answer)

                {

                    Console.WriteLine("Çok Güzel doğru cevabı buldunuz");
                    Console.WriteLine("\n------------------------------\n");
                }

                for (int i = answer; answer != multiplication; i++)
                {

                    Console.WriteLine("Lütfen Tekrar Deneyiniz");
                    Console.WriteLine("\n");
                    Console.WriteLine($"{numbers[0]} kere {numbers[1]} kac eder? ");
                    Console.WriteLine("\n------------------------------\n");
                    int answer1 = Convert.ToInt32(Console.ReadLine());

                    if (multiplication == answer1)

                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("Çok Güzel doğru cevabı buldunuz");
                        Console.WriteLine("\n------------------------------\n");
                        break;
                    }


                }

            } while (numbers.Length != 0);*/
            //-----------------------------------------------------------------------//

            //Bir dizideki tüm tekrarlı sayıları kaldıran ve güncelleyen bir programı yazın

            /*int[] arr = new int[100];
            int num; // Dizide toplam kaç eleman olacağını tutacak değişken 
            int i, j, k;

            Console.Write("Dizi Eleman Sayısını Girin: ");
            num = Convert.ToInt32(Console.ReadLine());

            //Dizi elemanlarını gir

            for (i = 0; i < num; i++)
            {
                Console.Write("Diziye Değer Gir: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }


            // Tkrarlayan elemanları bul

            for (i = 0; i < num; i++)
            {
                for (j = i + 1; j < num; j++)
                {
                    //Tekrarlı eleman varsa 
                    if (arr[i] == arr[j])
                    {
                        // Tekrarlı elemanı sil
                        for (k = j; k < num; k++)
                        {
                            arr[k] = arr[k + 1];
                        }

                        //Yinelenen öğeyi kaldırdıktan sonra boyutu azalt
                        num--;
                        j--;
                    }
                }
            }

            // Yinelenen öğeleri sildikten sonra diziyi yazdır
            Console.WriteLine("\nYinelenen değerler silindikten sonra dizi içeriği : ");
            for (i = 0; i < num; i++)
            {
                Console.WriteLine(arr[i]);
            }*/

            //-------------------------------------------------------------------------------//
            //Bir sayı dizisindeki tüm asal sayıların toplamını hesaplayan C# Sharp programı yazın.

            /* bool IsPrime(int number) 
             {
                 if (number <= 1)
                     return false;

                 if (number <= 3)
                     return true;

                 if (number % 2 == 0 || number % 3 == 0)
                     return false;                                           //!!!TEKRAR BAK

                 for (int i = 5; i * i <= number; i += 6)
                 {
                     if (number % i == 0 || number % (i + 2) == 0)
                         return false;
                 }

                 return true;

             }
             Console.Write("Bir sayı dizisi girin (boşluklarla ayrılmış): ");
             string input = Console.ReadLine();
             string[] numbers = input.Split(' ');
             int sumOfPrimes = 0;
             foreach (string num in numbers)
             {
                 if (int.TryParse(num, out int number))
                 {
                     if (IsPrime(number))
                     {
                         sumOfPrimes += number;
                     }
                 }
             }
             Console.WriteLine("Asal sayıların toplamı: " + sumOfPrimes);*/
            //-----------------------------------------------------------------------------//

            //Bir dizideki en küçük ve en büyük tamsayıları bulan programı yazın. Program dizinin
            //elemanlarını kullanıcıdan alsın

            /* int[] sayilar = new int[10];
             Random rnd = new Random();
             int min, mak;

             for (int i = 0; i < sayilar.Length; i++)
             {
                 sayilar[i] = rnd.Next(1, 10);
                 Console.WriteLine(sayilar[i]);
             }
             min = sayilar[0];
             mak = sayilar[0];
             for (int i = 1; i < sayilar.Length; i++)
             {
                 if (min > sayilar[i])
                     min = sayilar[i];
                 if (mak < sayilar[i])
                     mak = sayilar[i];
             }
             Console.WriteLine("=====================================");
             Console.WriteLine("=====================================");
             Console.WriteLine("Dizi içindeki en büyük sayı:>>" + mak);
             Console.WriteLine("Dizi içindeki en küçük sayı:>>" + min);*/





            Console.ReadLine();



        }
    }
}
