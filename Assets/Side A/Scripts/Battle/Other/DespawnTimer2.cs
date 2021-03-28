using UnityEngine;

public class DespawnTimer2 : MonoBehaviour
{
    public float despawnTime;

    private void Start()
    {
        Invoke("Despawn", despawnTime);
    }

    private void Despawn()
    {
        Destroy(gameObject);
    }
}
