using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class SRsorte : MonoBehaviour
{
    public static int CasaAtual;
    
    public static SRquestao Questao;
    
    [SerializeField]
    public static TMP_Text Pontuacao;

    [SerializeField]
    public static TMP_Text Fato;
    
    // Start is called before the first frame update
    void Start()
    {
        Fato = GameObject.Find("Fato").GetComponent<TMP_Text>();
        Pontuacao = GameObject.Find("Pontuacao").GetComponent<TMP_Text>();
        Fato.text = Questao.Fato;
        Pontuacao.text = "+" + Random.Range(1,4).ToString();
    }

    public static void Mover()
    {
        SceneManager.LoadScene("Tabuleiro");
        Tabuleiro.Pontuacao = int.Parse(Pontuacao.text);
        Tabuleiro.CasaAtual = CasaAtual;
    }
}