//реализация своего enumerable, но надо знать для чего он нужен
namespace ListStudents
{
    public interface IMyEnumerable
    {
        IMyIterator GetEnumerator(); //IEnumerable - это интерфейс, который определяет один метод GetEnumerator, 
        //который возвращает интерфейс IEnumerator , который, в свою очередь, разрешает доступ к коллекции только для чтения.
    }
}
