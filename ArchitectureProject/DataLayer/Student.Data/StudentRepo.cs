using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.GenericRepository;

// Create a local namespace to stand in for the missing DB.Core
namespace DB.Core
{
    // Create a placeholder Student class
    public class Student
    {
        // Add essential properties as needed
    }
}

namespace DataLayer.Student.Data
{
    public class StudentRepo : Repository<DB.Core.Student>, IStudentRepo
    {
        public StudentRepo(ArchitectureEntities context) : base(context)
        {
        }
    }
}