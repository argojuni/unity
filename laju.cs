using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laju : MonoBehaviour
{
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left*Time.deltaTime *15,Space.World);


    }


    private void OnCollisionEnter2D(Collision2D other)
{

    if (other.gameObject.CompareTag("as")){
        Destroy(gameObject);
        print(" kena meteor");


    }

}


    
}





