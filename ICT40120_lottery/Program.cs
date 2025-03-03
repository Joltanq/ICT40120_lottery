int number_of_values = 5;
int[] user_guess = new int[number_of_values];
int[] target_array = new int[number_of_values];
int lowestValue = 0;
int highestValue = 10;


Console.WriteLine(LinearSearch([1, 2, 3, 4, 5], 5));

//This loop accepts the user's input 
int number_of_value_iteration = 0;
while (number_of_value_iteration < number_of_values)
{
    Console.WriteLine("number");
    if (int.TryParse(Console.ReadLine(), out int enteredValue) )
    {
        if (LinearSearch(user_guess, enteredValue) == -1)
        {
            user_guess[number_of_value_iteration] = enteredValue;
            number_of_value_iteration++;
        }
        else
        {
            Console.WriteLine("Break");
        }
    }else
    {
        Console.WriteLine("Try again");
    }
}



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
    for (int i = 0; i < array.Length; i++)
        Console.WriteLine(array[i]);
}   


// Linear Search to search if the number has previously been provided
int LinearSearch(int[] array, int valuetoSearch)
{
    for (int i = 0; i < array.Length; i++)
        if (array[i] == valuetoSearch)
        {
            return i;
        }
    return -1;
}

Console.WriteLine("Found at");
Console.WriteLine(LinearSearch(user_guess, 4));
Console.WriteLine("----");

Console.WriteLine("target array");
PrintArray(target_array);
Console.WriteLine("user guess");
PrintArray(user_guess);

