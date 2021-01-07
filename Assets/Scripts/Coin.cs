using UnityEngine;

public class Coin : MonoBehaviour {
    public int value;

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.GetComponent<TopdownCharacter>()) {
            MoneyManager.AddCoins(value);
            Destroy(gameObject);
        }
    }
}
