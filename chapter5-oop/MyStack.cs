namespace chapter5_oop;

internal interface IMyStack
{
    int Count { get; }
    void Push(object item);
    object Pop();
    object Peek();
}

public class MyStack: IMyStack
{
    public int Count { get; private set; }
    private object[] _items;

    public MyStack()
    {
        _items = new object[4];
    }

    public MyStack(uint capacity)
    {
        _items = new object[capacity];
    }

    public void Push(object item)
    {
        if (Count == _items.Length)
        {
            var newStack = new object[_items.Length * 2];
            _items.CopyTo(newStack, 0);
            _items = newStack;
        }
        _items[Count++] = item;
    }

    public object Pop()
    {
        if (Count == 0) throw new InvalidOperationException("Stack is empty");
        
        return _items[--Count];
    }

    public object Peek()
    {
        if (Count == 0) throw new InvalidOperationException("Stack is empty");
        
        return _items[Count - 1];
    }
}