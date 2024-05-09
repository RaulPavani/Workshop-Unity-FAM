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
        ////Calcula a nova posi�ao da camera 
        ////X = (posi�ao atual do x + posi�ao do jogador)
        ////Y = posi�ao Y da camera
        ////Z = posi�ao Z da camera
        //newPosCamera = new Vector3(target.position.x + offset.x, transform.position.y, transform.position.z);

        ////Altera a posi�ao atual da camera para a nova posi�ao calculada
        //transform.position = newPosCamera;
    }
}
