using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SayHello : MonoBehaviour
{
    public TextMeshProUGUI textBox;
    public Image healthBar;

    // Awake runs as soon as the object is created
    void Awake()
    {
        
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SaySomething()
    {
        Debug.Log("Hello! How are you?");

        // Make our on screen text say "HELLO!"
        textBox.text = "Hello!";

        healthBar.fillAmount = 0.5f;
    }
        
 }
