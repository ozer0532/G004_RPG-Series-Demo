using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Rigidbody2D), typeof(Animator))]
public class TopdownCharacter : MonoBehaviour
{
    public float moveSpeed = 5;                                     // Revealing the move speed to the inspector
    public float interactRange;                                     // The range at which the player can interact with

    public static TopdownCharacter instance;

    private Vector2 direction = Vector2.down;                       // Makes down as the default direction

    private Rigidbody2D rb;
    private Animator anim;

    // Start is called before the first frame update
    void Start() {
        rb = GetComponent<Rigidbody2D>();                           // Getting the Rigidbody2D component
        anim = GetComponent<Animator>();

        instance = this;
    }

    private void Update() {
        // Interact button
        if (Input.GetMouseButtonDown(1))
        {
            // Get the mouse position in world coordinates
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            // Check if the mouse is within the player's reach
            if (Vector2.Distance(transform.position, mousePosition) < interactRange)
            {        
                // Check if an interactible was clicked
                InteractTrigger trigger = Physics2D.OverlapPoint(mousePosition)?.GetComponent<InteractTrigger>();
                if (trigger)
                {
                    trigger.Trigger();                              // Run the trigger
                }
            }
        }
    }

    // FixedUpdate is called once per fixed framerate frame
    void FixedUpdate() {
        // Getting input
        float xInput = Input.GetAxisRaw("Horizontal");              // Getting the raw horizontal input to make the movement more snappy
        float yInput = Input.GetAxisRaw("Vertical");                // Getting the raw vertical input to make the movement more snappy
        Vector2 moveInput = new Vector2(xInput, yInput).normalized; // Using the normalized input to make sure the player speed doesn't exceed its move speed

        // Change the player's velocity
        rb.velocity = moveInput * moveSpeed;                        // Setting the player's velocity

        if (moveInput != Vector2.zero) {
			direction = moveInput;
			PlayAnimation("Run", direction);
		} else {
			PlayAnimation("Idle", direction);
		}
    }

    // Plays the animation: animation_direction
    private void PlayAnimation(string animation, Vector2 direction) {
        // It takes two inputs, the animation and the direction.
        // For example, if we want to play and 'Idle' animation
        // facing the 'SE' (South-East) direction, we are basically
        // playing the 'Idle_SE' animation of the character

        // Get the direction of the character in angles, comparing the up direction
		float angle = Vector2.SignedAngle(Vector2.up, direction);
		
		// Get the closest cardinal (and intermediate) directions
		string directionName;
		if (angle < -157.5) {
		  directionName = "S";
		} else if (angle < -112.5) {
		  directionName = "SE";
		} else if (angle < -67.5) {
		  directionName = "E";
		} else if (angle < -22.5) {
		  directionName = "NE";
		} else if (angle < 22.5) {
		  directionName = "N";
		} else if (angle < 67.5) {
		  directionName  = "NW";
		} else if (angle < 112.5) {
		  directionName = "W";
		} else if (angle < 157.5) {
		  directionName = "SW";
		} else {
		  directionName = "S";
		}

        anim.Play(animation + "_" + directionName);
    }
}