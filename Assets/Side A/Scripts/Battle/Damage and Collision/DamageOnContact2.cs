using UnityEngine;

public class DamageOnContact2 : MonoBehaviour
{
    public int damage;

    private BulletController2 bulletController;

    private void Awake()
    {
        bulletController = GetComponent<BulletController2>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject != bulletController.owner)
        {
            Destructible destructible = collision.GetComponent<Destructible>();
            if (destructible)
            {
                destructible.Damage(damage);
            }
        }
    }
}
