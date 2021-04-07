
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }


    public float movementSpeed = 0.01f;

    // Update is called once per frame
    void Update()
    {
       bool forward= Input.GetKey(KeyCode.W);
       bool back = Input.GetKey(KeyCode.S);
       bool left = Input.GetKey(KeyCode.A);
       bool right = Input.GetKey(KeyCode.D);


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

    }
}
