using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int pontos;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        //Para carregar automaticamente ao iniciar
        GameObject player = GameObject.FindWithTag("Player");
        CarregarJogo(player);
    }

    public void AdicionarPontos(int valor)
    {
        pontos += valor;
    }

    public void SalvarJogo(Vector3 playerPos)
    {
        SaveSystem.SalvarJogo(playerPos, pontos);
    }

    public void CarregarJogo(GameObject player)
    {
        SaveData data = SaveSystem.CarregarJogo();
        if (data != null)
        {
            player.transform.position = new Vector3(data.playerX, data.playerY, data.playerZ);
            pontos = data.pontos;
        }
    }
}