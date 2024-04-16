using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.VisualScripting;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEditor;
using UnityEditor.Experimental.Rendering;
using UnityEngine;
using UnityEngine.UI;

public class ProjectileSpawn : MonoBehaviour
{
    [SerializeField] GameObject[] projectilePrefab;
    [SerializeField] GameObject projectileSpawn;
    [SerializeField] Dropdown projectileSelector;
    [SerializeField] Button start;
    int projectileChosen;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = start.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void projectilePick()
    {
        if (projectileSelector.value==1)
        {
            projectileChosen = 1;
        }

        if (projectileSelector.value == 2)
        {
            projectileChosen = 2;
        }

        if (projectileSelector.value == 3)
        {
            projectileChosen = 3;
        }




    }

    void TaskOnClick()
    {
        if (projectileChosen == 1)
        {
            Instantiate(projectilePrefab[1], projectileSpawn.transform.position, Quaternion.identity);
        }

        if (projectileChosen == 2)
        {
            Instantiate(projectilePrefab[2], projectileSpawn.transform.position, Quaternion.identity);
        }

        if (projectileChosen == 3)
        {
            Instantiate(projectilePrefab[3], projectileSpawn.transform.position, Quaternion.identity);
        }



    }


}
