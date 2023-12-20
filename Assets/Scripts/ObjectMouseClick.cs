using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class ObjectMouseClick : MonoBehaviour
{

    public GameObject Player;
    public Camera selectionCamera;
    public float forceSize;
    private Rigidbody rb;
    private PlayerController playerController;
    public Animator anim;
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
       
        //Detects how close player is to item and plays pickup animation
        if (Vector3.Distance(thisDistance.position, Player.transform.position) < objectDistance)
        {

            print("You have found an object!");
            playerController.Pick_Up(objectName);
            this.anim.SetBool("pick up", true);
            //Debug.Log("pick up");

        }

    }

    private void OnMouseUp()
    {
        //Hides item when clicked on
        this.anim.SetBool("pick up", false);
        gameObject.SetActive(false);
        //Debug.Log("Stop pick up");
    }
}
