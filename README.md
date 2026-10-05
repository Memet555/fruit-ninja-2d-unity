# 🍉 Fruit Ninja 2D - Unity Game
## Unity ile Geliştirilmiş 2D Meyve Kesme Oyunu

Bu proje, efsanevi mobil oyun **Fruit Ninja** mekaniklerinin **Unity** oyun motoru ve **C#** programlama dili ile 2D olarak sıfırdan yeniden geliştirilmiş bir klonudur. Proje; dinamik kesme fiziği, rastgele fırlatıcı motoru, partikül ve dilim efektleri ile skor takip sistemlerini içerir.

---

## 🎮 Oynanış ve Mekanikler

- **Bıçak / Kılıç Kesme Mekaniği (`Sword.cs`, `Cut.cs`):** Fare imlecinin hareket yönüne göre dinamik bir kesme hattı (trail & collider) oluşturur. Dilimlenen nesneleri iki parçaya ayırarak yerçekimiyle düşmelerini sağlar.
- **Rastgele Fırlatıcı Sistemi (`SpawnerController.cs`):** Ekranın altından rastgele açılar, hızlar ve rotasyonlarla meyveleri fırlatır.
- **Fizik Tabanlı Hareket (`ObjectMove.cs`):** Rigidbody2D ve 2D çarpışma tespiti ile gerçekçi parabolik hareket dinamikleri.
- **Oyun ve Skor Yöneticisi (`GameManagerScript.cs`, `Manager.cs`):** Kesilen meyveleri puanlar, komboları takip eder ve oyun döngüsünü (Restart, Game Over) yönetir.

---

## 🛠️ Teknolojiler
- **Unity 2022.x+**
- **C#** (Oyun mekanikleri ve arayüz mantığı)
- **Unity 2D Physics** (RigidBody2D, CircleCollider2D, EdgeCollider2D)
- **TextMesh Pro** (Yüksek çözünürlüklü UI skor gösterimi)

---

## 🕹️ Nasıl Oynanır?
1. Oyunu başlatın.
2. Ekranda beliren meyveleri farenin sol tuşuna basılı tutarak sürükleyip kesin.
3. Meyveleri kaçırmadan en yüksek skoru toplamaya çalışın!

---

## 📦 Kurulum ve Unity ile Açma
1. Repoyu klonlayın:
   ```bash
   git clone https://github.com/Memet555/fruit-ninja-2d-unity.git
   ```
2. **Unity Hub** uygulamasını açın.
3. **"Open"** butonuna basarak `Fruit Ninja 2D` klasörünü seçin.
4. `Assets/Scenes` klasöründeki ana sahneyi açıp **Play (▶️)** butonuna basın.
