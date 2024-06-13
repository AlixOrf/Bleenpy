using System.Collections;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody myRB;
    public Inventory inventory; // Référence à l'inventaire du joueur
    public GameObject myTarget; // Assurez-vous que ceci est public
    public int totalKeysNeeded = 6; // Nombre total de clés nécessaires
    public Transform finalTower; // Référence à la tour finale
    public float attractionSpeed = 5f; // Vitesse à laquelle le joueur est attiré vers la tour

    private AudioSource audioSource; // Référence à l'AudioSource
    public AudioClip keyCollectSound; // Référence à l'effet sonore

    void Start()
    {
        if (inventory == null)
        {
            inventory = GetComponent<Inventory>();
        }
        audioSource = GetComponent<AudioSource>(); // Récupérer la référence à l'AudioSource
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Key"))
        {
            Debug.Log("Key detected.");
            inventory.AddKey();
            Destroy(other.gameObject); // Détruire la clé

            // Jouer l'effet sonore
            if (audioSource != null && keyCollectSound != null)
            {
                audioSource.PlayOneShot(keyCollectSound);
            }

            // Vérifie si le joueur a toutes les clés et si la coroutine n'est pas déjà en cours d'exécution
            if (HasAllKeys() && !IsInvoking("MoveToTower"))
            {
                Invoke("MoveToTower", 2f); // Démarrer la coroutine après un délai de 2 secondes (vous pouvez modifier cette valeur)
            }
        }
    }

    private IEnumerator MoveToTower()
    {
        while (Vector3.Distance(transform.position, finalTower.position) > 0.1f)
        {
            transform.position = Vector3.MoveTowards(transform.position, finalTower.position, attractionSpeed * Time.deltaTime);
            yield return null;
        }
        Debug.Log("Player reached the final tower.");
        // Vous pouvez ajouter ici le code pour déclencher la fin du jeu
    }

    public bool HasAllKeys()
    {
        return inventory.keyCount >= 6; // Vérifie si le joueur a toutes les clés
    }

    public void DisableControls()
    {
        // Désactiver les contrôles du joueur (implémentation à ajouter)
    }
}
