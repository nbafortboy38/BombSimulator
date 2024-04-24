using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class UIButtons : MonoBehaviour
{

    [SerializeField] UnityEngine.UI.Button atomBomb;
    [SerializeField] UnityEngine.UI.Button hydrogrenBomb;
    public int buttonClicked;

    // Start is called before the first frame update
    void Start()
    {

    
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void AtomButton()
    {
        buttonClicked = 1;

    }

    public void HydrogenButton()
    {
        buttonClicked = 2;
    }

}


