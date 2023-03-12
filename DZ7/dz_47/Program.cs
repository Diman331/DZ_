        int m = 3; // количество строк
        int n = 4; // количество столбцов

        double[,] array = new double[m, n]; // создаем двумерный массив

        Random rnd = new Random(); // создаем генератор случайных чисел

        // заполняем массив случайными вещественными числами
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                array[i, j] = rnd.NextDouble() * 20 - 10; // случайное число от -10 до 10
            }
        }

        // выводим массив на экран с ограничением 2 знаков после запятой
        Console.WriteLine($"m = {m}, n = {n}\n");
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{array[i, j]:0.#} ");
            }
            Console.WriteLine();
        }