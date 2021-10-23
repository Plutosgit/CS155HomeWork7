using System;
using System.Collections.Generic;
using System.Text;

namespace CS155HomeWork7
{
    class Counter
    {
        private int count;

        public Counter()
        {
            Console.WriteLine("Default constructor called..");
            count = 0;
        }

        public Counter(int start)
        {
            Console.WriteLine("User constructor called..");
            if (start >= 0)
            { 
                count = start;
            }
            else
            { 
                Console.WriteLine("\tCounters can be created only with non-negative integers! \n\tUser tried to create with " + start.ToString() + ". Setting count to 0!");
                count = 0;
            }
        }

        public int Count { get => count; } //return count; }  
        //public int Count { get => count; set => count = value; } //  was removed since problem statement says "There shoud be no input method or other setter methods. The only method that can set the counter is the one that sets it to 0."
        
        public void SetCounterToZero()
        {
            count = 0;
        }

        public void IncreaseByOne()
        {
            count++;
        }

        public void DecreaseByOne()
        {
            
            if (count > 0)  //This will ensure count is either 0 or > 0.
                count--;

        }

        public void ShowCount()
        {
            Console.WriteLine("Current count is: " + count);
        }

        public String toString()
        {
            return count.ToString();
        }

        public Boolean equals(Counter c)
        {
            if (this.count == c.count)
                return true;
            else
                return false;
            
        }
    }
}
