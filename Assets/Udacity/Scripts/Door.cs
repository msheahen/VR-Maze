using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
    // Create a boolean value called "locked" that can be checked in OnDoorClicked() 
    // Create a boolean value called "opening" that can be checked in Update() 
	public bool locked = true;
	public bool opening = false;
	public AudioSource doorOpened;
	public AudioSource doorLocked;


    void Update() {
        // If the door is opening and it is not fully raised
		if (opening) {
			// Then shift the door up
			if (transform.position.y < 20f) {
				// Animate the door raising up for as long as it is below 20 units

				transform.Translate (0, 3.5f * Time.deltaTime, 0, Space.World);
				// Animate the door raising up 3.5 units per second
				locked = false;
				// Door is not locked anymore.
			}
		}
           
    }

    public void OnDoorClicked() {
        // If the door is clicked and unlocked
		if (!locked) {
			// Set the "opening" boolean to true
			doorOpened.Play();
			opening = true;
		} else {
			doorLocked.Play();
		}

        // (optionally) Else
            // Play a sound to indicate the door is locked
    }

    public void Unlock()
    {
        // You'll need to set "locked" to false here
		locked = false;
    }
}
