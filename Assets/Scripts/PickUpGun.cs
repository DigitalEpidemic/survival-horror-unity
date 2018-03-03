using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpGun : MonoBehaviour {

	public float theDistance;
	public GameObject actionDisplay;
	public GameObject actionText;
	public GameObject fakeGun;
	public GameObject realGun;
	public GameObject extraCross;
	public GameObject guideArrow;

	void Update () {
		theDistance = PlayerCasting.distanceFromTarget;
	}

	void OnMouseOver () {
		if (theDistance <= 2) {
			extraCross.SetActive (true);
			actionText.GetComponent<Text> ().text = "Pick up gun";
			actionDisplay.SetActive (true);
			actionText.SetActive (true);
		}

		if (Input.GetButtonDown ("Action")) {
			if (theDistance <= 2) {
				this.GetComponent<BoxCollider> ().enabled = false;
				actionDisplay.SetActive (false);
				actionText.SetActive (false);
				fakeGun.SetActive (false);
				realGun.SetActive (true);
				guideArrow.SetActive (false);
			}
		}
	}

	void OnMouseExit () {
		extraCross.SetActive (false);
		actionDisplay.SetActive (false);
		actionText.SetActive (false);
	}

} // DoorCellOpen