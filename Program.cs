Console.WriteLine( "Границы целочисленных типов");
Console.WriteLine($"byte: {byte.MinValue} .. {byte.MaxValue}");
Console.WriteLine($"short: {short.MinValue} .. {short.MaxValue}");
Console.WriteLine($"int: {int.MinValue} .. {int.MaxValue}");
Console.WriteLine($"long: {long.MinValue} .. {long.MaxValue}");

Console.WriteLine();
Console.WriteLine( "Границы дробных типов");
Console.WriteLine($"float: {float.MinValue} .. {float. MaxValue}");
Console.WriteLine($"double: {double. MinValue} .. {double.MaxValue}");
Console.WriteLine($"decimal: {decimal.MinValue} .. {decimal. MaxValue}" );

Console.WriteLine();
Console.WriteLine("Переполнение byte");
byte maxByte = 255;
byte overflowed = (byte)(maxByte + 1);
Console.WriteLine($"255 + 1 для byte = {overflowed}");


Console.WriteLine();
Console.WriteLine("char");

char firstLetter = 'A';
char sepsrator = '-';
int charAsNumber = firstLetter; // char можно неявно превратить в int - это код символа в таблице Unicode

Console.WriteLine($"Символ: {firstLetter}, разделитель: {sepsrator}");
Console.WriteLine($"Код символа '{firstLetter}' в Unicode: {charAsNumber}");
Console.WriteLine($"Табуляция:\tпосле таба");
Console.WriteLine($"Перенос:\nпосле переноса");


Console.WriteLine();
Console.WriteLine("decimal против double");

double priceDouble = 0.1 + 0.2;
decimal priceDecimal = 0.1m + 0.2m;

Console.WriteLine($"double: 0.1 + 0.2 = {priceDouble}");
Console.WriteLine($"decimal: 0.1 + 0.2 = {priceDecimal}");


Console.WriteLine();
Console.WriteLine("var");

var studentAge = 20; // компилятор вывел int
var gpa = 4.75; // компилятор вывел double
var fullName = "Смирнова А.C."; // компилятор вывел string

Console.WriteLine($"{fullName}, возраст {studentAge}, средний балл {gpa}");


Console.WriteLine();
Console.WriteLine("Ввод текста");

Console.Write("Введите ваше имя: ");
string enteredName = Console.ReadLine();

Console.Write("Введите название вашей группы: ");
string enteredGroup = Console.ReadLine();

Console.WriteLine($"Здравствуйте, {enteredName} из группы {enteredGroup}!");


Console.WriteLine();
Console.WriteLine("Ввод чисел: Convert и Parse");

Console.Write("Введите ваш год рождения: ");
string birthYearInput = Console.ReadLine();

int birthYearConvert = Convert.ToInt32(birthYearInput);
int birthYearParse = int.Parse(birthYearInput);

Console.WriteLine($"Convert. ToInt32: {birthYearConvert}");
Console.WriteLine($"int.Parse: {birthYearParse}");
Console.WriteLine($"B 2030 году вам будет: {2030 - birthYearConvert} лет");

Console.WriteLine();
Console.WriteLine("Ввод чисел: TryParse");

Console.WriteLine("Введите количество прочитанных книг за семестр: ");
string bookInput = Console.ReadLine();

bool wasSuccessful = int.TryParse(bookInput, out int booksCount);

Console.WriteLine($"Удалось преобразовать: {wasSuccessful}");
Console.WriteLine($"Значение переменноц booksCount: {booksCount}");

Console.WriteLine();
Console.WriteLine("Введите имя и фамилию:");
string fullname = Console.ReadLine();

Console.WriteLine("Введите группу:");
string groupName = Console.ReadLine();

Console.WriteLine("Введите год рождения:");
string yearInput = Console.ReadLine();
bool yearLSK = int.TryParse(yearInput, out int birthYear);

Console.WriteLine("Введите средний балл:");
string gradeInput = Console.ReadLine();
bool gradeLKJ = double.TryParse(gradeInput, out double averageGrade);

Console.WriteLine("Введите любимую букву:");
string letterInput = Console.ReadLine();
char favoritelEtter = letterInput[0];

int age2030 = 2030 - birthYear;

bool isGoodGrade = averageGrade >= 4.0;

Console.WriteLine();
Console.WriteLine("    Анкета");
Console.WriteLine($"{fullname}, группа {groupName}");
Console.WriteLine($"Год рождения: {birthYear} (в 2030 будкт {age2030} лет)");
Console.WriteLine($"Средний балл: {averageGrade}");
Console.WriteLine($"Балл >= 4.0: {isGoodGrade}");
Console.WriteLine($"Любимая буква: {favoritelEtter}");

