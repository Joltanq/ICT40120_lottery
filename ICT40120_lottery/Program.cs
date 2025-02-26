int number_of_values = 2;
int[] user_guess = new int[number_of_values];
int[] target_array = new int[number_of_values];
int lowestValue = 0;
int highestValue = 10;

//This loop accepts the user's input
for (int i =0; i < number_of_values; i++)
{
    Console.WriteLine("Gimme number");
    user_guess[i] = int.Parse(Console.ReadLine());
}

Random rnd = new Random();

for (int i =0; i < number_of_values; i++)
{
    int randomNumber = rnd.Next(lowestValue, highestValue);
    target_array[i] = randomNumber;
}


foreach (int i in user_guess)
{
    Console.WriteLine(i);
}

Console.WriteLine("random array");
foreach (int i in target_array)
{
    Console.WriteLine(i);
}    
