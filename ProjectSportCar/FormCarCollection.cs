namespace ProjectCar;

/// <summary>
/// Форма для работы с коллекцией автомобилей
/// </summary>
public partial class FormCarCollection : Form
{
    /// <summary>
    /// Автопарк
    /// </summary>
    private AbstractCompany _autoPark;

    /// <summary>
    /// Конструктор
    /// </summary>
    public FormCarCollection()
    {
        InitializeComponent();

        _autoPark = new AutoPark(
            pictureBox.Width,
            pictureBox.Height,
            new MassiveGenericObjects<DrawningCar>());

        RefreshPicture();
    }

    /// <summary>
    /// Добавление грузовика
    /// </summary>
    private void ButtonAddCar_Click(object sender, EventArgs e)
    {
        CreateAndAddObjectToCollection(nameof(DrawningCar));
    }

    /// <summary>
    /// Добавление самосвала
    /// </summary>
    private void ButtonAddDumpTruck_Click(object sender, EventArgs e)
    {
        CreateAndAddObjectToCollection(nameof(DrawningDumpTruck));
    }

    /// <summary>
    /// Создание объекта и добавление его в коллекцию
    /// </summary>
    private void CreateAndAddObjectToCollection(string type)
    {
        Random random = new();
        DrawningCar car;

        switch (type)
        {
            case nameof(DrawningCar):
                car = new DrawningCar(
                    random.Next(100, 300),
                    random.Next(1000, 3000),
                    GetColor(random));
                break;

            case nameof(DrawningDumpTruck):
                car = new DrawningDumpTruck(
                    random.Next(100, 300),
                    random.Next(1000, 3000),
                    GetColor(random),
                    GetColor(random),
                    true,
                    Convert.ToBoolean(random.Next(0, 2)));
                break;

            default:
                return;
        }

        int countBefore = _autoPark.CountObjects;
        _autoPark = _autoPark + car;

        if (_autoPark.CountObjects > countBefore)
        {
            MessageBox.Show("Объект добавлен в автопарк");
            RefreshPicture();
        }
        else
        {
            MessageBox.Show("Не удалось добавить объект");
        }
    }

    /// <summary>
    /// Получение цвета через диалоговое окно
    /// </summary>
    private static Color GetColor(Random random)
    {
        using ColorDialog dialog = new();

        return dialog.ShowDialog() == DialogResult.OK
            ? dialog.Color
            : Color.FromArgb(
                random.Next(0, 256),
                random.Next(0, 256),
                random.Next(0, 256));
    }

    /// <summary>
    /// Удаление объекта по позиции
    /// </summary>
    private void ButtonRemoveCar_Click(object sender, EventArgs e)
    {
        if (!int.TryParse(maskedTextBoxPosition.Text.Trim(), out int position))
        {
            MessageBox.Show("Введите позицию объекта");
            return;
        }

        if (MessageBox.Show(
                "Удалить объект?",
                "Удаление",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No)
        {
            return;
        }

        int countBefore = _autoPark.CountObjects;
        _autoPark = _autoPark - position;

        if (_autoPark.CountObjects < countBefore)
        {
            MessageBox.Show("Объект удален");
            RefreshPicture();
        }
        else
        {
            MessageBox.Show("Не удалось удалить объект");
        }
    }

    /// <summary>
    /// Передача случайного объекта на первую форму
    /// </summary>
    private void ButtonGoToCheck_Click(object sender, EventArgs e)
    {
        DrawningCar? car = _autoPark.GetRandomObject();

        if (car is null)
        {
            MessageBox.Show("Не удалось получить объект");
            return;
        }

        using FormCar formCar = new();
        formCar.SetDrawningCar(car);
        formCar.ShowDialog();

        RefreshPicture();
    }

    /// <summary>
    /// Обновление изображения автопарка
    /// </summary>
    private void ButtonRefresh_Click(object sender, EventArgs e)
    {
        RefreshPicture();
    }

    /// <summary>
    /// Перерисовка автопарка
    /// </summary>
    private void RefreshPicture()
    {
        Image? oldImage = pictureBox.Image;
        pictureBox.Image = _autoPark.Show();
        oldImage?.Dispose();
    }
}