int a = new Random().Next(100, 1000);

// Поиск первого числа
int a1 = a / 100;
Console.WriteLine($"rand{a}, aa{a1}");

// Поиск второго числа
int a2 = a  % 100 / 10;
Console.WriteLine($"rand{a}, aa{a2}");

//Поиск третьего числа
int a3 = a % 10;
Console.WriteLine($"rand{a}, aa{a3}");