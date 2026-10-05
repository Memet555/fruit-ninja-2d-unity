using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Sahneleri yeniden yüklemek için gerekli
using UnityEngine.UI; // UI kontrolü için gerekli

public class GameManagerScript : MonoBehaviour
{
    public GameObject gameOverScreen; // Game Over ekranı paneli
    public Button restartButton; // Restart butonu
    public Button quitButton; // Quit butonu

    void Start()
    {
        gameOverScreen.SetActive(false); // Oyun başlarken Game Over ekranını gizle

        // Butonlara tıklama olaylarını bağlayın
        restartButton.onClick.AddListener(RestartGame);
        quitButton.onClick.AddListener(QuitGame);
    }

    public void ShowGameOverScreen()
    {
        gameOverScreen.SetActive(true); // Game Over ekranını göster
    }

    private void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Geçerli sahneyi yeniden yükle
    }

    private void QuitGame()
    {
        Application.Quit(); // Uygulamadan çık
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; // Editor içinde çalışmayı durdur
        #endif
    }
}
