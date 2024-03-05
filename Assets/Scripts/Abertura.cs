using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Abertura : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CalmaAi());
    }

    private IEnumerator CalmaAi()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("Tabuleiro");
        Tabuleiro.CasaAtual = 0;
    }
}
