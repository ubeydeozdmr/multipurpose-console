using System;

namespace UbeydeWorkspaceCSharp
{
    class MainClass
    {
        public static void Main()
        {

            Console.ForegroundColor = ConsoleColor.Gray;
            string name = "Ubeyde";
            Console.WriteLine("{0}'nin Çalışma Alanına Hoşgeldiniz!", name);
            Console.WriteLine("Çalıştırmak istediğiniz program hangisi ise lütfen onunla ilgili sayıyı yazıp enter'a basın.");
            Console.WriteLine("\t0\tUygulamadan çık.");
            Console.WriteLine("\t1\tİsminizi yazdırın");
            Console.WriteLine("\t2\tİki sayı ile dört işlem yapın.");
            Console.WriteLine("\t3\tAlmak istediğiniz ürünün indirimli fiyatını bulun.");
            Console.WriteLine("\t4\tÜç sınavın not ortalamasını bulun.");
            Console.WriteLine("\t5\tDikdörtgenin çevresini ve alanını bulun.");
            Console.WriteLine("\t6\tDaire veya daire diliminin alanını bulun.");
            Console.WriteLine("\t7\tÜç direncin eşdeğer direncini bulun.");
            Console.WriteLine("\t8\tYazdığınız sayının tek mi çift mi olduğunu görün.");
            Console.WriteLine("\t9\tBir sayıyı diğer bir sayıya bölüp kalanı bulun.");
            Console.WriteLine("\t10\tYazdırmak istediğiniz bir kelimeyi, cümleyi vb. istediğiniz kadar alt alta yazdırın.");
            Console.WriteLine("\t11\tVücut kitle indeksinizi hesaplayın.");
            Console.WriteLine("\t12\tSeçtiğiniz adette sayıyının miktarlarını yine siz seçerek toplayın.");

            try
            {
                byte selector = Convert.ToByte(Console.ReadLine());

                switch (selector)
                {
                    case 0:
                        Environment.Exit(0);
                        break;
                    case 1:
                        PrintYourName.PrintYourNameMain();
                        break;
                    case 2:
                        SimpleCalculator.SimpleCalculatorMain();
                        break;
                    case 3:
                        DiscountCalculator.DiscountCalculatorMain();
                        break;
                    case 4:
                        AverageMarkCalculator.AverageMarkCalculatorMain();
                        break;
                    case 5:
                        AreaOfRectangle.AreaOfRectangleMain();
                        break;
                    case 6:
                        AreaOfCircle.AreaOfCircleMain();
                        break;
                    case 7:
                        EquivalentResistanceCalculator.EquivalentResistanceCalculatorMain();
                        break;
                    case 8:
                        OddOrEven.OddOrEvenMain();
                        break;
                    case 9:
                        RemainderFinder.RemainderFinderMain();
                        break;
                    case 10:
                        TextRepeater.TextRepeaterMain();
                        break;
                    case 11:
                        BmiFinder.BmiFinderMain();
                        break;
                    case 12:
                        MultipleAddition.MultipleAdditionMain();
                        break;
                    default:
                        Main();
                        break;
                }
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t********************************************************************");
                Console.WriteLine("\t*                                                                  *");
                Console.WriteLine("\t*  BİR HATA OLUŞTU. LÜTFEN TALİMATLARI DOĞRU BİR ŞEKİLDE YAPINIZ.  *");
                Console.WriteLine("\t*                                                                  *");
                Console.WriteLine("\t********************************************************************");
                Main();
            }
        }
    }

    class PrintYourName
    {

        static string tekrarSor = "Tekrardan tam isminizi yazdırmak ister misiniz? (e/h)";

        public static void PrintYourNameMain()
        {
            string nameInput, surnameInput;
            Console.WriteLine("Lütfen isminizi giriniz.");
            nameInput = Console.ReadLine();
            Console.WriteLine("Lütfen soyisminizi giriniz.");
            surnameInput = Console.ReadLine();
            Console.WriteLine("Tam isminiz {0} {1}", nameInput, surnameInput);

            Console.WriteLine(tekrarSor);
            string selectedOption = Console.ReadLine();
            if (selectedOption == "e")
            {
                PrintYourNameMain();
            }
            else
            {
                MainClass.Main();
            }
        }
    }

    class SimpleCalculator
    {

        static string isleminizinSonucu = "İşleminizin sonucu: ";
        static string tekrarSor = "Tekrar işlem yapmak ister misiniz? (e/h)";

        public static void SimpleCalculatorMain()
        {
            decimal firstNumber, secondNumber;
            Console.WriteLine("Lütfen ilk sayıyı giriniz.");
            firstNumber = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Lütfen ikinci sayıyı giriniz.");
            secondNumber = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Lütfen bir işlem seçiniz. İlgili işlemin sembolünü yazıp enter'a basın.");
            Console.WriteLine("\t+\tToplama işlemi için");
            Console.WriteLine("\t-\tÇıkarma işlemi için");
            Console.WriteLine("\t*\tÇarpma işlemi için");
            Console.WriteLine("\t/\tBölme işlemi için");
            string selectedOperation = Console.ReadLine();

            if (selectedOperation == "+")
            {
                Console.WriteLine(isleminizinSonucu + (firstNumber + secondNumber));
            }
            else if (selectedOperation == "-")
            {
                Console.WriteLine(isleminizinSonucu + (firstNumber - secondNumber));
            }
            else if (selectedOperation == "*")
            {
                Console.WriteLine(isleminizinSonucu + (firstNumber * secondNumber));
            }
            else if (selectedOperation == "/")
            {
                Console.WriteLine(isleminizinSonucu + (firstNumber / secondNumber));
            }
            else
            {
                SimpleCalculatorMain();
            }

            Console.WriteLine(tekrarSor);
            string selectedOption = Console.ReadLine();
            if (selectedOption == "e")
            {
                SimpleCalculatorMain();
            }
            else
            {
                MainClass.Main();
            }
        }
    }

    class DiscountCalculator
    {

        static string tekrarSor = "Tekrar indirim ölçmek ister misiniz? (e/h)";

        public static void DiscountCalculatorMain()
        {
            double tagPrice, discount;
            Console.WriteLine("Lütfen almak istediğiniz ürünün etiket fiyatını girin.");
            tagPrice = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Almak istediğiniz üzere yüzde kaç indirim yapılacak?");
            discount = Convert.ToDouble(Console.ReadLine());

            if (discount > 100 || discount < 0 || tagPrice < 0)
            {
                Console.WriteLine("İndirim %100'den daha çok veya %0'dan daha az olamaz. Lütfen geçerli bir indirim oranı girin.");
                Console.ReadLine();
                DiscountCalculatorMain();
            }
            else
            {
                Console.WriteLine("İndirimli ürün fiyatınız: " + tagPrice * ((100 - discount) / 100));

                if (discount == 0)
                {
                    Console.WriteLine("İndirim oranının %0 olması aslında o ürüne indirim yapılmadığı anlamına gelir.");
                }

                if (discount == 100)
                {
                    Console.WriteLine("İndirim oranının %100 olması aslında o ürünün ücretsiz yapıldığı anlamına gelir.");
                }
            }

            Console.WriteLine(tekrarSor);
            string selectedOption = Console.ReadLine();
            if (selectedOption == "e")
            {
                DiscountCalculatorMain();
            }
            else
            {
                MainClass.Main();
            }

        }
    }

    class AverageMarkCalculator
    {

        static string tekrarSor = "Tekrar not ortalamanızı öğrenmek ister misiniz? (e/h)";

        public static void AverageMarkCalculatorMain()
        {
            byte mark1, mark2, mark3;
            Console.WriteLine("Lütfen birinci sınavınızın notunu giriniz.");
            mark1 = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Lütfen ikinci sınavınızın notunu giriniz.");
            mark2 = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Lütfen üçüncü sınavınızın notunu giriniz.");
            mark3 = Convert.ToByte(Console.ReadLine());

            if (mark1 < 0 || mark2 < 0 || mark3 < 0 || mark1 > 100 || mark2 > 100 || mark3 > 100)
            { Console.WriteLine("Girdiğiniz not değerleri sıfırdan küçük veya yüzden büyük olamaz."); AverageMarkCalculatorMain(); }

            Console.WriteLine("Not ortalamanız: " + (mark1 + mark2 + mark3) / 3);

            Console.WriteLine(tekrarSor);
            string selectedOption = Console.ReadLine();
            if (selectedOption == "e")
            {
                AverageMarkCalculator.AverageMarkCalculatorMain();
            }
            else
            {
                MainClass.Main();
            }
        }
    }

    class AreaOfRectangle
    {

        static string tekrarSor = "Tekrar dikdörtgen çevresini veya alanını ölçmek ister misiniz? (e/h)";

        public static void AreaOfRectangleMain()
        {

            int edge1, edge2;
            Console.WriteLine("Dikdörtgenin bir kenarını giriniz.");
            edge1 = Convert.ToInt32(Console.ReadLine());

            if (edge1 <= 0) { Console.WriteLine("Girdiğiniz kenar uzunluğu sıfırdan büyük olmak zorundadır."); AreaOfRectangleMain(); }

            Console.WriteLine("Dikdörtgenin diğer kenarını giriniz.");
            edge2 = Convert.ToInt32(Console.ReadLine());

            if (edge2 <= 0) { Console.WriteLine("Girdiğiniz kenar uzunluğu sıfırdan büyük olmak zorundadır."); AreaOfRectangleMain(); }

            Console.WriteLine("Dikdörtgenin çevresi " + (2 * (edge1 + edge2)) + ", alanı ise " + (edge1 * edge2) + "'dir.");

            Console.WriteLine(tekrarSor);
            string selectedOption = Console.ReadLine();
            if (selectedOption == "e")
            {
                AreaOfRectangleMain();
            }
            else
            {
                MainClass.Main();
            }
        }
    }

    class AreaOfCircle
    {
        static string tekrarSor = "Tekrar daire alanını bulmak ister misiniz? (e/h)";

        public static void AreaOfCircleMain()
        {
            double radius, angleOfCircleSegment;
            Console.WriteLine("Lütfen yarıçapı giriniz.");
            radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Lütfen daire diliminin açısını girin. Eğer daireniz tam daire ise 360 yazıp enter'a basın.");
            angleOfCircleSegment = Convert.ToDouble(Console.ReadLine());

            if (angleOfCircleSegment < 0 || angleOfCircleSegment > 360 || radius <= 0)
            { Console.WriteLine("Lütfen geçerli bir açı değeri giriniz. Ayrıca yarıçap sıfırdan büyük olmak zorunda."); AreaOfCircleMain(); }

            Console.WriteLine("Pi'yi 3 almak istiyorsanız 3, 3.14 almak istiyorsanız 4'e basıp enter'a basın.");
            string selectedOperation = Console.ReadLine();

            if (selectedOperation == "3")
            {
                AreaOfCircle3();
            }
            else if (selectedOperation == "4")
            {
                AreaOfCircle4();
            }
            else
            {
                AreaOfCircle.AreaOfCircleMain();
            }

            void AreaOfCircle3()
            {
                Console.WriteLine("Dairenin alanı: " + (3 * radius * radius * (angleOfCircleSegment / 360)));
            }

            void AreaOfCircle4()
            {
                Console.WriteLine("Dairenin alanı: " + (3.14 * radius * radius * (angleOfCircleSegment / 360)));
            }

            Console.WriteLine(tekrarSor);
            string selectedOption = Console.ReadLine();
            if (selectedOption == "e")
            {
                AreaOfCircle.AreaOfCircleMain();
            }
            else
            {
                MainClass.Main();
            }
        }
    }

    class EquivalentResistanceCalculator
    {

        static string tekrarSor = "Tekrar eşdeğer direnç ölçümü yapmak ister misiniz? (e/h)";

        public static void EquivalentResistanceCalculatorMain()
        {
            int resistance1, resistance2, resistance3; double equivalentResistance;
            Console.WriteLine("Birinci direnç değerini ohm cinsinden giriniz.");
            resistance1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İkinci direnç değerini ohm cinsinden giriniz.");
            resistance2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Üçüncü direnç değerini ohm cinsinden giriniz.");
            resistance3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Seri bağlama için a, paralel bağlama için b yazıp enter'a basın.");
            char selectedOperation = Convert.ToChar(Console.ReadLine());

            if (selectedOperation == 'a')
            {
                Serial();
            }
            else if (selectedOperation == 'b')
            {
                Parallel();
            }
            else
            {
                EquivalentResistanceCalculator.EquivalentResistanceCalculatorMain();
            }

            void Serial()
            {
                equivalentResistance = resistance1 + resistance2 + resistance3;
                Console.WriteLine("Eşdeğer direnç " + equivalentResistance);
            }

            void Parallel()
            {
                equivalentResistance = (resistance1 * resistance2 * resistance3) / (resistance1 * resistance2 + resistance2 * resistance3 + resistance1 * resistance3);
                Console.WriteLine("Eşdeğer direnç " + equivalentResistance);
            }

            Console.WriteLine(tekrarSor);
            string selectedOption = Console.ReadLine();
            if (selectedOption == "e")
            {
                EquivalentResistanceCalculator.EquivalentResistanceCalculatorMain();
            }
            else
            {
                MainClass.Main();
            }
        }
    }

    class OddOrEven
    {

        static string tekrarSor = "Tekrar sayı denemek ister misiniz? (e/h)";

        public static void OddOrEvenMain()
        {
            Console.WriteLine("Bir sayı girin ve enter'a basın.");
            int input = Convert.ToInt32(Console.ReadLine());

            if (input % 2 == 0)
            {
                Console.WriteLine("Girdiğiniz sayı çift.");
            }
            else if (input % 2 == 1)
            {
                Console.WriteLine("Girdiğiniz sayı tek.");
            }
            else { Console.WriteLine("Lütfen bir doğal sayı girdiğinizden emin olun. Girdiğiniz sayı değeri 0'dan küçük olamaz."); OddOrEvenMain(); }

            Console.WriteLine(tekrarSor);
            string selectedOption = Console.ReadLine();
            if (selectedOption == "e")
            {
                OddOrEven.OddOrEvenMain();
            }
            else
            {
                MainClass.Main();
            }
        }
    }

    class RemainderFinder
    {

        static string tekrarSor = "Tekrar kalan değerini bulmak ister misiniz? (e/h)";

        public static void RemainderFinderMain()
        {
            int dividend, divisor;
            Console.WriteLine("Lütfen bölmek istediğiniz sayıyı girin ve enter'a basın.");
            dividend = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(dividend + " sayısını hangi sayıya bölmek istiyorsunuz?");
            divisor = Convert.ToInt32(Console.ReadLine());

            if (dividend < 0 || divisor <= 0) { Console.WriteLine("Bölünen 0'dan küçük olamaz. Ayrıca bölen 0'dan büyük olmak zorunda."); RemainderFinderMain(); }

            Console.WriteLine("{0} sayısının {1} sayısına bölümünden kalan: " + (dividend % divisor), dividend, divisor);

            Console.WriteLine(tekrarSor);
            string selectedOption = Console.ReadLine();
            if (selectedOption == "e")
            {
                RemainderFinder.RemainderFinderMain();
            }
            else
            {
                MainClass.Main();
            }
        }
    }

    class TextRepeater
    {

        static string tekrarSor = "Tekrar denemek ister misiniz? (e/h)";

        public static void TextRepeaterMain()
        {
            Console.WriteLine("Lütfen girmek istediğiniz kelimeyi, cümleyi vb. girin ve enter'a basın.");
            string inputtedText = Console.ReadLine();
            Console.WriteLine("Girdiğiniz kelime, cümle vb. kaç defa tekrarlansın?");
            int counter = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < counter; i++)
            {
                Console.WriteLine(inputtedText);
                if (counter == i) { break; }
            }

            Console.WriteLine(tekrarSor);
            string selectedOption = Console.ReadLine();
            if (selectedOption == "e")
            {
                TextRepeater.TextRepeaterMain();
            }
            else
            {
                MainClass.Main();
            }
        }
    }

    class BmiFinder
    {

        static string tekrarSor = "Tekrar VKI ölçmek ister misiniz? (e/h)";

        public static void BmiFinderMain()
        {
            double weight, height, yourBMI;
            Console.WriteLine("Lütfen kilonuzu kg cinsinden giriniz.");
            weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Lütfen boyunuzu cm cinsinden giriniz.");
            height = Convert.ToDouble(Console.ReadLine());
            yourBMI = weight / ((height / 100) * (height / 100));
            Console.WriteLine("Vücut kitle indeksiniz: {0}", yourBMI);

            if (yourBMI < 18)
            {
                Console.WriteLine("Zayıf");
            } else
            if (yourBMI >= 18 && yourBMI < 25)
            {
                Console.WriteLine("Sağlıklı");
            } else
            if (yourBMI >= 25 && yourBMI < 30)
            {
                Console.WriteLine("Fazla kilolu");
            } else
            if (yourBMI >= 30 && yourBMI < 35)
            {
                Console.WriteLine("Obezite Tip 1");
            } else
            if (yourBMI >= 35 && yourBMI < 40)
            {
                Console.WriteLine("Obezite Tip 2");
            } else
            {
                Console.WriteLine("Obezite Tip 3");
            }

            Console.WriteLine(tekrarSor);
            string selectedOption = Console.ReadLine();
            if (selectedOption == "e")
            {
                BmiFinder.BmiFinderMain();
            }
            else
            {
                MainClass.Main();
            }
        }
    }

    class MultipleAddition
    {

        static string tekrarSor = "Tekrar denemek ister misiniz? (e/h)";

        public static void MultipleAdditionMain()
        {
            int number, counter, total = 0;
            Console.WriteLine("Kaç tane sayı toplayacaksınız?");
            counter = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= counter; i++)
            {
                Console.WriteLine("{0}. sayıyı girin: ", i);
                number = Convert.ToInt32(Console.ReadLine());
                total += number;
            }

            Console.WriteLine("Girdiğiniz {0} adet sayının toplamı: {1}", counter, total);

            Console.WriteLine(tekrarSor);
            string selectedOption = Console.ReadLine();
            if (selectedOption == "e")
            {
                MultipleAddition.MultipleAdditionMain();
            }
            else
            {
                MainClass.Main();
            }
        }
    }
}