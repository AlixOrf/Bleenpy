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
    }

    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // Recharge la scène actuelle
    }
}
