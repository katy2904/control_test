Console.Write("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());

string[] array = new string[size];

int count = 0;
string result = string.Empty;

for (int i = 0; i < size; i++)
{
    array[i] = Console.ReadLine();
    if (array[i].Length <= 3)
    {
        count++;
        result += array[i] + " ";
    }
}

string[] finalArray = result.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
Console.WriteLine($"В массиве[{String.Join(", ", array)}] элемента длиной "
                    +$"до 3-х символов включительно - {count}");
Console.WriteLine($"[{String.Join(", ", finalArray)}]");