using UnityEngine;

public class bombaScript : MonoBehaviour
{
    Animator bombAnim;
    void Start()
    {
        bombAnim = GetComponent<Animator>();
        Invoke("activateBomb", 1f);//Activa una función despues de un tiempo
    }

    void activateBomb()
    {
        bombAnim.SetBool("activated", true);
        Invoke("animexplosion", 2f);
    }
    void animexplosion()
    {
        bombAnim.SetTrigger("explode");
    }

    public void explota()
    {
        Destroy(gameObject,0.5f);
    }
}
