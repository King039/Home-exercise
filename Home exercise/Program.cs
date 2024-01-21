//string myString = "28";
//Console.WriteLine(myString);

//byte myByte = byte.Parse(myString);
//Console.WriteLine(myByte);

//nint myNint = nint.Parse(myString);
//Console.WriteLine(myNint);

//int myInt = int.Parse(myString);
//Console.WriteLine(myInt);

//long myLong = long.Parse(myString);
//Console.WriteLine(myLong);

//double myDouble = double.Parse(myString);
//Console.WriteLine(myDouble);



double PI = 3.14;
Console.WriteLine("Введите радиус окружности: ");
double radius = double.Parse(Console.ReadLine());
Console.WriteLine("Площадь круга равна: ");
Console.WriteLine(PI *  radius  *  radius);


Console.WriteLine("Введите ваше имя: ");
string name = Console.ReadLine();

Console.WriteLine("Введите вашу фамилию: ");
string surname = Console.ReadLine();

Console.WriteLine("Введите ваше отчество: ");
string familyName = Console.ReadLine();

Console.WriteLine("Укажите место работы: ");
string job = Console.ReadLine();

Console.WriteLine("Семейное положение: ");
string familyStatus = Console.ReadLine();

Console.WriteLine("Есть ли у вас дети: ");
string children = Console.ReadLine();

Console.WriteLine($"{name}\n{surname}\n{familyName}\n{job}\n{familyStatus}\n{children}");


