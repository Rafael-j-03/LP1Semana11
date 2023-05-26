using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    public class Program
    {
        private static void Main()
        {
            // Generate a random number
            Random random = new Random();

            // Generate a number between 1 and 100
            int targetNumber = random.Next(1, 101);


            // Create controller
            Controller controller = new Controller(targetNumber);

            // Create view
            IView view = new UglyView(controller);

            // Start program
            controller.Run(view);
        }
    }
}