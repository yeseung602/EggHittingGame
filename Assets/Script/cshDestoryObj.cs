using UnityEngine;

public class cshDestoryObj : MonoBehaviour
{
    public float delaytime = 10f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Invoke("destoryObj", delaytime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void destoryObj()
    {
        Destroy(gameObject);
    }
}
