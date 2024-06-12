using UnityEngine;
using System.Collections;

public class CloudSpawner : MonoBehaviour
{
    public GameObject[] cloudPrefabs; // Array de préfabs de nuages
    public float spawnInterval = 5f; // Intervalle de spawn en secondes
    public float spawnHeightMin = 2f; // Hauteur minimale de spawn
    public float spawnHeightMax = 5f; // Hauteur maximale de spawn
    public float spawnXPosition = 10f; // Position X de spawn (à droite de l'écran)
    public float despawnXPosition = -10f; // Position X de despawn (à gauche de l'écran)
    public float cloudSpeed = 2f; // Vitesse de déplacement des nuages

    // Nouveaux champs pour spécifier les positions Y et Z de spawn
    public float spawnYMin = 2f; // Hauteur minimale de spawn sur l'axe Y
    public float spawnYMax = 5f; // Hauteur maximale de spawn sur l'axe Y
    public float spawnZMin = 0f; // Position minimale de spawn sur l'axe Z
    public float spawnZMax = 0f; // Position maximale de spawn sur l'axe Z

    private void Start()
    {
        StartCoroutine(SpawnClouds());
    }

    private IEnumerator SpawnClouds()
    {
        while (true)
        {
            SpawnCloud();
            yield return new WaitForSeconds(spawnInterval);
        }
    }

    private void SpawnCloud()
    {
        int randomIndex = Random.Range(0, cloudPrefabs.Length);
        GameObject cloud = Instantiate(cloudPrefabs[randomIndex]);

        // Positionner le nuage à une hauteur aléatoire et à la position X de spawn
        float randomHeight = Random.Range(spawnHeightMin, spawnHeightMax);
        float randomY = Random.Range(spawnYMin, spawnYMax);
        float randomZ = Random.Range(spawnZMin, spawnZMax);

        cloud.transform.position = new Vector3(spawnXPosition, randomY, randomZ);

        // Ajouter le script de mouvement au nuage
        CloudMover cloudMover = cloud.AddComponent<CloudMover>();
        cloudMover.despawnXPosition = despawnXPosition;
        cloudMover.speed = cloudSpeed;
    }
}
