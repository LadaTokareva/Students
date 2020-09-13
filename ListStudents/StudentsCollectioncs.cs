//реализация списка студентов
using System.Collections.Generic;

namespace ListStudents
{
    public class StudentsCollection : IMyEnumerable
    {
        public List<Student> students_list { get; private set; }

        private ConsistenlyOrder consistenlyOrder;

        public Student Current => (Student)GetEnumerator().Current;
        public StudentsCollection()
        {
            students_list = new List<Student>();
            consistenlyOrder = new ConsistenlyOrder(this);
        }
        public StudentsCollection(List<Student> students_list) : this()
        {
            this.students_list = students_list;
        }
        public void AddStudent(Student student)
        {
            students_list.Add(student);
        }

        public IMyIterator GetEnumerator()
        {
            return consistenlyOrder;
        }
    }
}
