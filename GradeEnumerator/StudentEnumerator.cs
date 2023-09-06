using System.Collections;

namespace GradeEnumerator
{
    internal class StudentEnumerator : IEnumerator
    {
        List<Student> students = new List<Student>();

        int Position = -1;

        public StudentEnumerator(List<Student> _students) 
        {
            foreach(Student student in _students) 
            {
               if(student.Grade >= 18)
                    students.Add(student);
            }            
        }
        public object Current 
        {
            get 
            {
                if (Position == -1)
                    throw new InvalidOperationException();
                if (Position >= students.Count)
                    throw new InvalidOperationException();
                return students[Position];
            }  
        }

        public bool MoveNext()
        {
            if (Position < students.Count - 1)
            {
                Position++;
                return true;
            }
            else { return false; }
        }

        public void Reset()
        {
            Position = -1;
        }

     
    }
}