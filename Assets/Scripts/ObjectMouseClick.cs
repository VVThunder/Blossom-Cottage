using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class ObjectMouseClick : MonoBehaviour
{
    public Camera camera;
    public float forceSize;
    private Rigidbody rigidbody;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {

    }

    // Destroys item when clicked on
    private void OnMouseDown()
    {
        print("You have found an object!");
        Destroy(gameObject);
    }

}
