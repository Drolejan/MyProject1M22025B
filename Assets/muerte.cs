using UnityEngine;

public class muerte : MonoBehaviour
{
    public Transform spawn,pelota;//Variable para la posición de mi spawn y mi pelota
    Rigidbody2D pelotaRB;
    void Start()
    {
        //Busco el objeto Player y obtengo su componente rigidbody2d
        pelotaRB = GameObject.Find("Player").GetComponent<Rigidbody2D>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("MUERTE");
        pelota.position = spawn.position;//Hacemos que la pelota se vaya al spawn
        pelotaRB.linearVelocity = Vector2.zero;//Reseteamos la velocidad a 0
    }

}
