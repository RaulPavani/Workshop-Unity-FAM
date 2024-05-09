//Bibliotecas que vamos usar no script
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetGame : MonoBehaviour
{

    //Metodo chamado pelo botao de resetar cena na HUD
    public void ResetScene()
    {
        //Volta o tempo para 1 - despausa o jogo
        Time.timeScale = 1;

        //Recarrega a cena Tutorial
        SceneManager.LoadScene("Tutorial");
    }
}
