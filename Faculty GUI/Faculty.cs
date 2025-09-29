using System;
using System.Collections.Generic;
using System.Linq;

namespace Faculty_GUI
{
    public class Faculty
    {
        public string Name { get; }
        public string Life { get; }
        public string Department { get; }
        public string Start { get; }
        public string End { get; }
        public string Title { get; }
        public decimal FeedbackScore { get; set; }

        public Faculty(string name, string life, string department, string start, string end, string title, decimal feedbackScore)
        {
            Name = name;
            Life = life;
            Department = department;
            Start = start;
            End = end;
            Title = title;
            FeedbackScore = feedbackScore;
        }

        public string GenerateKey()
        {
            string[] nameParts = Name.Split();
            return nameParts.Length > 1 ? nameParts.Last() : Name; // Safely get last name
        }

        public decimal CalculateSalary()
        {
            decimal baseSalary = 50000;
            decimal yearsOfServiceBonus = (DateTime.Now.Year - DateTime.Parse(Start).Year) * 1000;
            decimal feedbackBonus = FeedbackScore >= 4.5m ? 5000 :
                                    (FeedbackScore >= 3.5m ? 2500 : 0);

            return baseSalary + yearsOfServiceBonus + feedbackBonus;
        }

        public static List<Faculty> GetFaculties()
        {
            return new List<Faculty>
            {
                new Faculty("Dr. John Smith", "(1975-)", "Computer Science", "01 January 2010", "Present", "Professor", 4.8m),
                new Faculty("Dr. Emily Johnson", "(1980-)", "Electrical Engineering", "01 September 2015", "Present", "Associate Professor", 4.0m),
                new Faculty("Prof. James Brown", "(1965-)", "Mechanical Engineering", "01 June 2005", "01 June 2020", "Professor", 3.9m),
                new Faculty("Dr. Linda White", "(1970-)", "Mathematics", "01 January 2012", "Present", "Lecturer", 4.3m),
               // New faculty members
                new Faculty("Dr. Robert Green", "(1978-)", "Physics", "01 August 2013", "Present", "Professor", 4.6m),
                new Faculty("Dr. Sarah Miller", "(1982-)", "Biology", "01 March 2016", "Present", "Assistant Professor", 4.1m),
                new Faculty("Prof. Michael Adams", "(1960-)", "Chemistry", "01 May 1999", "01 May 2020", "Professor", 3.7m),
                new Faculty("Dr. Anna Garcia", "(1985-)", "Environmental Science", "01 November 2018", "Present", "Lecturer", 4.4m),
            };
        }
    }
}
