using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class ObjectMouseClick : MonoBehaviour
{
    //How do I make it so picked up items are stored instead of destroyed and then can appear between scenes?

    public GameObject Player;
    public Camera selectionCamera;
    public float forceSize;
    private Rigidbody rb;
    private PlayerController playerController;
    [SerializeField] private string objectName;

    [SerializeField] Transform thisDistance;
    [SerializeField] public float objectDistance;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    void Update()
    {

    }

    private void OnMouseDown()
    {
        //How do I call function from playercontroller saying we have picked up(objectName)
       
        //Detects how close player is to item
        if (Vector3.Distance(thisDistance.position, Player.transform.position) < objectDistance)
        {
            print("You have found an object!");
            playerController.Pick_Up(objectName);
            // Destroys item when clicked on
            Destroy(gameObject);
        }
        
    }

}
