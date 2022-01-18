using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public GameObject batu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

 if (Input.GetButtonDown("Fire1")){
            fire();
        }



 void fire(){

Instantiate(batu,transform.position,Quaternion.identity);

 }




    }
}
