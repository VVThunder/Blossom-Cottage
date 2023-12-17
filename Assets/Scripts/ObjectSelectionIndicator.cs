using UnityEngine;

public class ObjectSelectionIndicator : MonoBehaviour
{
    //How do I make it so that it changes back to original item item colour when not hovering?
    //Also how do I make it so item can only be hovered over if player is close enough (Vector3.Distance?)
    //How can I make player turn to look at item when close?


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

        //Changes item colour to faded when cursor is hovered over
        meshRenderer.material.color = hoverColour;

        //Plays sfx when cursor is hovered over
        sfxAudio.PlayOneShot(pickupSound, 1.0f);
    }


    private void OnMouseExit()
    {
        //Changes item colour to red when cursor is not hovered over
        //Want to make this original item colour not red - I tried color, material and shader but none work
        meshRenderer.material.color = Color.green;
    }
}
