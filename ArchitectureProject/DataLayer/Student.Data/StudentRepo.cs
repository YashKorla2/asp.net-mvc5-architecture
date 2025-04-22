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
        DBCoreLoader.EnsureLoaded();
    }

        public StudentRepo(DbContext context) : base(context)
        {
        }
    }
}

// Ensure DB.Core types are loaded
static class DBCoreLoader
{
    static DBCoreLoader()
    {
        var assembly = AppDomain.CurrentDomain.GetAssemblies().FirstOrDefault(a => a.GetName().Name == "DB.Core");
        if (assembly == null)
        {
            string assemblyPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DB.Core.dll");
            if (File.Exists(assemblyPath))
            {
                Assembly.LoadFrom(assemblyPath);
            }
            else
            {
                throw new FileNotFoundException($"DB.Core.dll not found at {assemblyPath}");
            }
        }
    }

    public static void EnsureLoaded()
    {
        // This method is intentionally empty.
        // The static constructor will be called when this method is first accessed.
    }
}