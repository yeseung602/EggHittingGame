using UnityEngine;

public class cshPlayerController : MonoBehaviour
{
    public float speed = 5.5f;
    public float xRange = 5.5f;
    public float power = 500f;

    public GameObject CannonBall;
    public Transform SpawnPoint;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime, 0, 0);
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, -xRange, xRange), transform.position.y);

        if(Input.GetKeyDown(KeyCode.Space)) Shoot();
    }

    void Shoot()
    {
        GameObject newBall = Instantiate(CannonBall, SpawnPoint.position, Quaternion.identity);
        newBall.GetComponent<Rigidbody2D>().AddForce(Vector2.up * power);
    }
}
