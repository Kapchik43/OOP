namespace ProjectCar;

/// <summary>
/// Класс-хранилище компаний
/// </summary>
public class StorageCompanies
{
    /// <summary>
    /// Словарь компаний:
    /// ключ - название компании,
    /// значение - объект компании
    /// </summary>
    private readonly Dictionary<string, AbstractCompany> _companies;

    /// <summary>
    /// Список названий компаний
    /// </summary>
    public List<string> StorageKeys => new(_companies.Keys);

    /// <summary>
    /// Конструктор
    /// </summary>
    public StorageCompanies()
    {
        _companies = new Dictionary<string, AbstractCompany>();
    }

    /// <summary>
    /// Добавление компании в хранилище
    /// </summary>
    /// <param name="name">Название компании</param>
    /// <param name="collectionType">Тип коллекции</param>
    /// <param name="pictureWidth">Ширина области прорисовки</param>
    /// <param name="pictureHeight">Высота области прорисовки</param>
    /// <returns>true - компания добавлена, false - добавить не удалось</returns>
    public bool AddCompany(
        string name,
        CollectionType collectionType,
        int pictureWidth,
        int pictureHeight)
    {
        if (string.IsNullOrWhiteSpace(name) || collectionType == CollectionType.None)
        {
            return false;
        }

        string storageName = CreateStorageName(name, collectionType);

        if (_companies.ContainsKey(storageName))
        {
            return false;
        }

        AbstractCompany? company = CreateCompany(
            collectionType,
            pictureWidth,
            pictureHeight);

        if (company is null)
        {
            return false;
        }

        _companies.Add(storageName, company);
        return true;
    }

    /// <summary>
    /// Удаление компании из хранилища
    /// </summary>
    /// <param name="name">Название компании</param>
    /// <returns>true - компания удалена, false - удалить не удалось</returns>
    public bool DelCompany(string name)
    {
        if (string.IsNullOrWhiteSpace(name) || !_companies.ContainsKey(name))
        {
            return false;
        }

        return _companies.Remove(name);
    }

    /// <summary>
    /// Индексатор для получения компании по названию
    /// </summary>
    /// <param name="name">Название компании</param>
    /// <returns>Компания или null</returns>
    public AbstractCompany? this[string name]
    {
        get
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return null;
            }

            return _companies.TryGetValue(name, out AbstractCompany? company)
                ? company
                : null;
        }
    }

    /// <summary>
    /// Создание уникального имени компании для хранения
    /// </summary>
    private static string CreateStorageName(string name, CollectionType collectionType)
    {
        return $"{GetCollectionTypeName(collectionType)}: {name.Trim()}";
    }

    /// <summary>
    /// Получение текстового названия типа коллекции
    /// </summary>
    private static string GetCollectionTypeName(CollectionType collectionType)
    {
        return collectionType switch
        {
            CollectionType.Massive => "Массив",
            CollectionType.List => "Список",
            CollectionType.LinkedList => "Связанный список",
            _ => "Неизвестно"
        };
    }

    /// <summary>
    /// Создание компании с нужной реализацией коллекции
    /// </summary>
    private static AbstractCompany? CreateCompany(
        CollectionType collectionType,
        int pictureWidth,
        int pictureHeight)
    {
        ICollectionGenericObjects<DrawningCar>? collection = collectionType switch
        {
            CollectionType.Massive => new MassiveGenericObjects<DrawningCar>(),
            CollectionType.List => new ListGenericObjects<DrawningCar>(),
            CollectionType.LinkedList => new LinkedListGenericObjects<DrawningCar>(),
            _ => null
        };

        return collection is null
            ? null
            : new AutoPark(pictureWidth, pictureHeight, collection);
    }
}