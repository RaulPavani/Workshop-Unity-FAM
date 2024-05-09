//Bibliotecas que vamos usar no script
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    //Variavel que define a velocidade
    public float speed = 3f;

    //Variavel que define a força do pulo
    public float jumpForce = 5f;

    //Variavel para controlar o pulo (nao permitir pulo duplo)
    public bool canJump = true;

    //Variavel para armazenar o Rigidbody do jogador
    Rigidbody2D body;

    //Metodo chamada apenas uma vez ao carregar a cena
    void Start()
    {
        //Atribui o Rigidbody do jogador a uma variavel para nao
        //ficar usando GetComponent todavez que precisar usar o Rigidbody
        body = GetComponent<Rigidbody2D>();

        //Define a velocidade do rigdobdy e sempre vai
        //para direita na velocidade da nossa variavel speed
        body.velocity = Vector2.right * speed;
    }

    //Metodo que repete todo frame
    void Update()
    {
        //Comando para pular - Se apertar espaço e a variavel canJump for verdadeira
        if (Input.GetKeyDown(KeyCode.Space) && canJump)
        {
            //Muda o canJump para nao poder pular duas vezes
            canJump = false;

            //Caso o jogador esteja caindo - quando coleta moeda
            //Reseta a velocidade do y, para pular com força total
            if (body.velocity.y < 0)
            {
                body.velocity = new Vector2(body.velocity.x, 0);
            }

            //Adiciona uma força no player
            //para cima vezes a variavel jumpForce
            body.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }

    //Metodo chamado quando o colisor do tipo isTrigger colider com algo
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Se a colisao for com um objeto da tag Ground (Chao)
        if (collision.CompareTag("Ground"))
        {
            //Reseta o pulo
            canJump = true;
        }

        //Se a colisao for com um objeto da tag Coin (Objeto que reseta pulo)
        if (collision.CompareTag("Coin"))
        {
            //Reseta o pulo
            canJump = true;

            //Destroi o objeto que coletou
            Destroy(collision.gameObject);
        }

        //Se a colisao for com um objeto da tag Spike (Espinho)
        if (collision.CompareTag("Spike"))
        {
            //Recarrega a cena Tutorial
            SceneManager.LoadScene("Tutorial");
        }
    }
}
