
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
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# llama-github

[Ayrıntılı Doküman] https://deepwiki.com/JetXu-LLM/llama-github

[![PyPI versiyonu](https://badge.fury.io/py/llama-github.svg)](https://badge.fury.io/py/llama-github)
[![İndirme](https://static.pepy.tech/badge/Llama-github)](https://pepy.tech/project/Llama-github)
[![Lisans](https://img.shields.io/badge/License-Apache%202.0-blue.svg)](https://opensource.org/licenses/Apache-2.0)

Llama-github, sorgularınıza dayalı olarak GitHub'dan en alakalı kod parçacıklarını, sorunları ve depo bilgilerini (Agentic RAG tabanlı) almanıza yardımcı olan güçlü bir araçtır ve bunları değerli bilgi bağlamına dönüştürür. LLM Sohbet Botlarını, Yapay Zeka Ajanlarını ve Otomatik Geliştirici Ajanlarını karmaşık kodlama görevlerini çözmeleri için güçlendirir. İster hızlı çözümler arayan bir geliştirici, ister gelişmiş Otomatik Geliştirici AI Ajanları uygulayan bir mühendis olun, llama-github bunu kolay ve verimli hale getirir.

Eğer bu projeyi beğendiyseniz veya potansiyeli olduğunu düşünüyorsanız, lütfen bir ⭐️ verin. Desteğiniz en büyük motivasyon kaynağımız!

## Mimari
![Yüksek Seviye Mimari](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/./docs/high_level_architecture.drawio.svg)

## Kurulum
```
pip install llama-github
```

## Kullanım

llama-github'un nasıl kullanılacağına dair basit bir örnek:

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
context = github_rag.retrieve_context(
    query, # In professional mode, one query will take nearly 1 min to generate final contexts. You could set log level to INFO to monitor the retrieval progress
    # simple_mode = True
)

print(context)
```

Daha gelişmiş kullanım ve örnekler için lütfen [dokümantasyona](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/docs/usage.md) başvurun.

## Temel Özellikler

- **🔍 Akıllı GitHub Getirme**: Llama-github'un gücünü kullanarak, kullanıcı sorgularına göre GitHub'dan son derece alakalı kod parçacıkları, sorunlar ve depo bilgileri alın. Gelişmiş getirme tekniklerimizle en alakalı bilgilere hızlı ve verimli bir şekilde ulaşın.

- **⚡ Depo Havuzu Önbellekleme**: Llama-github yenilikçi bir depo havuzu önbellekleme mekanizmasına sahiptir. Depoları (README'ler, yapılar, kod ve sorunlar dahil) iş parçacıkları arasında önbelleğe alarak, llama-github GitHub arama getirme verimliliğini önemli ölçüde artırır ve GitHub API belirteci tüketimini en aza indirir. Llama-github'u çoklu iş parçacıklı üretim ortamlarında güvenle kullanın; optimum performans göstereceğinden ve değerli kaynaklarınızı koruyacağından emin olun.

- **🧠 LLM Destekli Soru Analizi**: Kullanıcı sorularını analiz etmek ve son derece etkili arama stratejileri ile kriterleri oluşturmak için son teknoloji dil modellerinden yararlanın. Llama-github karmaşık sorguları akıllıca parçalara ayırır, GitHub'ın geniş depo ağından en alakalı bilgileri almanızı sağlar.

- **📚 Kapsamlı Bağlam Oluşturma**: GitHub'dan alınan bilgileri gelişmiş dil modellerinin çıkarım yetenekleriyle sorunsuz bir şekilde birleştirerek zengin, bağlamsal olarak alakalı yanıtlar oluşturun. Llama-github, en karmaşık ve uzun soruları bile başarıyla ele alır, geliştirme ihtiyaçlarınızı destekleyecek kapsamlı ve içgörülü yanıtlar sunar.

- **🚀 Asenkron İşleme Mükemmelliği**: Llama-github baştan sona asenkron programlamanın tüm potansiyelinden yararlanacak şekilde inşa edilmiştir. Kod tabanında titizlikle uygulanan asenkron mekanizmalar sayesinde, llama-github birden fazla isteği eşzamanlı olarak işleyebilir ve genel performansı önemli ölçüde artırır. Llama-github'un yüksek hacimli iş yüklerini hızdan veya kaliteden ödün vermeden nasıl yönettiğini deneyimleyin.

- **🔧 Esnek LLM Entegrasyonu**: Llama-github'u çeşitli LLM sağlayıcıları, gömme modelleri ve yeniden sıralama modelleriyle kolayca entegre edin ve kütüphanenin yeteneklerini özel gereksinimlerinize göre uyarlayın. Genişletilebilir mimarimiz sayesinde llama-github'un işlevselliğini özelleştirebilir ve geliştirebilir, böylece kendi geliştirme ortamınıza sorunsuzca uyum sağlar.

- **🔒 Güçlü Kimlik Doğrulama Seçenekleri**: Llama-github hem kişisel erişim belirteçlerini hem de GitHub Uygulama kimlik doğrulamasını destekler; bu da onu farklı geliştirme kurulumlarına entegre etme esnekliği sunar. Bireysel bir geliştirici olun ya da kurumsal bir ortamda çalışıyor olun, llama-github güvenli ve güvenilir kimlik doğrulama mekanizmaları ile ihtiyacınızı karşılar.

- **🛠️ Günlükleme ve Hata Yönetimi**: Sorunsuz operasyonlar ve kolay sorun giderme bizim için önemlidir. Bu nedenle llama-github kapsamlı günlükleme ve hata yönetimi mekanizmalarıyla donatılmıştır. Kütüphanenin davranışına derinlemesine bakış elde edin, sorunları hızla teşhis edin ve istikrarlı, güvenilir bir geliştirme iş akışı sürdürün.

## 🤖 Yapay Zeka Destekli PR İnceleme Asistanımızı Deneyin: LlamaPReview

Llama-github'u faydalı buluyorsanız, yapay zeka destekli GitHub PR inceleme asistanımız LlamaPReview ile de ilgilenebilirsiniz. Geliştirme iş akışınızı tamamlamak ve kod kalitesini daha da artırmak için tasarlanmıştır.

### LlamaPReview'un Temel Özellikleri:
- 🚀 Tek tıkla kurulum, yapılandırma gerekmez, tamamen otomatik çalışır
- 💯 Şu anda ücretsiz kullanım - kredi kartı veya ödeme bilgisi gerekmez
- 🧠 Yapay zeka destekli, derin kod anlayışıyla otomatik PR incelemeleri
- 🌐 Birden fazla programlama dili desteği

**LlamaPReview, llama-github'un gelişmiş bağlam getirme ve LLM destekli analizini kullanarak** akıllı, bağlamdan haberdar kod incelemeleri sunar. Sanki deponuzun tüm bağlamına sahip kıdemli bir geliştirici her PR'ı otomatik olarak inceliyor gibi!

👉 [LlamaPReview'i Hemen Kurun](https://github.com/marketplace/llamapreview/) (Ücretsiz)

Bağlam getirme için llama-github'u, kod incelemeleri için LlamaPReview'u kullanarak güçlü, yapay zeka destekli bir geliştirme ortamı oluşturabilirsiniz.

## Vizyon ve Yol Haritası

### Vizyon

Vizyonumuz, GitHub ile sorunsuz bir şekilde entegre olarak LLM'leri otomatik olarak karmaşık kodlama görevlerini çözmede güçlendiren, yapay zeka odaklı geliştirme çözümlerinin geleceğinde merkezi bir modül olmaktır.

![Vizyon Mimarisi](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/./docs/vision.drawio.svg)

### Yol Haritası

Proje yol haritamızın ayrıntılı bir görünümü için lütfen [Proje Yol Haritası](https://github.com/users/JetXu-LLM/projects/2) sayfamızı ziyaret edin.

## Teşekkürler

Aşağıdaki açık kaynak projelere destekleri ve katkıları için teşekkürlerimizi sunarız:

- **[LangChain](https://github.com/langchain-ai/langchain)**: Llama-github'daki LLM istemi ve işleme yeteneklerine güç veren temel çerçeveyi sağladığı için.
- **[Jina.ai](https://github.com/jina-ai/reader)**: s.jina.ai API'si ve llama-github'daki oluşturulan bağlamların doğruluk ve alakasını artıran açık kaynak yeniden sıralayıcı ve gömme modelleri sunduğu için.

Katkıları, llama-github'un geliştirilmesinde çok önemli olmuştur ve daha yenilikçi çözümler için projelerini incelemenizi kesinlikle tavsiye ederiz.

## Katkıda Bulunma

Llama-github'a katkıda bulunmak isteyenleri memnuniyetle karşılıyoruz! Daha fazla bilgi için lütfen [katkı yönergelerimizi](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/CONTRIBUTING.md) inceleyin.

## Lisans

Bu proje Apache 2.0 lisansı koşullarında lisanslanmıştır. Daha fazla ayrıntı için [LİSANS](LICENSE) dosyasına bakınız.

## İletişim

Sorularınız, önerileriniz veya geri bildiriminiz varsa lütfen [Jet Xu'nun e-postası](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/mailto:Voldemort.xu@foxmail.com) üzerinden bizimle iletişime geçmekten çekinmeyin.

---

Llama-github'u seçtiğiniz için teşekkür ederiz! Bu kütüphanenin yapay zeka geliştirme deneyiminizi artırmasını ve güçlü uygulamaları kolayca oluşturmanıza yardımcı olmasını umuyoruz.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-28

---