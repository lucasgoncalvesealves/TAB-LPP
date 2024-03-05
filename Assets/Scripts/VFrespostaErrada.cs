using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class VFrespostaErrada : MonoBehaviour
{
    public static int CasaAtual;
    
    public static VFquestao Questao;
    
    [SerializeField]
    public static TMP_Text Pontuacao;

    [SerializeField]
    public static TMP_Text Correcao;
    
    // Start is called before the first frame update
    void Start()
    {
        Correcao = GameObject.Find("Correcao").GetComponent<TMP_Text>();
        Pontuacao = GameObject.Find("Pontuacao").GetComponent<TMP_Text>();
        Correcao.text = Questao.Correcao;
        Pontuacao.text = Random.Range(-1,-4).ToString();
    }

    public static void Mover()
    {
        SceneManager.LoadScene("Tabuleiro");
        Tabuleiro.Pontuacao = int.Parse(Pontuacao.text);
        Tabuleiro.CasaAtual = CasaAtual;
    }
}