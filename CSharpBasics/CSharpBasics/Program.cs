using System;

namespace CSharpBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //////*********1
            //Console.Write("Enter number : ");
            //int number = int.Parse(Console.ReadLine());
            //Console.WriteLine("number is :" + number);
            //////*********2
            //string stringNumber = "123A";
            //int result;
            //bool isIntger =  int.TryParse(stringNumber, out result);
            //if (isIntger) 
            //{
            //    Console.WriteLine("Number is integer : " + result);
            //}
            //else 
            //{ 
            //    Console.WriteLine("contains non-numeric characters " + stringNumber); 
            //}
            //////************3
            //float num1 = 15.5f;
            //float num2 = 15.6f;
            //float result = num1 + num2;
            //Console.WriteLine(result);
            //////************4
            //string s = "mohamedahmed";
            //string sub = s.Substring(0, 7);
            //Console.WriteLine(sub);
            //////***********5
            //int v1 = 5;
            //int v2;
            //v2 = v1;
            //Console.WriteLine("Before v1 {0} && v2 {1}", v1, v2);
            //v1 = 10;
            //Console.WriteLine("After v1 {0} && v2 {1}",v1,v2);
            //// each variable has reserved place in memory and v2 value not change when v1 change
            //////****************6
            //obj a = new obj();
            //a.x = 5;
            //obj b = new obj();
            //b = a;
            //Console.WriteLine("A = {0}, B = {1}", a.x, b.x);
            //a.x = 15;
            //Console.WriteLine("A = {0}, B = {1}", a.x, b.x);
            //// a and b are references assignment the address of object palce in memeory and when assigment ref b to ref a then ref b have the same address in ref a
            //////***********7
            //string a = "ahmed";
            //string b = "Mohamed";
            //string concat = a + " " + b;
            //Console.WriteLine(concat);
            //////**********8
            //Console.WriteLine("enter amount to calculate interest");
            //double amount = double.Parse(Console.ReadLine());
            //Console.WriteLine("enter rate per year");
            //double rate = double.Parse(Console.ReadLine());
            //Console.WriteLine("enter time in years");
            //int time = int.Parse(Console.ReadLine());
            //double interest = (amount * rate * time) / 100;
            //Console.WriteLine("Interest is  : {0}" , interest);
            //////***********9
            //Console.WriteLine("Enter your weight in Kg : ");
            //double weight = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter hour height in meters : ");
            //double height = double.Parse(Console.ReadLine())/100;
            //double BMI = (weight) / (height * height);
            //Console.WriteLine("BMI is {0}", BMI);
            ////*************10
            //Console.WriteLine("enter degree : ");
            //int degree = int.Parse(Console.ReadLine());
            //string result = degree < 10 ? "Just Cold" : degree > 30 ? "Juse hot" : "Just Good";
            //Console.WriteLine(result);
            ////12********************
            //DateTime date = new DateTime(2024, 6, 14); Console.WriteLine($"The event is on {date:MM/dd/yyyy}");
            //// ouput: The event is on 06/14/2024
            ///////13********************
            //int d;
            //d = Convert.ToInt32(!(30 < 20));
            //Console.WriteLine(d);
            //// A value 1 will bt assigned to d
            /////14*****************
            //Console.WriteLine(13 / 2 + " " + 13 % 2); 
            /////output 6 1
            /////15
            //int num = 1, z = 5;
            //if (!(num <= 0))
            //    Console.WriteLine(++num + z++ + " " + ++z); // => this will execute
            //else
            //    Console.WriteLine(--num + z-- + " " + --z);

            ////output: 7 7 

        }


        class obj
        {
            public int x { get; set; }
        }
    }
}