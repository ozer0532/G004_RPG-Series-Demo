using UnityEngine;

public class SpikeBush : MonoBehaviour
{
    public int damageAmount;

    private void OnCollisionEnter2D(Collision2D collision) {
        Destructible destructible = collision.gameObject.GetComponent<Destructible>();
        if (destructible) {
            destructible.Damage(damageAmount);
        }
    }
}
