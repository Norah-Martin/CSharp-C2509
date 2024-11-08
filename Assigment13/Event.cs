using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment13
{
    public  class Event
    {

        //Create an event called OnCompleted in a class Process. Raise the event when a process is
        //completed.Subscribe to the event from the main program to display a message.

        public static int count;
        public event EventHandler OnCompleted;
        public void counter()
        {
            count++;
            if (count == 3)
            {
                OnCompleted?.Invoke(this, EventArgs.Empty);


            }
        }

        //8.Create a delegate called StringOperationDelegate that accepts a string parameter and returns a
        //string. Write three different methods that modify the string in different ways(e.g., convert to
        //uppercase, reverse, add a prefix). Use the delegate to call each method. 
        public string Uppercase(string str)
        {
            str = str.ToUpper();
            return str;
        }
        public string Lowercase(string str)
        {
            str = str.ToLower();
            return str;
        }
        public string Remove(string str)
        {
            str = str.Remove(2, 5);
            return str;
        }





    }
}
