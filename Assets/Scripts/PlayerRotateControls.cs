
using UnityEngine;

public class PlayerRotateControls : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    public float rotationSpeed = 1f;
    public float movementSpeed = 0.1f;

    // Update is called once per frame
    void Update()

    {
        bool forward = Input.GetKey(KeyCode.W);
        bool back = Input.GetKey(KeyCode.S);
        bool left = Input.GetKey(KeyCode.A);
        bool right = Input.GetKey(KeyCode.D);
        bool rotateLeft = Input.GetKey(KeyCode.Q);
        bool rotateRight = Input.GetKey(KeyCode.E);

        if (forward)
        {
            transform.Translate(Vector3.up * movementSpeed * Time.deltaTime);
        }

        if (back)
        {
            transform.Translate(Vector3.down * movementSpeed * Time.deltaTime);
        }

        if (left)
        {
            transform.Translate(Vector3.left * movementSpeed * Time.deltaTime);
        }

        if (right)
        {
            transform.Translate(Vector3.right * movementSpeed * Time.deltaTime);
        }

        if (rotateLeft)
        {
            transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);
        }

        if (rotateRight)
        {
            transform.Rotate(0f, 0f, -rotationSpeed * Time.deltaTime);
        }
    }
}
    