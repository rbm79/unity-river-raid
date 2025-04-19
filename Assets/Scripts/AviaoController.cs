// Importa a biblioteca principal do Unity, necessária para usar MonoBehaviour e outros componentes
using UnityEngine;

// Este script controla a movimentação da nave do jogador com as teclas direcionais
public class AviaoController : MonoBehaviour
{
    // Velocidade de movimento da nave
    public float velocidade = 5f;

    // Limites horizontais (eixo X) e verticais (eixo Y) da nave na tela
    public float limiteX = 2.5f;
    public float limiteY = 4.5f;

    // O método Update é chamado a cada frame do jogo
    void Update()
    {
        // Lê a entrada horizontal (teclas A/D ou setas ← →)
        float movimentoX = Input.GetAxis("Horizontal") * velocidade * Time.deltaTime;

        // Lê a entrada vertical (teclas W/S ou setas ↑ ↓)
        float movimentoY = Input.GetAxis("Vertical") * velocidade * Time.deltaTime;

        // Move a nave de acordo com os valores obtidos nos eixos X e Y
        transform.Translate(movimentoX, movimentoY, 0);

        // Recupera a posição atual da nave
        Vector3 posicao = transform.position;

        // Limita a posição no eixo X para não sair da tela
        posicao.x = Mathf.Clamp(posicao.x, -limiteX, limiteX);

        // Limita a posição no eixo Y para evitar que a nave suba/abaixe demais
        posicao.y = Mathf.Clamp(posicao.y, -limiteY, limiteY);

        // Aplica a nova posição corrigida à nave
        transform.position = posicao;
    }
}
