using UnityEngine;
using System.Collections;

public class ControlScript : MonoBehaviour {

	public GUIText SelectionText;

	public GUIText FirstOption;
	public GUIText SecondOption;
	public GUIText ThirdOption;
	public GUIText FourthOption;
	public GUIText FifthOption;


	private float offset = 0.5f;

	private bool arrowKeyDown = false;
	private bool returnKeyDown = false;



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//Check Uparrow to select items
		if (Input.GetKeyDown (KeyCode.UpArrow)) 
		{
			if(!arrowKeyDown){
			Vector3 tempVector = transform.position;
				if ((tempVector.y + offset) > 0)
				{
					//do nothing
				}
				else{
			tempVector.y = tempVector.y + offset;
			transform.position = tempVector;
				arrowKeyDown = true;
				}
			}

		}
		//Check Downarrow to select items
		if (Input.GetKeyDown (KeyCode.DownArrow)) 
		{
			if(!arrowKeyDown){
				Vector3 tempVector = transform.position;
					if ((tempVector.y - offset) < -2f)
					{
						//do nothing
					}
					else{
				tempVector.y = tempVector.y - offset;
				transform.position = tempVector;
				arrowKeyDown = true;
				}
			}

		}
		if (Input.GetKeyDown (KeyCode.Return)) 
		{
			if(!returnKeyDown){
				SelectionText.text = getSelection();
				returnKeyDown = true;
			}
		}
		if (Input.GetKeyUp (KeyCode.DownArrow)) 
		{
			if(arrowKeyDown){
				arrowKeyDown = false;
			}
			
		}
		if (Input.GetKeyUp (KeyCode.UpArrow)) 
		{
			if(arrowKeyDown){
				arrowKeyDown = false;
			}
			
		}
		if (Input.GetKeyUp (KeyCode.Return)) 
		{
			if(returnKeyDown){
				returnKeyDown = false;
			}
			
		}

	}

	string getSelection()
	{
		if (transform.position.y == 0f) {
			return FirstOption.text;
				}else
		{
			if (transform.position.y == -0.5f) {
				return SecondOption.text;
			}else
			{
				if (transform.position.y == -1f) {
					return ThirdOption.text;
				}else
				{
					if (transform.position.y == -1.5f) {
						return FourthOption.text;
					}else
					{
						if (transform.position.y == -2f) {
							return FifthOption.text;
						}}}}}
		return transform.position.y.ToString();
	}

	// Catches Keypresses on the Keyboard and moves the selector
//	void OnGUI() {
//		var e = Event.current;
//		if (e.isKey) {
//			if (e.keyCode == KeyCode.DownArrow)
//			{
//				Vector3 tempVector = transform.position;
//				tempVector.y = tempVector.y - offset;
//				transform.position = tempVector;
//			}
//			if (e.keyCode == KeyCode.UpArrow)
//			{
//				Vector3 tempVector = transform.position;
//				tempVector.y = tempVector.y + offset;
//				transform.position = tempVector;
//			}
//			if (e.keyCode == KeyCode.S)
//			{
//				debugtext.text = "Pressed Down";
//				Vector3 tempVector = transform.position;
//				tempVector.y = tempVector.y - offset;
//				transform.position = tempVector;
//			}
//			if (e.keyCode == KeyCode.W)
//			{
//				debugtext.text = "Pressed Up";
//				Vector3 tempVector = transform.position;
//				tempVector.y = tempVector.y + offset;
//				transform.position = tempVector;
//			}
//
//		}
//	}
}
