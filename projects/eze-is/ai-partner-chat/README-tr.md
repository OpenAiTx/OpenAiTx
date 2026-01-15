
<div align="right">
  <details>
    <summary >🌐 Dil</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# AI Partner Chat

Bir Claude Skills projesi, AI'ın kişiselleştirilmiş sohbet ortağınız olmasını sağlar.

## Proje Tanıtımı

AI Partner Chat, kullanıcı profili, AI profili ve vektörleştirilmiş kişisel notları bütünleştirerek kişiselleştirilmiş, bağlam farkındalığı olan bir sohbet deneyimi sunar. Bu yetenek, AI'ın daha önceki düşüncelerinizi, tercihlerinizi ve bilgi tabanınızı hatırlamasına ve alıntı yapmasına olanak tanır; böylece daha tutarlı ve kişisel bir etkileşim deneyimi oluşturur.

## Temel Özellikler

### 🎭 Çift Profil Sistemi
- **Kullanıcı Profili**: Arka planınızı, uzmanlıklarınızı, ilgi alanlarınızı ve iletişim tercihlerinizi tanımlar
- **AI Profili**: AI’nın rol konumunu, iletişim tarzını ve etkileşim şeklini özelleştirir

### 📝 Akıllı Not Arama
- Markdown notlarınızı otomatik olarak indeksler
- Diyalog içeriğine göre ilgili geçmiş kayıtları akıllıca arar
- Sohbet sırasında önceki fikirlerinizi ve notlarınızı doğal olarak alıntılar

### 💬 Kişiselleştirilmiş Sohbet
- Profiliniz ve notlarınız temelinde kişiselleştirilmiş yanıtlar üretir
- Sohbetin bağlam bütünlüğünü korur
- Fikirlerinizi bir arkadaş gibi doğal bir şekilde alıntılar, mekanik “kayda göre” yaklaşımı yerine

## Kullanım Senaryoları

Şu durumlarda ihtiyacınız olduğunda:
- Kişiselleştirilmiş iletişim, genel cevaplar yerine
- Bağlamı algılayan yanıtlar, AI arka planınızı hatırlayabilir
- AI önceki fikirlerinizi ve notlarınızı hatırlayıp alıntılayabilir
- Her seferinde sıfırdan başlamak yerine devamlı bir sohbet deneyimi

## Kurulum ve Kullanım

### Yetenek Kurulumu

Bu projeyi çalışma dizininizdeki `.claude/skills/` klasörüne kopyalayın:

```
<你的项目根目录>/
└── .claude/
    └── skills/
        └── ai-partner-chat/    # 本技能包
            ├── assets/
            ├── scripts/
            ├── SKILL.md
            └── README.md
```

### Beceri Kullanımı

Claude Code'da aşağıdaki komutu göndererek bu beceriyi etkinleştirebilirsiniz:

```
遵循 ai-partner-chat 对话
```

AI ajanı otomatik olarak şunları yapar:
- Yetenek yapılandırmasını ve yönergeleri okur
- Gerekli dizin yapısını oluşturur (`notes/`, `config/`, `vector_db/` vb.)
- İhtiyacınıza göre başlatma işlemini gerçekleştirir

### Başlatma Süreci

#### Yöntem 1: AI'nın otomatik oluşturup yapılandırmasına izin verin

İlk kullanımda doğrudan AI'ya şunu söyleyin:

```
我刚刚在 notes 里放入了对应的笔记，请根据笔记内容，进行向量化；并基于笔记内容，推测并更新 user-persona.md，以及最适合我的 ai-persona.md
```

AI ajanı şunları yapar:
1. `notes/` dizinindeki not içeriklerini analiz eder
2. Not formatına göre akıllıca bölümlendirir ve vektör veritabanı oluşturur
3. Notlara dayanarak senin geçmişini ve tercihlerini tahmin eder
4. Otomatik olarak `config/user-persona.md` dosyasını oluşturur ve günceller
5. Senin özelliklerine göre öneride bulunur ve `config/ai-persona.md` dosyasını oluşturur

#### Yöntem 2: Profili manuel olarak yapılandırma

Eğer profilini kendin tanımlamak istersen:
1. AI ajanı şablondan otomatik olarak profil dosyalarını `config/` dizinine oluşturur
2. Bu dosyaları elle düzenleyerek profilini özelleştirebilirsin
3. Sonrasında AI’ya vektörleştirme işlemi yapmasını söyleyebilirsin

### Sohbete başlama

Yapılandırma tamamlandıktan sonra, her kullanımda sadece şunu göndermen yeterlidir:

```
遵循 ai-partner-chat 对话
```
AI şunları yapacaktır:
- Profilini okuyarak geçmişini anlayacak
- İlgili geçmiş notları arayacak
- Kişiselleştirilmiş, bağlama duyarlı yanıtlar oluşturacak

## Proje Yapısı

### Yetenek Paketi Yapısı (`.claude/skills/ai-partner-chat/` içinde yer alır)


```
ai-partner-chat/
├── assets/              # 画像模板
│   ├── user-persona-template.md
│   └── ai-persona-template.md
├── scripts/             # 核心脚本
│   ├── chunk_schema.py
│   ├── vector_indexer.py
│   ├── vector_utils.py
│   └── requirements.txt
├── SKILL.md            # 技能详细文档（AI agent 会读取此文件）
└── README.md           # 本文件
```

### Kullanıcı veri dizini (proje kök dizininde bulunur)

AI agent, proje kök dizininde aşağıdaki yapıyı oluşturacaktır:

```
<项目根目录>/
├── notes/              # 你的笔记（由你或 AI agent 创建）
├── config/             # 画像配置（由 AI agent 创建）
│   ├── user-persona.md
│   └── ai-persona.md
├── vector_db/          # 向量数据库（由 AI agent 创建）
└── venv/               # Python 虚拟环境（由 AI agent 创建）
```

**Önemli**: Kullanıcı verileri ile yetenek paketleri ayrıdır, bu da yedekleme ve taşımayı kolaylaştırır.

## İş Akışı

1. **Profil Yükleme**: Kullanıcı ve AI profillerini okuyarak etkileşim arka planını anlama
2. **Notları Arama**: Kullanıcı sorgusuna göre, vektör veritabanından en ilgili notları bulma
3. **Bağlam Oluşturma**: Profil bilgileri, ilgili notlar ve diyalog geçmişini birleştirme
4. **Yanıt Oluşturma**: Bağlam temelinde kişiselleştirilmiş ve doğal yanıtlar üretme

## Öne Çıkan Özellikler

### 🤖 AI Agent Akıllı Parçalama
Sistem, her bir notun gerçek formatını analiz eder ve en uygun parçalama stratejisini dinamik olarak üretir, önceden belirlenmiş şablonlar kullanmaz. Bu, notlarınız hangi formatta olursa olsun en iyi şekilde işleneceği anlamına gelir.

### 🎯 Doğal Alıntı
AI, geçmiş bilgilerinizi hatırlıyormuş gibi doğal biçimde diyaloga dahil eder, "kayda göre" gibi ifadelerle sertçe değil, akıcı biçimde konuşmaya entegre eder.

### 📦 Veri Bağımsızlığı
Tüm verileriniz (notlar, profiller, vektör veritabanı) proje kök dizininde saklanır; bu sayede kolayca yedeklenebilir, taşınabilir veya farklı yeteneklerle paylaşılabilir.

## En İyi Uygulamalar

### Profil Tasarımı
- **Açık ve Net**: Belirsiz profil genel yanıtlar alınmasına sebep olur
- **Örnek İçerikli**: AI profilinde beklenen etkileşim tarzını örneklerle gösterin
- **Düzenli Güncelleme**: Diyalog kalitesine göre profili sürekli iyileştirin

### Not Yönetimi
- **Serbest Format**: Sistem her türlü not yapısına uyum sağlar
- **Zengin İçerik**: Derinlemesine notlar daha iyi arama sonuçları getirir
- **Zamanında Güncelleme**: Yeni notları indekse eklemeyi unutmayın

### Diyalog Deneyimi
- **Doğal Alıntı**: Notları yalnızca gerçekten ilgili olduğunda alıntılayın
- **Akıcı Kalın**: Alıntılar diyalogun doğal akışını bozmasın
- **Kaliteye Odaklanın**: Bağlantı sayısından çok anlamlı bağlantıları tercih edin

## Bakım ve Güncelleme

### Yeni Not Ekleme
Yeni notu `notes/` dizinine ekledikten sonra, AI'ya şunu söyleyin:

```
我刚刚在 notes 里添加了新笔记，请更新向量数据库
```

AI ajanı yeni notları otomatik olarak analiz eder ve dizini günceller.

### Profil Güncelleme
`config/` dizini altındaki profil dosyasını doğrudan düzenleyebilir veya AI'ya söyleyebilirsiniz:

```
请根据我最近的笔记内容，更新 user-persona.md 和 ai-persona.md
```

### Dizinleri Yeniden Oluşturma
Not yapısında önemli bir değişiklik olduğunda, AI'ya söyleyin:

```
请重新初始化向量数据库
```

AI agent tüm notları yeniden analiz edecek ve dizini yeniden oluşturacaktır.

## Dikkat Edilmesi Gerekenler

- **İlk Çalıştırma**: AI agent, vektör veritabanını ilk kez oluştururken gömme modelini (yaklaşık 4.3GB) otomatik olarak indirecek, lütfen sabırlı olun
- **Python Ortamı**: AI agent gerekli bağımlılıkları yükleyerek otomatik olarak sanal ortam oluşturacaktır
- **Veri Depolama**: Tüm veriler (notlar, profiller, vektör veritabanı) proje kök dizininde saklanır, yetenek paketi dizininde değil
- **Yetenek Konumu**: Yetenek paketinin `.claude/skills/ai-partner-chat/` dizininde olduğundan emin olun

## Daha Fazla Bilgi

Detaylı teknik dokümantasyon ve kullanım kılavuzu için `SKILL.md` dosyasına bakınız.

---

AI'nın sadece bir araç değil, sizi gerçekten anlayan bir sohbet ortağı olmasını sağlayın.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-15

---