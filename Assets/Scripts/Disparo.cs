using UnityEngine;

public class Disparo : MonoBehaviour
{
    public GameObject prefabTiro;
    public Transform pontoDeDisparo;

    public float tempoEntreTiros = 0.3f;
    private float tempoUltimoTiro = 0f;

    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && Time.time > tempoUltimoTiro + tempoEntreTiros)
        {
            Instantiate(prefabTiro, pontoDeDisparo.position, Quaternion.identity);
            tempoUltimoTiro = Time.time;
        }
    }
}
