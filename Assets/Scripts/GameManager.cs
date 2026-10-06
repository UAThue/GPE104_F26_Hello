using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;

    public GameObject mainMenuScreen;
    public GameObject pressStartScreen;
    public GameObject gameplayScreen;
    public GameObject creditsScreen;

    public float screenMinX;
    public float screenMaxX;
    public float screenMinY;
    public float screenMaxY;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        } else
        {
            Destroy(gameObject);
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        TurnOnPressStartScreen();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TurnOnPressStartScreen()
    {
        mainMenuScreen.SetActive(false);
        creditsScreen.SetActive(false);
        pressStartScreen.SetActive(true);
        gameplayScreen.SetActive(false);
    }

    public void TurnOnGameplayScreen ()
    {
        mainMenuScreen.SetActive(false);
        creditsScreen.SetActive(false);
        pressStartScreen.SetActive(false);
        gameplayScreen.SetActive(true);
    }

    public void TurnOnCreditsScreen()
    {
        mainMenuScreen.SetActive(false);
        creditsScreen.SetActive(true);
        pressStartScreen.SetActive(false);
        gameplayScreen.SetActive(false);
    }

    public void TurnOnMainMenuScreen()
    {
        mainMenuScreen.SetActive(true);
        creditsScreen.SetActive(false);
        pressStartScreen.SetActive(false);
        gameplayScreen.SetActive(false);
    }
}
