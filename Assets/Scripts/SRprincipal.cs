using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class SRprincipal : MonoBehaviour
{
    public static int CasaAtual;
    
    private static List<SRquestao> NaoRespondidas;
    public static SRquestao QuestaoAtual;
    
    // Start is called before the first frame update
    void Start()
    {
        if (NaoRespondidas == null || NaoRespondidas.Count == 0)
        {
            NaoRespondidas = Resources.LoadAll("SorteOuReves", typeof(SRquestao)).Cast<SRquestao>().ToList();
        }
        int IndiceQuestaoAleatoria = Random.Range(0, NaoRespondidas.Count);
        QuestaoAtual = NaoRespondidas[IndiceQuestaoAleatoria];
        NaoRespondidas.RemoveAt(IndiceQuestaoAleatoria);
    }

    public static void SorteOuReves()
    {
        if (QuestaoAtual.Sorte)
        {
            SceneManager.LoadScene("SorteOuRevesSorte");
            SRsorte.Questao = QuestaoAtual;
            SRsorte.CasaAtual = CasaAtual;
        }
        else
        {
            SceneManager.LoadScene("SorteOuRevesReves");
            SRreves.Questao = QuestaoAtual;
            SRreves.CasaAtual = CasaAtual;
        }
    }
}
