namespace ProjectCar;

/// <summary>
/// Класс, отвечающий за прорисовку и перемещение объекта-сущности
/// </summary>
public class DrawningCar
{
    /// <summary>
    /// Класс-сущность
    /// </summary>
    protected EntityCar? _entityCar;

    /// <summary>
    /// Левая координата прорисовки
    /// </summary>
    protected int? _startPosX;

    /// <summary>
    /// Верхняя координата прорисовки
    /// </summary>
    protected int? _startPosY;

    /// <summary>
    /// Ширина прорисовки грузовика
    /// </summary>
    private readonly int _drawningCarWidth = 150;

    /// <summary>
    /// Высота прорисовки грузовика
    /// </summary>
    private readonly int _drawningCarHeight = 90;

    public int? PosX => _startPosX;

    public int? PosY => _startPosY;

    public double? CarStep => _entityCar?.Step;

    public int DrawningCarWidth => _drawningCarWidth;

    public int DrawningCarHeight => _drawningCarHeight;

    /// <summary>
    /// Закрытый конструктор для общей инициализации
    /// </summary>
    private DrawningCar()
    {
        _startPosX = null;
        _startPosY = null;
    }

    /// <summary>
    /// Конструктор простого грузовика
    /// </summary>
    public DrawningCar(int speed, double weight, Color bodyColor) : this()
    {
        _entityCar = new EntityCar(speed, weight, bodyColor);
    }

    /// <summary>
    /// Конструктор для наследников, чтобы менять размеры объекта
    /// </summary>
    protected DrawningCar(int carWidth, int carHeight) : this()
    {
        _drawningCarWidth = carWidth;
        _drawningCarHeight = carHeight;
    }

    public void SetPosition(int x, int y)
    {
        _startPosX = x;
        _startPosY = y;
    }

    public void MoveLeft()
    {
        if (_entityCar is null || !_startPosX.HasValue)
        {
            return;
        }

        _startPosX -= (int)_entityCar.Step;
    }

    public void MoveRight()
    {
        if (_entityCar is null || !_startPosX.HasValue)
        {
            return;
        }

        _startPosX += (int)_entityCar.Step;
    }

    public void MoveUp()
    {
        if (_entityCar is null || !_startPosY.HasValue)
        {
            return;
        }

        _startPosY -= (int)_entityCar.Step;
    }

    public void MoveDown()
    {
        if (_entityCar is null || !_startPosY.HasValue)
        {
            return;
        }

        _startPosY += (int)_entityCar.Step;
    }

    /// <summary>
    /// Прорисовка простого грузовика
    /// </summary>
    public virtual void DrawTransport(Graphics g)
    {
        if (_entityCar is null || !_startPosX.HasValue || !_startPosY.HasValue)
        {
            return;
        }

        using Pen pen = new(Color.Black);
        using SolidBrush bodyBrush = new(_entityCar.BodyColor);
        using SolidBrush wheelBrush = new(Color.Black);

        // кузов / платформа грузовика
        g.FillRectangle(bodyBrush, _startPosX.Value, _startPosY.Value + 43, 150, 16);
        g.DrawRectangle(pen, _startPosX.Value, _startPosY.Value + 43, 150, 16);

        // кабина грузовика слева
        g.FillRectangle(bodyBrush, _startPosX.Value, _startPosY.Value, 39, 39);
        g.DrawRectangle(pen, _startPosX.Value, _startPosY.Value, 39, 39);

        // колеса
        g.FillEllipse(wheelBrush, _startPosX.Value, _startPosY.Value + 55, 33, 33);
        g.FillEllipse(wheelBrush, _startPosX.Value + 75, _startPosY.Value + 55, 33, 33);
        g.FillEllipse(wheelBrush, _startPosX.Value + 110, _startPosY.Value + 55, 33, 33);
    }
}