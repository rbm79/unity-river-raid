using UnityEngine;

// Este script controla o comportamento de um tiro disparado pela nave
public class Tiro : MonoBehaviour
{
    // Velocidade do proj�til ao subir
    public float velocidade = 10f;

    // O m�todo Update() � chamado uma vez por frame
    void Update()
    {
        // Move o tiro para cima (no eixo Y) de forma cont�nua
        transform.Translate(Vector3.up * velocidade * Time.deltaTime);

        // Se o tiro ultrapassar o topo da tela (Y > 20), ele � destru�do
        // Isso evita que ele fique consumindo mem�ria desnecessariamente
        if (transform.position.y > 20f)  // ajuste conforme o tamanho da sua cena/c�mera
        {
            Destroy(gameObject);  // Destroi o GameObject associado a este script
        }
    }
}
