using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PhotonComm : MonoBehaviour {

	// Create variables 
	private string particleURI = "https://api.particle.io/v1/devices/2f0021000547353138383138/setArm?access_token=6fe872f4848ab100432e84ba7f4f51341f9f0318";



	// Create coroutine
	IEnumerator SetArm()
	{
		WWWForm form = new WWWForm ();
		form.AddField ("leg", "Left");

		UnityWebRequest www = UnityWebRequest.Post (particleURI, form);
		yield return www.SendWebRequest ();

		if (www.isNetworkError || www.isHttpError) {
			Debug.Log (www.error);
		} else {
			Debug.Log ("Text upload complete!");
		}
	}
}