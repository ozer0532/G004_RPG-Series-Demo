using UnityEngine;

[RequireComponent(typeof(SkillController))]
public abstract class SkillSpawnBase : MonoBehaviour
{
    protected void AddOwner(GameObject spawnedObject)
    {
        BulletController controller = spawnedObject.GetComponent<BulletController>();
        if (controller)
        {
            controller.owner = GetComponent<SkillController>().owner;
        }
    }
}
