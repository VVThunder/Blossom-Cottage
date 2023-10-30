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
    private void OnMouseDown()
    {
        Destroy(gameObject);
    }

}
