namespace ProjectCar;

/// <summary>
/// Фабрика по созданию стратегии перемещения
/// </summary>
public static class TemplateMovementFactory
{
    /// <summary>
    /// Значения для выпадающего списка
    /// </summary>
    public static string[] Values => ["К центру", "К правому нижнему краю"];

    /// <summary>
    /// Создание стратегии перемещения по выбранному значению
    /// </summary>
    public static BaseTemplateMovement? CreateTemplateMovement(string value)
    {
        return value switch
        {
            "К центру" => new MoveToCenter(),
            "К правому нижнему краю" => new MoveToRightDownBorder(),
            "К правом нижнему краю" => new MoveToRightDownBorder(),
            "К краю" => new MoveToRightDownBorder(),
            _ => null
        };
    }
}