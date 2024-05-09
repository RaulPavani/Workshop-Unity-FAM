using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalLine : MonoBehaviour
{
    //Referencia para o painel de vitoria
    public GameObject canvasHud;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Se a colisao for com um objeto da tag Player
        if (collision.CompareTag("Player"))
        {
            //Ativa o painel de vitoria
            canvasHud.SetActive(true);

            //Muda o timescale do jogo para 0 (pausa o jogo)
            Time.timeScale = 0;
        }

        
    }
}
