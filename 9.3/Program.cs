      //Задайте значения M и N. Напишите программу, которая найдёт наибольший общий делитель (НОД) этих чисел с помощью рекурсии.      
            Console.Write("Введите первое число = ");
 
            int n = Convert.ToInt32(Console.ReadLine());
 
            Console.Write("Введите второе число = ");
 
            int m = Convert.ToInt32(Console.ReadLine());
 
            if (n == 0 && m == 0)
            {
                Console.WriteLine("Наибольший общий делитель не существует");
            }
            else if (m == 0)
            {
                Console.WriteLine("Наибольший общий делитель = {0}", n);
            }
            else
            {
                while (n != 0)
                {
                    int mod = m % n;
                    m = n;
                    n = mod;
                }
 
                Console.WriteLine("Наибольший общий делитель = {0}", m);
            }
 
            Console.ReadKey();