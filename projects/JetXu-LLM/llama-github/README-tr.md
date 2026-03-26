<div align="right">
  <details>
    <summary >🌐 Dil</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# llama-github

[Ayrıntılı Belge] https://deepwiki.com/JetXu-LLM/llama-github

[![PyPI sürümü](https://badge.fury.io/py/llama-github.svg)](https://badge.fury.io/py/llama-github)
[![İndirmeler](https://static.pepy.tech/badge/Llama-github)](https://pepy.tech/project/Llama-github)
[![Lisans](https://img.shields.io/badge/License-Apache%202.0-blue.svg)](https://opensource.org/licenses/Apache-2.0)

Llama-github, sorgularınıza göre GitHub'daki en alakalı kod parçacıklarını, sorunları ve depo bilgilerini (Agentic RAG tabanlı) bulmanıza yardımcı olan güçlü bir araçtır; bunları değerli bilgi bağlamına dönüştürür. LLM Sohbetbotlarını, AI Ajanlarını ve Otomatik geliştirme Ajanlarını karmaşık kodlama görevlerini çözmek için güçlendirir. İster hızlı çözümler arayan bir geliştirici, ister gelişmiş Otomatik Geliştirme AI Ajanlarını uygulayan bir mühendis olun, llama-github bunu kolay ve verimli hale getirir.


Eğer bu projeyi beğendiyseniz veya potansiyeli olduğuna inanıyorsanız, lütfen bir ⭐️ verin. Desteğiniz en büyük motivasyonumuz!

## Mimari
![Yüksek Seviyede Mimari](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/./docs/high_level_architecture.drawio.svg)

## Kurulum
```
pip install llama-github
```

Mevcut desteklenen çalışma zamanı hedefi: Python `3.10+`.

## Kullanım

llama-github'u nasıl kullanacağınızla ilgili basit bir örnek:

```python
from llama_github import GithubRAG

# Initialize GithubRAG with your credentials
github_rag = GithubRAG(
    github_access_token="your_github_access_token", 
    openai_api_key="your_openai_api_key", # Optional in Simple Mode
    jina_api_key="your_jina_api_key" # Optional - unless you want high concurrency production deployment (s.jina.ai API will be used in llama-github)
)

# Retrieve context for a coding question (simple_mode is default set to False)
query = "How to create a NumPy array in Python?"
contexts = github_rag.retrieve_context(
    query,
    # simple_mode = True
)

print(contexts[0]["url"])
print(contexts[0]["context"])
```

`retrieve_context()` bir liste halinde bağlam (context) sözlükleri döndürür. Her bir öğe en az `context` ve `url` içerir.

Daha gelişmiş kullanım ve örnekler için lütfen [dokümantasyonu](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/docs/usage.md) inceleyin. Çalıştırılabilir düşük maliyetli örnekler ise [`examples/`](examples) klasöründe mevcuttur.

## Temel Özellikler

- **🔍 Akıllı GitHub Alımı**: Llama-github ile kullanıcı sorgularına göre oldukça ilgili kod parçacıkları, sorunlar ve depo bilgilerini GitHub’dan alın. Gelişmiş alım tekniklerimiz, en alakalı bilgilere hızlı ve verimli şekilde ulaşmanızı sağlar.

- **⚡ Depo Havuzu Önbellekleme**: Llama-github yenilikçi bir depo havuzu önbellekleme mekanizmasına sahiptir. Depoları (README’ler, yapılar, kodlar ve sorunlar dahil) iplikler arasında önbelleğe alarak, llama-github GitHub arama alım verimliliğini önemli ölçüde artırır ve GitHub API token tüketimini en aza indirir.

- **🧠 LLM Destekli Soru Analizi**: Kullanıcı sorularını analiz etmek ve oldukça etkili arama stratejileri ile kriterler üretmek için son teknoloji dil modellerinden yararlanın. Llama-github karmaşık sorguları akıllıca parçalara ayırır ve GitHub’ın geniş depo ağı içinden en alakalı bilgileri elde etmenizi sağlar.

- **📚 Kapsamlı Bağlam Üretimi**: GitHub’dan alınan bilgileri gelişmiş dil modellerinin çıkarım yetenekleriyle kusursuzca birleştirerek zengin, bağlamsal olarak alakalı yanıtlar üretin. Llama-github en karmaşık ve uzun soruları bile ele alır; geliştirme ihtiyaçlarınızı destekleyecek şekilde kapsamlı, içgörülü ve geniş bağlamlı yanıtlar sunar.

- **🚀 Asenkron İşlem Mükemmelliği**: Llama-github tamamen asenkron programlamanın tüm potansiyelinden yararlanacak şekilde sıfırdan inşa edilmiştir. Kod tabanına özenle işlenmiş asenkron mekanizmalar sayesinde, llama-github birden fazla isteği aynı anda işleyebilir ve genel performansı önemli ölçüde artırır.

- **🔧 Esnek LLM Entegrasyonu**: Llama-github’ı çeşitli LLM sağlayıcıları, gömülü modeller, yeniden sıralama modelleri veya LangChain uyumlu bir sohbet modeli ile kolayca entegre edin; kütüphanenin yeteneklerini kendi ihtiyaçlarınıza göre özelleştirin.

- **🔒 Güçlü Kimlik Doğrulama Seçenekleri**: Llama-github hem kişisel erişim token’ları hem de GitHub Uygulama kimlik doğrulamasını destekler; farklı geliştirme ortamlarına entegre etmek için esneklik sunar. Bireysel bir geliştirici olun ya da kurumsal ortamda çalışın, llama-github güvenli ve güvenilir kimlik doğrulama mekanizmalarıyla hizmetinizde.

- **🛠️ Kayıt ve Hata Yönetimi**: Sorunsuz operasyonlar ve kolay hata ayıklamanın önemini biliyoruz. Bu yüzden llama-github, kapsamlı kayıt tutma ve hata yönetimi mekanizmalarıyla donatılmıştır. Kütüphanenin davranışına derinlemesine bakış kazanın, sorunları hızla teşhis edin ve istikrarlı, güvenilir bir geliştirme akışı sağlayın.

## 🤖 Yapay Zeka Destekli PR İnceleme Asistanımızı Deneyin: LlamaPReview

Llama-github’ı faydalı buluyorsanız, yapay zeka destekli GitHub PR inceleme asistanımız LlamaPReview ile de ilgilenebilirsiniz. Geliştirme iş akışınızı tamamlamak ve kod kalitesini daha da artırmak için tasarlanmıştır.

### LlamaPReview’ın Temel Özellikleri:
- 🚀 Tek tıklamayla kurulum, sıfır yapılandırma, tamamen otomatik çalışma
- 💯 Şu anda ücretsizdir – kredi kartı veya ödeme bilgisi gerektirmez
- 🧠 Yapay zeka destekli, otomatik PR incelemeleriyle derinlemesine kod anlayışı
- 🌐 Birden fazla programlama dilini destekler

**LlamaPReview, akıllı ve bağlama duyarlı kod incelemeleri sağlamak için llama-github’ın gelişmiş bağlam alımı ve LLM destekli analizini kullanır.** Sanki deponuzun tüm bağlamına hakim kıdemli bir geliştirici her PR’ı otomatik olarak inceliyor gibi!

👉 [LlamaPReview’i Şimdi Kurun](https://github.com/marketplace/llamapreview/) (Ücretsiz)

Bağlam alımı için llama-github’ı ve kod incelemeleri için LlamaPReview’i kullanarak güçlü, yapay zeka destekli bir geliştirme ortamı oluşturabilirsiniz.

## Vizyon ve Yol Haritası

### Vizyon

Vizyonumuz, GitHub ile sorunsuz bir şekilde entegre olarak LLM’lerin karmaşık kodlama görevlerini otomatik olarak çözmesini sağlayan, AI tabanlı geliştirme çözülerinin geleceğinde kilit bir modül olmaktır.

![Vizyon Mimarisi](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/./docs/vision.drawio.svg)

### Yol Haritası

Önceki yol haritasının tarihsel görünümü için lütfen [Vizyon ve Yol Haritası](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/VISION_AND_ROADMAP.md) adresini ziyaret edin.

## Teşekkürler

Aşağıdaki açık kaynak projelere destekleri ve katkıları için teşekkürlerimizi sunarız:

- **[LangChain](https://github.com/langchain-ai/langchain)**: Llama-github’da LLM tetikleme ve işleme yeteneklerini güçlendiren temel framework’ü sağladığı için.
- **[Jina.ai](https://github.com/jina-ai/reader)**: Llama-github’da üretilen bağlamların doğruluğunu ve alaka düzeyini artıran s.jina.ai API’si ile açık kaynaklı reranker ve embedding modellerini sunduğu için.

Katkıları, llama-github’ın geliştirilmesinde çok önemli olmuştur ve daha yenilikçi çözümler için projelerini incelemenizi tavsiye ederiz.

## Katkı

Llama-github’a katkıda bulunmak isteyenleri memnuniyetle karşılıyoruz! Daha fazla bilgi için [katkı yönergelerimize](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/CONTRIBUTING.md) göz atın.

## Lisans

Bu proje, Apache 2.0 lisansı kapsamında lisanslanmıştır. Daha fazla ayrıntı için [LİSANS](LICENSE) dosyasını inceleyin.

## İletişim

Herhangi bir sorunuz, öneriniz veya geri bildiriminiz varsa, lütfen [Jet Xu’nun e-postasına](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/mailto:Voldemort.xu@foxmail.com) ulaşmaktan çekinmeyin.

---

Llama-github’ı seçtiğiniz için teşekkür ederiz! Bu kütüphanenin AI geliştirme deneyiminizi artırmasını ve güçlü uygulamalar oluşturmanıza yardımcı olmasını umuyoruz.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-26

---