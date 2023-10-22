using System.Collections;

namespace chapter5_oop;

internal interface IMyStack<T>: IEnumerable<T>
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

    // public IEnumerator<T> GetEnumerator()
    // {
    //     var copyArr = new T[Count];
    //     Array.Copy(_items, copyArr, Count);
    //     return new MyStackEnumerable<T>(copyArr);
    // }
    
    public IEnumerator<T> GetEnumerator()
    {
        for (int i = Count - 1; i >= 0; i--)
        {
            yield return _items[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

class MyStackEnumerable<T>: IEnumerator<T>
{
    private readonly T[] _items;
    private int _position;

    public MyStackEnumerable(T[] items)
    {
        _items = items;
        _position = items.Length - 1;
    }
    
    public T Current
    {
        get
        {
            return _items[_position];
        }
    }

    object IEnumerator.Current
    {
        get
        {
            return Current;
        }
    }

    public bool MoveNext()
    {
        return --_position >= 0;
    }

    public void Reset()
    {
        _position = _items.Length - 1;
    }

    public void Dispose()
    {
    }
}