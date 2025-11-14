
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;      // Prefab que será instanciado
    public float intervalo = 2f;   // Tempo entre os spawns
    public float raio = 5f;        // Distância aleatória do centro

    private float tempo;

    void Update()
    {
        tempo += Time.deltaTime;
        if (tempo >= intervalo)
        {
            Spawnar();
            tempo = 0f;
        }
    }

    void Spawnar()
    {
        // Gera posição aleatória em torno do spawner
        Vector3 pos = transform.position + new Vector3(
            Random.Range(-raio, raio),
            0,
            Random.Range(-raio, raio)
        );

        Instantiate(prefab, pos, Quaternion.identity);
    }
}
