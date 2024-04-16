using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class UIButtons : MonoBehaviour
{

    [SerializeField] public Button menu;
    [SerializeField] public Button projectileDropdown;
    [SerializeField] public Canvas canvas;

    // Start is called before the first frame update
    void Start()
    {

    
     

        Button btn = menu.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TaskOnClick()
    {

    }

}
