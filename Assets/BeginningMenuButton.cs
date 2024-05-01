using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BeginningMenuButton : MonoBehaviour
{

    [SerializeField] Button beginningMenuButton;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    public void TaskOnClick()
    {
        SceneManager.LoadScene("SampleScene--Level Design");
    }
}
