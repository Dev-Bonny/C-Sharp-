namespace system;

class Car
{
    string color;
    int SerialNo;
    string Classification;

    static void Main(string[] args)
    {
        Car Mercedes = new Car();
        Mercedes.color = "Black";
        Mercedes.SerialNo = 1234;
        Mercedes.Classification = "Sedan";


        Car Toyota = new Car();
        Toyota.color = "White";
        Toyota.SerialNo = 5678;
        Toyota.Classification = "SUV";


        Car BMW = new Car();
        BMW.color = "Blue";
        BMW.SerialNo = 9012;
        BMW.Classification = "Coupe";


        Console.WriteLine("Mercedes color is: " + Mercedes.color + ", Serial No: " + Mercedes.SerialNo + ", Classification: " + Mercedes.Classification);
        Console.WriteLine("Toyota color is: " + Toyota.color + ", Serial No: " + Toyota.SerialNo + ", Classification: " + Toyota.Classification);
        Console.WriteLine("BMW color is: " + BMW.color + ", Serial No: " + BMW.SerialNo + ", Classification: " + BMW.Classification);
    }

}