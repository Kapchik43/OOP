namespace ProjectCar;

/// <summary>
/// Адаптер между DrawningCar и IMoveableObject
/// </summary>
public class MoveableAdapterCar : IMoveableObject
{
    private readonly DrawningCar _car;

    public MoveableAdapterCar(DrawningCar car)
    {
        _car = car;
    }

    public ObjectCoordinates? ObjectCoordinates
    {
        get
        {
            if (!_car.PosX.HasValue || !_car.PosY.HasValue)
            {
                return null;
            }

            return new ObjectCoordinates(
                _car.PosX.Value,
                _car.PosY.Value,
                _car.DrawningCarWidth,
                _car.DrawningCarHeight);
        }
    }

    public int ObjectStep => Math.Max(1, (int)(_car.CarStep ?? 1));

    public void SetObjectPosition(int x, int y) => _car.SetPosition(x, y);

    public void MoveObject(MovementDirection direction)
    {
        switch (direction)
        {
            case MovementDirection.Left:
                _car.MoveLeft();
                break;

            case MovementDirection.Up:
                _car.MoveUp();
                break;

            case MovementDirection.Right:
                _car.MoveRight();
                break;

            case MovementDirection.Down:
                _car.MoveDown();
                break;
        }
    }

    public void DrawObject(Graphics graphics) => _car.DrawTransport(graphics);
}