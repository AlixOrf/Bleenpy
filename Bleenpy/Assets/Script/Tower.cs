using UnityEngine;
using System.Collections;

public class Tower : MonoBehaviour
{
    public float suctionSpeed = 5f; // Vitesse d'aspiration
    public GameObject victoryCanvas; // Référence au canvas contenant l'écran de victoire

    private void OnTriggerEnter(Collider other)
    {
        Player player = other.GetComponent<Player>();
        if (player != null && player.HasAllKeys())
        {
            // Déclencher l'aspiration
            StartCoroutine(SuckPlayerIn(player));
        }
    }

    private IEnumerator SuckPlayerIn(Player player)
    {
        // Déactive les contrôles du joueur (optionnel)
        player.DisableControls();

        // Aspirer le joueur vers la tour
        while (Vector3.Distance(player.transform.position, transform.position) > 0.1f)
        {
            player.transform.position = Vector3.MoveTowards(player.transform.position, transform.position, suctionSpeed * Time.deltaTime);
            yield return null;
        }

        // Action après que le joueur soit aspiré (optionnel)
        // Par exemple : charger une nouvelle scène, afficher un message, etc
        victoryCanvas.SetActive(true);

    }
}
