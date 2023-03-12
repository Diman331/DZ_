        // Создаем трехмерный массив размером 2x2x2
        int[,,] array = new int[2, 2, 2];

        // Заполняем массив неповторяющимися двузначными числами
        int num = 10;
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                for (int k = 0; k < 2; k++)
                {
                    array[i, j, k] = num;
                    num++;
                }
            }
        }

        // Выводим массив построчно с индексами каждого элемента
        Console.WriteLine("Массив размером 2 x 2 x 2");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                for (int k = 0; k < 2; k++)
                {
                    Console.Write($"{array[i, j, k]:00}({i},{j},{k}) ");
                }
                Console.WriteLine();
            }
        }