namespace GhinImp;

// Record для хранения данных о персонаже

public record Character
{
    public string Name { get; init; }
    public string Element { get; }
    public int AttackPower { get; set; }

   /* private string _e1;
   public string E1 { get => _e1; set => _e1 = value; }
   */
   
   
    public List<Skill> Skills;

    public Character(string name, string element, int attackPower, List<Skill> skills)
    {
        Name = name;
        Element = element;
        AttackPower = attackPower;
        Skills = skills;
    }

    // Метод для проверки силы атаки
    public bool IsPowerful()
    {
        return AttackPower > 80;
    }
}