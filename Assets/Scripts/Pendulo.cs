using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pendulo : MonoBehaviour
{
    [Range(-360.0f,360.0f)] public float angulo = 90f;

    [Range(0.0f, 20f)] public float velocidade = 2.0f;

    [Range(0.0f, 30f)] public float tempoInicio = 0.0f;

    Quaternion inicio, fim;

    // Start is called before the first frame update
    void Start()
    {
        inicio = PenduloRotacao(angulo);
        fim = PenduloRotacao(-angulo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        tempoInicio += Time.deltaTime;
        transform.rotation = Quaternion.Lerp(inicio, fim, (Mathf.Sin(tempoInicio * velocidade + Mathf.PI / 2) + 1.0f) / 2.0f);
    }

    Quaternion PenduloRotacao(float angulo)
    {
        var penduloRotacao = transform.rotation;
        var angulo2 = penduloRotacao.eulerAngles.x + angulo;
        if (angulo2 > 360)
            angulo2 -= 360;
        else if (angulo2 < -360)
            angulo2 += 360;

        penduloRotacao.eulerAngles = new Vector3(angulo2, penduloRotacao.eulerAngles.y, penduloRotacao.eulerAngles.z);
        return penduloRotacao;
    }
}
