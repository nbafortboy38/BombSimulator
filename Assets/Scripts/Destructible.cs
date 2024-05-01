using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructible : MonoBehaviour
{

    public GameObject destroyedVersion;
    public Vector3 offSet;
    
    
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Debug.Log("hello");
        Instantiate(destroyedVersion, transform.position+offSet, transform.rotation);
    }



}
