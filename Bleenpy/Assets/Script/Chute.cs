using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerFallDetector : MonoBehaviour
{
    public float fallThreshold = -10f; // La hauteur à laquelle le joueur "meurt"
    public GameObject retryPanel; // Le panel UI pour le Retry

    void Start()
    {
        retryPanel.SetActive(false); // Assurez-vous que le panel Retry est désactivé au démarrage
    }

    void Update()
    {
        if (transform.position.y < fallThreshold)
        {
            ShowRetryScreen();
        }
    }

    void ShowRetryScreen()
    {
        retryPanel.SetActive(true); // Affiche le panel Retry
        Time.timeScale = 0f; // Arrête le jeu
    }

    public void Retry()
    {
        Time.timeScale = 1f; // Relance le jeu
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // Recharge la scène actuelle
    }
}
