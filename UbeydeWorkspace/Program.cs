using System;

namespace UbeydeWorkspaceCSharp
{
    class MainClass
    {
        public static void Main()
        {
            string name = "Ubeyde";
            Console.WriteLine("{0}'nin Çalışma Alanına Hoşgeldiniz!", name);
            Console.WriteLine("Çalıştırmak istediğiniz program hangisi ise lütfen onunla ilgili sayıyı yazıp enter'a basın.");
            Console.WriteLine("\t0\tİsminizi yazdırın");
            Console.WriteLine("\t1\tİki sayı ile dört işlem yapın.");
            Console.WriteLine("\t2\tAlmak istediğiniz ürünün indirimli fiyatını bulun.");
            Console.WriteLine("\t3\tÜç sınavın not ortalamasını bulun.");
            Console.WriteLine("\t4\tDikdörtgenin çevresini ve alanını bulun.");
            byte selector = Convert.ToByte(Console.ReadLine());

            switch(selector)
            {
                case 0:
                    PrintYourName.PrintYourNameMain();
                    break;
                case 1:
                    SimpleCalculator.SimpleCalculatorMain();
                    break;
                case 2:
                    DiscountCalculator.DiscountCalculatorMain();
                    break;
                case 3:
                    AverageMarkCalculator.AverageMarkCalculatorMain();
                    break;
                case 4:
                    AreaOfRectangle.AreaOfRectangleMain();
                    break;
                default:
                    Main();
                    break;
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
            Console.WriteLine("Tam isminiz {0} {1}",nameInput, surnameInput);

            Console.WriteLine(tekrarSor);
            string selectedOption = Console.ReadLine();
            if (selectedOption == "e")
            {
                PrintYourNameMain();
            } else
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
            } else if (selectedOperation == "*")
            {
                Console.WriteLine(isleminizinSonucu + (firstNumber * secondNumber));
            } else if (selectedOperation == "/")
            {
                Console.WriteLine(isleminizinSonucu + (firstNumber / secondNumber));
            }

            Console.WriteLine(tekrarSor);
            string selectedOption = Console.ReadLine();
            if (selectedOption == "e")
            {
                SimpleCalculatorMain();
            } else
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
            } else
            {
                Console.WriteLine("İndirimli ürün fiyatınız: " + tagPrice * ( ( 100 - discount ) / 100 ) );
                
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
            } else
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
            Console.WriteLine("Not ortalamanız: " + ( mark1 + mark2 + mark3 ) / 3 );

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

        static string tekrarSor = "Tekrar dikdörtgen çevresini veya alanını ölçmek ister misiniz?";

        public static void AreaOfRectangleMain()
        {

            int edge1, edge2;
            Console.WriteLine("Dikdörtgenin bir kenarını giriniz.");
            edge1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dikdörtgenin diğer kenarını giriniz.");
            edge2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dikdörtgenin çevresi " + ( 2 * ( edge1 + edge2 ) ) + ", alanı ise " + ( edge1 * edge2 ) + "'dir." );

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
}