using System;
using System.Collections.Generic;   //this lets you use object in the list/boxdata

namespace boxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an empty list of type <object>
            List<object>boxData = new List<object>();
            //add the following values to the list [7, 28, -1, true, "chair"]
            boxData.Add(7);
            boxData.Add(28);
            boxData.Add(-1);
            boxData.Add(true);
            boxData.Add("chair");
            
            int sum =0;
            //need to count the objects so set int sum to equal 0, now loop through each item in the list and set variable x for item.
            foreach(var x in boxData){
                //foreach goes through the boxdata and parses it for data type.
                if(x is int){
                    int IsInt =(int)x;
                    sum += IsInt;
                }
                Console.WriteLine(x);//each line of boxData will get printed
            }
            Console.WriteLine("sum:"+sum);//this will add the int values and provide a response, it is set to add all values and there is a negative value but it will do the math for me.
        }
    }
}
