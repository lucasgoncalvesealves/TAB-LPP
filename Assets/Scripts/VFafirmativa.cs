using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;

public class VFafirmativa : MonoBehaviour
{
    public static int CasaAtual;
    
    private static List<VFquestao> NaoRespondidas;
    public static VFquestao QuestaoAtual;
    
    [SerializeField]
    public static TMP_Text Afirmativa;

    // Start is called before the first frame update
    void Start()
    {
        if (NaoRespondidas == null || NaoRespondidas.Count == 0)
        {
            NaoRespondidas = Resources.LoadAll("VerdadeiroOuFalso", typeof(VFquestao)).Cast<VFquestao>().ToList();
        }
        int IndiceQuestaoAleatoria = Random.Range(0, NaoRespondidas.Count);
        QuestaoAtual = NaoRespondidas[IndiceQuestaoAleatoria];
        Afirmativa = GameObject.Find("Afirmativa").GetComponent<TMP_Text>();
        Afirmativa.text = QuestaoAtual.Afirmativa;
        NaoRespondidas.RemoveAt(IndiceQuestaoAleatoria);
    }

    public static void AfirmativaVerdadeira()
    {
        if (QuestaoAtual.EhVerdade)
        {
            SceneManager.LoadScene("VerdadeiroOuFalsoCerto");
            VFrespostaCerta.Questao = QuestaoAtual;
            VFrespostaCerta.CasaAtual = CasaAtual;
        }
        else
        {
            SceneManager.LoadScene("VerdadeiroOuFalsoErrado");
            VFrespostaErrada.Questao = QuestaoAtual;
            VFrespostaErrada.CasaAtual = CasaAtual;
        }
    }

    public static void AfirmativaFalsa()
    {
        if (!QuestaoAtual.EhVerdade)
        {
            SceneManager.LoadScene("VerdadeiroOuFalsoCerto");
            VFrespostaCerta.Questao = QuestaoAtual;
            VFrespostaCerta.CasaAtual = CasaAtual;
        }
        else
        {
            SceneManager.LoadScene("VerdadeiroOuFalsoErrado");
            VFrespostaErrada.Questao = QuestaoAtual;
            VFrespostaErrada.CasaAtual = CasaAtual;
        }
    }
}