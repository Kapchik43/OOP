namespace ProjectCar;

/// <summary>
/// Класс, отвечающий за прорисовку и перемещение самосвала
/// </summary>
public class DrawningDumpTruck : DrawningCar
{
    /// <summary>
    /// Конструктор самосвала
    /// </summary>
    public DrawningDumpTruck(
        int speed,
        double weight,
        Color bodyColor,
        Color additionalColor,
        bool dumpBody,
        bool tent) : base(170, 105)
    {
        _entityCar = new EntityDumpTruck(
            speed,
            weight,
            bodyColor,
            additionalColor,
            dumpBody,
            tent);
    }

    /// <summary>
    /// Прорисовка самосвала
    /// </summary>
    public override void DrawTransport(Graphics g)
    {
        if (_entityCar is null ||
            _entityCar is not EntityDumpTruck dumpTruck ||
            !_startPosX.HasValue ||
            !_startPosY.HasValue)
        {
            return;
        }

        // Сдвигаем базовый грузовик, чтобы у продвинутого объекта были поля сверху и слева
        _startPosX += 10;
        _startPosY += 10;

        base.DrawTransport(g);

        _startPosX -= 10;
        _startPosY -= 10;

        using Pen pen = new(Color.Black);
        using SolidBrush additionalBrush = new(dumpTruck.AdditionalColor);

        int x = _startPosX.Value;
        int y = _startPosY.Value;

        // Кузов самосвала
        if (dumpTruck.DumpBody)
        {
            Point[] body =
            {
                new Point(x + 50, y + 60),
                new Point(x + 65, y + 22),
                new Point(x + 155, y + 22),
                new Point(x + 160, y + 60)
            };

            g.FillPolygon(additionalBrush, body);
            g.DrawPolygon(pen, body);
        }

        // Тент над кузовом
        if (dumpTruck.Tent)
        {
            Point[] tent =
            {
                new Point(x + 65, y + 22),
                new Point(x + 80, y + 8),
                new Point(x + 140, y + 8),
                new Point(x + 155, y + 22)
            };

            g.FillPolygon(additionalBrush, tent);
            g.DrawPolygon(pen, tent);
        }
    }
}