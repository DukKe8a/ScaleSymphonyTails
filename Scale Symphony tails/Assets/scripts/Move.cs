
using UnityEngine;

public class Move : MonoBehaviour
{
    public float velocidad;
    public Rigidbody2D Rb;
    void Start()
    {
        Rb.velocity = transform.up * velocidad;
    }

}
