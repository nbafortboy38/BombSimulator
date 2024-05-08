
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionSounds : MonoBehaviour
{

    public bool bombDropped;
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip bombDrop;
    [SerializeField] AudioClip bombExplosion;
    [SerializeField] int waitTime = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bombDropped = GameObject.Find("Start").GetComponent<ProjectileSpawn>().bombDropped;

        if (bombDropped == true)
        {
            audioSource.PlayOneShot(bombDrop);
            StartCoroutine("SoundDelay");
            
            audioSource.PlayOneShot(bombExplosion);
        }
    }


    IEnumerator SoundDelay()
    {
        
        yield return new WaitForSeconds(waitTime);
    }

}
