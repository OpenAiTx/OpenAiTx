![2](https://github.com/user-attachments/assets/a18257a3-a678-4fd4-bf77-750dab4d99bb)

# Agent

Doğal dil komutlarını yorumlayan, kodu dinamik olarak oluşturan ve çalıştıran, çalışma ortamını sıfır sürtünmeyle yöneten, yüksek hızlı ve kendi kendine yeten bir Python AI ajan framework’üdür. OpenAI Python SDK’sını kullanır. Otomatik bağımlılık kurulumu, güvenli ortam yapılandırması, yapılandırılmış günlükleme ve güçlü Python araçlarını gömülü olarak sunmak için minimalist bir eklenti arayüzü gibi özelliklere sahiptir—tüm bunlar izinli Apache 2.0 lisansı altında sunulmaktadır.

## ⭐ Yıldız Geçmişi

<p align="center">
  <a href="https://star-history.com/#machinegpt/agent&Date">
    <img alt="Star History Chart" src="https://api.star-history.com/svg?repos=machinegpt/agent&type=Date&theme=dark" onerror="this.src='https://api.star-history.com/svg?repos=machinegpt/agent&type=Date'" />
  </a>
</p>


## 🔧 Ortam Kurulumu

### Python Sanal Ortamı
Projeyi kurmadan önce bir sanal ortam oluşturmanız önerilir. Aşağıdaki adımları izleyin:

Sanal ortamlar hakkında bilgi edinin: [Python Packaging Guide](https://packaging.python.org/en/latest/guides/installing-using-pip-and-virtual-environments/)

Sanal ortamı oluşturun ve etkinleştirin:

**Windows:**

```
py -m venv .venv
.venv\Scripts\activate
```

**macOS/Linux:**
```
python3 -m venv .venv
source .venv/bin/activate
```

### Proje Kurulumu
Bu projenin çalışabilmesi için bir OpenAI API anahtarı gereklidir. Bunu sağlamak için, kök dizinde aşağıdaki içeriğe sahip bir .env dosyası oluşturun:
```
OPENAI_API_KEY=
```
Alternatif olarak, sağlanan .env.example dosyasını kopyalayıp anahtarı güncelleyebilirsiniz:
```
cp .env.example .env
```

## 🧠 Başlatma
Ajana başlamak için, sadece şunu çalıştırın:
```
git clone https://github.com/machinegpt/agent.git
cd agent

python machine.py
```

## ✨ Katkılar

Katkılar, öneriler, hata raporları ve düzeltmeler memnuniyetle karşılanır!

Yeni özellikler, bileşenler veya uzantılar için lütfen bir issue açarak tartışın ve ardından bir PR gönderin.

## 💖 Bu proje, katkıda bulunan tüm kişilere sayesinde mevcut durumunda var olmaktadır
<a href="https://github.com/machinegpt/agent/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=machinegpt/agent" />
</a>

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-04

---