using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;
using DataLayer.GenericRepository;

namespace DataLayer.Student.Data
{
    public class StudentRepo : Repository<DB.Core.Student>, IStudentRepo
    {
        static StudentRepo()
        {
            string assemblyPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DB.Core.dll");
            Assembly.LoadFrom(assemblyPath);
        }

        public StudentRepo(DbContext context) : base(context)
        {
        }
    }
}