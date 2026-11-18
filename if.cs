/*Console.Write("Enter your age: ");

int age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Your age is: " + age);

if(age >= 18)
{
    Console.WriteLine("You are eligible to vote");
}
else if(age >= 13 && age < 18)
{
    Console.WriteLine("You are a teenager");
}
else
{
    Console.WriteLine("You are very young");
}
*/

Console.WriteLine("Enter the Time in 24 hour clock format: ");

int time = Convert.ToInt32(Console.ReadLine());

string result = (time > 1800) ? "Good Evening" : "Good Morning";

Console.WriteLine(result);