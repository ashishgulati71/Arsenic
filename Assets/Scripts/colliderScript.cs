using UnityEngine;
using System.Collections;

public class colliderScript : MonoBehaviour {
	string subject;
	string body; 
	int value;
	void Update(){
		
		//StatUpdate();
		if(Input.GetMouseButtonDown(0)){
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			if(Physics.Raycast(ray, out hit, 100000.0f)){
				Debug.Log (hit.collider.name);
				PerformTheTask(hit.collider);
			}
		}
	}

		void PerformTheTask(Collider gridobject)
		{
			switch(gridobject.name){
		case "share" :ShareButton ();break;
		case "emoji1" :value=1;break;
		case "emoji2" :value=2;break;
		case "emoji3" :value=3;break;
		case "emoji4" :value=4;break;
		case "tweet1" :value=5;break;
		case "tweet2" :value=6;break;

		}
	}

		public void ShareButton(){
			AndroidJavaClass intentClass = new AndroidJavaClass ("android.content.Intent");
			AndroidJavaObject intentObject = new AndroidJavaObject ("android.content.Intent");
			intentObject.Call<AndroidJavaObject>("setAction", intentClass.GetStatic<string>("ACTION_SEND"));
			intentObject.Call<AndroidJavaObject>("setType", "text/plain");
			subject=" SEE THIS @ARSENIC";
			if(value==1)
			body="its nice,isnt it?";
		
		if(value==2)
			body="its crazy,isnt it?";
		
		if(value==3)
			body="its sad,isnt it?";
		
		if(value==4)
			body="its very bad,isnt it?";
		
		if(value==5)
			Application.OpenURL ("https://twitter.com/localdesktop/status/741862111157051393");

			intentObject.Call<AndroidJavaObject>("putExtra", intentClass.GetStatic<string>("EXTRA_SUBJECT"), subject);
			intentObject.Call<AndroidJavaObject>("putExtra", intentClass.GetStatic<string>("EXTRA_TEXT"), body);
			
			AndroidJavaClass unity = new AndroidJavaClass ("com.unity3d.player.UnityPlayer");
			AndroidJavaObject currentActivity = unity.GetStatic<AndroidJavaObject>("currentActivity");
			
			currentActivity.Call ("startActivity", intentObject);
		}

	}

