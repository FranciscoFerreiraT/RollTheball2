using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab; // Prefab del enemigo que quieres duplicar
    public Transform spawnPoint; // Punto de aparición del enemigo
    private bool spawning = false; // Variable de control para evitar duplicaciones simultáneas

    // Método para duplicar el enemigo
    void SpawnEnemy()
    {
        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
        spawning = false; // Reiniciamos la variable de control después de la duplicación
    }

    void Start()
    {
        // Llama al método SpawnEnemy() cada 5 segundos después de un retraso inicial de 0 segundos
        InvokeRepeating("SpawnEnemy", 0f, 20f);
    }

    void Update()
    {
        // Si estamos en proceso de duplicación, no hacemos nada
        if (spawning)
            return;

        // Activamos la duplicación y marcamos que estamos en proceso de duplicación
        spawning = true;
        // Llamamos al método SpawnEnemy() para iniciar la duplicación
        SpawnEnemy();
    }
}
