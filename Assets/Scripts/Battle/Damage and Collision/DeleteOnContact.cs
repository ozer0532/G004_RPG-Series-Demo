using UnityEngine;

public class DeleteOnContact : MonoBehaviour
{
    private BulletController controller;

    private void Awake()
    {
        controller = GetComponent<BulletController>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (controller?.owner != collision.gameObject && !collision.isTrigger)
        {
            Destroy(gameObject);
        }
    }
}
