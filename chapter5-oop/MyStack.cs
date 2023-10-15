namespace chapter5_oop;

internal interface IMyStack<T>
{
    int Count { get; }
    void Push(T item);
    T Pop();
    T Peek();
}

public class MyStack<T>: IMyStack<T>
{
    public int Count { get; private set; }
    private T[] _items;

    public MyStack()
    {
        _items = new T[4];
    }

    public MyStack(uint capacity)
    {
        _items = new T[capacity];
    }

    public void Push(T item)
    {
        if (Count == _items.Length)
        {
            var newStack = new T[_items.Length * 2];
            _items.CopyTo(newStack, 0);
            _items = newStack;
        }
        _items[Count++] = item;
    }

    public T Pop()
    {
        if (Count == 0) throw new InvalidOperationException("Stack is empty");
        
        return _items[--Count];
    }

    public T Peek()
    {
        if (Count == 0) throw new InvalidOperationException("Stack is empty");
        
        return _items[Count - 1];
    }
}