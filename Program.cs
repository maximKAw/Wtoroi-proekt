public class User
{
    // Свойства пользователя
    public string Name { get; set; }   // Имя пользователя
    public DateTime RegistrationDate { get; private set; }  // Дата регистрации
    public bool Premiumakk { get; protected set; }           // Является ли пользователь премиум-пользователем
    private string Email { get; set; }                      // Электронная почта (доступна только внутри класса)

    // Конструктор для инициализации объекта
    public User(string name, string email)
    {
        Name = name;
        Email = email;
        RegistrationDate = DateTime.Now;
        Premiumakk = false;
    }

    /// <summary>
    /// Изменение статуса премиум-аккаунта
    /// </summary>
    public void SetPremium(bool isPremium)
    {
        Premiumakk = isPremium;
    }

    override public string ToString()
    {
        return $"Имя: {Name}, Дата регистрации: {RegistrationDate.ToShortDateString()}, Премиум-статус: {(Premiumakk ? "Да" : "Нет")}";
    }
}