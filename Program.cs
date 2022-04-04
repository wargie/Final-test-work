string[] arrayFirst =  {"labas", "hi", "pryvitannie", "privet"};
int countFirst = CountStringLessThreeChar(arrayFirst);
string[] resultFirst =  FillResultArray(arrayFirst,countFirst);


string[] arraySecond = {"1234", "16", "-41", "my_sun"};
int countSecond  = CountStringLessThreeChar(arraySecond);
string[] resultSecond = FillResultArray(arraySecond,countSecond);


string[] arrayThird = {"Poland", "Lithuania", "Belarus"};
int countThird = CountStringLessThreeChar(arrayThird);
string[] resultThird = FillResultArray(arrayThird, countThird);

void PrintArray(string[] array) 
{

    for (int i = 0; i < array.Length; i++)
        {
            if (i != array.Length - 1) Console.Write($"{array[i]}, ");
            else Console.Write($"{array[i]}.");
        }
    Console.WriteLine();
}




PrintArray(resultFirst);
PrintArray(resultSecond);
PrintArray(resultThird);