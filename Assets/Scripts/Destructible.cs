using UnityEngine;

public class Destructible : MonoBehaviour
{
    public int maxHealth;
    [HideInInspector]
    public int currentHealth;

    private void Start() {
        currentHealth = maxHealth;
        print("Health: " + currentHealth);
    }

    public void Damage(int amount) {
        currentHealth -= amount;
        print("Health: " + currentHealth);
        if (currentHealth <= 0) {
            Destroy(gameObject);
        }
    }
}
