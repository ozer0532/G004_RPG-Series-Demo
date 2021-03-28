using UnityEngine;

public class SkillTeleportToDirection : SkillSpawnBase
{
    public Vector3 direction;

    private Transform owner;

    private void Awake()
    {
        owner = GetComponent<SkillController>().owner.transform;
    }

    public void OnSkillUse()
    {
        Vector3 rotatedDirection = transform.TransformVector(direction);
        owner.Translate(rotatedDirection);
    }
}
