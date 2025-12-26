using UnityEngine;

public class inimigo : MonoBehaviour
{
    public float velocidade = 5f; // A velocidade do movimento

    void Start()
    {
        // Escolhe um lugar aleatório para começar
        float posX = Random.Range(-8f, 8f);
        float posY = Random.Range(-4f, 4f);
        transform.position = new Vector3(posX, posY, 0f);
    }

    void Update()
    {
        // ISSO faz ele se mexer: Move para a direita (X positivo)
        transform.position += new Vector3(velocidade * Time.deltaTime, 0f, 0f);

        // Se ele sair muito para a direita, volta para a esquerda
        if (transform.position.x > 11f)
        {
            transform.position = new Vector3(-11f, transform.position.y, 0f);
        }
    }
}