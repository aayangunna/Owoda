using System;

namespace Owoda
{
    internal class OwoDaa
    {
        static void Main(string[] args)
        {

            var owoDa = new OwoDaa();
            double finalCollection = owoDa.OwoDa();

        }

        public double OwoDa()
        {
            double yourFee;
            double totalCollected = 0;
            double fee;

            for (int count = 1; count < 5; count++)
            {
                Console.WriteLine("Enter type of Vehicle:");
                Console.WriteLine("Motorcycle");
                Console.WriteLine("Tricycle");
                Console.WriteLine("MiniBus");
                Console.WriteLine("Bus");

                string vehicleType = Console.ReadLine();
                vehicleType = vehicleType.ToLower();



                switch (vehicleType)
                {
                    case "motorcycle":
                        fee = 50;
                        break;

                    case "tricycle":
                        fee = 100;
                        break;

                    case "minibus":
                        fee = 150;
                        break;

                    case "bus":
                        fee = 200;
                        break;

                    default:
                        fee = 250;
                        break;

                }


                Console.WriteLine("Are you a member");
                Console.WriteLine("True or False");
                string member = (Console.ReadLine());
                member = member.ToLower();

                if (member == "true")
                {
                    fee = fee * 0.7;
                }
                else
                {
                    fee = fee;
                }



                Console.WriteLine("Number of trips you've done:");
                int trips = int.Parse(Console.ReadLine());

                yourFee = fee * trips;
                Console.WriteLine("Your fee is " + yourFee + " naira after " + trips + "trips.");

                totalCollected += yourFee;

            }

            Console.WriteLine("Total Money Collected from 5 drivers:" + totalCollected + " naira.");

            return 0;
        }
    }


}
