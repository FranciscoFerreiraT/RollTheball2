using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Transform player; // Referencia al jugador
    public float velocidad = 5f; // Velocidad a la que se mueve el enemigo
    public float distanciaParaPerseguir = 10f; // Distancia a partir de la cual el enemigo comienza a perseguir al jugador

    private void Update()
    {
        // Calcula la distancia entre el enemigo y el jugador
        float distanciaAlJugador = Vector3.Distance(transform.position, player.position);

        // Si la distancia es menor que la distancia para perseguir, el enemigo comienza a perseguir al jugador
        if (distanciaAlJugador < distanciaParaPerseguir)
        {
            // Calcula la dirección hacia la que debe moverse el enemigo para alcanzar al jugador
            Vector3 direccion = (player.position - transform.position).normalized;

            // Mueve al enemigo en la dirección del jugador
            transform.Translate(direccion * velocidad * Time.deltaTime);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // Si el enemigo entra en contacto con el jugador, termina el juego
        if (other.CompareTag("Player"))
        {
            // Aquí puedes agregar cualquier lógica para terminar el juego, como mostrar un mensaje de "Game Over", reiniciar el nivel, etc.
            Debug.Log("¡El enemigo te ha atrapado! Game Over.");
            // Aquí podrías llamar a una función que maneje el fin del juego.
        }
    }
}
