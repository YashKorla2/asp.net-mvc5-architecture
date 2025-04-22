using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using DataLayer.GenericRepository;
using DB.Core;

[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("DB.Core")]

namespace DataLayer.Student.Data
{
    public class StudentRepo : Repository<DB.Core.Student>, IStudentRepo
    {
        static StudentRepo()
        {
            Assembly.LoadFrom(@"..\DB.Core\bin\Debug\DB.Core.dll");
        }

        public StudentRepo(DbContext context) : base(context)
        {
        }
    }
}