using UnityEngine;

public class tiroplayer : MonoBehaviour
{
    float speed = 10f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += speed * Time.deltaTime * Vector3.up;
         Destroy(gameObject, 4f);
        //transform.Rotate += speed * Time.deltaTime * Vector3.up;
    }
}
