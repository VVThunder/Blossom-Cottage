using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class ObjectMouseClick : MonoBehaviour
{
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
        //Check how close the player is to the object before allowing pick up


        //Call function from playercontroller saying we have picked up(objectName)



        print("You have found an object!");

        // Destroys item when clicked on
        Destroy(gameObject);
    }

}
