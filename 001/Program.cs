
int  main ()
{
Console.WriteLine("Введите текст:");
string[] textMass;
string text = Console.ReadLine();
textMass = text.Split(' ');
int len = textMass.Length;
Console.WriteLine("Количество слов:");
Console.WriteLine($"{len}");
return len;
}
