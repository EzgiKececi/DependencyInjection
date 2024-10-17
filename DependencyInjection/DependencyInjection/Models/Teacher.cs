using System.Globalization;

namespace DependencyInjection.Entities
{
    public class Teacher : ITeacher
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string GetInfo()
        {
            return FirstName + " " + LastName;  
        }

        
    }
}
