<p align="center">
    <img src="https://raw.githubusercontent.com/basketoengine/Basketo/main/readmeimgs/logo.png" alt="Basketo Oyun Motoru Logosu" width="200"/>
</p>

<h2 align="center">Oluştur, Oyna, İlham Ver. Hayat Bulan Oyunlar. ✨</h2>

<h1 align="center">Basketo Oyun Motoru</h1>

<div align="center">

[![Discord](https://img.shields.io/discord/1373185493742911609?logo=discord&label=Discord&color=5B5BD6&logoColor=white)](https://discord.gg/F3DswRMW) <!-- Discord sunucu kimliğinizi buraya ekleyin -->
[![GitHub stars](https://img.shields.io/github/stars/basketoengine/Basketo?style=social)](https://github.com/basketoengine/Basketo)
[![X (eski adıyla Twitter)](https://img.shields.io/twitter/follow/BaslaelWorkneh?style=social&logo=x)](https://x.com/BaslaelWorkneh)

</div>

<p align="center">
Basketo Engine’e hoş geldiniz - harika ve yüksek performanslı bir motor oluşturmak için en iyi çabamızı ortaya koyduğumuz bir tutku projesi. Hedefimiz, onu AI-Native bir oyun motoru haline getirmek. Unity benzeri editör arayüzü, Gemini AI entegrasyonu, gelişmiş çoklu ses efekti sistemi ve güçlü ECS mimarisi ile öne çıkar. Katkıda bulunmak, fikir önermek veya sadece büyümesini izlemek için burada olsanız da, bu yolculuğun bir parçasısınız! 🚀
</p>
## 🚀 Motorun Mevcut Durumu
<p align="center">
  <img src="https://raw.githubusercontent.com/basketoengine/Basketo/main/readmeimgs/image3.png" alt="Current State of Basketo Engine" width="700"/>
</p>

<p align="center">
  <em>En son gelişmeleri ve özellikleri aksiyon halinde inceleyin!</em> 🎮
</p>

## ✨ Temel Özellikler

### 🎮 **Unity Benzeri Editör Arayüzü**
- **Çift pencereli kurulum**: Sahne editörü ve oyun görünümü yan yana
- **Canlı düzenleme**: Oyun çalışırken sahneleri düzenleyin
- **İnceleyici paneli**: Sürükle-bırak ile görsel bileşen düzenleme
- **Hiyerarşi görünümü**: Varlıkları organize etme ve yönetme
- **Varlık tarayıcısı**: Kolay doku ve ses yönetimi

### 🤖 **Yapay Zeka Odaklı Geliştirme**
- **Gemini AI Entegrasyonu**: Oyun geliştirme için doğal dilde komutlar
- **Akıllı betik oluşturma**: Yapay zeka destekli Lua betiği üretimi
- **Varlık düzenleme**: Değişiklikleri sade İngilizce ile tarif edin
- **Kolay API kurulumu**: Yerleşik Gemini API anahtarı yapılandırması
### 🔊 **Gelişmiş Ses Sistemi**
- **Çoklu ses efektleri**: Her varlık için birden fazla isimlendirilmiş ses (yürüme, zıplama, saldırı, vb.)
- **Geleneksel ses**: Arka plan müziği ve ortam sesleri
- **Lua entegrasyonu**: Komut dosyalarından `PlaySound(entity, "action")` ile ses tetikleme
- **Görsel editör**: Denetçi üzerinden ses efektlerini yönetme

### 🎯 **Varlık-Bileşen-Sistem (ECS)**
- **Yüksek performans**: Çok sayıda varlık için optimize edilmiş
- **Modüler tasarım**: Gerektiği gibi bileşenleri karıştır ve eşleştir
- **Komut dosyası entegrasyonu**: Tam ECS erişimi ile Lua betik yazma
- **Gerçek zamanlı güncellemeler**: Canlı bileşen düzenleme

### 🎨 **Grafik & Animasyon**
- **Sprite işleme**: Verimli 2D grafik iş hattı
- **Animasyon sistemi**: Döngülü, kare tabanlı animasyonlar
- **Dönüşüm sistemi**: Konum, dönüş ve ölçeklendirme
- **Kamera sistemi**: Birden fazla kamera desteği

### ⚡ **Fizik & Çarpışma**
- **Çarpışma algılama**: Uzamsal optimizasyonlu AABB çarpışma
- **Rigidbody fiziği**: Yerçekimi, hız ve kuvvetler
- **Çarpışma geribildirimleri**: Komut dosyasından erişilebilen çarpışma olayları
- **Uzamsal bölme**: Performans için quadtree optimizasyonu
## 🎬 Aşağıdaki görsele tıklayarak bir video gösterimini izleyebilirsiniz:
<p align="center">
  <a href="https://x.com/BaslaelWorkneh/status/1922713614697288096">
    <img src="https://raw.githubusercontent.com/basketoengine/Basketo/main/readmeimgs/image2.png" alt="Basketo Engine Demo" width="500"/>
  </a>
</p>

## � Hızlı Başlangıç Rehberi

### 1. **Gemini API Anahtarınızı Alın** (Opsiyonel fakat Tavsiye Edilir)
- [Google AI Studio](https://aistudio.google.com/app/apikey) adresini ziyaret edin
- Giriş yapın ve ücretsiz bir API anahtarı oluşturun
- Bu, doğal dil komutları gibi yapay zeka destekli özellikleri etkinleştirir

### 2. **Derleyin ve Çalıştırın**
```bash
git clone --recurse-submodules git@github.com:basketoengine/Basketo.git
cd Basketo && mkdir build && cd build
cmake .. && make -j$(nproc)
./BasketoGameEngine
```
### 3. **Yapay Zeka Özelliklerini Yapılandırın**
- Motorda, AI Prompt paneline gidin (altta)
- "🤖 Gemini AI Configuration" seçeneğini bulun
- API anahtarınızı girin ve "Kaydet"e tıklayın

### 4. **Oluşturmaya Başlayın**
- AI komutlarını deneyin: `"create a player at 100 200"`
- Denetleyicide varlıklara ses efektleri ekleyin
- Lua betikleri yazın veya AI'ın onları oluşturmasına izin verin
- Canlı geliştirme için çift pencereli editörü kullanın

## �🛠️ Motoru Derleme (Linux) 🐧

### Gereksinimler
- CMake 3.26.0 veya üzeri gereklidir.
- SDL2, SDL2_image, SDL2_ttf, SDL2_mixer
- Lua 5.4
- g++ (C++17)
- libcurl (AI özellikleri için)
- nlohmann/json (alt modül olarak dahil)
- ImGui (alt modül olarak dahil)
### Derleme Adımları
```bash
# Depoyu klonlayın
git clone --recurse-submodules git@github.com:basketoengine/Basketo.git

cd Basketo

mkdir build && cd build

cmake ..

make -j$(nproc)

```

### Çalıştırma
```bash
./BasketoGameEngine

```
Fizik testini çalıştırmak istiyorsanız:
```bash
./PhysicsTest

```

## 🛠️ Motorun Derlenmesi (Windows) 💻

### Ön Koşullar

1. **Visual Studio 2022 (Community Edition veya üzeri)**  
   Şu iş yükleriyle birlikte yükleyin:
   - Masaüstü geliştirme (C++) ile
   - C++ CMake araçları (Windows için)
   - Windows 10 veya 11 SDK

2. **CMake** (Visual Studio ile birlikte gelir veya https://cmake.org/download/ adresinden indirebilirsiniz)

3. **vcpkg** (bağımlılıkları yüklemek için kullanılır)


---
### Bağımlılıkları Yükleyin

```bash
# VS 2022 için Geliştirici Komut İstemcisi veya PowerShell açın

# vcpkg'yi klonlayın

git clone https://github.com/microsoft/vcpkg.git
cd vcpkg

.\bootstrap-vcpkg.bat

# Gerekli kütüphaneleri yükleyin
.\vcpkg install sdl2 sdl2-image sdl2-ttf sdl2-mixer lua curl

```

---

### Derleme Adımları
```bash
# Basketo deposunu klonlayın
git clone --recurse-submodules git@github.com:basketoengine/Basketo.git
cd Basketo
mkdir build && cd build

# CMake ile yapılandırın
cmake .. -DCMAKE_TOOLCHAIN_FILE=C:/yol/vcpkg/scripts/buildsystems/vcpkg.cmake -DCMAKE_BUILD_TYPE=Release

# "C:/yol/vcpkg" kısmını vcpkg dizininizin tam yolu ile değiştirin

# Motoru derleyin
cmake --build . --config Release
```

---

### Çalıştırma

```bash
# build/Release dizininden
```
./BasketoGameEngine.exe

# Fizik testini çalıştırmak için
./PhysicsTest.exe
```

## 📚 Dokümantasyon

### Temel Özellikler
- **[Ses Efektleri Sistemi](https://raw.githubusercontent.com/basketoengine/Basketo/main/docs/SoundEffectsSystem.md)**: Çoklu ses efektleri için eksiksiz rehber
- **[Gemini API Kurulumu](https://raw.githubusercontent.com/basketoengine/Basketo/main/docs/GeminiAPIKeySetup.md)**: Adım adım AI yapılandırması
- **[Lua Betik Yazımı](assets/Scripts/)**: Örnek betikler ve API referansı

### Örnek Kullanım

#### AI Destekli Geliştirme
```bash
# Doğal dil komutları
"100 200 konumunda bir oyuncu karakteri oluştur"
"oyuncuya zıplama davranışı ekle"
"düşmanın daha hızlı hareket etmesini sağla"

# Script oluşturma
gemini_script bir platformer kontrolcüsü oluştur çift zıplama ile
```

#### Çoklu Ses Efektleri
```lua
-- Lua betiklerinizde
PlaySound(entity, "jump")    -- Zıplama sesini çal
PlaySound(entity, "walk")    -- Yürüme sesini çal
PlaySound(entity, "attack")  -- Saldırı sesini çal

-- Sesin var olup olmadığını kontrol et
if HasSoundEffect(entity, "jump") then
    PlaySound(entity, "jump")
end
```

#### Bileşen Sistemi
- **Transform**: Konum, rotasyon, ölçek
- **Sprite**: Doku çizimi
- **Animation**: Kare tabanlı animasyonlar
- **Script**: Lua davranış betikleri
- **Collider**: Fiziksel çarpışma
- **Rigidbody**: Fizik simülasyonu
- **Audio**: Arka plan müziği
- **SoundEffects**: Birden fazla isimlendirilmiş ses
- **Camera**: Görünüm yönetimi
## 🤝 Katkıda Bulunun

Topluluğumuzdan gelen katkıları çok seviyoruz ❤️. Katkıda bulunma veya projeyi geliştirme amacıyla çalıştırma detayları için [Katkı Rehberimize](https://raw.githubusercontent.com/basketoengine/Basketo/main/ContributionGuidline.md) göz atabilirsiniz. <!-- Bu dosyanın sizde mevcut olduğu varsayılmıştır -->

- 🐛 Bir hata mı buldunuz? Bir issue açın!
- ✨ Harika bir özellik fikriniz mi var? Dinlemek isteriz!
- 💻 Katkıda bulunmak mı istiyorsunuz? Forklayın, kodlayın ve bir pull request oluşturun!

Bu motoru birlikte geliştirelim ve oyun geliştirmeyi herkes için eğlenceli ve kolay hale getirelim. 🌍

## 👥 Topluluk
Kocaman bir sarılmayla hoş geldiniz 🤗. Her türlü topluluk katkısı için çok heyecanlıyız - ister kod iyileştirmeleri 📝, ister dokümantasyon güncellemeleri 📚, hata raporları 🐞, özellik talepleri 💡 ve Discord'da tartışmalar 🗣️ olsun.

Topluluğumuza buradan katılabilirsiniz:

- 👋 [Discord topluluğumuza katılın](https://discord.gg/F3DswRMW)
- ⭐ [GitHub’da bizi yıldızlayın](https://github.com/basketoengine/Basketo)

## 🙏 Bize Destek Olun:
Sürekli gelişiyoruz ve yakında daha fazla özellik ve örnek sunacağız 🌟. Bu projeyi seviyorsanız, lütfen GitHub reposunda bize bir yıldız ⭐ bırakın [![GitHub](https://img.shields.io/github/stars/basketoengine/Basketo?color=5B5BD6)](https://github.com/basketoengine/Basketo), böylece gelişmeleri takip edebilir ve büyümemize yardımcı olabilirsiniz. 🌱

---

Mutlu kodlamalar ve oyun yapımlar! 🎉🎮


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-10

---