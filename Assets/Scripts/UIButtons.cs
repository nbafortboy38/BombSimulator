using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class UIButtons : MonoBehaviour
{

    [SerializeField] UnityEngine.UI.Button atomBomb;
    [SerializeField] UnityEngine.UI.Button hydrogrenBomb;
    bool atomButtonEnabled = false;
    bool hydrogenButtonEnabled = false;


    // Start is called before the first frame update
    void Start()
    {

    
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnEnable()
    {
      
    }
}


