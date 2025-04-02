using TMPro;
using UnityEngine;

public class PlayerUI : MonoBehaviour
{
    public TextMeshProUGUI promptText;

    public void UpdateText(string promptMessage)
    {
        promptText.text = promptMessage;
    }
}
