namespace ProjectCar;

/// <summary>
/// Реализация компании по варианту 2 - автопарк
/// </summary>
public class AutoPark : AbstractCompany
{
    /// <summary>
    /// Конструктор
    /// </summary>
    public AutoPark(
        int pictureWidth,
        int pictureHeight,
        ICollectionGenericObjects<DrawningCar> collection)
        : base(pictureWidth, pictureHeight, 200, 130, collection)
    {
    }

    /// <summary>
    /// Прорисовка разметки автопарка
    /// </summary>
    protected override void DrawBackgound(Graphics g)
    {
        g.Clear(Color.White);

        using Pen markingPen = new(Color.Gray, 2);

        int placesInRow = Math.Max(1, _pictureWidth / _placeSizeWidth);
        int maxCount = CalcMaxCount();

        for (int i = 0; i < maxCount; i++)
        {
            int row = i / placesInRow;
            int column = i % placesInRow;

            int x = column * _placeSizeWidth + 5;
            int y = row * _placeSizeHeight + 5;

            g.DrawRectangle(
                markingPen,
                x,
                y,
                _placeSizeWidth - 10,
                _placeSizeHeight - 10);
        }
    }

    /// <summary>
    /// Прорисовка объектов в направлении вправо, вниз
    /// </summary>
    protected override void DrawObjects(Graphics g)
    {
        int placesInRow = Math.Max(1, _pictureWidth / _placeSizeWidth);
        int maxCount = CalcMaxCount();

        for (int i = 0; i < maxCount; i++)
        {
            DrawningCar? car = _collection.GetObject(i);

            if (car is null)
            {
                continue;
            }

            int row = i / placesInRow;
            int column = i % placesInRow;

            int cellX = column * _placeSizeWidth;
            int cellY = row * _placeSizeHeight;

            int x = cellX + (_placeSizeWidth - car.DrawningCarWidth) / 2;
            int y = cellY + (_placeSizeHeight - car.DrawningCarHeight) / 2;

            car.SetPosition(x, y);
            car.DrawTransport(g);
        }
    }
}