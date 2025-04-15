using UnityEngine;

public class FundoScroll : MonoBehaviour  // 👈 tem que bater com o nome do arquivo
{
    public float velocidade = 2f;
    public float altura = 19.2f;
    public Transform outroFundo;

    void Update()
    {
        transform.Translate(Vector3.down * velocidade * Time.deltaTime);

        if (transform.position.y <= -altura)
        {
            transform.position = new Vector3(
                transform.position.x,
                outroFundo.position.y + altura,
                transform.position.z
            );
        }
    }
}
