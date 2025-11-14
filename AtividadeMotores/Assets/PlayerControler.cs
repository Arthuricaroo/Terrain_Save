using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(h, 0, v) * speed * Time.deltaTime);

        // Salvar com tecla S
        if (Input.GetKeyDown(KeyCode.S))
            GameManager.instance.SalvarJogo(transform.position);

        // Carregar com tecla L
        if (Input.GetKeyDown(KeyCode.L))
            GameManager.instance.CarregarJogo(gameObject);
    }
}