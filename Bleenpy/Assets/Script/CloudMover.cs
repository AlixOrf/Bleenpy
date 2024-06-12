using UnityEngine;

public class CloudMover : MonoBehaviour
{
    public float speed = 2f; // Vitesse de déplacement
    public float despawnXPosition = -10f; // Position X de despawn (à gauche de l'écran)

    private void Update()
    {
        // Déplacer le nuage vers la gauche
        transform.Translate(Vector3.left * speed * Time.deltaTime);

        // Vérifier si le nuage doit être détruit
        if (transform.position.x < despawnXPosition)
        {
            Destroy(gameObject);
        }
    }
}
