using System;

namespace CodingExercise6_Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
                Phone one = new Phone();
                Phone two = new Phone("Apple", "IPhone 12");
                Phone three = new Phone("Apple", "IPhone 12", "September 24, 2021");

                one.Introduce();
                two.Introduce();
                three.Introduce();
        

        }
    }
}
