using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructible : MonoBehaviour
{

    public GameObject destroyedVersion;
    public Vector3 offSet;
    
    
    public void Destroy()
    {
        Instantiate(destroyedVersion, transform.position+offSet, transform.rotation);
        Destroy(gameObject);
    }
    


}
