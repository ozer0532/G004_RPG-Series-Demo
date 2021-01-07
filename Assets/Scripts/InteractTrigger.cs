using UnityEngine;
using UnityEngine.Events;

public class InteractTrigger : MonoBehaviour
{
    public UnityEvent onTrigger;
    
    public void Trigger() {
        onTrigger.Invoke();
    }
}
