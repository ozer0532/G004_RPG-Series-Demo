using UnityEngine;
using UnityEngine.Events;

public class DelayTrigger : MonoBehaviour
{
    public bool oneTimerOnly;
    public UnityEvent onTrigger;

    private bool running;

    public void Trigger(float delay)
    {
        if (!oneTimerOnly || !running)
        {
            running = true;
            Invoke("RunEvent", delay);
        }
    }

    private void RunEvent()
    {
        onTrigger.Invoke();
        running = false;
    }
}
