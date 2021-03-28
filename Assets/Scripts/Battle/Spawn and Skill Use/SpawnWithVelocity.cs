using UnityEngine;

public class SpawnWithVelocity : SkillSpawnBase
{
    public GameObject spawnablePrefab;
    public float rotationalOffset;

    public Transform spawnOrigin;
    public float speed;
    public bool spawnRotated = true;

    public void OnSkillUse()
    {
        Quaternion rotation;
        if (spawnRotated)
        {
            rotation = Quaternion.Euler(0, 0, transform.eulerAngles.z + rotationalOffset);
        }
        else
        {
            rotation = Quaternion.identity;
        }
        GameObject spawnedObject = Instantiate(spawnablePrefab, spawnOrigin.position, rotation);
        AddOwner(spawnedObject);

        Rigidbody2D rb2d = spawnedObject.GetComponent<Rigidbody2D>();
        if (rb2d)
        {
            rb2d.velocity = transform.right * speed;
        }
    }
}
