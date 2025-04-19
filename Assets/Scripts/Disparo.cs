// Importa a biblioteca principal do Unity
using UnityEngine;

// Este script � respons�vel por detectar o comando de disparo e instanciar os proj�teis da nave
public class Disparo : MonoBehaviour
{
    // Refer�ncia ao prefab do tiro (projetil que ser� instanciado ao disparar)
    public GameObject prefabTiro;

    // Ponto de onde o tiro ser� disparado (geralmente um filho da nave)
    public Transform pontoDeDisparo;

    // Tempo m�nimo entre um disparo e outro (cad�ncia de tiro)
    public float tempoEntreTiros = 0.3f;

    // Armazena o tempo do �ltimo disparo feito
    private float tempoUltimoTiro = 0f;

    // Update � chamado uma vez por frame
    void Update()
    {
        // Verifica se a tecla espa�o est� pressionada
        // e se j� passou tempo suficiente desde o �ltimo disparo
        if (Input.GetKey(KeyCode.Space) && Time.time > tempoUltimoTiro + tempoEntreTiros)
        {
            // Instancia um novo tiro na posi��o definida, com rota��o padr�o (sem rota��o)
            Instantiate(prefabTiro, pontoDeDisparo.position, Quaternion.identity);

            // Atualiza o tempo do �ltimo disparo
            tempoUltimoTiro = Time.time;
        }
    }
}
