using UnityEngine;
using UnityEngine.UI; // Добавь эту строку
using TMPro;


public class Collectible : MonoBehaviour
{
    public int coins = 0;
    void OnTriggerEnter(Collider other)
    {
        // Проверяем, что это игрок
        if (other.TryGetComponent<PlayerController>(out var player))
        {
            // Уничтожаем текущий объект
            Destroy(gameObject);

            player.coins++;
            GameObject coinsText = GameObject.Find("CoinsText");
            coinsText.GetComponent<TMP_Text>().text = "Монеты: " + player.coins + " / 10";
        }
    }
}