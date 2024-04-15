using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[SerializeField] GameObject[] projectilePrefab;

public class ProjectileSpawn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public OnButtonClick(Start)
    {

        
        int projectilePick = Random.Range(0, 6);
        Instantiate(projectilePrefab[projectilePick], Quaternion.identity));

    }


}
