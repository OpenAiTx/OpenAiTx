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


[English](https://raw.githubusercontent.com/sz30/2048--/main/README.md) | [简体中文](https://raw.githubusercontent.com/sz30/2048--/main/README.zh-CN.md) | [繁體中文](https://raw.githubusercontent.com/sz30/2048--/main/README.zh-TW.md)

# 🎮 2048++

Klasik 2048 oyununun geliştirilmiş bir versiyonu, şimdi daha da eğlenceli özelliklerle! Bu küçük projeyi boş zamanımda hazırladım—umarım size de biraz neşe getirir!

## 🎯 Oyun Tanıtımı

2048, basit ama bağımlılık yapan bir sayı birleştirme oyunudur. 4x4'lük bir ızgarada yukarı, aşağı, sola veya sağa kaydırarak aynı sayıya sahip blokları birleştirin. Amaç? 2048'e ulaşmak (ama durmak zorunda değilsiniz, daha yüksek puanlar için devam edebilirsiniz)!

**Nasıl oynanır:**
- Blokları hareket ettirmek için yön tuşlarını veya WASD tuşlarını kullanın.
- Aynı sayıya sahip iki karo çarpıştığında, tek bir karo halinde birleşirler.
- Her hamleden sonra, rastgele bir boş alana yeni bir 2 veya 4 gelir.
- Hamle kalmadığında oyun sona erer.

## ✨ Özel Özellikler

### 1. Geri Al Fonksiyonu
- Yanlış bir hamle mi yaptınız? Sorun değil!
- Sadece "Geri Al" düğmesine basın ve bir önceki adıma dönün.
- Başlangıca kadar istediğiniz kadar geri alabilirsiniz.
- Artık yanlışlıkla dokunmak oyununuzu mahvetmesin!

### 2. Gizli Hile Modu
- Sihirli diziyi girin: ←←→→ →→←← (sol, sol, sağ, sağ, sağ, sağ, sol, sol)
- Tüm karolar sihirli bir şekilde 128'e dönüşür!
- Sadece eğlence amaçlı bir Paskalya yumurtası.
- İpucu: Hile yapmak eğlencelidir, ama aşırıya kaçmayın! 😉

## 🎯 Demo

🎯 : [Burada oynayın](http://2048.765431.xyz/)
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
- `2048.py`: Flask ile yazılmış arka uç sunucusu, oyun mantığını ve API isteklerini yönetir.
- `script.js`: Ön uç oyun mantığı, hareketler, animasyonlar ve özel özellikler dahil.
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

Kendi tarzını yaratmak ister misin? Yeni bir görünüm için `styles.css` dosyasını değiştir, ya da oynanışı değiştirmek için `script.js` dosyasına dal. Tüm kodlar kolayca müdahale edilebilmesi için detaylıca yorumlanmıştır!

## 📝 Lisans

GPL-2.0 lisansı

## 🤝 Katkıda Bulunma

Hâlâ güncelleniyor! Sorunlar ve Çekme İstekleri çok memnuniyetle karşılanır—bu oyunu birlikte daha da harika yapalım!


## 🙏 Teşekkürler

Bu projeye destek veren aşağıdaki sponsorlarımıza teşekkürler:
- [Aurora Cloud](https://www.free-vps.net/) sunucu desteği sağladı

---
_Son güncelleme: Ekim 2025_


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-29

---