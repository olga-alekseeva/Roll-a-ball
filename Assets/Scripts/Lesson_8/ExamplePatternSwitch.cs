using System;
using UnityEngine;

namespace Lesson_8
{
    internal sealed class ExamplePatternSwitch
    {
        private enum Rainbow
        {
            None   = 0,
            Red    = 1,
            Orange = 2,
            Yellow = 3,
            Green  = 4,
            Blue   = 5,
            Indigo = 6,
            Violet = 7
        }
        
        private void Main()
        {
            Debug.Log(Select(Rainbow.Blue));
        }
        
        private string Select(Rainbow rainbow)
        {
            switch (rainbow)
            {
                case Rainbow.Red: return "Red";
                case Rainbow.Orange: return "Orange";
                case Rainbow.Yellow: return "Yellow";
                case Rainbow.Green: return "Green";
                case Rainbow.Blue: return "Blue";
                case Rainbow.Indigo: return "Indigo";
                case Rainbow.Violet: return "Violet";
                default: throw new ArgumentException("Нет такого цвета");
            }
        }
        
        private string Select8(Rainbow rainbow)
        {
            return rainbow switch
            {
                Rainbow.Red => "Red",
                Rainbow.Orange => "Orange",
                Rainbow.Yellow => "Yellow",
                Rainbow.Green => "Green",
                Rainbow.Blue => "Blue",
                Rainbow.Indigo => "Indigo",
                Rainbow.Violet => "Violet",
                _ => throw new ArgumentException("Нет такого цвета")
            };
        }


        #region MyRegion
        
        private sealed class Student
        {
            public string Name { get; set; }
            public string EducationalInstitution { get; set; }
            public string AcademicPerformance { get; set; }
        }

        private string Select8(Student student)
        {
            if (student is { Name: "roman" })
            {
                
            }
            if (student is { })
            {
                
            }
            return student switch
            {
                { EducationalInstitution: "Institute", AcademicPerformance: "Excellent" } => "Здравствуйте",
                { EducationalInstitution: "College" } => "Привет!",
                { EducationalInstitution: "School" } => "Здоров",
                { } => "Hello world!",
                _ => "Not Found"
            };
        }

        #endregion


        #region MyRegion

        private enum Gender
        {
            None      = 0,
            Male      = 1,
            Female    = 2,
            Indefined = 3
        }

        private string Select8(Gender gender, int age)
        {
            return (gender, age) switch
            {
                (Gender.Female, 14) => "Девочка",
                (Gender.Female, 18) => "Девушка",
                (Gender.Female, 30) => "Женщина",
                (Gender.Female, 70) => "Бабушка",
                _ => "Не понятно"
            };
        }

        #endregion
  
        
        #region MyRegion

        private sealed class People

        {
            public string Name { get; set; }
            public Gender Gender { get; set; }
            public int Age { get; set; }

            public void Deconstruct(out string name, out Gender gender, out int age)
            {
                name = Name;
                gender = Gender;
                age = Age;
            }
        }

        private string Select8(People people)
        {
            return people switch
            {
                ("Lera", Gender.Female, 18) => "Female",
                ("Roman", Gender.Male, _) => "Male",
                ("Ilya", Gender.Indefined, _) => "Dean",
                (_, _, 17) => "Minor",
                (_, Gender.Indefined, _) => "Indefined",
                _ => "Not recognized"
            };
        }

        #endregion

    }
}
