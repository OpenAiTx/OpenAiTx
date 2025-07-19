<div align="right">
  <details>
    <summary >🌐 Diğer Diller</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>


[English](https://raw.githubusercontent.com/sz30/2048-magic/main/README.md) | [简体中文](https://raw.githubusercontent.com/sz30/2048-magic/main/README.zh-CN.md) | [繁體中文](https://raw.githubusercontent.com/sz30/2048-magic/main/README.zh-TW.md)

# 🎮 2048++

Klasik 2048 oyununun geliştirilmiş versiyonu, şimdi çok daha eğlenceli özelliklerle! Bu küçük projeyi boş zamanlarımda hazırladım—umarım size de keyif verir!

## 🎯 Oyun Tanıtımı

2048, basit ama bağımlılık yapan bir sayı birleştirme oyunudur. 4x4 bir ızgarada, aynı sayıya sahip kutucukları birleştirmek için yukarı, aşağı, sola veya sağa kaydırın. Amaç? 2048’e ulaşmak (ama isterseniz daha yüksek puanlar için devam edebilirsiniz)!

**Nasıl oynanır:**
- Kutucukları hareket ettirmek için ok tuşlarını veya WASD’yi kullanın.
- Aynı sayıya sahip iki kutucuk çarpıştığında, tek bir kutucuk olarak birleşirler.
- Her hamleden sonra, rastgele boş bir yere yeni bir 2 veya 4 gelir.
- Hamle yapacak yer kalmadığında oyun biter.

## ✨ Özel Özellikler

### 1. Geri Alma Fonksiyonu
- Yanlış bir hamle mi yaptınız? Sorun değil!
- Sadece "Geri Al" butonuna basarak bir adım geriye gidebilirsiniz.
- Başlangıca kadar istediğiniz kadar geri alabilirsiniz.
- Artık bir parmak hatası oyununuzu mahvetmeyecek!

### 2. Gizli Hile Modu
- Sihirli diziyi girin: ←←→→ →→←← (sol, sol, sağ, sağ, sağ, sağ, sol, sol)
- Tüm kutucuklar sihirli bir şekilde 128’e dönüşecek!
- Bu bir Paskalya yumurtası, sadece eğlence amaçlı.
- İpucu: Hile yapmak eğlenceli olabilir ama abartmayın! 😉

## 🎯 Demo

🎯 Buradan oyna: [http://2048.ct8.pl](http://2048.ct8.pl:9969/)
<img width="1279" alt="demo" src="https://github.com/user-attachments/assets/0df2c956-b6d9-4371-a916-f6ac3ae642be" />



## 📁 Proje Yapısı
```
2048/
├── static/
│ ├── css/
│ │ └── styles.css # Game styles
│ └── js/
│ └── script.js # Frontend game logic
├── index.html # Main game page
└── 2048.py # Backend server
```
**Dosya Açıklamaları:**
- `2048.py`: Flask ile yazılmış backend sunucusu, oyun mantığını ve API isteklerini yönetir.
- `script.js`: Ön yüz oyun mantığı, hamleler, animasyonlar ve özel özellikler dahil.
- `styles.css`: Oyun stilleri, her şeyin güzel ve duyarlı görünmesini sağlar.
- `index.html`: Her şeyi bir araya getiren ana sayfa.

## 🚀 Başlarken

**Yöntem 1: Sürümü İndir**
1. En son sürümü indirin.
2. Python 3.x yüklü olduğundan emin olun.
3. Bağımlılıkları yükleyin: `pip install flask`
4. Çalıştırın: `python 2048.py`
5. Tarayıcınızı açın ve şu adrese gidin: [http://localhost:9969](http://localhost:9969)

**Yöntem 2: GitHub'dan Klonla**
```bash
git clone https://github.com/sz30/2048.git
cd 2048
pip install flask
python 2048.py
```
## 🎨 Özelleştirme

Kendinize göre uyarlamak mı istiyorsunuz? Yeni bir görünüm için `styles.css` dosyasını düzenleyin veya oynanışı değiştirmek için `script.js` dosyasına dalın. Tüm kodlar kolayca düzenlenebilmesi için iyi açıklanmıştır!

## 📝 Lisans

GPL-2.0 lisansı

## 🤝 Katkıda Bulunun

Hâlâ güncelleniyor! Sorunlar ve Çekme İstekleri çok memnuniyetle karşılanır—bu oyunu birlikte daha da harika yapalım!


## 🙏 Teşekkürler

Bu projeye destek veren aşağıdaki sponsorlara teşekkürler:
- [Serv00](https://www.serv00.com/) sunucuyu sağladığı için

---
_Son güncelleme: Haz. 2025_



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-19

---