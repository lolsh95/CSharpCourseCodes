﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringType
{
    class Program
    {
        static void Main(string[] args)
        {
            //\' \" \\ \0 \a \b \n \r \t \v \f
            //@

            string myString = "Nazar said This is a good cours, and I think";
            string myString2 = @" Yes it's";
            string myString3 = myString + myString2;

           
            Console.WriteLine("{0}", myString3);
            Console.ReadKey();

            /*

            Q1/ how can I use the character @ instead of the \ in this string to get same result
            
            "Nazar has said\"This is a unique course\", and I think so";

            Q2/ What is the purpose of these escape characters \t \v \f

               */

        /*  
  
 for more information visit
          http://www.youtube.com/c/AToZForLearning 
		  
Visit our channel page on facebook
          https://www.facebook.com/AToZForLearning/

If you have any question in English or Arabic welcome to our facebook group 
          https://www.facebook.com/groups/AToZForLearningProgramming/  
			  
		  
		  */}
    }
}
