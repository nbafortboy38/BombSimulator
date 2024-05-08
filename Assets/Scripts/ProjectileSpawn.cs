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

    [SerializeField] GameObject projectileSpawn;
    [SerializeField] GameObject atomBombPrefab;
    [SerializeField] GameObject hydrogenBombPrefab;
    [SerializeField] Button start;
    public int buttonClicked;
    [SerializeField] UIButtons uiButtonsScript;
    public bool bombDropped = false;
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



    public void TaskOnClick()
    {

        int projectileChosen = uiButtonsScript.buttonClicked;

        if (projectileChosen == 1)
        {
            Instantiate(atomBombPrefab, projectileSpawn.transform.position, Quaternion.identity);
        }

        if (projectileChosen == 2)
        {
            Instantiate(hydrogenBombPrefab, projectileSpawn.transform.position, Quaternion.identity);

        }

        bombDropped = true;

    }


}
