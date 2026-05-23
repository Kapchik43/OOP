namespace ProjectCar;

/// <summary>
/// Параметризованный набор объектов на основе List
/// </summary>
/// <typeparam name="T">Параметр: ограничение - ссылочный тип</typeparam>
public class ListGenericObjects<T> : ICollectionGenericObjects<T>
    where T : class
{
    /// <summary>
    /// Список объектов
    /// </summary>
    private readonly List<T> _collection;

    /// <summary>
    /// Максимально допустимое число объектов
    /// </summary>
    private int _maxCount;

    /// <summary>
    /// Количество объектов в коллекции
    /// </summary>
    public int CountObjects => _collection.Count;

    /// <summary>
    /// Установка максимального количества элементов
    /// </summary>
    public int MaxCount
    {
        set
        {
            if (value > 0)
            {
                _maxCount = value;
            }
        }
    }

    /// <summary>
    /// Конструктор
    /// </summary>
    public ListGenericObjects()
    {
        _collection = new List<T>();
    }

    /// <summary>
    /// Получение объекта по позиции
    /// </summary>
    public T? GetObject(int position)
    {
        if (position < 0 || position >= _collection.Count)
        {
            return null;
        }

        return _collection[position];
    }

    /// <summary>
    /// Добавление объекта в конец списка
    /// </summary>
    public bool InsertObject(T obj)
    {
        if (_maxCount <= 0 || _collection.Count >= _maxCount)
        {
            return false;
        }

        _collection.Add(obj);
        return true;
    }

    /// <summary>
    /// Добавление объекта на конкретную позицию
    /// </summary>
    public bool InsertObject(T obj, int position)
    {
        if (_maxCount <= 0 || _collection.Count >= _maxCount)
        {
            return false;
        }

        if (position < 0 || position > _collection.Count)
        {
            return false;
        }

        _collection.Insert(position, obj);
        return true;
    }

    /// <summary>
    /// Удаление объекта по позиции
    /// </summary>
    public bool RemoveObject(int position)
    {
        if (position < 0 || position >= _collection.Count)
        {
            return false;
        }

        _collection.RemoveAt(position);
        return true;
    }
}