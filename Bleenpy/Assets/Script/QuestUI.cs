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
        instructionText.text = "Bienvenue dans le jeu !\n\nBut du jeu : Récupérez les 6 clés disséminées dans l'île et amenez-les à la tour principale avec un maisonnette dessus pour gagner";
        instructionPanel.SetActive(true);
    }

    public void CloseInstructions()
    {
        instructionPanel.SetActive(false);
    }
}
