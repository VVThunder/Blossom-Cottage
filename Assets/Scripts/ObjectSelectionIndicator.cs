using UnityEngine;

public class ObjectSelectionIndicator : MonoBehaviour
{
    public MeshRenderer meshRenderer;
    public AudioClip pickupSound;
    private AudioSource sfxAudio;
    //public Color originalColour;
    public Color hoverColour = Color.gray;

    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        sfxAudio = GetComponent<AudioSource>();
        //originalColour = gameObject.GetComponent<Color>();
    }

    private void OnMouseEnter()
    {

        // Changes item colour to faded when cursor is hovered over
        meshRenderer.material.color = hoverColour;

        //Plays sfx when cursor is hovered over
        sfxAudio.PlayOneShot(pickupSound, 1.0f);
    }


    private void OnMouseExit()
    {
        // Changes item colour back to default when cursor is not hovered over
        meshRenderer.material.color = Color.red;
    }
}
