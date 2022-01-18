using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class senggol : MonoBehaviour
{
  
void Update()
    {
        transform.Translate(Vector3.left*Time.deltaTime *25,Space.World);


    }


private void OnCollisionEnter2D(Collision2D other)
{

    if (other.gameObject.CompareTag("as")){
        // Destroy(gameObject);
        // print(" kena floor");
        gameObject.SetActive(false);


    }


}

}
