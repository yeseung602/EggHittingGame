using UnityEngine;
using UnityEngine.Rendering;

public class cshChickBall : MonoBehaviour
{
    public GameObject divChickBall;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void division()
    {
        GameObject chick = Instantiate(divChickBall, gameObject.transform.position, Quaternion.identity);
        chick.GetComponent<Rigidbody2D>().AddForce(new Vector2(0.5f, 0.5f) * 300f);
        chick = Instantiate(divChickBall, gameObject.transform.position, Quaternion.identity);
        chick.GetComponent<Rigidbody2D>().AddForce(new Vector2(-0.5f, 0.5f) * 300f);
        Destroy(gameObject);
    }
}
