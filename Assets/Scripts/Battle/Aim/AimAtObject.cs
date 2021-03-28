using UnityEngine;

public class AimAtObject : SkillAimBase
{
    public Transform aimTarget;
    public float rotationalOffset;  // 0 = facing right; 90 = facing up; -90 = facing down; etc..

    private void FixedUpdate()
    {
        Aim();
    }

    private void Aim()
    {
        Vector2 aimDirection = aimTarget.position - transform.position;

        float aimRotation = Vector2.SignedAngle(Vector2.right, aimDirection);

        // Rotate transform towards aim direction + offset
        transform.eulerAngles = new Vector3(0, 0, aimRotation + rotationalOffset);
    }
}
