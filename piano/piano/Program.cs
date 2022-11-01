namespace piano
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo key;
            Console.WriteLine("Переключение между октавами осуществляется клавишами F1 и F2 ");
            Console.WriteLine("Чтобы выйти из программы, нажмите ESC.");
            key = Console.ReadKey();

            if (key.Key == ConsoleKey.F1)
            {
                Console.WriteLine("Вы выбрали первую октаву.");
                firstoctavia();
            }
            else if (key.Key == ConsoleKey.F2)
            {
                Console.WriteLine("Вы выбрали вторую октаву.");
                secondoctavia();
            }
            else if (key.Key == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }
        }
        static void Sound(int key)
        {
            Console.Beep(key, 500);
        }

        static void firstoctavia()
        {
            int[] firstoctavia = new int[] { 523, 554, 587, 622, 659, 699, 740, 784, 831, 880, 932, 988, };
            ConsoleKeyInfo key;

            do
            {
                key = Console.ReadKey();

                if (key.Key == ConsoleKey.D)
                {
                    Sound(firstoctavia[0]);
                }

                if (key.Key == ConsoleKey.R)
                {
                    Sound(firstoctavia[1]);
                }
                if (key.Key == ConsoleKey.F)
                {
                    Sound(firstoctavia[2]);
                }
                if (key.Key == ConsoleKey.T)
                {
                    Sound(firstoctavia[3]);
                }
                if (key.Key == ConsoleKey.G)
                {
                    Sound(firstoctavia[4]);
                }
                if (key.Key == ConsoleKey.H)
                {
                    Sound(firstoctavia[5]);
                }
                if (key.Key == ConsoleKey.U)
                {
                    Sound(firstoctavia[6]);
                }
                if (key.Key == ConsoleKey.J)
                {
                    Sound(firstoctavia[7]);
                }
                if (key.Key == ConsoleKey.I)
                {
                    Sound(firstoctavia[8]);
                }
                if (key.Key == ConsoleKey.K)
                {
                    Sound(firstoctavia[9]);
                }
                if (key.Key == ConsoleKey.O)
                {
                    Sound(firstoctavia[10]);
                }
                if (key.Key == ConsoleKey.L)
                {
                    Sound(firstoctavia[11]);
                }
                if (key.Key == ConsoleKey.Escape)
                {
                    Environment.Exit(0);
                }
            }
            while (key.Key != ConsoleKey.F2);
            Console.WriteLine("Вы переключились на вторую октаву.");
            secondoctavia();
        }
        static void secondoctavia()
        {
            int[] secondoctavia = new int[] { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976 };
            ConsoleKeyInfo key;

            do
            {
                key = Console.ReadKey();

                if (key.Key == ConsoleKey.D)
                {
                    Sound(secondoctavia[0]);
                }

                if (key.Key == ConsoleKey.R)
                {
                    Sound(secondoctavia[1]);
                }
                if (key.Key == ConsoleKey.F)
                {
                    Sound(secondoctavia[2]);
                }
                if (key.Key == ConsoleKey.T)
                {
                    Sound(secondoctavia[3]);
                }
                if (key.Key == ConsoleKey.G)
                {
                    Sound(secondoctavia[4]);
                }
                if (key.Key == ConsoleKey.H)
                {
                    Sound(secondoctavia[5]);
                }
                if (key.Key == ConsoleKey.U)
                {
                    Sound(secondoctavia[6]);
                }
                if (key.Key == ConsoleKey.J)
                {
                    Sound(secondoctavia[7]);
                }
                if (key.Key == ConsoleKey.I)
                {
                    Sound(secondoctavia[8]);
                }
                if (key.Key == ConsoleKey.K)
                {
                    Sound(secondoctavia[9]);
                }
                if (key.Key == ConsoleKey.O)
                {
                    Sound(secondoctavia[10]);
                }
                if (key.Key == ConsoleKey.L)
                {
                    Sound(secondoctavia[11]);
                }
                if (key.Key == ConsoleKey.Escape)
                {
                    Environment.Exit(0);
                }
            }
            while (key.Key != ConsoleKey.F1);
            Console.WriteLine("Вы переключились на первую октаву.");
            firstoctavia();
        }

    }
}