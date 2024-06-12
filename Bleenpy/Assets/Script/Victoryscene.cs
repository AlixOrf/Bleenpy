using UnityEngine;

public class VictoryScreen : MonoBehaviour
{
    public GameObject victoryCanvas; // Référence au canvas contenant l'écran de victoire

    public void DisplayVictoryScreen()
    {
        victoryCanvas.SetActive(true); // Active le canvas de victoire
        // Ajoutez ici du code supplémentaire si nécessaire, comme l'arrêt du jeu ou la lecture d'une animation
    }
}
