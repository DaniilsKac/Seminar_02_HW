// Дополнительное:
// Назовём число «интересным» если его произведение цифр делится на их сумму БЕЗ остатка. Напишите программу, которая заполняет массив на 10 «интересных» случайных целых чисел от 10 до 1000(999 - последнее). (каждый эл-т массива – сгенерирован случайно)
// Пример для 1 элемента массива: 591, сумма: 5+9+1 = 15; произведение: 5*9*1 = 45; 45 / 15 - делится НАЦЕЛО, число "интересное"
// [591, 532, 189, 523, 333, 546, 527, 275, 456, 264]

const int SIZE =10;
        var nums = Enumerable.Range(10, 1000).ToList();
        int[] result = new int[SIZE];
        string? numberindex = Convert.ToString(nums);
        Random rand = new Random();
        for (int i = 0; i < SIZE; i++)
        {
            int pos = rand.Next(0, nums.Count);
            result[i] = nums[pos];
            nums.RemoveAt(pos);
        }
        foreach (var i in result)
        {
            Console.Write(" "+i);
        }