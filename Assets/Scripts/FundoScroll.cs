// Importa a biblioteca principal do Unity, necessária para usar componentes como MonoBehaviour e Transform
using UnityEngine;

// Este script faz o fundo do jogo se mover para baixo continuamente e reinicia sua posição para criar efeito de scroll infinito
public class FundoScroll : MonoBehaviour  // 👈 o nome da classe deve ser igual ao nome do arquivo .cs
{
    // Velocidade com que o fundo se move para baixo
    public float velocidade = 2f;

    // Altura do sprite de fundo (em Unity units), usada para calcular o ponto de reinício
    public float altura = 19.2f;

    // Referência ao outro fundo (o par que faz parte do looping visual)
    public Transform outroFundo;

    // Este método é chamado uma vez por frame
    void Update()
    {
        // Move o fundo atual para baixo continuamente, simulando movimento da câmera ou cenário
        transform.Translate(Vector3.down * velocidade * Time.deltaTime);

        // Verifica se este fundo já saiu completamente da tela (passou da altura definida)
        if (transform.position.y <= -altura)
        {
            // Reposiciona este fundo logo acima do outro fundo, criando o efeito de rolagem contínua
            transform.position = new Vector3(
                transform.position.x,
                outroFundo.position.y + altura,
                transform.position.z
            );
        }
    }
}
