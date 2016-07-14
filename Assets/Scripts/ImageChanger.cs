using UnityEngine;
using System.Collections;
using Vuforia;

public class ImageChanger : MonoBehaviour {
	public Texture[] myTextures = new Texture[6];
	int arrayPos=0;
	int x=1	;
	public AudioClip sound;
	AudioSource audio;
	public GameObject quad;

//	private TrackableBehaviour ImageTarget;

	// Use this for initialization
	void Start () {
		audio=GetComponent<AudioSource>();
//		Debug.Log (ImageTarget.name);

	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log(Time.time);
		if(x==0)	
			StartCoroutine(Changer());

		if(arrayPos==6){
			Application.LoadLevel(Application.loadedLevel);
		}
	}

IEnumerator Changer(){
		x=1;
		//yield return new WaitForSeconds(6);
		renderer.material.mainTexture = myTextures[arrayPos];
		arrayPos++;
		yield return new WaitForSeconds(5);
		x=0;

}
	public void buttonpresed(){

		//quad.SetActive(true);
		audio.PlayOneShot (sound,1.0f);
		x=0;
	//	Debug.Log (y);
		//quad.SetActive(true);
	}
}
