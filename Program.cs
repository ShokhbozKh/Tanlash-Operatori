namespace Tanlash_Operatori
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1
            /*
             * + (qo'shish)
            - (ayirish)
            * (ko'paytirish)
            / (bo'lish)
            */
            /*
            Console.Write("1-Son kiriting:");
            int n = int.Parse(Console.ReadLine());
            Console.Write("2-Son kiriting:");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("+    -    *    /");
            Console.Write("Tanlang:");
            char amal = char.Parse(Console.ReadLine());

            switch(amal)
            {
                case '+':
                    Console.WriteLine($"Qushuv amali, {n} + {m} = {n+m}");
                    break;
                case '-':
                    Console.WriteLine($"Ayiruv  amali, {n} - {m} = {n - m}");
                    break;
                case '*':
                    Console.WriteLine($"Kupaytiruv amali, {n} * {m} = {n * m}");
                    break;
                case '/':
                    Console.WriteLine($"Buluv amali  amali, {n} / {m} = {n / m}");
                    break;

                default: Console.WriteLine("bunday amal yuq ", amal); 
                    break;
            }
            */
            #endregion

            #region 2
            /*
             * Rang tanlash:
            Foydalanuvchi "qizil", "yashil", "sariq", yoki "ko'k" ranglardan 
            birini tanlasin. Dastur shu rangni ekranga chiqarsin.
            */
            /*
            Console.WriteLine("Rang tanlang:\n qizil-> r \n yashil-> g \n sariq-> y \n ko'k-> b");
            char color = char.Parse(Console.ReadLine());

            switch(color)
            {
                case 'r':
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Qizil rang tanlandi");
                    break;
                case 'g':
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Yashil rang tanlandi");
                    break;
                case 'y':
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Sariq rang tanlandi");
                    break;
                case 'b':
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Ko'k rang tanlandi");
                    break;
                default: Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Rang tanlashda Xatolik bor");
                    break;
            }
            Thread.Sleep(4000);
            Console.ResetColor();
            Console.Clear();
            Main(args);
            */
            #endregion

            

        }
    }
}
