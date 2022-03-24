using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator animator;

    private AudioSource somEfeito;
    void Start()
    {
        somEfeito = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!Input.GetKey(KeyCode.Space))
            return;
        
    }

    public void caminho()
    {
        Debug.Log("Caminho");
        somEfeito.Play();
    }

    public void Abrir()
    {
        animator.SetTrigger("Open");
    }
}
