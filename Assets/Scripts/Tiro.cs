using UnityEngine;

// Este script controla o comportamento de um tiro disparado pela nave
public class Tiro : MonoBehaviour
{
    // Velocidade do projétil ao subir
    public float velocidade = 10f;

    // O método Update() é chamado uma vez por frame
    void Update()
    {
        // Move o tiro para cima (no eixo Y) de forma contínua
        transform.Translate(Vector3.up * velocidade * Time.deltaTime);

        // Se o tiro ultrapassar o topo da tela (Y > 20), ele é destruído
        // Isso evita que ele fique consumindo memória desnecessariamente
        if (transform.position.y > 20f)  // ajuste conforme o tamanho da sua cena/câmera
        {
            Destroy(gameObject);  // Destroi o GameObject associado a este script
        }
    }
}
