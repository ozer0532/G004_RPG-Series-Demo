using UnityEngine;

public class ReplaceOnTimerEnd : MonoBehaviour
{
    public GameObject replacementPrefab;
    public float despawnTime;
    public float initialSpeed;
    private BulletController controller;

    private void Awake()
    {
        controller = GetComponent<BulletController>();
    }

    private void Start()
    {
        Invoke("Replace", despawnTime);
    }

    private void Replace()
    {
        GameObject instantiatedGameObject = Instantiate(replacementPrefab, transform.position, transform.rotation);
        BulletController bullet = instantiatedGameObject.GetComponent<BulletController>();
        if (bullet)
        {
            bullet.owner = controller.owner;
        }
        Rigidbody2D rb2d = instantiatedGameObject.GetComponent<Rigidbody2D>();
        if (rb2d)
        {
            rb2d.velocity = transform.right * initialSpeed;
        }
        Destroy(gameObject);
    }
}
