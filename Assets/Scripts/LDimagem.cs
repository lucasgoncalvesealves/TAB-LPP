using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;

public class LDimagem : MonoBehaviour
{
    public static int CasaAtual;
    
    private static List<LDquestao> NaoRespondidas;
    public static LDquestao QuestaoAtual;
    
    [SerializeField]
    public Image Imagem;

    // Start is called before the first frame update
    void Start()
    {
        if (NaoRespondidas == null || NaoRespondidas.Count == 0)
        {
            NaoRespondidas = Resources.LoadAll("LesaoDetectada", typeof(LDquestao)).Cast<LDquestao>().ToList();
        }
        if (QuestaoAtual == null)
        {
            int IndiceQuestaoAleatoria = Random.Range(0, NaoRespondidas.Count);
            QuestaoAtual = NaoRespondidas[IndiceQuestaoAleatoria];
            NaoRespondidas.RemoveAt(IndiceQuestaoAleatoria);
        }
            Imagem = GameObject.Find("Imagem").GetComponent<Image>();
            Imagem.sprite = QuestaoAtual.Imagem;
    }

    public static void Avancar()
    {
        SceneManager.LoadScene("LesaoDetectadaDescricao");
        LDdescricao.QuestaoAtual = QuestaoAtual;
        LDdescricao.CasaAtual = CasaAtual;
    }
}
