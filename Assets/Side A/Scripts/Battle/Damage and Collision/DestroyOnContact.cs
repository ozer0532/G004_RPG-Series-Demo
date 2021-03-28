using UnityEngine;

public class DestroyOnContact : MonoBehaviour
{
    private BulletController2 bulletController;

    private void Awake()
    {
        bulletController = GetComponent<BulletController2>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject != bulletController.owner)
        {
            Destroy(gameObject);
        }
    }
}
