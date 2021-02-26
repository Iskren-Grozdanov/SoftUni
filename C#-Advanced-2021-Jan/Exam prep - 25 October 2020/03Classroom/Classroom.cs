using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassroomProject
{
    class Classroom
    {
        private List<Student> students;

        public Classroom(int capacity)
        {
            Capacity = capacity;
            students = new List<Student>();
        }
        public int Capacity { get; set; }
        public int Count { get { return students.Count; } }

        public string RegisterStudent(Student student)
        {
            if (students.Count < Capacity)
            {
                students.Add(student);
                return $"Added student {student.FirstName} {student.LastName}";
            }
            else
            {
                return "No seats in the classroom";
            }
        }

        public string DismissStudent(string firstName, string lastName)
        {
            Student student = students.FirstOrDefault(s => s.FirstName == firstName && s.LastName == lastName);

            if (student == null)
            {
                return "Student not found";
            }
            else
            {
                return $"Dismissed student {student.FirstName} {student.LastName}";
            }
        }

        public string GetSubjectInfo(string subject)
        {
            Student student = students.FirstOrDefault(x => x.Subject == subject);
            var sb = new StringBuilder();

            if (students.Contains(student))
            {
                sb.AppendLine($"Subject: {subject}");
                sb.AppendLine("Students:");
                foreach (var item in students.Where(x => x.Subject == subject))
                {
                    sb.AppendLine($"{item.FirstName} {item.LastName}");
                }
            }
            else
            {
                sb.AppendLine("No students enrolled for the subject");
            }

            return sb.ToString();
        }

        public int GetStudentsCount()
        {
            return students.Count;
        }

        public Student GetStudent(string firstName, string lastName)
        {
            Student student = students.FirstOrDefault(s => s.FirstName == firstName && s.LastName == lastName);

            return student;
        }


    }
}
