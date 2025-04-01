namespace Lab2;

class Program
{
    static void Main(string[] args)
    {
        // Step 1 Variable Declarations   
           int coolnumber = 34;
           Console.WriteLine("a cool number is " + coolnumber);
           double cooldouble = 3.14D;
           Console.WriteLine("we simplify pi by using " + cooldouble);
           float coolfloater = 3.14F;
           Console.WriteLine(coolfloater + " is just easier to use"); 
           char coolcharacter = 'K';
           Console.WriteLine("My name starts with the letter " + coolcharacter);
           bool coolbool = false;
           Console.WriteLine("do i have any experience with coding? " + coolbool);
           string coolstring = "that is my ted talk";
           Console.WriteLine(coolstring);


        // Step 2 Type Casting
            double mydub = 9.78;
            int myint = (int) mydub;
            bool mybool = true;
            Console.WriteLine(mydub);
            Console.WriteLine(myint);
            Console.WriteLine(Convert.ToString(myint));
            Console.WriteLine(Convert.ToString(mybool));

        // Step 3 User input and type conversion
            Console.WriteLine("Enter username:");
            string userName = Console.ReadLine();
            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello " + userName +", you are " + age + " years old");

        // Step 4 Arithmetic Operators
           int num1 = 53;
           int num2 = 133;
           int addresult = num1 + 10;
           int subtractresult = num2 - 2;
           int multiplyresult = num1 * 3;
           int divisionresult = num2 / 2;
           int modulusresult = num1 % 2;
           Console.WriteLine("Addition: (num1 plus 10) = " + addresult );
           Console.WriteLine("Subtraction: (num2 minus 2) = " + subtractresult );
           Console.WriteLine("Multiply: (num1 times 3) = " + multiplyresult );
           Console.WriteLine("Division: (num2 divided by 10) = " + divisionresult );
           Console.WriteLine("Modulus: (num1 modulus 10) = " + modulusresult );

        // Step 5 Floating Point Precision
           float floatPrecision = 1.123456789F;
           double doubleprecison = 1.123456789D;
           Console.WriteLine(doubleprecison);
           Console.WriteLine(floatPrecision);
           // The float value was rounded up.
        
        // Step 6 Increment and Decrement
           int number = 10;
           Console.WriteLine("initial value" + number);
           number++;
           Console.WriteLine("After Increment: " + number);
           number--;
           Console.WriteLine("After Decrement: " + number);



           

            
    }   
}
