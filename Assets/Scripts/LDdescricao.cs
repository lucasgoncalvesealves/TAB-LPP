using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;

public class LDdescricao : MonoBehaviour
{
    public static int CasaAtual;
    
    public static LDquestao QuestaoAtual;
     
    [SerializeField]
    public TMP_Text Descricao;

    // Start is called before the first frame update
    void Start()
    {
        Descricao = GameObject.Find("Descricao").GetComponent<TMP_Text>();
        Descricao.text = QuestaoAtual.Descricao;
    }

    public static void Avancar()
    {
        SceneManager.LoadScene("LesaoDetectadaOpcoes");
        LDopcoes.QuestaoAtual = QuestaoAtual;
        LDopcoes.CasaAtual = CasaAtual;
    }

    public static void Voltar()
    {
        SceneManager.LoadScene("LesaoDetectadaImagem");
        LDimagem.QuestaoAtual = QuestaoAtual;
        LDimagem.CasaAtual = CasaAtual;
    }
}
