using UnityEngine;

public class bombaScript : MonoBehaviour
{
    void Start()
    {
        Invoke("explota", 3f);//Activa una función despues de un tiempo
    }

    void explota()
    {
        Destroy(gameObject);
    }
}
