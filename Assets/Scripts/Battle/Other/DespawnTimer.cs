using UnityEngine;

public class DespawnTimer : MonoBehaviour
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
