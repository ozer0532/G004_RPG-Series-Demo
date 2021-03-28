using UnityEngine;

public class OffsetPositionOnAwake : MonoBehaviour
{
    public Space relativeTo = Space.World;
    public Vector3 offset;

    private void Awake()
    {
        transform.Translate(offset, relativeTo);
    }
}
