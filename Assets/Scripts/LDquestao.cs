using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "LDquestao", menuName = "Questão/Lesão Detectada")]
public class LDquestao : ScriptableObject
{
    public Sprite Imagem;
    public string Descricao;
    public string OpcaoA;
    public string OpcaoB;
    public string OpcaoC;
    public string OpcaoD;
    public string Resposta;
}
