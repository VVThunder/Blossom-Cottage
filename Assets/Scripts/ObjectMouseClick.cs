using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class ObjectMouseClick : MonoBehaviour
{
    //How do I make it so item can only be picked up when player is close to it (Vector3.Distance?)
    //How do I make it so picked up items are stored instead of destroyed and then can appear between scenes?

    public Camera selectionCamera;
    public float forceSize;
    private Rigidbody rb;
    [SerializeField] private string objectName;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {

    }

    private void OnMouseDown()
    {
        //How do I check how close the player is to the object before allowing pick up
        //how do I call function from playercontroller saying we have picked up(objectName)

        print("You have found an object!");

        // Destroys item when clicked on
        Destroy(gameObject);
    }

}
