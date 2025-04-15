using UnityEngine;

public class Tiro : MonoBehaviour
{
    public float velocidade = 10f;

    void Update()
    {
        transform.Translate(Vector3.up * velocidade * Time.deltaTime);

        // Destroi se sair da tela
        if (transform.position.y > 20f)  // ajuste conforme sua câmera
        {
            Destroy(gameObject);
        }
    }
}
