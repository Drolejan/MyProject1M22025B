using UnityEngine;

public class topdown : MonoBehaviour
{
    [SerializeField] float speed=10;
    float movX, movY;
    Rigidbody2D playerRB;
    public GameObject bomba;//Aqui va nuestro prefab
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
        //Movimiento con Rigidbody (Este vamos a usar)
        playerRB.linearVelocity = new Vector2(movX, movY) * speed;

        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(bomba,transform.position,Quaternion.identity);
        }
    }
}
