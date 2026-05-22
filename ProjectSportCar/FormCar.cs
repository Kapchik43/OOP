using ProjectCar.Drawnings;

namespace ProjectCar;

public partial class FormCar : Form
{
    private readonly CanvasForCar _canvas;

    private DirectionType _checkBordersState;

    private BaseTemplateMovement? _templateMovement;

    public FormCar()
    {
        InitializeComponent();

        _canvas = new CanvasForCar(pictureBoxSportCar.Width, pictureBoxSportCar.Height);
        _checkBordersState = DirectionType.None;
        _templateMovement = null;

        comboBoxPointOfDestination.Items.Clear();
        comboBoxPointOfDestination.Items.AddRange(TemplateMovementFactory.Values);
    }

    /// <summary>
    /// Получение автомобиля из формы коллекции
    /// </summary>
    public void SetDrawningCar(DrawningCar car)
    {
        InsertCarObject(car);
    }

    /// <summary>
    /// Добавление автомобиля на полотно
    /// </summary>
    private void InsertCarObject(DrawningCar car, Random? random = null)
    {
        random ??= new Random();

        if (_canvas.InsertCar(car))
        {
            _canvas.SetCarPosition(random.Next(10, 100), random.Next(10, 100));

            _templateMovement = null;
            comboBoxPointOfDestination.Enabled = true;
            comboBoxPointOfDestination.SelectedIndex = -1;

            Draw();
        }
    }

    private void Draw()
    {
        pictureBoxSportCar.Image = _canvas.DrawCanvas();
    }

    private void ButtonCreateCar_Click(object sender, EventArgs e)
    {
        CreateObject(nameof(DrawningCar));
    }

    private void ButtonCreateDumpTruck_Click(object sender, EventArgs e)
    {
        CreateObject(nameof(DrawningDumpTruck));
    }

    private void CreateObject(string type)
    {
        Random random = new();

        DrawningCar? drawningCar = null;

        switch (type)
        {
            case nameof(DrawningCar):
                drawningCar = new DrawningCar(
                    random.Next(100, 300),
                    random.Next(1000, 3000),
                    Color.FromArgb(
                        random.Next(0, 256),
                        random.Next(0, 256),
                        random.Next(0, 256)));
                break;

            case nameof(DrawningDumpTruck):
                bool dumpBody = true;
                bool tent = Convert.ToBoolean(random.Next(0, 2));

                drawningCar = new DrawningDumpTruck(
                    random.Next(100, 300),
                    random.Next(1000, 3000),
                    Color.FromArgb(
                        random.Next(0, 256),
                        random.Next(0, 256),
                        random.Next(0, 256)),
                    Color.FromArgb(
                        random.Next(0, 256),
                        random.Next(0, 256),
                        random.Next(0, 256)),
                    dumpBody,
                    tent);
                break;
        }

        if (drawningCar is null)
        {
            return;
        }

        InsertCarObject(drawningCar, random);
    }

    private void ButtonMove_Click(object sender, EventArgs e)
    {
        string name = ((Button)sender)?.Name ?? string.Empty;

        DirectionType direction = DirectionType.None;

        switch (name)
        {
            case "buttonUp":
                direction = DirectionType.Up;
                break;

            case "buttonDown":
                direction = DirectionType.Down;
                break;

            case "buttonLeft":
                direction = DirectionType.Left;
                break;

            case "buttonRight":
                direction = DirectionType.Right;
                break;
        }

        if (_canvas.MoveTransport(direction))
        {
            Draw();
        }
    }

    private void ButtonCheckBorders_Click(object sender, EventArgs e)
    {
        Random random = new();

        switch (_checkBordersState)
        {
            case DirectionType.None:
            case DirectionType.Down:
                _canvas.SetCarPosition(
                    random.Next(10, 100) - 1000,
                    random.Next(10, 100));
                _checkBordersState = DirectionType.Left;
                break;

            case DirectionType.Left:
                _canvas.SetCarPosition(
                    random.Next(10, 100),
                    random.Next(10, 100) - 1000);
                _checkBordersState = DirectionType.Up;
                break;

            case DirectionType.Up:
                _canvas.SetCarPosition(
                    random.Next(10, 100) + pictureBoxSportCar.Width,
                    random.Next(10, 100));
                _checkBordersState = DirectionType.Right;
                break;

            case DirectionType.Right:
                _canvas.SetCarPosition(
                    random.Next(10, 100),
                    random.Next(10, 100) + pictureBoxSportCar.Height);
                _checkBordersState = DirectionType.Down;
                break;
        }

        Draw();
    }

    private void comboBoxPointOfDestination_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (_canvas.DrawningCar is null)
        {
            return;
        }

        _templateMovement = TemplateMovementFactory.CreateTemplateMovement(comboBoxPointOfDestination.Text);

        if (_templateMovement is null)
        {
            return;
        }

        _templateMovement.SetData(
            new MoveableAdapterCar(_canvas.DrawningCar),
            pictureBoxSportCar.Width,
            pictureBoxSportCar.Height);

        comboBoxPointOfDestination.Enabled = false;
    }

    private void buttonMovementStep_Click(object sender, EventArgs e)
    {
        if (_templateMovement is null)
        {
            return;
        }

        _templateMovement.MakeStep();

        if (_templateMovement.IsFinishReached)
        {
            comboBoxPointOfDestination.Enabled = true;
            comboBoxPointOfDestination.SelectedIndex = -1;
        }

        Draw();
    }
}