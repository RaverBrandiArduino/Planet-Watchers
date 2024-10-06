using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoAndando : MonoBehaviour
{
    private CharacterController character;
    private Animator animator;
    private Vector3 inputs;

    [SerializeField] private float velocidade = 2f;

    void Start()
    {

        character = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
        
    }


    void Update()
    {
        inputs.Set(
            Input.GetAxis("Horizontal"),
            0, 
            Input.GetAxis("Vertical")
        );
        character.Move((transform.forward * inputs.magnitude * Time.deltaTime * velocidade));
        character.Move((Vector3.down * Time.deltaTime));


        if (inputs != Vector3.zero) {
            animator.SetBool("andando", true);
            transform.forward = Vector3.Slerp(transform.forward, inputs, Time.deltaTime * 10);


        }

        else {
            animator.SetBool("andando", false);
        }
        
    }
}



