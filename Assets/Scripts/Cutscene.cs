using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cutscene : MonoBehaviour
{
    public GameObject mainPlayer;
    public GameObject sceneCam;
    public GameObject LampAnimation;
    public GameObject LampStatic;
    public GameObject LampSwing;
    public float movementX;
    public float movementY;
    public float movementZ;
    //public Transform player;
    
    private void OnTriggerEnter(Collider other)
    {
        

        sceneCam.SetActive(true);
        mainPlayer.SetActive(false);
        LampStatic.SetActive(false);
        LampAnimation.SetActive(true);
        LampSwing.SetActive(false);
        StartCoroutine(FinishCut());
    }

    IEnumerator FinishCut()
    {

        yield return new WaitForSeconds(5);
        this.gameObject.GetComponent<BoxCollider>().enabled = false;

        

        
        
        
        mainPlayer.SetActive(true);
        LampSwing.SetActive(true);
        mainPlayer.transform.position = new Vector3(sceneCam.transform.position.x, mainPlayer.transform.position.y, sceneCam.transform.position.z);
        LampStatic.SetActive(false);
        LampAnimation.SetActive(false);    
        sceneCam.SetActive(false);
    }
}
