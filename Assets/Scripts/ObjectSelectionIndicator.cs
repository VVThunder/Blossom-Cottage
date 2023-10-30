using UnityEngine;

public class ObjectSelectionIndicator : MonoBehaviour
{
    private Renderer renderer;

    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    private void OnMouseEnter()
    {
        renderer.material.color = Color.blue;
    }

    private void OnMouseExit()
    {
        renderer.material.color = Color.red;
    }
}
