using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserLogin;

namespace StudentInfoSystem_
{
    class StudentValidation
    {
        public static Student GetStudentDataByUser(User user)
        {
            if (user == null) throw new ArgumentNullException(nameof(user));

            string facultyNumber = user.FakNum;

            if (string.IsNullOrWhiteSpace(facultyNumber))
                throw new ArgumentException("Faculty number is missing.", nameof(user));

            var student = StudentData.TestStudents.FirstOrDefault(s => s.FacultyNumber == facultyNumber);

            if (student == null)
                throw new ArgumentException("No student found with the provided faculty number.", nameof(user));

            return student;
        }

    }
}
