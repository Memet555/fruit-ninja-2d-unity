using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  // UI kullanmak için gerekli

public class SpawnerController : MonoBehaviour
{
    public GameObject prefab;

    public float minX;
    public float maxX;

    public Sprite[] sprites;

    public float startTime;
    private float time;

    // Sayaç değişkeni
    private int fruitCount = 0;

    // UI Text öğesi
    public Text fruitCounterText;

    void Start()
    {
        // Sayacı ilk başta güncelle
        UpdateFruitCounter();
    }

    void Update()
    {
        if(time <= 0) {
            spawnObject();
            time = startTime;
        }
        else {
            time -= Time.deltaTime;
        }
    }

    private void spawnObject() {
        GameObject newPrefab = Instantiate(prefab);
        newPrefab.transform.position = new Vector2(
            Random.Range(minX, maxX),
            transform.position.y
        );

        // Nesnenin z koordinatını ayarlayın, böylece her zaman ön planda olur
        newPrefab.transform.position = new Vector3(newPrefab.transform.position.x, newPrefab.transform.position.y, 1f);

        Sprite randomSprite = sprites[Random.Range(0, sprites.Length)];
        newPrefab.GetComponent<SpriteRenderer>().sprite = randomSprite;

        // SpriteRenderer'ın "Order in Layer" değerini de kontrol ederek daha da emin olabilirsiniz
        newPrefab.GetComponent<SpriteRenderer>().sortingOrder = 10;

        // Meyve sayacını artır
        fruitCount++;

        // UI'yi güncelle
        UpdateFruitCounter();
    }

    // UI'deki sayacı güncelleyen fonksiyon
    private void UpdateFruitCounter()
    {
        if (fruitCounterText != null)
        {
            fruitCounterText.text = "Meyve Kesildi: " + fruitCount.ToString();
        }
    }
}
