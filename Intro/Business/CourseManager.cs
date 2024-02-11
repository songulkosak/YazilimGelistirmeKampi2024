using Intro.DataAccess.Concretes;
using Intro.Emtities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.Business
{
    public class CourseManager
    {

        public List<Course> GetAll()
        {
            //business rules
            CourseDal courseDal = new CourseDal();

            return courseDal.GetAll();
        }
    }
}
