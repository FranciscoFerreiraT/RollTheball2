using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance; // Referencia estática al GameManager para acceder desde cualquier script

    public int score = 0; // Puntuación actual del juego
    public Text scoreText; // Texto en pantalla para mostrar la puntuación

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

    private void UpdateScoreUI()
    {
        // Actualizar el texto de la puntuación en la interfaz de usuario
        scoreText.text = "Puntuación: " + score;
    }

    public void AddScore(int value)
    {
        // Añadir puntuación y actualizar el texto de la interfaz de usuario
        score += value;
        UpdateScoreUI();
    }
}

