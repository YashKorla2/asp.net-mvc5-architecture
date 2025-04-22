using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;
using DataLayer.GenericRepository;
using DB.Core;

namespace DataLayer.Student.Data
{
    public class StudentRepo : Repository<DB.Core.Student>, IStudentRepo
    {
        static StudentRepo()
        {
            string assemblyPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DB.Core.dll");
            if (File.Exists(assemblyPath))
            {
                Assembly assembly = Assembly.LoadFrom(assemblyPath);
                if (AppDomain.CurrentDomain.GetAssemblies().All(a => a.FullName != assembly.FullName))
                {
                    AppDomain.CurrentDomain.Load(assembly.GetName());
                }
            }
            else
            {
                throw new FileNotFoundException($"DB.Core.dll not found at {assemblyPath}");
            }
        }

        public StudentRepo(DbContext context) : base(context)
        {
        }
    }
}