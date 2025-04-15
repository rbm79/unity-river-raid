using UnityEngine;

public class AviaoController : MonoBehaviour
{
    public float velocidade = 5f;
    public float limiteX = 2.5f;
    public float limiteY = 4.5f;

    void Update()
    {
        float movimentoX = Input.GetAxis("Horizontal") * velocidade * Time.deltaTime;
        float movimentoY = Input.GetAxis("Vertical") * velocidade * Time.deltaTime;

        transform.Translate(movimentoX, movimentoY, 0);

        // Limita posição nos eixos X e Y
        Vector3 posicao = transform.position;
        posicao.x = Mathf.Clamp(posicao.x, -limiteX, limiteX);
        posicao.y = Mathf.Clamp(posicao.y, -limiteY, limiteY);
        transform.position = posicao;
    }
}
