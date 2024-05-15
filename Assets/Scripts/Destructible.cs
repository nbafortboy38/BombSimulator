using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Destructible : MonoBehaviour
{

    public GameObject destroyedVersion;
    public Vector3 offSet;
    public ParticleSystem part;

    public void Start()
    {
        part = GameObject.FindGameObjectWithTag("shockwave").GetComponent<ParticleSystem>();
    }

    public void BreakBuildings()
    {
        Instantiate(destroyedVersion, transform.position+offSet, transform.rotation);
        Destroy(gameObject);
    }

    public void OnParticleCollision(GameObject other)
    {
        Debug.Log("particles connected");
        BreakBuildings();
    }

}
