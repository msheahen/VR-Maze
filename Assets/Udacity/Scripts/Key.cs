using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
    //Create a reference to the KeyPoofPrefab and Door
	public GameObject keyPoof;
	public Door door;
	public bool collected;

	void Update()
	{
		//Not required, but for fun why not try adding a Key Floating Animation here :)
		transform.position = new Vector3(transform.position.x, Mathf.Sin(Time.time * 0.75f)+2, transform.position.z);
	}

	public void OnKeyClicked()
	{
		// Instatiate the KeyPoof Prefab where this key is located
		// Make sure the poof animates vertically
		if (keyPoof) {
			Instantiate (keyPoof, transform.position, Quaternion.Euler (300, 0, 0));
		}

		// Call the Unlock() method on the Door
		// Set the Key Collected Variable to true
		door.Unlock();

		// Destroy the key. Check the Unity documentation on how to use Destroy
		Destroy (gameObject, 0.2f);

	}
}
