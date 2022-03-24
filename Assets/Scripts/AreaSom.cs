using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaSom : MonoBehaviour
{
    // Start is called before the first frame update
    private BoxCollider[] coliders;
    public AudioClip Audio;
    void Start()
    {
        coliders = GetComponentsInChildren<BoxCollider>();
        GetComponent<AudioSource>().clip = Audio;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        GetComponent<AudioSource>().PlayOneShot(GetComponent<AudioSource>().clip);
        foreach(BoxCollider Box in coliders)
        {
            
            Box.enabled = false;
        }
    }
}
