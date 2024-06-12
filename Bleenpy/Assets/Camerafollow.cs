using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // Le personnage à suivre
    public Vector3 offset; // L'offset entre la caméra et le personnage
    public float smoothSpeed = 0.125f; // La vitesse de lissage du mouvement de la caméra

    void LateUpdate()
    {
        // Position désirée de la caméra
        Vector3 desiredPosition = target.position + offset;

        // Position lissée de la caméra
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        // Appliquer la position lissée à la caméra
        transform.position = smoothedPosition;

        // Optionnel: faire en sorte que la caméra regarde toujours le personnage
        transform.LookAt(target);
    }
}
