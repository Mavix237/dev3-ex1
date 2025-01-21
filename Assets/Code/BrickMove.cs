using UnityEngine;

public class BrickMove : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Vector3 pos = transform.position;
        pos.x += Time.deltaTime;
        pos.x = Mathf.Clamp(pos.x, 0, 5);
        pos.y += Time.deltaTime;
        pos.y = Mathf.Clamp(pos.y, 0, 5);
        pos.z += Time.deltaTime;
        pos.z = Mathf.Clamp(pos.z, 0, 5);
        transform.position = pos;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
