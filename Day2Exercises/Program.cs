using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //These exercises cover Operators, Expressions and Conditionals
            //in C#. This is covered in the first week of We Can Code It part-time
            //training class. It covers chapters 5-8 in the C# Players Guide book.
            //The slides can be found under GitHub WCCI-PartTime / Course-Resources
            //

            //Jessica is 23 years old.
            //Sam is 47.
            //Jessica is younger than Sam.

            int jessicaAge = 23;
            int samAge = 47;
            Console.WriteLine(!(jessicaAge < samAge));
            Console.ReadKey();

            //Lisa is cooking muffins.
            //The recipe calls for 7 cups of sugar. 
            //She has already put in two cups.
            //How many cups does she need to put in?

            int cupsRequired = 7;
            int cupsAdded = 2;
            Console.WriteLine("Lisa needs to put in " + (cupsRequired - cupsAdded) +" more cups");
            Console.ReadKey();

            //At a restaurant, Mike and his three friends decided to 
            //divide the bill evenly. 
            //If each person paid $13, what was the total bill?

            int totalNumberInParty = 4;
            int totalEachPersonPaid = 13;
            Console.WriteLine("The total bill for Mike and his three friends is " + totalNumberInParty * totalEachPersonPaid);
            Console.ReadKey();

            //How many packages of diapers can you buy with $40 
            //if one package costs $8?

            int totalMoneyAvailableForDiapers = 40;
            int pricePerPackageOfDiapers = 8;
            Console.WriteLine("You can buy " + (totalMoneyAvailableForDiapers / pricePerPackageOfDiapers) + " packages of diapers with " + totalMoneyAvailableForDiapers + " dollars");
            Console.ReadKey();

            Console.WriteLine("What was your score?");
            int score = int.Parse(Console.ReadLine());
            Console.WriteLine("Your score was " + score);
            Console.ReadKey();

            //C# Exercises 06/29/16

            //Muffin Exercise
            //Lisa is cooking muffins.
            //Recipe calls for 7 cups of sugar.
            //She already has put in two cups. 
            //How many more cups does she need to put in? 

            int totalSugarNeededInCups = 7;
            int sugarAlreadyAddedToMixInCups = 2;
            Console.WriteLine(totalSugarNeededInCups - sugarAlreadyAddedToMixInCups);
            Console.ReadLine();

            //Mike and three friends split a bill evenly
            //Each person paid $13
            //What was the total bill?


            int totalEachPersonPaidyes = 13;
            int totalNumberInPartyyes = 4;
            Console.WriteLine(totalEachPersonPaidyes * totalNumberInPartyyes);
            Console.ReadLine();

            //How many packages of diapers can you buy with $40 if one package costs $8?

            int totalMoneyAvailable = 40;
            int pricePerPackage = 8;
            Console.WriteLine(totalMoneyAvailable / pricePerPackage);
            Console.ReadLine();

            //Last Friday Trevon had $29.
            //Over the weekend he received some money for cleaning the attic.
            //He now has $41. 
            //How much money did he receive?

            int totalMoneyAfterWeekend = 41;
            int totalMoneyBeforeWeekend = 29;
            Console.WriteLine(totalMoneyAfterWeekend - totalMoneyBeforeWeekend);
            Console.ReadLine();

            //Last week Julia ran 30 miles more than Pranav.
            //Julia ran 47 miles.
            //How many miles did Pranav run?


            int totalJuliaMiles = 47;
            int totalJuliaMoreThanPranav = 30;
            Console.WriteLine(totalJuliaMiles - totalJuliaMoreThanPranav);
            Console.ReadLine();



            //How many boxes of envelopes can you buy with $12 if one box costs $3?

            int totalMoneyAvailableEnvelopes = 12;
            int pricePerBox = 3;
            Console.WriteLine(totalMoneyAvailableEnvelopes / pricePerBox);
            Console.ReadLine();

            //After paying $5.12 for a salad, Norachai has $27.10.
            //How much money did he have before buying the salad?

            double totalMoneyAfterSalad = 27.10;
            double priceOfSalad = 5.12;
            Console.WriteLine(totalMoneyAfterSalad + priceOfSalad);
            Console.ReadLine();

            //331 students went on a field trip.
            //Six busses were filled and 7 students traveled in cars. 
            //How many students were in each bus?

            int totalStudentsOnFieldTrip = 331;
            int totalStudentsInCars = 7;
            int totalNumberOfBuses = 6;
            Console.WriteLine((totalStudentsOnFieldTrip - totalStudentsInCars) / totalNumberOfBuses);
            Console.ReadLine();

            //Aliyah had $24 to spend on seven pencils. 
            //After buying them she had $10. 
            //How much did each pencil cost?

            int totalMoneyAfterPencils = 10;
            int totalNumberOfPencils = 7;
            int totalMoneyBeforePencils = 24;
            Console.WriteLine((totalMoneyBeforePencils - totalMoneyAfterPencils) / totalNumberOfPencils);
            Console.ReadLine();

            //The sum of three consecutive numbers is 72.
            //What are the smallest of these numbers?

            int seventyTwoDividedByThree = 24;
            Console.WriteLine(seventyTwoDividedByThree--);
            Console.ReadLine();

            //The sum of three consecutive even numbers is 48.
            //What are the smallest of these numbers?

            int fourtyEightDividedByThree = 16;
            Console.WriteLine(fourtyEightDividedByThree - 2);
            Console.ReadLine();

            //Maria bought seven boxes. 
            //A week later half of all her boxes were destroyed in a fire. 
            //There are now only 22 boxes left. 
            //With how many did she start?

            int totalBoxesRemaining = 22;
            int totalBoxesPurchased = 7;
            Console.WriteLine((totalBoxesRemaining * 2) - totalBoxesPurchased);
            Console.ReadLine();



        }
    }
}
