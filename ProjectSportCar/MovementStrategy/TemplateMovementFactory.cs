namespace ProjectCar;

/// <summary>
/// Фабрика по получению стратегии перемещения
/// </summary>
public static class TemplateMovementFactory
{
    /// <summary>
    /// Словарь шаблонов стратегий перемещения
    /// </summary>
    private static readonly Dictionary<string, BaseTemplateMovement> _templates = new()
    {
        { "К центру", new MoveToCenter() },
        { "К правому нижнему краю", new MoveToRightDownBorder() }
    };

    /// <summary>
    /// Набор возможных значений для ComboBox
    /// </summary>
    public static string[] Values => [.. _templates.Keys];

    /// <summary>
    /// Получение стратегии перемещения по выбранному значению
    /// </summary>
    public static BaseTemplateMovement? CreateTemplateMovement(string value)
    {
        _templates.TryGetValue(value, out BaseTemplateMovement? template);
        return template;
    }
}