using UnityEngine;

public class ScaleWithTime2 : MonoBehaviour
{
    public float scalingRate;

    private void FixedUpdate()
    {
        transform.localScale += Vector3.one * scalingRate * Time.deltaTime; 
    }
}
