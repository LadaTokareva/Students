//описание интерфейса итератора, то есть набор функций которые должен описать итератор (это что то типо абстрактного класса)
using System.Collections;

namespace ListStudents
{
    public interface IMyIterator : IEnumerator
    {
        int Position { get; }
        bool MovePrev();
        bool MoveEnd();
        bool MoveFirst();
        bool IsFirst();
        bool IsLast();
    }
}
