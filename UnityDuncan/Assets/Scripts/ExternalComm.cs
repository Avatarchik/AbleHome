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
//		WWWForm form = new WWWForm();
//		form.AddField( "leg", "Left" );
//
//		UnityWebRequest www = UnityWebRequest.Post(particleURI, form);
//		yield return www.SendWebRequest();
//
//		if(www.isNetworkError || www.isHttpError) {
//			Debug.Log(www.error);
//		}
//		else {
//			Debug.Log("Text upload complete!");
//		}



		AmazonLambdaConfig config = new AmazonLambdaConfig() { RegionEndpoint = RegionEndpoint.APSouth1};
		AmazonLambdaClient client = new AmazonLambdaClient("AccKey", "SecKey", config);
		InvokeRequest request = new InvokeRequest() { FunctionName = "FuncName" };
		InvokeResponse response = client.Invoke(request);
		if (null != response && response.StatusCode == 200)
		{
			var sr = new StreamReader(response.Payload);
			string result = sr.ReadToEnd();
		}
	}

	void Start()
	{
		// Start coroutine to get Particle light data 
		StartCoroutine(SetArm());
	}
}