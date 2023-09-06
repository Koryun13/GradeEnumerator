using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeEnumerator
{
    public class ClassRoom
    {

        List<Student> students;

        public ClassRoom(List<Student> _students)
        {
            students = _students;
        }

        public IEnumerator GetEnumerator()
        {
            return new StudentEnumerator(students);
        }

    }
}
