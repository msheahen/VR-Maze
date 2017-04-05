using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
    //Create a reference to the CoinPoofPrefab
	public GameObject coinPoof;

	public void Update(){
		transform.Rotate (0,10,0*Time.deltaTime); //rotates 50 degrees per second around z axis
	}

    public void OnCoinClicked() {
        // Instantiate the CoinPoof Prefab where this coin is located

		if (coinPoof) {
			Instantiate (coinPoof, transform.position, Quaternion.Euler (300, 0, 0));
		}
        // Make sure the poof animates vertically


        // Destroy this coin. Check the Unity documentation on how to use Destroy
		Destroy (gameObject, 0.2f);
    }

}
