using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoJogador : MonoBehaviour
{

    //public float velocidadeJogador;
    //public Rigidbody oRigidbody;

    private float horizontalInput;
    private float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
    horizontalInput = Input.GetAxis("Horizontal");
    verticalInput = Input.GetAxis("Vertical");
    transform.Translate(Vector3.forward * Time.deltaTime * verticalInput);
    transform.Translate(-Vector3.right * Time.deltaTime * horizontalInput);
   // oRigidbody.AddForce(movimentoX, 0f, movimentoZ);
    } 

}
