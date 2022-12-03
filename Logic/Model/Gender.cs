namespace Logic.Model;

public class Gender
{   /// <summary>
    /// Пол
    /// Название
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// Создать пол
    /// </summary>
    /// <param name="name"></param>
    /// <exception cref="ArgumentNullException"></exception>

    public Gender(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentNullException("Имя пола не может быть пустым или null",nameof(name));
        }
        Name = name;
    }

    public override string ToString()
    {
        return Name;
    }
}