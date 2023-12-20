using UnityEngine;

public class ObjectSelectionIndicator : MonoBehaviour
{

    public GameObject Player;
    public MeshRenderer meshRenderer;
    public AudioClip interactSound;
    private AudioSource sfxAudio;
    public Color hoverColour = Color.gray;
    [SerializeField] Transform thisDistance;
    [SerializeField] public float objectDistance;

    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        sfxAudio = GetComponent<AudioSource>();
    }

    private void OnMouseEnter()
    {
        //Detects how close player is to item
        if (Vector3.Distance(thisDistance.position, Player.transform.position) < objectDistance)
        {
            //Changes item colour to faded when cursor is hovered over
            meshRenderer.material.color = hoverColour;

            //Plays sfx when cursor is hovered over
            sfxAudio.PlayOneShot(interactSound, 1.0f);
        }
    }

    private void OnMouseExit()
    {
        //Changes item colour back to default when mouse not over it
        meshRenderer.material.color = Color.white;
    }
}
