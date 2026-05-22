namespace ProjectCar;

/// <summary>
/// Форма для работы с коллекцией автомобилей и хранилищем компаний
/// </summary>
public partial class FormCarCollection : Form
{
    /// <summary>
    /// Текущая выбранная компания
    /// </summary>
    private AbstractCompany? _company;

    /// <summary>
    /// Хранилище компаний
    /// </summary>
    private readonly StorageCompanies _storageCompanies;

    /// <summary>
    /// Конструктор
    /// </summary>
    public FormCarCollection()
    {
        InitializeComponent();

        _storageCompanies = new StorageCompanies();
        _company = null;

        ClearPicture();
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
    /// Создание объекта и добавление его в выбранную компанию
    /// </summary>
    private void CreateAndAddObjectToCollection(string type)
    {
        if (_company is null)
        {
            MessageBox.Show(
                "Сначала создайте и выберите компанию",
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            return;
        }

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

        int countBefore = _company.CountObjects;
        _company = _company + car;

        if (_company.CountObjects > countBefore)
        {
            MessageBox.Show("Объект добавлен в выбранную компанию");
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
    /// Удаление объекта по позиции из выбранной компании
    /// </summary>
    private void ButtonRemoveCar_Click(object sender, EventArgs e)
    {
        if (_company is null)
        {
            MessageBox.Show(
                "Сначала выберите компанию",
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            return;
        }

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

        int countBefore = _company.CountObjects;
        _company = _company - position;

        if (_company.CountObjects < countBefore)
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
    /// Передача случайного объекта из выбранной компании на форму тестирования
    /// </summary>
    private void ButtonGoToCheck_Click(object sender, EventArgs e)
    {
        if (_company is null)
        {
            MessageBox.Show(
                "Сначала выберите компанию",
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            return;
        }

        DrawningCar? car = _company.GetRandomObject();

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
    /// Обновление изображения выбранной компании
    /// </summary>
    private void ButtonRefresh_Click(object sender, EventArgs e)
    {
        RefreshPicture();
    }

    /// <summary>
    /// Добавление новой компании в хранилище
    /// </summary>
    private void ButtonCompanyAdd_Click(object sender, EventArgs e)
    {
        CollectionType collectionType = GetSelectedCollectionType();

        if (string.IsNullOrWhiteSpace(textBoxCompanyName.Text) ||
            collectionType == CollectionType.None)
        {
            MessageBox.Show(
                "Не все данные заполнены",
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            return;
        }

        bool result = _storageCompanies.AddCompany(
            textBoxCompanyName.Text,
            collectionType,
            pictureBox.Width,
            pictureBox.Height);

        if (!result)
        {
            MessageBox.Show(
                "Компания с таким именем уже существует или тип коллекции не выбран",
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            return;
        }

        RefreshListBoxItems();

        if (listBoxCompanies.Items.Count > 0)
        {
            listBoxCompanies.SelectedIndex = listBoxCompanies.Items.Count - 1;
        }
    }

    /// <summary>
    /// Удаление выбранной компании из хранилища
    /// </summary>
    private void ButtonCompanyDel_Click(object sender, EventArgs e)
    {
        if (listBoxCompanies.SelectedItem is null)
        {
            MessageBox.Show("Компания не выбрана");
            return;
        }

        string companyName = listBoxCompanies.SelectedItem.ToString() ?? string.Empty;

        if (MessageBox.Show(
                "Удалить компанию?",
                "Удаление",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No)
        {
            return;
        }

        if (_storageCompanies.DelCompany(companyName))
        {
            _company = null;
            RefreshListBoxItems();
            ClearPicture();
            MessageBox.Show("Компания удалена");
        }
        else
        {
            MessageBox.Show("Не удалось удалить компанию");
        }
    }

    /// <summary>
    /// Выбор компании из ListBox
    /// </summary>
    private void ListBoxCompanies_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (listBoxCompanies.SelectedItem is null)
        {
            return;
        }

        string companyName = listBoxCompanies.SelectedItem.ToString() ?? string.Empty;
        AbstractCompany? company = _storageCompanies[companyName];

        if (company is null)
        {
            MessageBox.Show("Компания не найдена");
            return;
        }

        _company = company;
        RefreshPicture();
    }

    /// <summary>
    /// Получение выбранного типа коллекции
    /// </summary>
    private CollectionType GetSelectedCollectionType()
    {
        if (radioButtonMassive.Checked)
        {
            return CollectionType.Massive;
        }

        if (radioButtonList.Checked)
        {
            return CollectionType.List;
        }

        if (radioButtonLinkedList.Checked)
        {
            return CollectionType.LinkedList;
        }

        return CollectionType.None;
    }

    /// <summary>
    /// Обновление списка компаний
    /// </summary>
    private void RefreshListBoxItems()
    {
        listBoxCompanies.Items.Clear();

        foreach (string companyName in _storageCompanies.StorageKeys)
        {
            if (!string.IsNullOrWhiteSpace(companyName))
            {
                listBoxCompanies.Items.Add(companyName);
            }
        }

        ClearPicture();
    }

    /// <summary>
    /// Перерисовка выбранной компании
    /// </summary>
    private void RefreshPicture()
    {
        Image? oldImage = pictureBox.Image;
        pictureBox.Image = _company?.Show();
        oldImage?.Dispose();
    }

    /// <summary>
    /// Очистка PictureBox
    /// </summary>
    private void ClearPicture()
    {
        Image? oldImage = pictureBox.Image;
        pictureBox.Image = null;
        oldImage?.Dispose();
    }
}