using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class HCrespostaCerta : MonoBehaviour
{
    public static int CasaAtual;

    public static HCquestao Questao;
    
    [SerializeField]
    public static TMP_Text Resposta;
    
    [SerializeField]
    public static TMP_Text Pontuacao;

    // Start is called before the first frame update
    void Start()
    {
        Resposta = GameObject.Find("Resposta").GetComponent<TMP_Text>();
        Pontuacao = GameObject.Find("Pontuacao").GetComponent<TMP_Text>();
        Resposta.text = "A alternativa correta é:\n\n" + Questao.Resposta;
        Pontuacao.text = "+" + Random.Range(1,4).ToString();
    }

    public static void Mover()
    {
        SceneManager.LoadScene("Tabuleiro");
        Tabuleiro.Pontuacao = int.Parse(Pontuacao.text);
        Tabuleiro.CasaAtual = CasaAtual;
    }
}