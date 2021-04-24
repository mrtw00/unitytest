using UnityEngine;

public class Head : MonoBehaviour
{
    public float speed = 3f;
    public float rotationSpeed = 200f;
    private float horizontal = 0f;

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {
        transform.Translate(Vector2.up * speed * Time.fixedDeltaTime, Space.Self);
        transform.Rotate(Vector3.forward * rotationSpeed * horizontal * Time.fixedDeltaTime);
    }
}
