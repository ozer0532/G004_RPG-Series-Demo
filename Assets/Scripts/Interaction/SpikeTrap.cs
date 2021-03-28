using UnityEngine;

public class SpikeTrap : MonoBehaviour
{
    public int damageAmount;

    public float onDelay;
    public float offDelay;
    public Sprite onSprite;
    public Sprite offSprite;
    public Collider2D triggerCollider;
    public SpriteRenderer spriteRenderer;


    private void Start() {
        Invoke("TurnOn", onDelay);
    }

    private void TurnOn() {
        triggerCollider.enabled = true;
        spriteRenderer.sprite = onSprite;
        Invoke("TurnOff", offDelay);
    }

    private void TurnOff() {
        triggerCollider.enabled = false;
        spriteRenderer.sprite = offSprite;
        Invoke("TurnOn", onDelay);
    }
    private void OnTriggerEnter2D(Collider2D collision){
        Destructible destructible = collision.GetComponent<Destructible>();
        if (destructible)
        {
            destructible.Damage(damageAmount);
        }
    }
}
