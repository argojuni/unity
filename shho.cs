using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shho : MonoBehaviour
{
 
   public  GameObject rudal;
    public GameObject bulletposition;

     public float speed = 100f;
   
    

    // Update is called once per frame
    void Update()


    {
float translation = Input.GetAxis("Vertical")*speed ;

float translation2 = Input.GetAxis("Horizontal")*speed ;


        if (Input.GetButtonDown("Fire1")){
            fire();
        }

        
        transform.Translate(0, translation*Time.deltaTime, 0);

        transform.Translate(translation2*Time.deltaTime, 0, 0);
        




        
    }






 private void fire(){

// Instantiate(rudal,bulletposition.transform.position   ,Quaternion.identity);

GameObject bullet = obekctpool.instance.getpoolObject();

if(bullet!=null){
    bullet.transform.position = bulletposition.transform.position;
    bullet.transform.rotation = bulletposition.transform.rotation;
    bullet.SetActive(true);
}
 }


}
