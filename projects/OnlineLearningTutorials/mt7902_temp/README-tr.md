
<div align="right">
  <details>
    <summary >🌐 Dil</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# 🎯 MT7902 Sürücüsü, MT7921 Sürücüsünün Alt Parçası Olarak (✅ Çalışıyor)
Mediatek mt7902 wifi 6E çipi Bluetooth ve WiFi Desteği

> [!ÖNEMLİ]
> Linux 7.1 Çekirdeği Resmi Olarak MT7902 WIFI 6E çipini Destekliyor


## 📁 Depoyu Klonlama
Depoyu yerel bilgisayarınıza kopyalayın
  ```
  git clone https://github.com/OnlineLearningTutorials/mt7902_temp
  ```
Eğer geçmiş geçmişi klonlamak istemiyorsanız
  ```
  git clone --depth 1 https://github.com/OnlineLearningTutorials/mt7902_temp
  ```

## Kurulum


### 🚀 Kurulum Kılavuzu Scripti (Ubuntu Tabanlı Sistemler için Önerilir)
Scripti henüz çalıştırılabilir değilse çalıştırılabilir yapın
```
chmod +x ./install_guide.sh
```
Şimdi bu betiği çalıştır
```
./install_guide.sh
```
Gerektiğinde otomatik olarak şifre isteyecektir
* Bu betik, sizi sırasıyla firmware, bluetooth ve wifi sürücüsünü yüklemeye yönlendirecek
* Ubuntu üzerinde linux 7.0 çekirdeği ile test edilmiştir

### 🚀 Kolay Otomatik Düzeltme (Arch Tabanlı Sistemler için Önerilir)
WiFi ve Bluetooth'unuzu herhangi bir modern çekirdekte hızlıca düzeltmek istiyorsanız, şu adımları izleyin:

Betik zaten çalıştırılabilir değilse, çalıştırılabilir yapın
```
chmod +x ./fix_my_wifi.sh
```

**Otomatik düzeltme betiğini** sudo ile çalıştırın:
```bash
sudo bash fix_my_wifi.sh
```

#### 📖 Bu script ne yapar:
* **Bağımlılıkları kontrol eder:** `gcc`/`clang`, `make`, `bc` ve mevcut `kernel-headers` kurulu olup olmadığını kontrol eder. Eğer yoksa, tercih ettiğiniz paket yöneticisiyle kurulum yapar.
* **Sürücüleri derler:** Hem WiFi hem de Bluetooth sürücülerini tam olarak sizin kernel versiyonunuz için otomatik olarak oluşturur.
* **Kalıcı Düzeltme:** Bilgisayarınızı yeniden başlattıktan sonra bile WiFi'nin aktif kalmasını sağlayan bir sistem servisi yükler.
* **Güvenlik:** Modülleri özel bir dizine (`/lib/modules/mt7902_custom`) yükleyerek varsayılan sistem dosyalarınızın bozulmasını engeller.

> [!NOT]
> Bu işlemi ilk kez çalıştırdığınızda gerekli derleme araçlarını (derleyici, linux-headers vb.) indirmek için internet bağlantısına (Ethernet veya telefonunuzdan USB tethering yoluyla) ihtiyacınız olacak.


## ✅ Test Edildi (Onaylandı)
Bu düzeltme doğrulandı ve çalıştığı teyit edildi:

* **Marka:** ASUS
* **Model:** Vivobook Go (E1404FA), Vivobook 14 (X1404ZA)
* **Yonga Seti:** MediaTek MT7902 (WiFi 6E)
* **Kernel Sürümü:** 6.19.0 (Linux), 6.19.11, 7.0.7
* **İşletim Sistemleri:** Arch, Ubuntu
* **Paket Yöneticisi:** pacman, apt

## Kullanılabilir:
* **İşletim Sistemi**: PM'lerden birini destekleyen herhangi bir işletim sistemi
* **Tercih edilen paket yöneticileri**: apt, pacman, dnf, zypper, nix-shell
* **Kernel sürümleri**: 6.14-7.0.7


## 🔧 Kullanılan Firmware’ler
Firmware’ler `firmware` klasöründe saklanır.


## 📱 Bluetooth ✅ (Çalışıyor)
> [!UYARI]
> Eğer bluetooth sürücüsü `gen4-mt7902` ile çakışıyorsa lütfen bluetooth firmware dosyasını kaldırın, böylece bu sürücü ile çakışmaz.
> ``` sudo rm /lib/firmware/mediatek/mt7902/BT_RAM_CODE_MT7902_1_1_hdr.bin.zst ```
> Bu proje şu firmware’i kullanır:
> ``` /lib/firmware/mediatek/BT_RAM_CODE_MT7902_1_1_hdr.bin.zst ```

Bluetooth'u etkinleştirmek için mevcut kernel sürümünüzün dizinine gidin. ``
Örneğin kernel linux-6.16 varsa, `./linux-6.16/drivers/bluetooth` dizinine gidin.
Bu dizinde terminali açın ve `make` komutuyla derleyin.
İki çekirdek modülü derlenir: `btusb.ko` ve `btmtk.ko`.
Cihazınızda bluetooth'u etkinleştirmek için sisteminizdeki btusb ve btmtk modüllerini kaldırın ve bu iki dosyayı yükleyin, şu komutları kullanın
```
sudo rmmod btusb 
sudo rmmod btmtk

sudo insmod btmtk.ko
sudo insmod btusb.ko

```
Şimdi bluetooth'unuzun çalışıp çalışmadığını kontrol edin.

## 💻 WiFi ✅ (Çalışıyor)
> [!IMPORTANT]
> Bazı sınırlamalarla çalışan bir depo [burada](https://github.com/hmtheboy154/gen4-mt7902)

mt7902 için, yakın zamanda mediatek tarafından yayımlanan WiFi sürücüsü `latest` klasörünün içinde.

Eğer Ubuntu kullanıyorsanız, sadece `latest` klasörüne gidin ve terminalde aşağıdaki komutu çalıştırın.
```
make
```

Tüm modülleri derleyecek, sıkıştıracak ve yükleyecek (orijinal çekirdek modülünü değiştirilmiş modül ile değiştirecek). Eğer başka bir dağıtım kullanıyorsanız veya tüm adımları istemiyorsanız ve sadece kodu derlemek istiyorsanız, terminalde çalıştırın
```
make module_compile
```
Derlediğiniz modülü sıkıştırmak için, ardından terminalde çalıştırın
```
make module_compress
```
Sıkıştırılmış modülü sistemin çekirdek modülüne kurmak için terminalde çalıştırın
```
make module_install
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-07

---