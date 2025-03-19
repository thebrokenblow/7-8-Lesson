namespace ConsoleApp11.Iterator;

public interface IIterator<T>
{
    bool HasNext();
    T Next();
}