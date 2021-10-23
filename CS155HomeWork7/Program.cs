using System;

namespace CS155HomeWork7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Homework 7 Classes in C#. Counters!");
            Console.WriteLine();

            Console.WriteLine("Testing starts..");
            Console.WriteLine("Result of trying to create a counter with a negative start count (-10)..");
            Counter negCounter = new Counter(-10);


            Console.WriteLine();
            Console.WriteLine("Creating 2 counters, A with default constructor & B with user constructor..");
            Counter aCounter = new Counter();
            Counter bCounter = new Counter(5);
            aCounter.ShowCount();
            bCounter.ShowCount();


            String sEquals;

            //Print count as we start..
            Console.WriteLine();
            Console.WriteLine("2 Counters as we start testing.. " + "Counter A: " + aCounter.Count.ToString() + " Counter B: " + bCounter.Count.ToString());

            //aCounter.Count = 5;   Cannot set count per problem statement that "the only method that can set the counter is the one that sets it to 0."

            sEquals = aCounter.equals(bCounter) ? "Yes" : "No";
            Console.WriteLine("Are these 2 Counters equal?      " + sEquals);

            Console.WriteLine();
            Console.WriteLine("Now, incrementing counter A by 10 and counter B by 5..");
            for (int i = 0; i < 10; i++)
            {
                aCounter.IncreaseByOne();               //Increment aCounter by 10
                if (i < 5) bCounter.IncreaseByOne();    //Increment bcounter by 5
            }
            Console.WriteLine("2 Counters after incrementing..  " + "Counter A: " + aCounter.Count.ToString() + " Counter B: " + bCounter.Count.ToString());

            sEquals = aCounter.equals(bCounter) ? "Yes" : "No";
            Console.WriteLine("Are these 2 Counters equal now?  " + sEquals);

            Console.WriteLine();
            Console.WriteLine("Now, decrementing both counters by 3..");
            for (int i = 0; i < 3; i++)
            {
                aCounter.DecreaseByOne();    //Decrement aCounter by 3
                bCounter.DecreaseByOne();    //Decrement aCounter by 3
            }
            Console.WriteLine("2 Counters after decrementing..  " + "Counter A: " + aCounter.Count.ToString() + " Counter B: " + bCounter.Count.ToString());


            Console.WriteLine();
            Console.WriteLine("Now, resetting counter A to 0..");
            aCounter.SetCounterToZero();
            Console.WriteLine("2 Counters after resetting A..   " + "Counter A: " + aCounter.Count.ToString() + " Counter B: " + bCounter.Count.ToString());

            Console.WriteLine();
            Console.WriteLine("Now, using ShowCount to display the counters A and B..");
            aCounter.ShowCount();
            bCounter.ShowCount();

            Console.WriteLine("\nEnd of testing counters!");

        }
    }
}
