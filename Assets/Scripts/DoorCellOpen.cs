using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorCellOpen : MonoBehaviour {

	public float theDistance;
	public GameObject actionDisplay;
	public GameObject actionText;
	public GameObject theDoor;
	public AudioSource creakSound;
	public GameObject extraCross;

	void Update () {
		theDistance = PlayerCasting.distanceFromTarget;
	}

	void OnMouseOver () {
		if (theDistance <= 2) {
			extraCross.SetActive (true);
			actionDisplay.SetActive (true);
			actionText.SetActive (true);
		}

		if (Input.GetButtonDown ("Action")) {
			if (theDistance <= 2) {
				this.GetComponent<BoxCollider> ().enabled = false;
				actionDisplay.SetActive (false);
				actionText.SetActive (false);
				theDoor.GetComponent<Animation> ().Play ("FirstDoorOpenAnim");
				creakSound.Play ();
			}
		}
	}

	void OnMouseExit () {
		extraCross.SetActive (false);
		actionDisplay.SetActive (false);
		actionText.SetActive (false);
	}

} // DoorCellOpen