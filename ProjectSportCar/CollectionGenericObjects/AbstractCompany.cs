namespace ProjectCar;

/// <summary>
/// Абстрактная компания, имеющая коллекцию автомобилей
/// </summary>
public abstract class AbstractCompany
{
    /// <summary>
    /// Размер одного места по ширине
    /// </summary>
    protected readonly int _placeSizeWidth;

    /// <summary>
    /// Размер одного места по высоте
    /// </summary>
    protected readonly int _placeSizeHeight;

    /// <summary>
    /// Ширина области прорисовки
    /// </summary>
    protected readonly int _pictureWidth;

    /// <summary>
    /// Высота области прорисовки
    /// </summary>
    protected readonly int _pictureHeight;

    /// <summary>
    /// Коллекция объектов
    /// </summary>
    protected readonly ICollectionGenericObjects<DrawningCar> _collection;

    /// <summary>
    /// Количество объектов в коллекции
    /// </summary>
    public int CountObjects => _collection.CountObjects;

    protected AbstractCompany(
        int pictureWidth,
        int pictureHeight,
        int placeSizeWidth,
        int placeSizeHeight,
        ICollectionGenericObjects<DrawningCar> collection)
    {
        _pictureWidth = pictureWidth;
        _pictureHeight = pictureHeight;
        _placeSizeWidth = placeSizeWidth;
        _placeSizeHeight = placeSizeHeight;
        _collection = collection;
        _collection.MaxCount = CalcMaxCount();
    }

    /// <summary>
    /// Перегрузка оператора сложения: добавление автомобиля в компанию
    /// </summary>
    public static AbstractCompany operator +(AbstractCompany company, DrawningCar car)
    {
        company._collection.InsertObject(car);
        return company;
    }

    /// <summary>
    /// Перегрузка оператора вычитания: удаление автомобиля по позиции
    /// </summary>
    public static AbstractCompany operator -(AbstractCompany company, int position)
    {
        company._collection.RemoveObject(position);
        return company;
    }

    /// <summary>
    /// Получение случайного объекта из коллекции
    /// </summary>
    public DrawningCar? GetRandomObject()
    {
        List<DrawningCar> objects = new();

        for (int i = 0; i < CalcMaxCount(); i++)
        {
            DrawningCar? car = _collection.GetObject(i);

            if (car is not null)
            {
                objects.Add(car);
            }
        }

        if (objects.Count == 0)
        {
            return null;
        }

        return objects[Random.Shared.Next(objects.Count)];
    }

    /// <summary>
    /// Вывод всей коллекции
    /// </summary>
    public Bitmap Show()
    {
        Bitmap bitmap = new(_pictureWidth, _pictureHeight);

        using Graphics graphics = Graphics.FromImage(bitmap);
        DrawBackgound(graphics);
        DrawObjects(graphics);

        return bitmap;
    }

    /// <summary>
    /// Прорисовка фона
    /// </summary>
    protected abstract void DrawBackgound(Graphics g);

    /// <summary>
    /// Расстановка и прорисовка объектов
    /// </summary>
    protected abstract void DrawObjects(Graphics g);

    /// <summary>
    /// Вычисление максимального количества мест
    /// </summary>
    protected int CalcMaxCount()
    {
        return (int)(Math.Truncate((double)_pictureWidth / _placeSizeWidth) *
                     Math.Truncate((double)_pictureHeight / _placeSizeHeight));
    }
}