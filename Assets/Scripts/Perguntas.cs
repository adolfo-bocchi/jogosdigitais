using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Perguntas : MonoBehaviour
{
    public bool notPergunta = true;
    public Text texto;
    private GameObject jogador;
    private GameObject gate;
    
    private string correta;
    private string[] resp;

    [Range(0.1f, 20f)] public float distancia = 3f;

    List<string> perguntas = new List<string>() 
    { 
        "qual a capital da ucrania?", 
        "Quanto é 2 + 2?", 
        "Qual a cor da camisa do cebolinha?" 
    };
    List<string[]> respostas = new List<string[]>() 
    { 
        new string[] { "mariupol", "kiev" },
        new string[] { "4", "3" },
        new string[] { "amarelo", "verde" },
    };
    
    List<string> corretas = new List<string>()
    {
        "kiev",
        "4",
        "verde"
    };
    // Start is called before the first frame update
    void Start()
    {
        texto.enabled = false;
        jogador = GameObject.FindGameObjectWithTag("Player");
        gate = GameObject.FindGameObjectWithTag("Gate");
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position, jogador.transform.position) < distancia)
        {
            //random pergunta
            if (notPergunta)
                geraPergunta();
            texto.enabled = true;
            if (Input.GetKey(KeyCode.Alpha0))
            {
                Debug.Log("cliquei no 0");
                if(resp[0].Equals(correta))
                {
                    //abre o portao
                    gate.GetComponent<Gate>().Abrir();
                    Debug.Log("cliquei no 0 - abre o portao");
                }
            }
            if (Input.GetKey(KeyCode.Alpha1))
            {
                Debug.Log("cliquei no 1");
                if (resp[1].Equals(correta))
                {
                    //abre o portao
                    gate.GetComponent<Gate>().Abrir();
                    Debug.Log("cliquei no 1 - abre o portao");
                }
            }


        } else
        {
            texto.enabled= false;
            notPergunta=true;
        }

        //getkey validar a resposta como abre o portao

    }

    public void  geraPergunta()
    {
        int pos = Random.Range(0, perguntas.Count);
        string pergunta = perguntas[pos];
        resp = respostas[pos];
        correta = corretas[pos];

        string frase = pergunta + "\n";
        for (int i = 0; i < resp.Length; i++)
        {
            frase += "( " + i + " ) -" + resp[i] + "\n";
        }
        texto.text = frase;
        Debug.Log(frase);
        notPergunta = false;
    }
}
