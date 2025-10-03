using UnityEngine;

public class FieldCell : MonoBehaviour
{
    public float moisture = 0.5f;

    public void Spray(float amount)
    {
        moisture = Mathf.Min(1f, moisture + amount);
        UpdateColor();
    }

    void UpdateColor()
    {
        Renderer rend = GetComponent<Renderer>();
        rend.material.color = Color.Lerp(Color.red, Color.green, moisture);
    }
}
