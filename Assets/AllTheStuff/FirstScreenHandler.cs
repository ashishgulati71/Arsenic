using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FirstScreenHandler : MonoBehaviour {

	public GameObject OnlineImg;
	public GameObject OfflineImg;
	
	public GameObject InstructionsImageGO;
	bool Ins_visible;
	
	void Start(){
		Ins_visible = false;
		InstructionsImageGO.SetActive(false);
	}
	
	public void HelpButton(){
		
	}
	
	public void TapToScan(){
		Application.LoadLevel (1);
	}
	
	public void InstructionsTap(){
		if(!Ins_visible){
			InstructionsImageGO.SetActive(true);
		}else{
			InstructionsImageGO.SetActive(false);
		}
		Ins_visible = !Ins_visible;
	}
	
	
}
