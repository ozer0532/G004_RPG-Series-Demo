using UnityEngine;

public class ScaleWithTime : MonoBehaviour
{
    public float scalingRate;

    private void FixedUpdate()
    {
        transform.localScale += Vector3.one * scalingRate * Time.deltaTime;
    }
}
