using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceLayer.UnitOfWorkService;
using DbCore = DB.Core;

namespace ServiceLayer.StudentService
{
    public class StudentService : IStudentService
    {
        private IUnitOfWork _uow;
        public StudentService(IUnitOfWork uow)
        {
            _uow = uow;
        }
        public int AddStudent()
        {
            var s = new DbCore.Student();
// Access properties using the correct property names based on the Student class definition
            // For now, commenting out the property assignments that cause errors
            // s.Name = "Asad";  // This property doesn't exist in the current Student class
            s.Batch = "BS101";
            _uow.StudentRepo.Insert(s);
           var data = _uow.StudentRepo.GetById(1);
            // data.Name = "Omar";  // This property doesn't exist in the current Student class
            _uow.StudentRepo.Edit(data);
            _uow.Commit();
            return 0;
        }
    }
}