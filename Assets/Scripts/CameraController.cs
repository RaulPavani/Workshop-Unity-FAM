//Bibliotecas que vamos usar no script
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //Variavel que define a velocidade
    public float speed = 3f;

    //Variavel para armazenar o Rigidbody do jogador
    Rigidbody2D body;

    void Start()
    {
        //Atribui o Rigidbody do jogador a uma variavel para nao
        //ficar usando GetComponent todavez que precisar usar o Rigidbody
        body = GetComponent<Rigidbody2D>();

        //Define a velocidade do rigdobdy e sempre vai
        //para direita na velocidade da nossa variavel speed
        body.velocity = Vector2.right * speed;
    }

    void FixedUpdate()
    {
        ////Calcula a nova posiçao da camera 
        ////X = (posiçao atual do x + posiçao do jogador)
        ////Y = posiçao Y da camera
        ////Z = posiçao Z da camera
        //newPosCamera = new Vector3(target.position.x + offset.x, transform.position.y, transform.position.z);

        ////Altera a posiçao atual da camera para a nova posiçao calculada
        //transform.position = newPosCamera;
    }
}
