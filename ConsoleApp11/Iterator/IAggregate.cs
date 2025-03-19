namespace ConsoleApp11.Iterator;

public interface IAggregate<T>
{
    IIterator<T> CreateIterator();
}
