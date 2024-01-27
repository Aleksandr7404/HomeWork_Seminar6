// // Задайте произвольную строку. Выясните, является ли она палиндромом.

bool ChekPoly(string word)
{
    bool polyndrom = false;
    for (int i = 0; i < word.Length / 2; i++)
    {
        if (word[i] == word[word.Length - 1 - i])
            polyndrom = true;
        else
            polyndrom = false;
        
    }
    return polyndrom;

}

Console.Clear();

Console.WriteLine("Введите слово для проверки: ");
String poly = Console.ReadLine();
if (ChekPoly(poly) == true)
{
    Console.WriteLine($"{poly} - палиндром");
}
else
{
    Console.WriteLine($"{poly} - не палиндром");
}


// public class Task3
// {
// public static void Main(string[] args)
// {
// // Входная строка для проверки
// string input = "шалаш";
// // Вызов метода для проверки, является ли строка палиндромом
// // Вывод результата
// bool isPalindrome = IsPalindrome(input);
// Console.WriteLine(isPalindrome ? "Да" : "Нет");
// }
// // Метод для проверки, является ли строка палиндромом
// public static bool IsPalindrome(string str)
// {
// // Нормализация строки путем удаления не буквенно-цифровыхсимволов и приведения к нижнему регистру
// string normalized = new string(str.Where(char.IsLetterOrDigit).ToArray()).ToLower();
// // Сравнение строки с ее перевернутым вариантом
// return normalized.SequenceEqual(normalized.Reverse());
// }
// }
