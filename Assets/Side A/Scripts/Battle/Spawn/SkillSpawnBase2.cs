using UnityEngine;

public abstract class SkillSpawnBase2 : MonoBehaviour
{
    protected void AddOwner(GameObject spawnedObject)
    {
        BulletController2 bullet = spawnedObject.GetComponent<BulletController2>();
        if (bullet)
        {
            bullet.owner = GetComponent<SkillController2>().owner;
        }
    }
}
