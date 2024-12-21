using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Update is called once per frame
    private GameObject camera_;

    void Start()
    {
        camera_ = GameObject.Find("Main Camera");
    }


    void Update()
    {
        float speed = 5f;
        Rigidbody2D rb2D = gameObject.GetComponent<Rigidbody2D>();

        if (Input.GetKey(KeyCode.A))
        {
            rb2D.linearVelocityX = -speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb2D.linearVelocityX = speed;
        }
        if (Input.GetKeyDown(KeyCode.Space) && rb2D.linearVelocityY == 0f) // Definatly the right way to check if object is not in air :)
        {
            rb2D.AddForce(new Vector2(0f, 300f));
        }

        Transform t = camera_.GetComponent<Transform>();
        t.position = new Vector3(transform.position.x, t.position.y, t.position.z);
    }
}
