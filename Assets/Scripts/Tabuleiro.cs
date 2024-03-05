using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tabuleiro : MonoBehaviour
{
    private static GameObject Peao;
    
    public static int Pontuacao;
    public static int CasaAtual;

    void Start()
    {
        Peao = GameObject.Find("Peão");
        Peao.GetComponent<FollowThePath>().moveAllowed = true;
    }
    
    void Update()
    {
        if (Pontuacao >= 0)
        {
            if (Peao.GetComponent<FollowThePath>().waypointIndex > CasaAtual + Pontuacao)
            {
                Peao.GetComponent<FollowThePath>().moveAllowed = false;
                CasaAtual = Peao.GetComponent<FollowThePath>().waypointIndex - 1;
            }
        }
        else
        {
            if (Peao.GetComponent<FollowThePath>().waypointIndex < CasaAtual + Pontuacao)
            {
                Peao.GetComponent<FollowThePath>().moveAllowed = false;
                CasaAtual = Peao.GetComponent<FollowThePath>().waypointIndex + 1;
            }
        }
        
        if (Peao.GetComponent<FollowThePath>().waypointIndex < 0)
        {
            StartCoroutine(CalmaAi());
            CasaAtual = 0;
        }
        
        if (Peao.GetComponent<FollowThePath>().waypointIndex >= Peao.GetComponent<FollowThePath>().waypoints.Length)
        {
            StartCoroutine(CalmaAi());
            CasaAtual = 45;
        }

        StartCoroutine(CalmaAi());
    }

    private IEnumerator CalmaAi()
    {
        yield return new WaitForSeconds(3);
        carregaCena(CasaAtual);
    }

    public void carregaCena(int Casa)
    {
        if (Casa >= 44)
        {
            SceneManager.LoadScene("FimDeJogo");
        }
        else if (Casa % 5 == 0)
        {
            SceneManager.LoadScene("VerdadeiroOuFalsoAfirmativa");
            VFafirmativa.CasaAtual = CasaAtual;
        }
        else if (Casa % 5 == 1)
        {
            SceneManager.LoadScene("HoraDoCuidadoPergunta");
            HCpergunta.QuestaoAtual = null;
            HCpergunta.CasaAtual = CasaAtual;
        }
        else if (Casa % 5 == 2)
        {
            SceneManager.LoadScene("SorteOuRevesPrincipal");
            SRprincipal.CasaAtual = CasaAtual;
        }
        else if (Casa % 5 == 3)
        {
            SceneManager.LoadScene("LesaoDetectadaImagem");
            LDimagem.QuestaoAtual = null;
            LDimagem.CasaAtual = CasaAtual;
        }
        else if (Casa % 5 == 4)
        {
            switch (Random.Range(1,3))
            {
                case 1:
                    SceneManager.LoadScene("VerdadeiroOuFalsoAfirmativa");
                    VFafirmativa.CasaAtual = CasaAtual;
                    break;
                case 2:
                    SceneManager.LoadScene("HoraDoCuidadoPergunta");
                    HCpergunta.QuestaoAtual = null;
                    HCpergunta.CasaAtual = CasaAtual;
                    break;
                case 3:
                    SceneManager.LoadScene("SorteOuRevesPrincipal");
                    SRprincipal.CasaAtual = CasaAtual;
                    break;
            }
        }
    }
}
