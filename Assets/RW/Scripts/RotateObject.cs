using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public GameObject objectRotate;
	public float rotatespeed = 50f;
	bool rotatestatus = false;

	public void rotatear(){
		if(rotatestatus == false)	{
			rotatestatus = true;
		}
		else{
			rotatestatus = false;
		}
	}

	void Update(){
		if(rotatestatus == true){
			objectRotate.transform.Rotate(Vector3.up, rotatespeed * Time.deltaTime);
		}
	}
}