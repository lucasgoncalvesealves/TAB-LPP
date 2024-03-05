using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "HCquestao", menuName = "Questão/Hora do Cuidado")]
public class HCquestao : ScriptableObject
{
    public string Pergunta;
    public string OpcaoA;
    public string OpcaoB;
    public string OpcaoC;
    public string OpcaoD;
    public string Resposta;
}
