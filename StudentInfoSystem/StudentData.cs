using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem_
{
    public class StudentData
    {
        private static List<Student> _testStudents = new List<Student>()
        {
            new Student()
            {
                Name = "Mira",
                Surname = "Nayef",
                Faculty = "FKST",
                Specialty = "KSI",
                Degree = "Bachelor",
                Status = "Certified",
                FacultyNumber = "12345",
                Year = 3,
                Potok = "A",
                Group = 46
            }
        };

        public static IReadOnlyList<Student> TestStudents => _testStudents.AsReadOnly();
    }
}
