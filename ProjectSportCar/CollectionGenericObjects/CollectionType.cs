namespace ProjectCar;

/// <summary>
/// Тип коллекции, на основе которой будет создана компания
/// </summary>
public enum CollectionType
{
    /// <summary>
    /// Не определено
    /// </summary>
    None = 0,

    /// <summary>
    /// Массив
    /// </summary>
    Massive = 1,

    /// <summary>
    /// Обычный список
    /// </summary>
    List = 2,

    /// <summary>
    /// Связанный список
    /// </summary>
    LinkedList = 3
}