using System.Runtime.InteropServices;

int number_of_values = 5;
int[] user_guess = new int[number_of_values];
int[] target_array = new int[number_of_values];
//still need to check if its within bounds fr low n high
int lowestValue = 0;
int highestValue = 10;

//This loop accepts the user's input 
//int number_of_value_iteration = 0;
//while (number_of_value_iteration < number_of_values)
//{
//    Console.WriteLine("number");
//    if (int.TryParse(Console.ReadLine(), out user_guess[number_of_value_iteration]))
//    {
//        number_of_value_iteration++;
//    }else
//    {
//        Console.WriteLine("Try again");
//    }
//}

//this fills the target array with random numbers
Random rnd = new Random();
for (int i =0; i < number_of_values; i++)
{
    int randomNumber = rnd.Next(lowestValue, highestValue);
    target_array[i] = randomNumber;
}

//create print function
void PrintArray(int[] array)
{
    Array.Sort(array);
    for (int i = 0; i < array.Length; i++)
        Console.WriteLine(array[i]);
}


// Linear Search searches throuhg the array
int LinearSearch(int[] array, int[] arraytoSearch)
{
    int[] tempArray = new int[number_of_values];
    int k = 0;
    for (int i = 0; i < array.Length; i++)
        for (int j =0; j < arraytoSearch.Length; j++)
            if (array[i] == arraytoSearch[j])
            {
                tempArray[k] = arraytoSearch[j];
                k++;
            }
    return -1;
}

Console.WriteLine("Found at");
//Console.WriteLine(LinearSearch(user_guess, [1,2,3,4,5]));
Console.WriteLine(LinearSearch([2,2,8,7,4], [1,2,3,4,5]));
Console.WriteLine("----");

Console.WriteLine("target array");
PrintArray(target_array);
Console.WriteLine("user guess");
PrintArray(user_guess);

