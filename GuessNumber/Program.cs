// Console.Write("Введите число: ");
// int number = int.Parse(Console.ReadLine());
// if (number > 0) {
//     Console.WriteLine("Число положительное.");
// }
// else if (number < 0) {
//     Console.WriteLine("Число отрицательное.");
// }
// else {
//     Console.WriteLine("Число равно нулю.");
// }


// Console.Write("Введите балл (0-100): ");
// int score = int.Parse(Console.ReadLine());

// if (score >= 91) {
//     Console.WriteLine("Оценка: Отлично (5)");
// }
// else if (score >= 71) {
//     Console.WriteLine("Оценка: Хорошо (4)");
// }
// else if (score >= 51) {
//     Console.WriteLine("Оценка: Удовлетворительно (3)");
// }
// else {
//     Console.WriteLine("Оценка: Неудовлетворительно (2)");
// }


// Console.Write("Введите количество посещений (из 19): ");
// int attendance = int.Parse(Console.ReadLine());
// Console.Write("Введите средний балл по практике: ");
// double practiceGpa = double.Parse(Console.ReadLine());

// bool goodAttendance = attendance >= 14; 
// bool goodGrades = practiceGpa >= 3.0;   

// if (goodAttendance && goodGrades) {
//     Console.WriteLine("+ Допуск к экзамену разрешён.");
// }
// else if (!goodAttendance && goodGrades) {
//     Console.WriteLine("- Недостаточно посещений. Нужно отработать пропуски.");
// }
// else if (goodAttendance && !goodGrades) {
//     Console.WriteLine("- Низкий балл по практике. Нужно пересдать работы.");
// }
// else {
//     Console.WriteLine("- Проблемы и с посещаемостью, и с оценками. Срочно к преподавателю.");
// }

// Console.Write("Введите ваш возраст: ");
// int age = int.Parse(Console.ReadLine());
// string ageGroup = age >= 18 ? "совершеннолетний" : "несовершеннолетний";
// Console.WriteLine($"Вы {ageGroup}.");

// Console.Write("\nВведите температуру за окном (°C): ");
// double temp = double.Parse(Console.ReadLine());
// string weather = temp >= 20 ? "тепло" : (temp >= 0 ? "прохладно" : "мороз");
// Console.WriteLine($"За окном {weather}.");

// Console.Write("\nВведите число: ");
// int n = int.Parse(Console.ReadLine());
// string parity = n % 2 == 0 ? "чётное" : "нечётное";
// Console.WriteLine($"Число {n} — {parity}.");


// Console.WriteLine("Меню");
// Console.WriteLine("1. Посмотреть расписание");
// Console.WriteLine("2. Посмотреть оценки");
// Console.WriteLine("3. Связаться с преподавателем");
// Console.WriteLine("4. Выйти");
// Console.Write("Выберите пункт (1-4): ");
// string choice = Console.ReadLine();

// switch (choice) {
//     case "1":
//         Console.WriteLine("Расписание: ИСП-244, каб. 102, 08:30");
//         break;
//     case "2":
//         Console.WriteLine("Ваши оценки: ИРСПО — 20, РМП — 35,");
//         break;
//     case "3":
//         Console.WriteLine("Email: denis.leontev92@yandex.ru");
//         break;
//     case "4":
//         Console.WriteLine("До свидания!");
//         break;
//     default:
//         Console.WriteLine($"Ошибка: пункт «{choice}» не существует. Введите число от 1 до 4.");
//         break;
// }

// Console.Write("\nВведите номер месяца (1-12): ");
// int monthNumber = int.Parse(Console.ReadLine());

// switch (monthNumber) {
//     case 12:
//     case 1:
//     case 2:
//         Console.WriteLine("Зима");
//         break;
//     case 3:
//     case 4:
//     case 5:
//         Console.WriteLine("Весна");
//         break;
//     case 6:
//     case 7:
//     case 8:
//         Console.WriteLine("Лето");
//         break;
//     case 9:
//     case 10:
//     case 11:
//         Console.WriteLine("Осень");
//         break;
//     default:
//         Console.WriteLine("Неверный номер месяца. Введите число от 1 до 12.");
//         break;
// }


// using System;

// class Program
// {
//     static void Main()
//     {
//         Random random = new Random();
//         int secret = random.Next(1, 101);
//         int attempts = 0;
//         bool guessed = false;
//         Console.WriteLine("Угадай число (1-100)");
//         Console.WriteLine("Я загадал число. Попробуй угадать!");
//         while (!guessed)
//         {
//             Console.Write("Введите число: ");
//             string input = Console.ReadLine();
//             if (!int.TryParse(input, out int guess))
//             {
//                 Console.WriteLine("Ошибка: введите целое число!");
//                 continue; 
//             }
//             if (guess < 1 || guess > 100)
//             {
//                 Console.WriteLine("!!! Число должно быть от 1 до 100!");
//                 continue; 
//             }
//             attempts++;
//             if (guess < secret)
//             {
//                 // Подсказка «горячо/тепло/холодно» через switch
//                 int diff = secret - guess;
//                 string hint = GetHint(diff);
//                 Console.WriteLine($"↑ Больше! {hint}\n");
//             }
//             else if (guess > secret)
//             {
//                 int diff = guess - secret;
//                 string hint = GetHint(diff);
//                 Console.WriteLine($"↓Меньше! {hint}\n");
//             }
//             else
//             {
//                 guessed = true; 
//             }
//         }
//         string result = attempts <= 7 
//             ? $"Отличный результат! Всего {attempts} попыток." 
//             : $"Число найдено за {attempts} попыток. Можно лучше!";

//         Console.WriteLine($"�Правильно! Загаданное число: {secret}");
//         Console.WriteLine($"{result}");
//     }
//     static string GetHint(int diff)
//     {
//         switch (diff)
//         {
//             case <= 3:
//                 return "�Горячо!";
//             case <= 10:
//                 return "�Тепло!";
//             case <= 20:
//                 return "🌀Прохладно!"; 
//             default:
//                 return "❄Холодно!";
//         }
//     }
// }

// Задание 1
// Console.Write("Введите пароль: ");
// string password = Console.ReadLine();
// Console.Write("Подтвердите пароль: ");
// string confirm = Console.ReadLine();

// if (password == confirm)
// {
//     Console.WriteLine("Пароль принят");
// }
// else
// {
//     Console.WriteLine("Пароль не принят");
// }

// Задание 2
// Console.Write("Введите ваш возраст: ");
// int age = int.Parse(Console.ReadLine());

// if (age >= 18)
// {
//     Console.WriteLine("Доступ разрешён");
// }
// else
// {
//     Console.WriteLine("Доступ запрещён");
// }

// Задание 3
// Console.Write("Введите первое число: ");
// double num1 = double.Parse(Console.ReadLine());
// Console.Write("Введите второе число: ");
// double num2 = double.Parse(Console.ReadLine());
// Console.Write("Введите операцию (+, -, *, /): ");
// string op = Console.ReadLine();

// switch (op)
// {
//     case "+":
//         Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
//         break;
//     case "-":
//         Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
//         break;
//     case "*":
//         Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
//         break;
//     case "/":
//         if (num2 != 0)
//         {
//             Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
//         }
//         else
//         {
//             Console.WriteLine("Ошибка: деление на ноль!");
//         }
//         break;
//     default:
//         Console.WriteLine("Ошибка: неизвестная операция.");
//         break;
// }

// Задание 4
// Console.Write("Введите первое число: ");
// int a = int.Parse(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int b = int.Parse(Console.ReadLine());
// Console.Write("Введите третье число: ");
// int c = int.Parse(Console.ReadLine());

// int sum = 0;

// if (a > 0) sum += a;
// if (b > 0) sum += b;
// if (c > 0) sum += c;

// Console.WriteLine($"Сумма положительных чисел: {sum}");

// Задание 5
// Console.WriteLine("Вы стоите перед первой дверью.");
// Console.WriteLine("Путь А: Войти в комнату с огромным драконом.");
// Console.WriteLine("Путь В: Пойти по тёмному коридору.");
// Console.Write("Выберите путь (А или В): ");
// string path = Console.ReadLine().ToUpper();

// if (path == "А" || path == "A")
// {
//     Console.WriteLine("\nДракон говорит: \"Кто не дышит, но живёт;");
//     Console.WriteLine("хоть не нужно — много пьёт;");
//     Console.WriteLine("и в жизни, и в смерти тело как лёд.\"");
//     Console.Write("Ваш ответ: ");
//     string answer = Console.ReadLine().ToLower();

//     if (answer == "рыба")
//     {
//         Console.WriteLine("Дракон открывает дверь в следующую комнату. Вы прошли дальше!");
//     }
//     else
//     {
//         Console.WriteLine("Дракон вас съел! Игра окончена.");
//     }
// }
// else if (path == "В" || path == "B")
// {
//     Console.WriteLine("\nВы в тёмной комнате. Перед вами две двери.");
//     Console.WriteLine("Дверь 1: За ней скрыты сокровища Dungeon Master'а.");
//     Console.WriteLine("Дверь 2: За ней — ловушка с ядовитыми шипами.");
//     Console.Write("Какую дверь выберете? (1 или 2): ");
//     string door = Console.ReadLine();

//     if (door == "1")
//     {
//         Console.WriteLine("Вы нашли сокровища Dungeon Master'а! Победа!");
//     }
//     else if (door == "2")
//     {
//         Console.WriteLine("Вы попали в ловушку с ядовитыми шипами! Игра окончена.");
//     }
//     else
//     {
//         Console.WriteLine("Неверный выбор. Вы остались в тёмной комнате навсегда.");
//     }
// }
// else
// {
//     Console.WriteLine("Неверный путь. Вы остались стоять перед дверью.");
// }