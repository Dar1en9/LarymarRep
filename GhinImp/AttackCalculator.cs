namespace GhinImp;


// Класс для вычисления среднего показателя силы атаки
public class AttackCalculator
{
    // Метод для вычисления среднего показателя силы атаки
    private Func<IEnumerable<int>, int> _averageAttackCalculation = (attacks) => attacks.Sum() / attacks.Count();

    
    // Метод для вычисления среднего показателя силы атаки
    public double CalculateAverageAttack(Character character)
    {
        return _averageAttackCalculation(new List<int> { character.AttackPower });
    }
}