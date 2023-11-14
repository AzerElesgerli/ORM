using CodeFirst.DAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    public class StudentService
    {

        private   AppDBContext _context;
        public List<Student> GetAll()
        {
            var students = _context.Students.ToList();
            return students;
        }
        public void   GETBYId(int id)
        { //Student verdikde return error verrir,ona gore void istifade eledim

            Student students = _context.Students.FirstOrDefault(x => x.Id == 1);
            Console.WriteLine($"Name: {students.Name} ,Surname: {students.Surname} ,AvgPoint: {students.AvgPoint}");

        }
        public void Create(Student student)
        {
            Student students = new Student
            {
                Name = "Azer",
                Surname = "Elesgerli"

            };
            _context.Students.Add(student);
            _context.SaveChanges();
        }


        public void UpdateSt(int id, string name, string surname, float Avgpoint)
        {
            Student UpdateST = _context.Students.Find(id);
            UpdateST.Name = name;
            UpdateST.Surname = surname;
            UpdateST.AvgPoint = Avgpoint;
            _context.Students.Update(UpdateST);
            _context.SaveChanges();

        }
        public void Delete(int id)
        {
            Student deleteSt=_context.Students.Find(id);

            if (deleteSt != null)
            {
                _context.Students.Remove(deleteSt);
                _context.SaveChanges();
            }
        }
    }
}