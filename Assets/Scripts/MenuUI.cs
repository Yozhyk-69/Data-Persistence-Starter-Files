using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class MenuUI : MonoBehaviour
{
    public TMP_InputField nameInput;

    public void StartGame()
    {
        PlayerData.Instance.playerName = nameInput.text;
        SceneManager.LoadScene("Main"); // Change if your main scene has a different name
    }
}