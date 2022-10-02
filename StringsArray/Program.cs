String[] arr = new String[5];

void showSmallArr()
{
    Console.WriteLine("Введите 5 слов, разделяя каждый нажанием Enter");

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Console.ReadLine();
    }
    Console.WriteLine("Массив заполнен");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine(arr[i]);
    }
        Console.WriteLine("Массив с тремя и менее символами:");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine(arr[i]);
    }
}

showSmallArr();
