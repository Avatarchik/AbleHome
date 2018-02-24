using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PhotonComm : MonoBehaviour {

	// Create variables 
//	private int lightValue;
//	private float remappedValue;
//	private string lightValString;
	private string particleURI = "https://api.particle.io/v1/devices/2f0021000547353138383138/setArm?access_token=6fe872f4848ab100432e84ba7f4f51341f9f0318";
//	private Transform cubeTransform;
//	private Vector3 tempScale;




	// Create coroutine
	IEnumerator SetArm()
	{
//		List<IMultipartFormSection> formData = new List<IMultipartFormSection>();
//		formData.Add( new MultipartFormDataSection("field1=foo&field2=bar") );
//		formData.Add( new MultipartFormFileSection("my file data", "myfile.txt") );

		WWWForm form = new WWWForm();
		form.AddField( "leg", "Left" );

		UnityWebRequest www = UnityWebRequest.Post(particleURI, form);
		yield return www.SendWebRequest();

		if(www.isNetworkError || www.isHttpError) {
			Debug.Log(www.error);
		}
		else {
			Debug.Log("Text upload complete!");
		}




		// This while loop will repeat as long as our application runs
//		while (true)
//		{
//			// Assign the URI to a variable so that it's easier to handle
//			particleURI = "https://api.particle.io/v1/devices/2f0021000547353138383138/setArm?access_token=6fe872f4848ab100432e84ba7f4f51341f9f0318";
//			UnityWebRequest www = UnityWebRequest.Post(particleURI, "Left");
//			yield return www.SendWebRequest();
////			yield return new WaitForSeconds(1);
//		}

	}

	void Start()
	{
		// Start coroutine to get Particle light data 
		StartCoroutine(SetArm());
	}
}