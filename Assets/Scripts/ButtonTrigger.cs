using UnityEngine;
using UnityEngine.Events;

public class ButtonTrigger : MonoBehaviour
{
    public UnityEvent onEnter;
    public UnityEvent onExit;

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.GetComponent<TopdownCharacter>()) {
            onEnter.Invoke();
        }
    }

    private void OnTriggerExit2D(Collider2D collision) {
        if (collision.GetComponent<TopdownCharacter>()) {
            onExit.Invoke();
        }
    }
}
