using System;
using System.Collections.Generic;
using System.Linq;

namespace MiniProjectMVC.Models
{
    // Simple in-memory "database" so the project runs with zero setup.
    // Swap this out for Entity Framework + SQL Server if you want persistence.
    public static class StudentRepository
    {
        private static List<Student> _students;
        private static int _nextId;

        static StudentRepository()
        {
            _students = new List<Student>
            {
                new Student { Id = 1, Name = "Aarav Shah",   Email = "aarav.shah@example.com",   Semester = 3, Course = "Computer Science", EnrollmentDate = new DateTime(2024, 7, 15) },
                new Student { Id = 2, Name = "Diya Patel",   Email = "diya.patel@example.com",    Semester = 5, Course = "Information Technology", EnrollmentDate = new DateTime(2023, 7, 10) },
                new Student { Id = 3, Name = "Kabir Mehta",  Email = "kabir.mehta@example.com",   Semester = 1, Course = "Electronics", EnrollmentDate = new DateTime(2025, 7, 20) }
            };
            _nextId = _students.Count + 1;
        }

        public static List<Student> GetAll()
        {
            return _students;
        }

        public static Student GetById(int id)
        {
            return _students.FirstOrDefault(s => s.Id == id);
        }

        public static Student Add(Student student)
        {
            student.Id = _nextId++;
            _students.Add(student);
            return student;
        }

        public static bool Update(Student student)
        {
            var existing = GetById(student.Id);
            if (existing == null) return false;

            existing.Name = student.Name;
            existing.Email = student.Email;
            existing.Semester = student.Semester;
            existing.Course = student.Course;
            existing.EnrollmentDate = student.EnrollmentDate;
            return true;
        }

        public static bool Delete(int id)
        {
            var existing = GetById(id);
            if (existing == null) return false;
            _students.Remove(existing);
            return true;
        }
    }
}
