using UnityEngine;

public class ObjectSelectionIndicator : MonoBehaviour
{
    //Also how do I make it so item can only be hovered over if player is close enough (Vector3.Distance?)
    //How can I make player turn to look at item when close?

    public MeshRenderer meshRenderer;
    public AudioClip interactSound;
    private AudioSource sfxAudio;
    public Color hoverColour = Color.gray;

    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        sfxAudio = GetComponent<AudioSource>();
    }

    private void OnMouseEnter()
    {
        //Changes item colour to faded when cursor is hovered over
        meshRenderer.material.color = hoverColour;

        //Plays sfx when cursor is hovered over
        sfxAudio.PlayOneShot(interactSound, 1.0f);
    }


    private void OnMouseExit()
    {
        //Changes item colour back to default when mouse not over it
        meshRenderer.material.color = Color.white;
    }
}
