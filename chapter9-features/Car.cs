namespace chapter9_features;

internal class Car
{
    public event ToHighSpeed? ToHighSpeedDriving;
    public delegate void ToHighSpeed(int speed);

    private int _speed = 0;

    public void IncreaseSpeed()
    {
        _speed += 30;
        if (_speed >= 100) ToHighSpeedDriving?.Invoke(_speed);
    }

    public void Stop()
    {
        _speed = 0;
    }
}
