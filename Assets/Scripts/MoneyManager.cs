using UnityEngine;

public class MoneyManager : MonoBehaviour
{
    public static int coins;

    public static void AddCoins(int amount) {
        coins += amount;
        print("Money: " + coins);
    }

    public static void RemoveCoins(int amount) {
        coins -= amount;
    }
}
