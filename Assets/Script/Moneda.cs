using UnityEngine;

public class RecolectarMonedas : MonoBehaviour
{
    // Método llamado cuando el jugador entra en contacto con un collider
    void OnTriggerEnter(Collider other)
    {
        // Verifica si el objeto con el que el jugador colisionó es la moneda
        if (other.CompareTag("Moneda"))
        {
            // Destruye la moneda
            Destroy(other.gameObject);
            
            // Aquí puedes agregar lógica adicional, como aumentar la puntuación del jugador,
            // reproducir un sonido, etc.
            
            Debug.Log("Moneda recolectada!"); // Este es solo un ejemplo, puedes eliminar esta línea si lo deseas
        }
    }
}
