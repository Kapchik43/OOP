namespace ProjectCar;

/// <summary>
/// Интерфейс описания действий для набора хранимых объектов
/// </summary>
/// <typeparam name="T">Параметр: ограничение - ссылочный тип</typeparam>
public interface ICollectionGenericObjects<T>
    where T : class
{
    /// <summary>
    /// Количество объектов в коллекции
    /// </summary>
    int CountObjects { get; }

    /// <summary>
    /// Установка максимального количества элементов
    /// </summary>
    int MaxCount { set; }

    /// <summary>
    /// Получение объекта по позиции
    /// </summary>
    T? GetObject(int position);

    /// <summary>
    /// Добавление объекта в коллекцию
    /// </summary>
    bool InsertObject(T obj);

    /// <summary>
    /// Добавление объекта в коллекцию на конкретную позицию
    /// </summary>
    bool InsertObject(T obj, int position);

    /// <summary>
    /// Удаление объекта из коллекции с конкретной позиции
    /// </summary>
    bool RemoveObject(int position);
}
