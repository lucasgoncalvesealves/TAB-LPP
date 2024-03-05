using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FimDeJogo : MonoBehaviour
{
    public void Recomecar()
    {
        SceneManager.LoadScene("Tabuleiro");
        Tabuleiro.CasaAtual = 0;
        Tabuleiro.Pontuacao = 0;
    }
}
