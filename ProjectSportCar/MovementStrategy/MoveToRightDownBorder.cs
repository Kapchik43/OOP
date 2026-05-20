namespace ProjectCar;

/// <summary>
/// Стратегия перемещения объекта к правому нижнему краю формы
/// </summary>
public class MoveToRightDownBorder : BaseTemplateMovement
{
    protected override bool IsTargetDestination()
    {
        ObjectCoordinates? objectCoordinates = GetObjectCoordinates();

        if (objectCoordinates is null)
        {
            return false;
        }

        return FieldWidth - objectCoordinates.RightBorder <= GetStep() &&
               FieldHeight - objectCoordinates.DownBorder <= GetStep();
    }

    protected override void MoveToTarget()
    {
        ObjectCoordinates? objectCoordinates = GetObjectCoordinates();

        if (objectCoordinates is null)
        {
            return;
        }

        if (FieldWidth - objectCoordinates.RightBorder > GetStep())
        {
            MoveRight();
        }

        if (FieldHeight - objectCoordinates.DownBorder > GetStep())
        {
            MoveDown();
        }
    }
}