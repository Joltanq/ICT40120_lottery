int number_of_values = 5;
int[] user_guess_array = new int[number_of_values];
int[] target_array = new int[number_of_values];
int[] correct_guesses_array = new int[number_of_values];
int lowestValue = 0;
int highestValue = 10;

//This loop accepts the user's input 
int number_of_value_iteration = 0;
while (number_of_value_iteration < number_of_values)
{
    Console.WriteLine("number");
    if (int.TryParse(Console.ReadLine(), out int enteredValue) )
    {
        if (LinearSearch(user_guess_array, enteredValue, number_of_value_iteration) == -1)
        {
            if(enteredValue <= highestValue && enteredValue >= lowestValue)
            {
                user_guess_array[number_of_value_iteration] = enteredValue;
                number_of_value_iteration++;
            }
            else
            {
                Console.WriteLine($"The number has to be between {lowestValue} and {highestValue}");
            }
        }
        else
        {
            Console.WriteLine("You gave me that number before. Give me a new one");
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
    if (LinearSearch(target_array,randomNumber,i) == -1)
    {
        target_array[i] = randomNumber;
    }    
}

//create print function
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.WriteLine(array[i]);
}   


// Linear Search to search if the number has previously been provided
int LinearSearch(int[] array, int valuetoSearch, int validLength)
{
    for (int i = 0; i < validLength; i++)
        if (array[i] == valuetoSearch)
        {
            return i;
        }
    return -1;
}


// BinarySearch to check the array for win conditions

Array.Sort(user_guess_array);
Array.Sort(target_array);
int BinarySearch(int[] array, int valuetoSearch,int low, int high)
{
    if (high >= low)
    {
        int mid = (high + low) / 2;
        if (array[mid] == valuetoSearch) return mid;
        if (array[mid] > valuetoSearch) return BinarySearch(array, valuetoSearch, low, mid - 1);

            return BinarySearch(array, valuetoSearch, mid +1, high );
    }
    return -1;
}

int CountCorrectGuesses(int [] array)
{
    int correct_guess = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] != -1)
        {
            correct_guess++;
        }
    return correct_guess;
}


//Console.WriteLine(LinearSearch(user_guess, 4));

// Creates new array to store index of correct guess
for (int i = 0; i < number_of_values; i++)
    //BinarySearch(target_array, user_guess[i], 0 , number_of_values);
    correct_guesses_array[i] = BinarySearch([3,5,6,8,9], user_guess_array[i], 0 , number_of_values);

Console.WriteLine("number of gueses");
Console.WriteLine(CountCorrectGuesses(correct_guesses_array)); 


Console.WriteLine("----");

Console.WriteLine("target array");
PrintArray(target_array);
Console.WriteLine("user guess");
PrintArray(user_guess_array);

