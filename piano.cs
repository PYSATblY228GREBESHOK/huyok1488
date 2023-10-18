namespace pianinka
{
    internal class nono4ku
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Всего 4 октавы, чтобы поменять октаву нажмите с F2 до F5" 
            "\n"
            "или нажмите "Esc", чтобы закончить сессию");
            ConsoleKeyInfo start = Console.ReadKey();

            while (start.Key != ConsoleKey.Escape)
            {
                if (start.Key == ConsoleKey.F5)
                {
                    Console.WriteLine("F5");
                    while (start.Key != ConsoleKey.F4 && start.Key != ConsoleKey.F3 && start.Key != ConsoleKey.F2 && start.Key != ConsoleKey.Escape)
                    {
                        start = key(start, 0);
                    }
                }else if(start.Key == ConsoleKey.F2)
                {
                    Console.WriteLine("F2");
                    while (start.Key != ConsoleKey.F5 && start.Key != ConsoleKey.F3 && start.Key != ConsoleKey.F4 && start.Key != ConsoleKey.Escape)
                    {
                        start = key(start, 2);
                    }
                }
                else if (start.Key == ConsoleKey.F3)
                {
                    Console.WriteLine("F3");
                    while (start.Key != ConsoleKey.F2 && start.Key != ConsoleKey.F5 && start.Key != ConsoleKey.F4 && start.Key != ConsoleKey.Escape)
                    {
                        start = key(start, 3);
                    }
                }
                else if( start.Key == ConsoleKey.F4)
                {
                    Console.WriteLine("F4");
                    while (start.Key != ConsoleKey.F2 && start.Key != ConsoleKey.F3 && start.Key != ConsoleKey.F5 && start.Key != ConsoleKey.Escape)
                    {
                        start = key(start,1);
                    }
                }
                else
                {
                    Console.WriteLine(" - Такой октавы нет");
                    start = Console.ReadKey();
                }
            }
        }

        static int sound(int i, int j) 
        {
            int[,] arr = new int[4, 12] {{ 523, 587, 659, 698, 784, 880, 987, 554, 622, 740, 830, 936},
            { 261, 293, 329, 349, 392, 440, 494, 277, 311, 370, 415, 366},
            {65, 73, 82, 87, 98, 110, 123, 69, 78, 93, 103, 116},
            {130, 146, 164, 174, 196, 220, 246, 138, 155, 185, 207, 233 }};
            return arr[i,j];
        }
        static ConsoleKeyInfo key (ConsoleKeyInfo i) start,int // функция клавиш
        {
            start = Console.ReadKey();

            if (start.Key == ConsoleKey.Q){ //до
            
                int j = 0;
                int note = sound(i, j);
                sound2(note);
            }

            else if (start.Key == ConsoleKey.W){ // ре
            
                int j = 1;
                int note = sound(i, j);
                sound2(note);
            }

            else if (start.Key == ConsoleKey.E){ // ми
            
                int j = 2;
                int note = sound(i, j);
                sound2(note);
            }

            else if (start.Key == ConsoleKey.R){ // фа
            
                int j = 3;
                int note = sound(i, j);
                sound2(note);
            }

            else if (start.Key == ConsoleKey.T){ // соль
            
                int j = 4; 
                int note = sound(i, j);
                sound2(note);
            }

            else if (start.Key == ConsoleKey.Y){ // ля
            
                int j = 5; 
                int note = sound(i, j);
                sound2(note);
            }

            else if (start.Key == ConsoleKey.U){ // си
                int j = 6;
                int note = sound(i, j);
                sound2(note);
            }
            else if (start.Key == ConsoleKey.D1){
                int j = 7;
                int note = sound(i, j);
                sound2(N);
            }

            else if (start.Key == ConsoleKey.D2){
                int j = 8;
                int note = sound(i, j);
                sound2(note);
            }

            else if (start.Key == ConsoleKey.D3){
                int j = 9;
                int note = sound(i, j);
                sound2(note);
            }

            else if (start.Key == ConsoleKey.D4){
                int j = 10;
                int note = sound(i, j);
                sound2(note);
            }

            else if (start.Key == ConsoleKey.D5){
                int j = 11;
                int note = sound(i, j);
                Console.Clear();
                Console.Beep(note, 200);
            }

            else if (start.Key != ConsoleKey.F2 && start.Key != ConsoleKey.F3 && start.Key != ConsoleKey.F5 && start.Key != ConsoleKey.F4 && start.Key != ConsoleKey.Escape)
            {
                Console.WriteLine(" - Такой клавиши нет");
            }
            return start;
        }

        public static void sound2(int  N){
            Console.Clear();
            Console.Beep(note, 200);
        }
    }
}