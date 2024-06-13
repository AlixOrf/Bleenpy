using UnityEngine;
using UnityEngine.UI;

public class InstructionUI : MonoBehaviour
{
    public GameObject instructionPanel; // Référence au panneau d'instructions
    public Text instructionText; // Référence au texte d'instructions

    void Start()
    {
        ShowInstructionsAtStart();
    }

    public void ShowInstructionsAtStart()
    {
        instructionText.text = "Goal of the game: Collect the 6 keys scattered around the island and bring them to the main tower with a house on it to win";
        instructionPanel.SetActive(true);
    }

    public void CloseInstructions()
    {
        instructionPanel.SetActive(false);
    }
}
