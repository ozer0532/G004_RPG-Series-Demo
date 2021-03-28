using UnityEngine;

public class SummonInCircleArea : MonoBehaviour
{
    public float startDelay;
    public float interval;
    public int amount;
    public GameObject summonedPrefab;
    public float circleRadius;
    public bool spawnRotated = true;

    private int amountRemaining;

    private BulletController controller;

    private void Awake()
    {
        controller = GetComponent<BulletController>();
        amountRemaining = amount;
    }

    private void Start()
    {
        Invoke("Spawn", startDelay);
    }

    private void Spawn()
    {
        amountRemaining -= 1;

        Vector3 spawnPosition = transform.position + (Vector3)(Random.insideUnitCircle * circleRadius);
        GameObject instantiatedGameObject = Instantiate(summonedPrefab, spawnPosition, spawnRotated?transform.rotation:Quaternion.identity);
        BulletController bullet = instantiatedGameObject.GetComponent<BulletController>();
        if (bullet)
        {
            bullet.owner = controller.owner;
        }

        if (amountRemaining > 0)
        {
            Invoke("Spawn", interval);
        }
    }
}
