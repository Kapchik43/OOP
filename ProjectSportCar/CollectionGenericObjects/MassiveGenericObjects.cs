namespace ProjectCar;

/// <summary>
/// Параметризованный набор объектов на основе массива
/// </summary>
/// <typeparam name="T">Параметр: ограничение - ссылочный тип</typeparam>
public class MassiveGenericObjects<T> : ICollectionGenericObjects<T>
    where T : class
{
    /// <summary>
    /// Массив объектов
    /// </summary>
    private T?[] _collection;

    /// <summary>
    /// Количество занятых мест
    /// </summary>
    public int CountObjects
    {
        get
        {
            int count = 0;

            for (int i = 0; i < _collection.Length; i++)
            {
                if (_collection[i] is not null)
                {
                    count++;
                }
            }

            return count;
        }
    }

    /// <summary>
    /// Установка максимального количества элементов
    /// </summary>
    public int MaxCount
    {
        set
        {
            if (value > 0)
            {
                Array.Resize(ref _collection, value);
            }
        }
    }

    /// <summary>
    /// Конструктор
    /// </summary>
    public MassiveGenericObjects()
    {
        _collection = new T?[0];
    }

    /// <summary>
    /// Получение объекта по позиции
    /// </summary>
    public T? GetObject(int position)
    {
        if (position < 0 || position >= _collection.Length)
        {
            return null;
        }

        return _collection[position];
    }

    /// <summary>
    /// Добавление объекта в начало коллекции
    /// </summary>
    public bool InsertObject(T obj)
    {
        return InsertObject(obj, 0);
    }

    /// <summary>
    /// Добавление объекта на конкретную позицию
    /// </summary>
    public bool InsertObject(T obj, int position)
    {
        if (position < 0 || position >= _collection.Length)
        {
            return false;
        }

        if (_collection[position] is null)
        {
            _collection[position] = obj;
            return true;
        }

        for (int i = position + 1; i < _collection.Length; i++)
        {
            if (_collection[i] is null)
            {
                _collection[i] = obj;
                return true;
            }
        }

        for (int i = position - 1; i >= 0; i--)
        {
            if (_collection[i] is null)
            {
                _collection[i] = obj;
                return true;
            }
        }

        return false;
    }

    /// <summary>
    /// Удаление объекта по позиции
    /// </summary>
    public bool RemoveObject(int position)
    {
        if (position < 0 || position >= _collection.Length)
        {
            return false;
        }

        if (_collection[position] is null)
        {
            return false;
        }

        _collection[position] = null;
        return true;
    }
}