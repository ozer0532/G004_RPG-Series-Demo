using UnityEngine;

public class AIAnimationData : MonoBehaviour
{
	public Animator anim;
	public string currentAnimation { get; private set; } = "Idle";
	public Vector2 currentDirection { get; private set; } = Vector2.down;
	public Vector2 currentDirectionSnapped { get; private set; } = Vector2.down;
	public string currentDirectionName { get; private set; } = "S";
	public float currentAngle { get; private set; } = 180;

	public void PlayAnimation(string animation)
    {
		currentAnimation = animation;
		anim.Play(animation + "_" + currentDirectionName);
	}

	public void PlayAnimation(Vector2 direction)
    {
		PlayAnimation(currentAnimation, direction);
    }

	public void PlayAnimation(string animation, Vector2 direction) {
		// It takes two inputs, the animation and the direction.
		// For example, if we want to play and 'Idle' animation
		// facing the 'SE' (South-East) direction, we are basically
		// playing the 'Idle_SE' animation of the character

		currentAnimation = animation;
		currentDirection = direction;

		// Get the direction of the character in angles, comparing the up direction
		currentAngle = Vector2.SignedAngle(Vector2.up, direction);
		
		// Get the closest cardinal (and intermediate) directions
		if (currentAngle < -157.5) {
		  currentDirectionName = "S";
		  currentDirectionSnapped = Vector2.down;
		} else if (currentAngle < -112.5) {
		  currentDirectionName = "SE";
		  currentDirectionSnapped = new Vector2(1, -1);
		} else if (currentAngle < -67.5) {
		  currentDirectionName = "E";
		  currentDirectionSnapped = Vector2.right;
		} else if (currentAngle < -22.5) {
		  currentDirectionName = "NE";
		  currentDirectionSnapped = new Vector2(1, 1);
		} else if (currentAngle < 22.5) {
		  currentDirectionName = "N";
		  currentDirectionSnapped = Vector2.up;
		} else if (currentAngle < 67.5) {
		  currentDirectionName  = "NW";
		  currentDirectionSnapped = new Vector2(-1, 1);
		} else if (currentAngle < 112.5) {
		  currentDirectionName = "W";
		  currentDirectionSnapped = Vector2.left;
		} else if (currentAngle < 157.5) {
		  currentDirectionName = "SW";
		  currentDirectionSnapped = new Vector2(-1, -1);
		} else {
		  currentDirectionName = "S";
		  currentDirectionSnapped = Vector2.down;
		}

        anim.Play(animation + "_" + currentDirectionName);
    }
}
