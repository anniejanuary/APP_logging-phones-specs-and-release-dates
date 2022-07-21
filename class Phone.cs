using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingExercise6_Constructors
{
    internal class Phone
    {
        public string Company;
        public string Model;
        public string ReleaseDay;

        // Place for your constructors
        public Phone()
        {
            this.Company = "unknown";
            this.Model = "unknown";
            this.ReleaseDay = "unknown";
        }

        public Phone(string Company, string Model)
        {
            this.Company = Company;
            this.Model = Model;
        }

        public Phone(string company, string model, string releaseDay)
        {
            this.Company = company;
            this.Model = model;
            this.ReleaseDay = releaseDay;
        }

        public void Introduce()
        {
            if (ReleaseDay == null)
            {
                Console.WriteLine($"Phone brand: {Company}. Model: {Model}.");
            }
            else
            {
                Console.WriteLine($"Phone brand: {Company}. Model: {Model}. Release day: {ReleaseDay}");
            }
        }

    }
}

