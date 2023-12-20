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
    private GameManager gameManager;

    void Start()
    {

        rb = GetComponent<Rigidbody>();
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();

    }

    void Update()
    {
        
    }

    public void OnMouseDown()
    {
       
        //Detects how close player is to item and plays pickup animation
        if (Vector3.Distance(thisDistance.position, Player.transform.position) < objectDistance)
        {

            print("You have found an object!");
            playerController.Pick_Up(objectName);
            this.anim.SetBool("pick up", true);
            gameManager.UpdateItemsCollected(1);
            //Debug.Log("pick up");

        }

    }

    //Hides item when clicked on
    private void OnMouseUp()
    {

        this.anim.SetBool("pick up", false);
        gameObject.SetActive(false);
        //Debug.Log("Stop pick up");

    }

}
