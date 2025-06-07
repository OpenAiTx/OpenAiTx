## FanImeTsf

Bu, [FanImeServer](https://github.com/fanlumaster/FanImeServer)'ın TSF ucudur.

Not: Şu anda yalnızca 64-bit Uygulamalar desteklenmektedir.

## Nasıl Derlenir

### Gereksinimler

- Visual Studio 2022
- CMake
- vcpkg
- Python3
- gsudo

vcpkg ve gsudo'nun **Scoop** ile kurulu olduğundan emin olun.

## Derleme Adımları

### Derleme

Öncelikle, depoyu klonlayın,

```powershell
git clone --recursive https://github.com/fanlumaster/FanImeTsf.git
```

Sonra, ortamı hazırlayın,

```powershell
cd FanImeTsf
python .\scripts\prepare_env.py
```

Daha sonra derleyin,

```powershell
.\scripts\lcompile.ps1
```

### Kurulum

Powershell'i yönetici olarak başlatın, sistemde `Enable sudo` seçeneğinin açık olduğundan emin olun.

![](https://i.postimg.cc/zJCn9Cnn/image.png)

Ardından, `C:\Program Files\` dizininde `FanImeTsf` adında bir klasör oluşturun ve `FanImeTsf.dll` dosyasını buraya kopyalayın,

```powershell
gsudo
Copy-Item -Path ".\FanImeTsf\build64\Debug\FanImeTsf.dll" -Destination "C:\Program Files\FanImeTsf"
```

Sonra, kurulumunu yapın,

```powershell
cd "C:\Program Files\FanImeTsf"
sudo regsvr32 .\FanImeTsf.dll
```

### Kaldırma

```powershell
cd "C:\Program Files\FanImeTsf"
sudo regsvr32 /u .\FanImeTsf.dll
```

## Ekran Görüntüleri

![](https://i.postimg.cc/v8Bpx6Gf/image.png)

![](https://i.postimg.cc/ssBgtM5M/image.png)

![](https://i.postimg.cc/ryDqXH0B/image.png)

![](https://i.postimg.cc/2m9WJTgR/image.png)

![](https://i.postimg.cc/L96qQZT8/image.png)

![](https://i.postimg.cc/FNcz9QTv/image.png)

## Yol Haritası

Şu anda yalnızca Xiaohe Shuangpin desteklenmektedir.

### Çince

- Xiaohe Shuangpin
- Quanpin
- Hanzi Bileşenleri kullanımında yardımcı kodlar
- Özelleştirilebilir sözlük
- Özelleştirilebilir IME motoru
- Özelleştirilebilir temalar
- Basitleştirilmiş Çince ile Geleneksel Çince arasında geçiş yapabilme
- İngilizce otomatik tamamlama
- Açık Kaynaklı Bulut IME API'si
- Aday pencere arayüzünü dikey ve yatay modlar arasında değiştirme
- Özellik anahtarları: çoğu özellik kullanıcılar tarafından serbestçe açılıp kapatılabilir veya özelleştirilebilir olmalı

### Japonca Desteği

Belki başka bir proje.

Ve belki diğer bazı dillerin desteği.

### Referanslar

- [MS-TSF-IME-Demo](https://github.com/microsoft/Windows-classic-samples/tree/main/Samples/IME/cpp/SampleIME)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---