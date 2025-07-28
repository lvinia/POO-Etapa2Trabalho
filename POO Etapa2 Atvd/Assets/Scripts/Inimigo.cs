using UnityEngine;

public class Inimigo : Personagem
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.J))//esquerda
        {
            gameObject.transform.position -= new Vector3(getVelocidade()*Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.L))//direita
        {
            gameObject.transform.position += new Vector3(getVelocidade()*Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.I))//cima
        {
            gameObject.transform.position += new Vector3(0, getVelocidade()*Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.K))//baixo
        {
            gameObject.transform.position -= new Vector3(0, getVelocidade()*Time.deltaTime, 0);
        }
    }
}
