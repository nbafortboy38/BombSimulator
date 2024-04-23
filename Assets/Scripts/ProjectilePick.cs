using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.VisualScripting;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEditor;
using UnityEditor.Experimental.Rendering;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using TMPro;
using System.Threading.Tasks;

public class ProjectilePick : MonoBehaviour
{

    GameObject buttonManager;
 
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {

    }

    void Start()
    {
        buttonManager = GameObject.FindWithTag("ButtonManager");
        buttonManager.SetActive(false);

    }

    public void OnClick()
    {
        buttonManager.SetActive(true);


    }

}
