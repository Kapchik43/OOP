namespace ProjectCar;

/// <summary>
/// Класс-сущность "Грузовик"
/// </summary>
public class EntityCar
{
    /// <summary>
    /// Скорость
    /// </summary>
    public int Speed { get; init; }

    /// <summary>
    /// Вес
    /// </summary>
    public double Weight { get; init; }

    /// <summary>
    /// Основной цвет
    /// </summary>
    public Color BodyColor { get; init; }

    /// <summary>
    /// Шаг перемещения грузовика
    /// </summary>
    public double Step => Speed * 100 / Weight;

    /// <summary>
    /// Конструктор
    /// </summary>
    public EntityCar(int speed, double weight, Color bodyColor)
    {
        Speed = speed;
        Weight = weight;
        BodyColor = bodyColor;
    }
}