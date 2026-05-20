using ProjectCar.Drawnings;

namespace ProjectCar;

/// <summary>
/// Полотно
/// </summary>
public class CanvasForCar
{
    private DrawningCar? _drawningCar;

    private readonly int _canvasWidth;

    private readonly int _canvasHeight;

    /// <summary>
    /// Текущий прорисовываемый объект
    /// </summary>
    public DrawningCar? DrawningCar => _drawningCar;

    /// <summary>
    /// Конструктор полотна
    /// </summary>
    public CanvasForCar(int width, int height)
    {
        _canvasWidth = width;
        _canvasHeight = height;
    }

    public bool InsertCar(DrawningCar car)
    {
        if (car.DrawningCarWidth > _canvasWidth || car.DrawningCarHeight > _canvasHeight)
        {
            return false;
        }

        _drawningCar = car;
        return true;
    }

    public void SetCarPosition(int x, int y)
    {
        if (_drawningCar is null)
        {
            return;
        }

        if (x < 0)
        {
            x = 0;
        }

        if (y < 0)
        {
            y = 0;
        }

        if (x + _drawningCar.DrawningCarWidth > _canvasWidth)
        {
            x = _canvasWidth - _drawningCar.DrawningCarWidth;
        }

        if (y + _drawningCar.DrawningCarHeight > _canvasHeight)
        {
            y = _canvasHeight - _drawningCar.DrawningCarHeight;
        }

        _drawningCar.SetPosition(x, y);
    }

    public bool MoveTransport(DirectionType direction)
    {
        if (_drawningCar is null ||
            !_drawningCar.PosX.HasValue ||
            !_drawningCar.PosY.HasValue ||
            !_drawningCar.CarStep.HasValue)
        {
            return false;
        }

        switch (direction)
        {
            case DirectionType.Left:
                if (_drawningCar.PosX.Value - _drawningCar.CarStep.Value >= 0)
                {
                    _drawningCar.MoveLeft();
                    return true;
                }

                break;

            case DirectionType.Up:
                if (_drawningCar.PosY.Value - _drawningCar.CarStep.Value >= 0)
                {
                    _drawningCar.MoveUp();
                    return true;
                }

                break;

            case DirectionType.Right:
                if (_drawningCar.PosX.Value + _drawningCar.DrawningCarWidth + _drawningCar.CarStep.Value <= _canvasWidth)
                {
                    _drawningCar.MoveRight();
                    return true;
                }

                break;

            case DirectionType.Down:
                if (_drawningCar.PosY.Value + _drawningCar.DrawningCarHeight + _drawningCar.CarStep.Value <= _canvasHeight)
                {
                    _drawningCar.MoveDown();
                    return true;
                }

                break;
        }

        return false;
    }

    public Bitmap DrawCanvas()
    {
        Bitmap bmp = new(_canvasWidth, _canvasHeight);

        using Graphics graphics = Graphics.FromImage(bmp);
        _drawningCar?.DrawTransport(graphics);

        return bmp;
    }
}