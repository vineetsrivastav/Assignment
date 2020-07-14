using System;
using System.Collections.Generic;


namespace Assignment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Promotion> promotions = new List<Promotion>();

            Console.WriteLine("Please enter total number of order");

            int totalorders = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < totalorders; i++)
            {
                Console.WriteLine("Please enter the type of product:A,B,C or D");
                string type = Console.ReadLine();
                Promotion p = new Promotion(type);
                promotions.Add(p);
            }

            int totalPrice = GetTotalPrice(promotions);
            Console.WriteLine(totalPrice);
            Console.ReadLine();

        }

        public static int GetTotalPrice(List<Promotion> promotions)
        {
            int counterofA = 0;
            int priceofA = 50;
            int counterofB = 0;
            int priceofB = 30;
            int CounterofC = 0;
            int priceofC = 20;
            int CounterofD = 0;
            int priceofD = 15;
            foreach (Promotion pr in promotions)
            {
                if (pr.Id == "A" || pr.Id == "a")
                {
                    counterofA = counterofA + 1;
                }
                if (pr.Id == "B" || pr.Id == "b")
                {
                    counterofB = counterofB + 1;
                }
                if (pr.Id == "C" || pr.Id == "c")
                {
                    CounterofC = CounterofC + 1;
                }
                if (pr.Id == "D" || pr.Id == "d")
                {
                    CounterofD = CounterofD + 1;
                }
            }
            int promopriceofA = (counterofA / 3) * 130 + (counterofA % 3 * priceofA);
            int promopriceofB = (counterofB / 2) * 45 + (counterofB % 2 * priceofB);
            int promopriceofC = (CounterofC * priceofC);
            int promopriceofD = (CounterofD * priceofD);
            return promopriceofA + promopriceofB + promopriceofC + promopriceofD;

        }
    }
    public class Promotion
    {

        public string Id { get; set; }
        public decimal Price { get; set; }


        public Promotion(string id)
        {
            this.Id = id;
            switch (id)
            {
                case "A":
                    this.Price = 50m;

                    break;
                case "B":
                    this.Price = 30m;

                    break;
                case "C":
                    this.Price = 20m;

                    break;
                case "D":
                    this.Price = 15m;
                    break;
            }
        }

    }
}
