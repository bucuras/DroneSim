using UnityEngine;

public class DroneSpray : MonoBehaviour
{
    public float sprayAmount = 0.1f;
    public float sprayDistance = 10f;

    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, Vector3.down, out hit, sprayDistance))
            {
                FieldCell cell = hit.collider.GetComponent<FieldCell>();
                if (cell != null)
                    cell.Spray(sprayAmount * Time.deltaTime);
            }
        }
    }
}
