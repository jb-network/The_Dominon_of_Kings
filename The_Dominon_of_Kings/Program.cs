// This is challenge work for the "C# Players Guide"
// Level 7 The Dominion of Kings Challege

Console.WriteLine("Welcome to the Kingdom Calculator!");

//Estates, point value 1
Console.WriteLine("Enter the number of estates that you own: ");
int estate = Convert.ToInt32(Console.ReadLine());

//Duchies, point value 3
Console.WriteLine("Enter the number of Duchies that you own: ");
int duchy = Convert.ToInt32(Console.ReadLine());

//Province, point value 6
Console.WriteLine("Enter the number of provinces that you own: ");
int province = Convert.ToInt32(Console.ReadLine());

//convert number to point value. Estates do not need to be converted
duchy *= 3;
province *= 6;

//Get total points for all items listed by player and present score
int totalPoints = estate + duchy + province;
Console.WriteLine("Your total kingdom score is: {0}", totalPoints);

