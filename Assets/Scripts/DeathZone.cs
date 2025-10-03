using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class DeathZone : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<PlayerController>(out var player))
        {
            GameObject heartsPanel = GameObject.Find("HeartsPanel");
            if (heartsPanel != null && heartsPanel.transform.childCount > 0)
            {
                if (heartsPanel.transform.childCount == 1){
                    SceneManager.LoadScene("MainLevel");
                }
                Transform lastHeart = heartsPanel.transform.GetChild(heartsPanel.transform.childCount - 1);
                Destroy(lastHeart.gameObject);
            }
            
            player.transform.position = new Vector3(0, 1, 0);
        }
        
    }
}
