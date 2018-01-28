using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;

public class AOpening : MonoBehaviour {

	public GameObject thePlayer;
	public GameObject fadeScreenIn;
	public GameObject textBox;

	void Start () {
		thePlayer.GetComponent<FirstPersonController> ().enabled = false;
		StartCoroutine (ScenePlayer ());
	}

	IEnumerator ScenePlayer () {
		yield return new WaitForSeconds (1.5f);
		fadeScreenIn.SetActive (false);
		textBox.GetComponent<Text> ().text = "I need to get out of here.";

		yield return new WaitForSeconds (2f);
		textBox.GetComponent<Text> ().text = "";
		thePlayer.GetComponent<FirstPersonController> ().enabled = true;
	}

} // AOpening