using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentacaodaBolinha : MonoBehaviour
{
    
    public float velocidadeJogador;
    public Rigidbody oRigidbody;

    private float movimentoX;
    private float movimentoZ;



    // Start is called before the first frame update
    void Start()
    {
        MovimentoJogador();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void MovimentoJogador(){
        movimentoX = Input.GetAxis("Horizontal") * velocidadeJogador;
        movimentoZ = Input.GetAxis("Vertical") * velocidadeJogador; 

        oRigidbody.AddForce(movimentoX, 0f, movimentoZ);
    }
}
