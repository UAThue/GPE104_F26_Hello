using UnityEngine;

public class MainMenuUI : MonoBehaviour
{
    public void StartGame()
    {
        GameManager.instance.TurnOnGameplayScreen();
    }

    public void ShowCredits()
    {
        GameManager.instance.TurnOnCreditsScreen();
    }

}
