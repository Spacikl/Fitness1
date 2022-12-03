using System;
namespace Logic.Model;

public class User
{
    public string Name { get; }
    public Gender Gender { get; }
    public DateTime BirthDate { get; }
    public double Weight { get; set; }
    public double Height { get; set; }

    public User(string name, Gender gender, DateTime datetime, double weight, double height)
    {
        #region Проверка
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentNullException("Имя пользователя не может быть пустым или null.", nameof(name));
        }
        if (gender == null)
        {
            throw new ArgumentNullException("Пол не может быть null.",nameof(gender));
        }
        if (datetime<DateTime.Parse("01.01.1900") || datetime>=DateTime.Now)
        {
            throw new ArgumentException("Невозможна дата рождения.",nameof(datetime));
        }
        if (weight <= 0)
        {
            throw new ArgumentException("Вес не может быть меньше нуля.", nameof(weight));
        }
        if (height <= 0)
        {
            throw new ArgumentException("Рост не может быть меньше нуля.", nameof(height));
        }
        #endregion
        Gender = gender;
        Name = name;
        Weight = weight;
        Height = height;
        BirthDate = datetime;
    }
    public override string ToString()
    {
        return Name;
    }
    
}