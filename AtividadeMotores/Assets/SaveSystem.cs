
using UnityEngine;
using System.IO;

public static class SaveSystem
{
    private static string path = Application.persistentDataPath + "/save.json";

    public static void SalvarJogo(Vector3 posicao, int pontos)
    {
        SaveData data = new SaveData();
        data.playerX = posicao.x;
        data.playerY = posicao.y;
        data.playerZ = posicao.z;
        data.pontos = pontos;

        string json = JsonUtility.ToJson(data, true);
        File.WriteAllText(path, json);
        Debug.Log("Jogo salvo em: " + path);
    }

    public static SaveData CarregarJogo()
    {
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);
            return data;
        }
        else
        {
            Debug.LogWarning("Nenhum save encontrado!");
            return null;
        }
    }
}