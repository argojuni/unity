using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obekctpool : MonoBehaviour
{
    public static obekctpool instance;

    private List<GameObject> pooledObjects = new List<GameObject>();
    private int amounttopool = 20;
    [SerializeField] private GameObject missileprefabs;
    // Start is called before the first frame update

    private void Awake(){
        if(instance == null){
            instance = this;
        }
    }

    void Start()
    {
        for(int i=0; i<amounttopool; i++){
            GameObject obj = Instantiate(missileprefabs);
            obj.SetActive(false);
            pooledObjects.Add(obj);
        }
    }

    public GameObject getpoolObject(){
        for (int i =0; i<pooledObjects.Count; i++){
            if(!pooledObjects[i].activeInHierarchy){
                return pooledObjects[i];
            }
        }
        return null;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
