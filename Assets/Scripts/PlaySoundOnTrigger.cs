using UnityEngine;

public class PlaySoundOnTrigger : MonoBehaviour
{

    public AudioClip soundToPlay;
    private AudioSource audioSource;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Load in the audio source off of THIS object
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D (Collider2D other)
    {
        // Play sound
        AudioSource.PlayClipAtPoint(soundToPlay, transform.position);

        // TODO: Add 1 coin to the player

        // Destroy this coin
        Destroy(gameObject);

        /********************
        audioSource.PlayOneShot(soundToPlay);
        *********************/

        /***************************************
        // Load the sound into the audio source
        audioSource.clip = soundToPlay;

        // Tell it to play
        audioSource.Play();
        ****************************************/
    }
}
