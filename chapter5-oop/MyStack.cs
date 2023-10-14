namespace chapter5_oop;

interface IMyStack
{
    int Count { get; }
    void Push(object item);
    object Pop();
    object Peek();
}

public class MyStack: IMyStack
{
    public int Count { get; private set; } = 0;
    private object[] _stack = new object[4];

    public void Push(object item)
    {
        if (Count == _stack.Length)
        {
            var newLength = _stack.Length * 2;
            var newStack = new object[newLength];
            _stack.CopyTo(newStack, 0);
            _stack = newStack;
        }
        
        _stack[Count++] = item;
    }

    public object Pop()
    {
        if (Count == 0) throw new InvalidOperationException("Stack is empty");
        return _stack[--Count];
    }

    public object Peek()
    {
        if (Count == 0) throw new InvalidOperationException("Stack is empty");
        return _stack[Count - 1];
    }
}