using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject card;
    // Start is called before the first frame update
    void Start()
    {
         Vector3 cardPosition;
        for (int i =0;i<=9;i++){
           
             Instantiate(card,
                transform.position += Vector3.right* 2,
                transform.rotation);
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
