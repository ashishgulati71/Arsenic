using UnityEngine;
using System.Collections;

public class testt : MonoBehaviour {
	string body,subject;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public void ShareButton(){
		AndroidJavaClass intentClass = new AndroidJavaClass ("android.content.Intent");
		AndroidJavaObject intentObject = new AndroidJavaObject ("android.content.Intent");
		intentObject.Call<AndroidJavaObject>("setAction", intentClass.GetStatic<string>("ACTION_SEND"));
		intentObject.Call<AndroidJavaObject>("setType", "text/plain");
		subject=" SEE THIS @ARSENIC";
		body="https://twitter.com/localdesktop/status/741862111157051393";
		
		intentObject.Call<AndroidJavaObject>("putExtra", intentClass.GetStatic<string>("EXTRA_SUBJECT"), subject);
		intentObject.Call<AndroidJavaObject>("putExtra", intentClass.GetStatic<string>("EXTRA_TEXT"), body);
		
		AndroidJavaClass unity = new AndroidJavaClass ("com.unity3d.player.UnityPlayer");
		AndroidJavaObject currentActivity = unity.GetStatic<AndroidJavaObject>("currentActivity");
		
		currentActivity.Call ("startActivity", intentObject);
	}
}
