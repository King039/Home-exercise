//дз 5.1

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



//дз 7.1.2

//double PI = 3.14;
//Console.WriteLine("Введите радиус окружности: ");
//double radius = double.Parse(Console.ReadLine());
//Console.WriteLine("Площадь круга равна: ");
//Console.WriteLine(PI *  radius  *  radius);


//Console.WriteLine("Введите ваше имя: ");
//string name = Console.ReadLine();

//Console.WriteLine("Введите вашу фамилию: ");
//string surname = Console.ReadLine();

//Console.WriteLine("Введите ваше отчество: ");
//string familyName = Console.ReadLine();

//Console.WriteLine("Укажите место работы: ");
//string job = Console.ReadLine();

//Console.WriteLine("Семейное положение: ");
//string familyStatus = Console.ReadLine();

//Console.WriteLine("Есть ли у вас дети: ");
//string children = Console.ReadLine();

//Console.WriteLine($"{name}\n{surname}\n{familyName}\n{job}\n{familyStatus}\n{children}");



//дз 5.1

//const double MM_TO_CM = 0.1;
//const double MM_TO_M = 0.0001;
//const double MM_TO_KM = 0.000001;
//const double MM_TO_MILI = 6.213711922373341e-7;
//const double MM_TO_YD = 0.0010936132983;


//Console.WriteLine("Введите колличество мм: ");
//double mm = double.Parse(Console.ReadLine());
//double cm = mm * MM_TO_CM;
//Console.WriteLine($"{cm}см");


//double m = mm * MM_TO_M;
//Console.WriteLine($"{m}м");


//double km = mm * MM_TO_KM;
//Console.WriteLine($"{km}км");


//double mili = mm * MM_TO_MILI;
//Console.WriteLine($"{mili}мили");


//double yd = mm * MM_TO_YD;
//Console.WriteLine($"{yd}ярд");



// дз 5.2

// Первый продукт "кофе стандарт" цена 69,0 ; колличество 1


//Console.WriteLine("Укажите продукт: ");
//string firstProductName = Console.ReadLine();

//Console.WriteLine($"Укажите цену {firstProductName}: ");
//decimal firstProductPrice = decimal.Parse(Console.ReadLine());

//Console.WriteLine($"Укажите колличество продукта {firstProductName} , по цене {firstProductPrice}: ");
//int firstProductQuantity = int.Parse(Console.ReadLine());

//decimal sum = firstProductPrice * firstProductQuantity;


////// Второй продукт "рулет-спринг тв из ку" цена 70,0 ; колличество 1

//Console.WriteLine("Укажите продукт: ");
//string secondProductName = Console.ReadLine();

//Console.WriteLine($"Укажите цену {secondProductName}: ");
//decimal secondProductPrice = decimal.Parse(Console.ReadLine());

//Console.WriteLine($"Укажите колличество продукта {secondProductName} , по цене {secondProductPrice}: ");
//int secondProductQuantity = int.Parse(Console.ReadLine());

//decimal sum2 = secondProductPrice * secondProductQuantity;



//Console.WriteLine("*********************************************************");

//Console.WriteLine("№ Название\t\t\tЦена\tКолличество\tСумма");

//Console.WriteLine($"№1 {firstProductName}\t\t{firstProductPrice}\t{firstProductQuantity}\t\t{sum}");

//Console.WriteLine("НДС с расчитаной ставкой 18%\t\t\t\t10.53");

//Console.WriteLine($"№2 {secondProductName}\t{secondProductPrice}\t{secondProductQuantity}\t\t{sum2}");

//Console.WriteLine("НДС с расчитаной ставкой 10%\t\t\t\t6.36");

//Console.WriteLine("*********************************************************");

//Console.WriteLine($"Итого: {sum + sum2}");

//Console.WriteLine(" ");

//Console.WriteLine(" ");

//Console.WriteLine($"Электронные средства:\t\t\t\t{sum + sum2}");

//Console.WriteLine("НДС итога чека с расчитаной ставкой\n18%\t10.53");

//Console.WriteLine("НДС итога чека с расчитаной ставкой\n10%\t6.36");

//Console.WriteLine(" ");

//Console.WriteLine(" ");

//Console.WriteLine("*********************************************************");

//Console.WriteLine("ВИД НАЛОГООБЛАЖЕНИЯ: ОСН");

//Console.WriteLine("РЕГ. НОМЕР ККТ: 0000143873023483");

//Console.WriteLine("ЗАВОД. №:");

//Console.WriteLine("ФН. №: 8710000100265168");

//Console.WriteLine("ФД. №: 6026");

//Console.WriteLine("ФПД: 3322278314");


// дз 6.2

//string firstString = "512";

//int number = int.Parse(firstString);

//Console.WriteLine(number.GetType());

//string secondString = number.ToString();

//Console.WriteLine(secondString.GetType());

//Console.WriteLine(secondString);
//Console.ReadLine();



//string a = "100";

//int b = int.Parse(a);

//Console.WriteLine(b.GetType());

//string c = b.ToString();

//Console.WriteLine(c.GetType());

//Console.WriteLine(c);
//Console.ReadLine();


// 8.1
//1

//int book = 10;
//int petja = book;
//int alex = book - 4;
//int result = alex;
//int vanja = result - 2;
//int summa1 = petja + alex + vanja;
//Console.WriteLine($"Петя {petja} , Алёша {alex} , Ваня {vanja}.");
//Console.WriteLine($"Вместе {summa1}");
//Console.ReadLine();

////2

//int basket1 = 23;
//int basket2 = basket1 - 11;
//int summa = basket1 + basket2;
//Console.WriteLine($"В обоих корзинах {summa} яблока.");
//Console.ReadLine();

//8.2
//1

//int eggs = 10 + 3;
//int eat = 9;
//int resalt = eggs % eat;
//Console.WriteLine($"Осталось яиц: {resalt}.");
//Console.ReadLine();

////2

//int magazine = 25;
//int newspaper = magazine + 16;
//Console.WriteLine($"Ширина газеты {newspaper} см.");
//Console.ReadLine();

////3

//double potato = 44;
//double beet = potato / 4;
//double onion = beet / 2;
//Console.WriteLine($"Повар потратил {onion} кг. лука.");
//Console.ReadLine();

//8.3
//1

//Console.Write("Введите целое число: ");
//int number = int.Parse(Console.ReadLine());
//int division = number % 8;
//Console.WriteLine($"Остаток от деления на 8 равен: {division}");
//Console.ReadLine();

////2

//Console.Write("Введите число 1: ");
//int number1 = int.Parse(Console.ReadLine());
//Console.Write("Введите число 2: ");
//int number2 = int.Parse(Console.ReadLine());
//Console.Write("Введите число 3: ");
//int number3 = int.Parse(Console.ReadLine());
//int addition = number1+number2+number3;
//int multipliсation = number1*number2*number3;
//Console.WriteLine($"Сумма введенных чисел: {addition}");
//Console.WriteLine($"Произведение введенных чисел: {multipliсation}");
//Console.ReadLine();
//
