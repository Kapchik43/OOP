namespace ProjectCar;

/// <summary>
/// Параметризованный набор объектов на основе LinkedList
/// </summary>
/// <typeparam name="T">Параметр: ограничение - ссылочный тип</typeparam>
public class LinkedListGenericObjects<T> : ICollectionGenericObjects<T>
    where T : class
{
    /// <summary>
    /// Связанный список объектов
    /// </summary>
    private readonly LinkedList<T> _collection;

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
    public LinkedListGenericObjects()
    {
        _collection = new LinkedList<T>();
    }

    /// <summary>
    /// Получение объекта по позиции
    /// </summary>
    public T? GetObject(int position)
    {
        LinkedListNode<T>? node = GetNode(position);
        return node?.Value;
    }

    /// <summary>
    /// Добавление объекта в начало связанного списка
    /// </summary>
    public bool InsertObject(T obj)
    {
        if (_maxCount <= 0 || _collection.Count >= _maxCount)
        {
            return false;
        }

        _collection.AddFirst(obj);
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

        if (position == _collection.Count)
        {
            _collection.AddLast(obj);
            return true;
        }

        LinkedListNode<T>? node = GetNode(position);

        if (node is null)
        {
            return false;
        }

        _collection.AddBefore(node, obj);
        return true;
    }

    /// <summary>
    /// Удаление объекта по позиции
    /// </summary>
    public bool RemoveObject(int position)
    {
        LinkedListNode<T>? node = GetNode(position);

        if (node is null)
        {
            return false;
        }

        _collection.Remove(node);
        return true;
    }

    /// <summary>
    /// Получение узла связанного списка по позиции
    /// </summary>
    private LinkedListNode<T>? GetNode(int position)
    {
        if (position < 0 || position >= _collection.Count)
        {
            return null;
        }

        LinkedListNode<T>? node = _collection.First;

        for (int i = 0; i < position; i++)
        {
            node = node?.Next;
        }

        return node;
    }
}