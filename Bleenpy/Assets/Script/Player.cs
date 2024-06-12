using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Rigidbody myRB;
    public GameObject myTarget;
    public Inventory inventory; // Référence à l'inventaire du joueur

    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Key"))
        {
            Debug.Log("Key detected.");
            inventory.AddKey();
            Destroy(other.gameObject); // Détruire la clé
        }
    }
}



