using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public int keyCount = 0; // Compteur de clés
    public Text keyCountText; // Texte pour afficher le nombre de clés

    void Start()
    {
        UpdateKeyCountUI();
    }

    public void AddKey()
    {
        keyCount++;
        UpdateKeyCountUI();
    }

    private void UpdateKeyCountUI()
    {
        keyCountText.text = "Keys: " + keyCount.ToString();
    }
}

