using IAUFinal.BLL.Models;
using IAUFinal.Data;

using System;

namespace IAUFinal.BLL 
{
   

   public class Service:IService
    {

        private readonly ApplicationDbContext _db;
        public Service(ApplicationDbContext db)
        {
            _db = db;
        }
        void IService.AddStudent(string name, string family)
        {
          var  Student = new Student
            {
                name = name,
                family = family
            };
            _db.Add(Student);
            _db.SaveChanges();

        }
    }
}
