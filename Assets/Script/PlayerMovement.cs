using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;
    public float fuerzaSalto = 10f; // La fuerza aplicada al saltar
    private bool puedeSaltar = true; // Para evitar que el jugador salte múltiples veces en el aire

    // Referencia al Animator de la bola
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement);

        // Verifica si el jugador presiona la tecla de espacio y puede saltar
        if (Input.GetKeyDown(KeyCode.Space) && puedeSaltar) 
        {
            // Activa el trigger "JumpTrigger" en el Animator para iniciar la animación de deformación
            animator.SetTrigger("JumpTrigger");

            // Aplica una fuerza hacia arriba para simular el salto
            rb.AddForce(Vector3.up * fuerzaSalto, ForceMode.Impulse); 
            
            // Desactiva la capacidad de saltar hasta que el jugador vuelva a tocar el suelo
            puedeSaltar = false; 
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Verifica si el jugador ha tocado el suelo
        if (collision.gameObject.CompareTag("Ground")) 
        {
            // Activa la capacidad de saltar cuando el jugador toca el suelo
            puedeSaltar = true; 
        }
    }
}
