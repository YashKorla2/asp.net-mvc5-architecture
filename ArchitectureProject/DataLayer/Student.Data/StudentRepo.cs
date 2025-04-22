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
    public class StudentRepo : Repository<global::DB.Core.Student>, IStudentRepo
    {
        static StudentRepo()
        {
            string assemblyPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DB.Core.dll");
            Assembly assembly = Assembly.LoadFrom(assemblyPath);
            AppDomain.CurrentDomain.Load(assembly.GetName());

            Type studentType = assembly.GetType("DB.Core.Student");
            if (studentType == null)
            {
                throw new TypeLoadException("Unable to load type 'DB.Core.Student' from assembly 'DB.Core'.");
            }
        }

        public StudentRepo(DbContext context) : base(context)
        {
        }
    }
}