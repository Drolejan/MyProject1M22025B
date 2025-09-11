using UnityEngine;

public class topdown : MonoBehaviour
{
    [SerializeField] float speed=10;
    float movX, movY;
    Rigidbody2D playerRB;
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        movX = Input.GetAxis("Horizontal");
        movY = Input.GetAxis("Vertical");
        //Movimiento con Transform
        //transform.position += new Vector3(movX, movY, 0) * Time.deltaTime*speed;
        //Movimiento con Rigidbody
        playerRB.linearVelocity = new Vector2(movX, movY)*speed;
    }
}
