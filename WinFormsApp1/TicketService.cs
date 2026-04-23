using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    internal class TicketService
    {
        public static string Calculate(string name, int age, double distance, string category, string gender)
        {
            if (age < 12)
                return $"{name} Total: Free (age under 12)";

            double ratePerKm = category switch
            {
                "Category One" => 20.0,
                "Category Two" => 35.0,
                "Category Three" => 50.0,
                _ => 0.0
            };

            if (ratePerKm <= 0)
                return "Select a valid category.";

            double baseFare = ratePerKm * distance;

            bool isFemale = gender.Equals("Female", StringComparison.OrdinalIgnoreCase);
            double discount = isFemale ? 0.5 : 0.0;

            double total = baseFare * (1 - discount);

            return $"{name} Base: {baseFare:C2} Discount: {discount * 100}% Total: {total:C2}";
        }
    }
}
