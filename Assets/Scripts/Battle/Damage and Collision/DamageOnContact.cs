using UnityEngine;

public class DamageOnContact : MonoBehaviour
{
    public int damageAmount;

    private BulletController controller;

    private void Awake()
    {
        controller = GetComponent<BulletController>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (controller?.owner != collision.gameObject && !collision.isTrigger)
        {
            Destructible destructible = collision.GetComponent<Destructible>();
            if (destructible)
            {
                destructible.Damage(damageAmount);
            }
        }
    }
}

