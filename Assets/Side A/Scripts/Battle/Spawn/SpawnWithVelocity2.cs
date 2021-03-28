using UnityEngine;

public class SpawnWithVelocity2 : SkillSpawnBase2
{
    public GameObject prefab;
    public Transform spawnPosition;
    public float speed;

    private void OnSkillUse()
    {
        GameObject spawnedObject = Instantiate(prefab, spawnPosition.position, spawnPosition.rotation);
        AddOwner(spawnedObject);

        Rigidbody2D rb2d = spawnedObject.GetComponent<Rigidbody2D>();
        if (rb2d)
        {
            rb2d.velocity = spawnPosition.right * speed;
        }
    }
}
