using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelOpener : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Panel;
    public float sec = 2f;
    private IEnumerator coroutine;
    public void OpenPanel(){
    	// if(Panel != null)
    	// {
    	// 	bool isActive = Panel.activeSelf;
    	// 	Panel.SetActive(!isActive);
    	// }
 
    	
         if (!Panel.activeInHierarchy){
             Panel.SetActive(true);
         }
 		StartCoroutine(LateCall());
         
     }
 
     IEnumerator LateCall()
     {
 
         yield return new WaitForSeconds(sec);
 
         Panel.SetActive(false);
         
     }
}
