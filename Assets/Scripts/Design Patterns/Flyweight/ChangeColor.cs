using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    private Renderer renderer;
    private MaterialPropertyBlock propBlock;
    private void Awake()
    {
        renderer = GetComponent<Renderer>();
        propBlock = new MaterialPropertyBlock();
    }

    /*
    private void Update()
    {
        renderer.material.color = GetRandomColor();
        //renderer.material.SetColor("Color", GetRandomColor());
    }
    */

    private void Update()
    {
        // Get the current value of the material properties in the renderer.
        renderer.GetPropertyBlock(propBlock);
        // Assign our new value.
        propBlock.SetColor(name: "Color", value: GetRandomColor());
        // Apply the edited values to the renderer.
        renderer.SetPropertyBlock(propBlock);
    }

    private Color GetRandomColor()
    {
        return new Color(
            r: Random.Range(0f, 1f),
            g: Random.Range(0f, 1f),
            b: Random.Range(0f, 1f));
    }
}
