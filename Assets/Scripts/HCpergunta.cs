using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;

public class HCpergunta : MonoBehaviour
{
    public static int CasaAtual;
    
    private static List<HCquestao> NaoRespondidas;
    public static HCquestao QuestaoAtual;
    
    [SerializeField]
    public static TMP_Text Pergunta;

    // Start is called before the first frame update
    void Start()
    {
        if (NaoRespondidas == null || NaoRespondidas.Count == 0)
        {
            NaoRespondidas = Resources.LoadAll("HoraDoCuidado", typeof(HCquestao)).Cast<HCquestao>().ToList();
        }
        if (QuestaoAtual == null)
        {
            int IndiceQuestaoAleatoria = Random.Range(0, NaoRespondidas.Count);
            QuestaoAtual = NaoRespondidas[IndiceQuestaoAleatoria];
            NaoRespondidas.RemoveAt(IndiceQuestaoAleatoria);
        }
            Pergunta = GameObject.Find("Pergunta").GetComponent<TMP_Text>();
            Pergunta.text = QuestaoAtual.Pergunta;
    }

    public static void verOpcoes()
    {
        SceneManager.LoadScene("HoraDoCuidadoOpcoes");
        HCopcoes.QuestaoAtual = QuestaoAtual;
        HCopcoes.CasaAtual = CasaAtual;
    }
}
