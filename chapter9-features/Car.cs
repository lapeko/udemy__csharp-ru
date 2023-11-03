namespace chapter9_features;

internal class Car
{
    public delegate void ToHighSpeed(int speed);

    private ToHighSpeed? _toHighSpeedHandler;
    private int _speed = 0;

    public void IncreaseSpeed()
    {
        _speed += 30;
        if (_speed >= 100) _toHighSpeedHandler?.Invoke(_speed);
    }

    public void Stop()
    {
        _speed = 0;
    }

    public void RegisterHandlerOnToHighSpeed(ToHighSpeed toHighSpeed)
    {
        _toHighSpeedHandler += toHighSpeed;
    }
}
