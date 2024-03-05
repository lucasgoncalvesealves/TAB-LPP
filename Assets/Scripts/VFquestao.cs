using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "VFquestao", menuName = "Questão/Verdadeiro ou Falso")]
public class VFquestao : ScriptableObject
{
    public string Afirmativa;
    public bool EhVerdade;
    public string Correcao;
}
