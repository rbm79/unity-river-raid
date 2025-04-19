// Importa a biblioteca principal do Unity
using UnityEngine;

// Este script é responsável por detectar o comando de disparo e instanciar os projéteis da nave
public class Disparo : MonoBehaviour
{
    // Referência ao prefab do tiro (projetil que será instanciado ao disparar)
    public GameObject prefabTiro;

    // Ponto de onde o tiro será disparado (geralmente um filho da nave)
    public Transform pontoDeDisparo;

    // Tempo mínimo entre um disparo e outro (cadência de tiro)
    public float tempoEntreTiros = 0.3f;

    // Armazena o tempo do último disparo feito
    private float tempoUltimoTiro = 0f;

    // Update é chamado uma vez por frame
    void Update()
    {
        // Verifica se a tecla espaço está pressionada
        // e se já passou tempo suficiente desde o último disparo
        if (Input.GetKey(KeyCode.Space) && Time.time > tempoUltimoTiro + tempoEntreTiros)
        {
            // Instancia um novo tiro na posição definida, com rotação padrão (sem rotação)
            Instantiate(prefabTiro, pontoDeDisparo.position, Quaternion.identity);

            // Atualiza o tempo do último disparo
            tempoUltimoTiro = Time.time;
        }
    }
}
