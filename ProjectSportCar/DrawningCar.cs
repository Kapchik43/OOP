namespace ProjectCar;

/// <summary>
/// Класс, отвечающий за прорисовку и перемещение объекта-сущности
/// </summary>
public class DrawningCar
{
	/// <summary>
	/// Класс-сущность
	/// </summary>
	private EntityCar? _entityCar;

	/// <summary>
	/// Левая координата прорисовки автомобиля
	/// </summary>
	private int? _startPosX;

	/// <summary>
	/// Верхняя координата прорисовки автомобиля
	/// </summary>
	private int? _startPosY;

	/// <summary>
	/// Ширина прорисовки автомобиля
	/// </summary>
	private readonly int _drawningCarWidth = 150;

	/// <summary>
	/// Высота прорисовки автомобиля
	/// </summary>
	private readonly int _drawningCarHeight = 90;

	/// <summary>
	/// Левая координата прорисовки автомобиля
	/// </summary>
	public int? PosX => _startPosX;

	/// <summary>
	/// Верхняя координата прорисовки автомобиля
	/// </summary>
	public int? PosY => _startPosY;

	/// <summary>
	/// Шаг перемещения
	/// </summary>
	public double? CarStep => _entityCar?.Step;

	/// <summary>
	/// Ширина прорисовки автомобиля
	/// </summary>
	public int DrawningCarWidth => _drawningCarWidth;

	/// <summary>
	/// Высота прорисовки автомобиля
	/// </summary>
	public int DrawningCarHeight => _drawningCarHeight;

	/// <summary>
	/// Инициализация свойств
	/// </summary>
	/// <param name="speed">Скорость</param>
	/// <param name="weight">Вес автомобиля</param>
	/// <param name="bodyColor">Основной цвет</param>
	public void Init(int speed, double weight, Color bodyColor)
	{
		_entityCar = new EntityCar();
		_entityCar.Init(speed, weight, bodyColor);
		_startPosX = null;
		_startPosY = null;
	}

	/// <summary>
	/// Установка позиции
	/// </summary>
	/// <param name="x">Координата X</param>
	/// <param name="y">Координата Y</param>
	public void SetPosition(int x, int y)
	{
		_startPosX = x;
		_startPosY = y;
	}

	/// <summary>
	/// Сдвиг изображения влево
	/// </summary>
	public void MoveLeft()
	{
		if (_entityCar is null || !_startPosX.HasValue)
		{
			return;
		}

		_startPosX -= (int)_entityCar.Step;
	}

	/// <summary>
	/// Сдвиг изображения вправо
	/// </summary>
	public void MoveRight()
	{
		if (_entityCar is null || !_startPosX.HasValue)
		{
			return;
		}

		_startPosX += (int)_entityCar.Step;
	}

	/// <summary>
	/// Сдвиг изображения вверх
	/// </summary>
	public void MoveUp()
	{
		if (_entityCar is null || !_startPosY.HasValue)
		{
			return;
		}

		_startPosY -= (int)_entityCar.Step;
	}

	/// <summary>
	/// Сдвиг изображения вниз
	/// </summary>
	public void MoveDown()
	{
		if (_entityCar is null || !_startPosY.HasValue)
		{
			return;
		}

		_startPosY += (int)_entityCar.Step;
	}

	/// <summary>
	/// Прорисовка объекта
	/// </summary>
	/// <param name="g"></param>
	/// 


	public void DrawTransport(Graphics g)
	{
		if (_entityCar is null || !_startPosX.HasValue || !_startPosY.HasValue)
		{
			return;
		}

		using Pen pen = new(Color.Black);
		using SolidBrush bodyBrush = new(_entityCar.BodyColor);
		using SolidBrush wheelBrush = new(Color.Black);


        // кузов грузовика
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