using UnityEngine;

public class cshGameManager : MonoBehaviour
{

    public GameObject ChickBall;
    public Transform ChickBallSpwanPos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpwanObj", 0.1f, 3.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpwanObj()
    {
        Instantiate(ChickBall, ChickBallSpwanPos.transform.position, Quaternion.identity);
    }
}
