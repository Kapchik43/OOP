namespace ProjectCar;

/// <summary>
/// Класс-сущность "Самосвал"
/// </summary>
public class EntityDumpTruck : EntityCar
{
    /// <summary>
    /// Дополнительный цвет для кузова и тента
    /// </summary>
    public Color AdditionalColor { get; init; }

    /// <summary>
    /// Признак наличия кузова самосвала
    /// </summary>
    public bool DumpBody { get; init; }

    /// <summary>
    /// Признак наличия тента
    /// </summary>
    public bool Tent { get; init; }

    /// <summary>
    /// Конструктор
    /// </summary>
    public EntityDumpTruck(
        int speed,
        double weight,
        Color bodyColor,
        Color additionalColor,
        bool dumpBody,
        bool tent) : base(speed, weight, bodyColor)
    {
        AdditionalColor = additionalColor;
        DumpBody = dumpBody;
        Tent = tent;
    }
}