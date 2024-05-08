using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasOff : MonoBehaviour
{


    [SerializeField] Canvas fadeCanvas;
    [SerializeField] float alpha;



    // Start is called before the first frame update
    void Start()
    {
        

        
    }

    // Update is called once per frame
    void Update()
    {
        alpha = fadeCanvas.GetComponent<CanvasGroup>().alpha;

        if (fadeCanvas.GetComponent<CanvasGroup>().alpha == 0)
        {
            GameObject.FindGameObjectWithTag("FadeCanvas").SetActive(false);

        }
    }
}
