namespace ProjectCar;

/// <summary>
/// Стратегия перемещения объекта к центру формы
/// </summary>
public class MoveToCenter : BaseTemplateMovement
{
    protected override bool IsTargetDestination()
    {
        ObjectCoordinates? objectCoordinates = GetObjectCoordinates();

        if (objectCoordinates is null)
        {
            return false;
        }

        return Math.Abs(objectCoordinates.ObjectMiddleHorizontal - FieldWidth / 2) <= GetStep() &&
               Math.Abs(objectCoordinates.ObjectMiddleVertical - FieldHeight / 2) <= GetStep();
    }

    protected override void MoveToTarget()
    {
        ObjectCoordinates? objectCoordinates = GetObjectCoordinates();

        if (objectCoordinates is null)
        {
            return;
        }

        int diffX = objectCoordinates.ObjectMiddleHorizontal - FieldWidth / 2;

        if (Math.Abs(diffX) > GetStep())
        {
            if (diffX > 0)
            {
                MoveLeft();
            }
            else
            {
                MoveRight();
            }
        }

        int diffY = objectCoordinates.ObjectMiddleVertical - FieldHeight / 2;

        if (Math.Abs(diffY) > GetStep())
        {
            if (diffY > 0)
            {
                MoveUp();
            }
            else
            {
                MoveDown();
            }
        }
    }
}