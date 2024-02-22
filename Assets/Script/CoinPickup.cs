using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    public int scoreValue = 10; // Puntuación que se añade al recoger una moneda

    private void OnTriggerEnter(Collider other)
    {
        // Verificar si el objeto que ha entrado en contacto con esta moneda es el jugador
        if (other.CompareTag("Player"))
        {
            // Añadir la puntuación y destruir la moneda
            GameManager.instance.AddScore(scoreValue);
            Destroy(gameObject);
        }
    }
}
