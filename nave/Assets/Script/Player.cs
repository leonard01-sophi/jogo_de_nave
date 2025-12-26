using UnityEngine;
public class Player : MonoBehaviour
{
    [SerializeField]  float speed = 5f;
    [SerializeField] GameObject tiroPrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movimentacao();
        
    }
    void movimentacao()

    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0f, speed * Time.deltaTime, 0f);
        }
        
        if(Input.GetKey(KeyCode.S))
        {
            transform.position -= new Vector3(0f, speed * Time.deltaTime, 0f);
        }
        
        if(Input.GetKey(KeyCode.A))
        {
            transform.position -= new Vector3( speed * Time.deltaTime, 0f, 0f);
        }

        if(Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(speed * Time.deltaTime, 0f, 0f);
        }
        if(Input.GetMouseButtonDown(0))
        {
            Instantiate(tiroPrefab, transform.position, Quaternion.identity);
           
        }

    }

}
