using UnityEngine;

public class ReplaceOnContact : MonoBehaviour
{
    public GameObject replacementPrefab;
    private BulletController controller;

    private void Awake()
    {
        controller = GetComponent<BulletController>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject instantiatedGameObject = Instantiate(replacementPrefab, transform.position, transform.rotation);
        BulletController bullet = instantiatedGameObject.GetComponent<BulletController>();
        if (bullet)
        {
            bullet.owner = controller.owner;
        }
        Destroy(gameObject);
    }
}
