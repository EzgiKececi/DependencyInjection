using DependencyInjection.Entities;

namespace DependencyInjection.Models
{
    public class Classroom
    {
        private readonly ITeacher _teacher;

        public Classroom(ITeacher teacher)
        {
            _teacher = teacher;
        }

        public string GetTeacherInfo()
        {
            return _teacher.GetInfo();
        }


    }
}
