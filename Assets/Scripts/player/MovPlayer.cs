using UnityEngine;

public class MovPlayer : MonoBehaviour
{
    public float speed = 5f; // Velocidade de movimento do jogador
    private Rigidbody2D rb; // Referência ao componente Rigidbody2D do jogador
    private Vector3 position;
    private Vector3 velocity;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame asdasdasd
    void Update()
    {
       position = transform.position;
       velocity = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0) * speed;
         position += velocity * Time.deltaTime;
         transform.position = position;
        rb = GetComponent<Rigidbody2D>();
                 rb.MovePosition(position);

    }
}
