using UnityEngine;

public class AimTowardsMouse : SkillAimBase2
{
    private void Update()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 aimDirection = mousePosition - transform.position;

        float angle = Vector2.SignedAngle(Vector2.right, aimDirection);
        transform.eulerAngles = new Vector3(0, 0, angle);
    }
}
