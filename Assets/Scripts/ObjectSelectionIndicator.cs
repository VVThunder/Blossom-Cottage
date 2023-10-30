using UnityEngine;

public class ObjectSelectionIndicator : MonoBehaviour
{
    private Renderer renderer;
    public AudioClip pickupSound;
    private AudioSource sfxAudio;

    void Start()
    {
        renderer = GetComponent<Renderer>();
        sfxAudio = GetComponent<AudioSource>();
    }

    // Changes item colour to blue when cursor is hovered over and plays sfx
    private void OnMouseEnter()
    {
        renderer.material.color = Color.blue;
        sfxAudio.PlayOneShot(pickupSound, 1.0f);
    }

    // Changes item colour back to red when cursor is not hovered over
    private void OnMouseExit()
    {
        renderer.material.color = Color.red;
    }
}
