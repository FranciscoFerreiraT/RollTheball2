using UnityEngine;

public class ParpadearJugador : MonoBehaviour
{
    public Animator jugadorAnimator; // Referencia al componente Animator del jugador
    public Transform[] enemigos; // Lista de transformadas de los enemigos
    public float distanciaMinima = 5f; // Distancia mínima a la que un enemigo debe estar para activar el parpadeo

    void Update()
    {
        // Verificar la distancia a cada enemigo
        foreach (Transform enemigo in enemigos)
        {
            float distancia = Vector3.Distance(transform.position, enemigo.position);
            
            // Si un enemigo está lo suficientemente cerca, activar el parpadeo
            if (distancia < distanciaMinima)
            {
                jugadorAnimator.SetBool("Parpadeando", true);
                return; // Si un enemigo está cerca, no necesitamos seguir verificando los demás
            }
        }

        // Si no hay enemigos lo suficientemente cerca, desactivar el parpadeo
        jugadorAnimator.SetBool("Parpadeando", false);
    }
}
