using UnityEngine;

public class SpawnAtCursor : SkillSpawnBase
{
    public GameObject spawnablePrefab;
    public float rotationalOffset;
    public bool spawnRotated = false;

    public void OnSkillUse()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Quaternion rotation;
        if (spawnRotated)
        {
            rotation = Quaternion.Euler(0, 0, transform.eulerAngles.z + rotationalOffset);
        }
        else
        {
            rotation = Quaternion.identity;
        }

        GameObject spawnedObject = Instantiate(spawnablePrefab, mousePosition, rotation);
        AddOwner(spawnedObject);
    }
}
