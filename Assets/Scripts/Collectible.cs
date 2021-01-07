using UnityEngine;
using UnityEngine.Events;

public class Collectible : MonoBehaviour
{
    public UnityEvent onCollected;

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.GetComponent<TopdownCharacter>()) {
            onCollected.Invoke();
            Destroy(gameObject);
        }
    }

    public void AddCoins(int amount) {
        MoneyManager.AddCoins(amount);
    }
}
