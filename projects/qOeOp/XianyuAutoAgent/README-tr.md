<div align="right">
  <details>
    <summary >🌐 Dil</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# 🚀 Xianyu AutoAgent - Akıllı Xianyu Müşteri Hizmetleri Robotu Sistemi

[![Java Version](https://img.shields.io/badge/java21%2B-blue)](https://www.python.org/) [![LLM Powered](https://img.shields.io/badge/LLM-powered-FF6F61)](https://platform.openai.com/)

Xianyu platformu için özel olarak tasarlanmış yapay zeka destekli çözüm; Xianyu'da 7×24 otomatik nöbet, çoklu uzman işbirliğiyle karar verme, akıllı pazarlık ve bağlama duyarlı diyalog desteği sağlar.

## 🎮 Playground - Hızlı Deneyim (Yapılandırmasız Sürüm)

Yerel ortam veya Secrets ayarlamaya gerek yok! **GitHub Actions web arayüzünden parametre girerek** Xianyu robotunu tek tıkla başlatın.

### Nasıl Kullanılır
1. **Bu depoyu Fork'layın** → Sağ üstteki `Fork` butonuna tıklayın
2. **Action'ı tetikleyin**:
   - Kendi deponuzda `Actions` sekmesine girin
   - **`🚀 Run Service`** iş akışını seçin
   - **`Run workflow`** düğmesine tıklayın ve parametreleri girin:
      - `API Key`: Büyük dil modeli API anahtarınızı yapıştırın (ör. Alibaba Cloud DashScope)
      - `Cookies`: Xianyu web arayüzünden tam Cookie dizisini yapıştırın
3. **Çalışma günlüğüne bakın**:
   - Robot başlatıldıktan sonra Xianyu mesajlarını otomatik olarak dinler
   - Action günlüklerinde `🤖 Reply:` arayarak sohbet kayıtlarını görebilirsiniz

### Dikkat Edilecekler
⚠️ Geçici çalışma sınırına dikkat edin:
- Varsayılan çalışma süresi **30 dakika** (GitHub ücretsiz hesap limiti)
- Hassas bilgiler (ör. Cookie) **kaydedilmez**, sadece o oturumda geçerlidir

<div align="center">
  <img src="https://raw.githubusercontent.com/qOeOp/XianyuAutoAgent/main/./screenshots/workflow.png" width="400px" alt="workflow">
</div>

## 🌟 Temel Özellikler

### Akıllı Diyalog Motoru
| Modül        | Teknik Uygulama         | Temel Özellikler                                              |
| ------------ | ---------------------- | ------------------------------------------------------------ |
| Bağlam Algısı| Sohbet geçmişi saklama  | Hafif diyalog hafızası yönetimi, tüm sohbet geçmişi LLM'e bağlam olarak aktarılır |
| Uzman Yönlendirme| LLM prompt+Kural yönlendirme | Prompt mühendisliğine dayalı niyet tespiti → Uzman Agent dinamik dağıtımı, pazarlık/teknik/müşteri hizmetleri arasında sahne değiştirme desteği |

### İşlevsel Matris
| Modül     | Gerçekleştirildi                 | Planlanıyor                |
| --------- | ------------------------------- | ----------------------- |
| Temel Motor| ✅ LLM otomatik yanıt<br>✅ Bağlam yönetimi | 🔄 Duygu analizi geliştirmesi     |
| Pazarlık Sistemi | ✅ Kademeli fiyat indirme stratejisi   | 🔄 Piyasa karşılaştırması         |
| Teknik Destek | ✅ Web arama entegrasyonu              | 🔄 RAG bilgi tabanı geliştirmesi  |

## 🚴 Hızlı Başlangıç

### Sistem Gereksinimleri
- JDK 21+
- Maven 3.9.10+

### Kurulum Adımları

```bash
1. 克隆仓库
git clone https://github.com/qOeOp/XianyuAutoAgent.git
cd XianyuAutoAgent

2. 配置环境变量
- AI_DASHSCOPE_API_KEY : 阿里云大模型API-KEY
- COOKIES_STR : 闲鱼网页端Cookie

3. 执行命令
mvn spring-boot:run
注意：默认使用的模型是通义千问，如需使用其他API，请自行修改application.yml文件中的模型地址和模型名称；
COOKIES_STR自行在闲鱼网页端获取cookies(网页端F12打开控制台，选择Network，点击Fetch/XHR,点击一个请求，查看cookies)

4. (可选)创建提示词文件src/main/resources/*-prompt.txt
```
## 🤝 Katkıda Bulunma

Önerilerinizi Issue ile iletmeye veya PR ile kod katkısı yapmaya davetlisiniz, lütfen [Katkı Rehberi](https://contributing.md/)’ne uyunuz.



## 🛡 Dikkat Edilmesi Gerekenler

⚠️ Dikkat: **Bu proje yalnızca öğrenme ve iletişim amaçlıdır, herhangi bir ihlal durumunda lütfen yazarla iletişime geçip sildirin.**

Projenin hassasiyetinden dolayı, geliştirme ekibi herhangi bir zamanda **güncellemeyi durdurabilir** veya **projeyi silebilir**.


## 🧸 Özel Teşekkürler

Bu proje aşağıdaki açık kaynak projeler temel alınarak yeniden yapılandırılmıştır:
- [XianyuAutoAgent](https://github.com/shaxiu/XianyuAutoAgent) - Akıllı Xianyu müşteri hizmetleri robot sistemi, [@shaxiu](https://github.com/shaxiu) ve [@cv-cat](https://github.com/cv-cat) tarafından geliştirilmiştir


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---