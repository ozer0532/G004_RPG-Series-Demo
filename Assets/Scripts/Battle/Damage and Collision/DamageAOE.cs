using UnityEngine;

public class DamageAOE : MonoBehaviour
{
    public int damageAmount;

    public float damageRadius;
    public int strikeCount;
    public float strikeInterval;

    private int strikesElapsed;

    private void Start()
    {
        strikesElapsed = 1;
        Damage();
    }

    private void Damage()
    {
        Collider2D[] collidersInRange = Physics2D.OverlapCircleAll(transform.position, damageRadius);
        foreach (Collider2D collider in collidersInRange)
        {
            // Test if object can be damaged
            Destructible dest = collider.GetComponent<Destructible>();
            if (dest)
            {
                dest.Damage(damageAmount);
            }
        }

        strikesElapsed++;
        if (strikesElapsed < strikeCount)
        {
            Invoke("Damage", strikeInterval);
        }
    }
}
