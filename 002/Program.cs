
    Console.WriteLine("Write your  5 words");
    string [] array = new string[5];
    string [] array2 = new string[array.Length];
    for (int i = 0; i < 5; i++)
        array[i] = Console.ReadLine();
        Console.WriteLine("[" + string.Join ("," , array)+ "]");
    
    StringToArray(array, array2);
PrintArray(array2);
void StringToArray(string [] array, string [] array2)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if(array[i].Length <= 3)
        {
        array2[count] = array[i];
        count++;
        }
    }
}
void PrintArray(string  [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array = array.Where(x => x != null).ToArray();
        Console.WriteLine("[" + string.Join (",",  array)+ "]");
        
    }
}