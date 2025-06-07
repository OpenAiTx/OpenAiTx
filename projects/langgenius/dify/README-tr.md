![cover-v5-optimized](./images/GitHub_README_if.png)

<p align="center">
  📌 <a href="https://dify.ai/blog/introducing-dify-workflow-file-upload-a-demo-on-ai-podcast">Dify Workflow Dosya Yükleme Tanıtımı: Google NotebookLM Podcast'i Yeniden Oluşturun</a>
</p>

<p align="center">
  <a href="https://cloud.dify.ai">Dify Cloud</a> ·
  <a href="https://docs.dify.ai/getting-started/install-self-hosted">Kendi Sunucunda Kurulum</a> ·
  <a href="https://docs.dify.ai">Dokümantasyon</a> ·
  <a href="https://dify.ai/pricing">Dify sürüm genel bakışı</a>
</p>

<p align="center">
    <a href="https://dify.ai" target="_blank">
        <img alt="Static Badge" src="https://img.shields.io/badge/Product-F04438"></a>
    <a href="https://dify.ai/pricing" target="_blank">
        <img alt="Static Badge" src="https://img.shields.io/badge/free-pricing?logo=free&color=%20%23155EEF&label=pricing&labelColor=%20%23528bff"></a>
    <a href="https://discord.gg/FngNHpbcY7" target="_blank">
        <img src="https://img.shields.io/discord/1082486657678311454?logo=discord&labelColor=%20%235462eb&logoColor=%20%23f5f5f5&color=%20%235462eb"
            alt="Discord’da sohbet et"></a>
    <a href="https://reddit.com/r/difyai" target="_blank">  
        <img src="https://img.shields.io/reddit/subreddit-subscribers/difyai?style=plastic&logo=reddit&label=r%2Fdifyai&labelColor=white"
            alt="Reddit’e katıl"></a>
    <a href="https://twitter.com/intent/follow?screen_name=dify_ai" target="_blank">
        <img src="https://img.shields.io/twitter/follow/dify_ai?logo=X&color=%20%23f5f5f5"
            alt="X(Twitter)’da takip et"></a>
    <a href="https://www.linkedin.com/company/langgenius/" target="_blank">
        <img src="https://custom-icon-badges.demolab.com/badge/LinkedIn-0A66C2?logo=linkedin-white&logoColor=fff"
            alt="LinkedIn’de takip et"></a>
    <a href="https://hub.docker.com/u/langgenius" target="_blank">
        <img alt="Docker Pulls" src="https://img.shields.io/docker/pulls/langgenius/dify-web?labelColor=%20%23FDB062&color=%20%23f79009"></a>
    <a href="https://github.com/langgenius/dify/graphs/commit-activity" target="_blank">
        <img alt="Son ayki commitler" src="https://img.shields.io/github/commit-activity/m/langgenius/dify?labelColor=%20%2332b583&color=%20%2312b76a"></a>
    <a href="https://github.com/langgenius/dify/" target="_blank">
        <img alt="Kapatılan sorunlar" src="https://img.shields.io/github/issues-search?query=repo%3Alanggenius%2Fdify%20is%3Aclosed&label=issues%20closed&labelColor=%20%237d89b0&color=%20%235d6b98"></a>
    <a href="https://github.com/langgenius/dify/discussions/" target="_blank">
        <img alt="Tartışma gönderileri" src="https://img.shields.io/github/discussions/langgenius/dify?labelColor=%20%239b8afb&color=%20%237a5af8"></a>
</p>

<p align="center">
  <a href="./README.md"><img alt="README in English" src="https://img.shields.io/badge/English-d9d9d9"></a>
  <a href="./README_TW.md"><img alt="繁體中文文件" src="https://img.shields.io/badge/繁體中文-d9d9d9"></a>
  <a href="./README_CN.md"><img alt="简体中文版自述文件" src="https://img.shields.io/badge/简体中文-d9d9d9"></a>
  <a href="./README_JA.md"><img alt="日本語のREADME" src="https://img.shields.io/badge/日本語-d9d9d9"></a>
  <a href="./README_ES.md"><img alt="README en Español" src="https://img.shields.io/badge/Español-d9d9d9"></a>
  <a href="./README_FR.md"><img alt="README en Français" src="https://img.shields.io/badge/Français-d9d9d9"></a>
  <a href="./README_KL.md"><img alt="README tlhIngan Hol" src="https://img.shields.io/badge/Klingon-d9d9d9"></a>
  <a href="./README_KR.md"><img alt="README in Korean" src="https://img.shields.io/badge/한국어-d9d9d9"></a>
  <a href="./README_AR.md"><img alt="README بالعربية" src="https://img.shields.io/badge/العربية-d9d9d9"></a>
  <a href="./README_TR.md"><img alt="Türkçe README" src="https://img.shields.io/badge/Türkçe-d9d9d9"></a>
  <a href="./README_VI.md"><img alt="README Tiếng Việt" src="https://img.shields.io/badge/Ti%E1%BA%BFng%20Vi%E1%BB%87t-d9d9d9"></a>
  <a href="./README_DE.md"><img alt="README in Deutsch" src="https://img.shields.io/badge/German-d9d9d9"></a>
  <a href="./README_BN.md"><img alt="README in বাংলা" src="https://img.shields.io/badge/বাংলা-d9d9d9"></a>
</p>

Dify, açık kaynaklı bir LLM uygulama geliştirme platformudur. Sezgisel arayüzü, ajans tabanlı yapay zekâ iş akışı, RAG hattı, ajan yetenekleri, model yönetimi, gözlemlenebilirlik özellikleri ve daha fazlasını bir araya getirir; böylece prototipten üretime hızlıca geçiş yapmanızı sağlar.

## Hızlı başlangıç

> Dify’i kurmadan önce, makinenizin aşağıdaki minimum sistem gereksinimlerini karşıladığından emin olun:
>
> - CPU >= 2 Çekirdek
> - RAM >= 4 GiB

</br>

Dify sunucusunu başlatmanın en kolay yolu [docker compose](docker/docker-compose.yaml) kullanmaktır. Aşağıdaki komutlarla Dify’i çalıştırmadan önce, makinenizde [Docker](https://docs.docker.com/get-docker/) ve [Docker Compose](https://docs.docker.com/compose/install/) kurulu olduğundan emin olun:

```bash
cd dify
cd docker
cp .env.example .env
docker compose up -d
```

Çalıştırdıktan sonra, [http://localhost/install](http://localhost/install) adresinden tarayıcınızda Dify kontrol paneline erişebilir ve başlatma işlemini başlatabilirsiniz.

#### Yardım arıyorsanız

Dify kurulumunda sorun yaşarsanız lütfen [SSS](https://docs.dify.ai/getting-started/install-self-hosted/faqs) bölümümüze bakın. Hâlâ sorun yaşıyorsanız [topluluğa ve bize](#community--contact) ulaşın.

> Dify’ye katkıda bulunmak veya ek geliştirme yapmak istiyorsanız, [kaynak kodundan dağıtım rehberimize](https://docs.dify.ai/getting-started/install-self-hosted/local-source-code) bakın.

## Temel Özellikler

**1. İş Akışı (Workflow)**:
Tüm aşağıdaki özelliklerden ve daha fazlasından yararlanarak güçlü yapay zekâ iş akışlarını görsel bir tuval üzerinde oluşturun ve test edin.

**2. Kapsamlı model desteği**:
GPT, Mistral, Llama3 ve OpenAI API uyumlu tüm modeller dâhil olmak üzere onlarca çıkarım sağlayıcısı ve kendi sunucunda çalışan çözümlerden yüzlerce tescilli/açık kaynaklı LLM ile sorunsuz entegrasyon. Desteklenen model sağlayıcılarının tam listesini [burada](https://docs.dify.ai/getting-started/readme/model-providers) bulabilirsiniz.

![providers-v5](https://github.com/langgenius/dify/assets/13230914/5a17bdbe-097a-4100-8363-40255b70f6e3)

**3. Prompt IDE**:
Prompt tasarlamak, model performansını karşılaştırmak ve sohbet tabanlı bir uygulamaya metinden sese gibi ek özellikler eklemek için sezgisel arayüz.

**4. RAG Hattı**:
Belge alma işleminden geri getirmeye kadar her şeyi kapsayan kapsamlı RAG yetenekleri; PDF, PPT ve diğer yaygın belge biçimlerinden metin çıkarımı için kutudan çıktığı gibi destek.

**5. Ajan yetenekleri**:
LLM Fonksiyon Çağırma veya ReAct tabanlı ajanlar tanımlayabilir, ajan için önceden oluşturulmuş veya özel araçlar ekleyebilirsiniz. Dify, Google Search, DALL·E, Stable Diffusion ve WolframAlpha gibi 50’den fazla yerleşik yapay zekâ ajan aracı sunar.

**6. LLMOps**:
Uygulama günlüklerini ve performansını zaman içinde izleyin ve analiz edin. Üretim verileri ve açıklamaları temelinde promptları, veri kümelerini ve modelleri sürekli olarak geliştirebilirsiniz.

**7. Hizmet Olarak Arka Uç (Backend-as-a-Service)**:
Dify’nin tüm hizmetleri, ilgili API’lerle birlikte gelir; böylece Dify’yi kendi iş mantığınıza zahmetsizce entegre edebilirsiniz.

## Özellik Karşılaştırması

<table style="width: 100%;">
  <tr>
    <th align="center">Özellik</th>
    <th align="center">Dify.AI</th>
    <th align="center">LangChain</th>
    <th align="center">Flowise</th>
    <th align="center">OpenAI Assistants API</th>
  </tr>
  <tr>
    <td align="center">Programlama Yaklaşımı</td>
    <td align="center">API + Uygulama odaklı</td>
    <td align="center">Python Kod</td>
    <td align="center">Uygulama odaklı</td>
    <td align="center">API odaklı</td>
  </tr>
  <tr>
    <td align="center">Desteklenen LLM'ler</td>
    <td align="center">Zengin Çeşitlilik</td>
    <td align="center">Zengin Çeşitlilik</td>
    <td align="center">Zengin Çeşitlilik</td>
    <td align="center">Yalnızca OpenAI</td>
  </tr>
  <tr>
    <td align="center">RAG Motoru</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
  </tr>
  <tr>
    <td align="center">Ajan</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
    <td align="center">❌</td>
    <td align="center">✅</td>
  </tr>
  <tr>
    <td align="center">İş Akışı</td>
    <td align="center">✅</td>
    <td align="center">❌</td>
    <td align="center">✅</td>
    <td align="center">❌</td>
  </tr>
  <tr>
    <td align="center">Gözlemlenebilirlik</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
    <td align="center">❌</td>
    <td align="center">❌</td>
  </tr>
  <tr>
    <td align="center">Kurumsal Özellik (SSO/Erişim kontrolü)</td>
    <td align="center">✅</td>
    <td align="center">❌</td>
    <td align="center">❌</td>
    <td align="center">❌</td>
  </tr>
  <tr>
    <td align="center">Yerel Kurulum</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
    <td align="center">❌</td>
  </tr>
</table>

## Dify Kullanımı

- **Bulut </br>**
  Sıfır kurulumla denemek isteyen herkes için [Dify Cloud](https://dify.ai) hizmetini sunuyoruz. Kendi başına kurulan sürümün tüm yeteneklerini sunar ve sandbox planında 200 ücretsiz GPT-4 çağrısı içerir.

- **Kendi Sunucunda Dify Community Edition</br>**
  Dify’yi ortamınızda hızlıca çalıştırmak için bu [başlangıç rehberini](#quick-start) kullanın.
  Daha fazla referans ve derinlemesine talimatlar için [dokümantasyonumuzu](https://docs.dify.ai) kullanın.

- **Kurumsal / organizasyonlar için Dify</br>**
  Kurumsal odaklı ek özellikler sunuyoruz. [Sorularınızı bu sohbet botu üzerinden bize iletebilir](https://udify.app/chat/22L1zSxg6yW1cWQg) veya [bize e-posta gönderebilirsiniz](mailto:business@dify.ai?subject=[GitHub]Business%20License%20Inquiry) ve kurumsal ihtiyaçları tartışabiliriz. </br>
  > AWS kullanan girişimler ve küçük işletmeler için [AWS Marketplace’teki Dify Premium](https://aws.amazon.com/marketplace/pp/prodview-t22mebxzwjhu6) sürümünü inceleyin ve tek tıkla kendi AWS VPC’nize dağıtın. Kendi logonuz ve markanızla uygulama oluşturma seçeneğiyle uygun fiyatlı bir AMI paketidir.

## Güncel Kalın

Dify’yi GitHub’da yıldızlayın ve yeni sürümlerden anında haberdar olun.

![star-us](https://github.com/langgenius/dify/assets/13230914/b823edc1-6388-4e25-ad45-2f6b187adbb4)

## Gelişmiş Kurulum

Yapılandırmayı özelleştirmeniz gerekiyorsa, lütfen [.env.example](docker/.env.example) dosyamızdaki açıklamalara bakın ve kendi `.env` dosyanızdaki ilgili değerleri güncelleyin. Ayrıca, özel dağıtım ortamınıza ve gereksinimlerinize bağlı olarak, `docker-compose.yaml` dosyasının kendisinde de imaj sürümlerini, port eşleştirmelerini veya disk bağlamalarını değiştirmek gibi ayarlamalar yapmanız gerekebilir. Herhangi bir değişiklik yaptıktan sonra `docker-compose up -d` komutunu tekrar çalıştırın. Kullanılabilir ortam değişkenlerinin tam listesine [buradan](https://docs.dify.ai/getting-started/install-self-hosted/environments) ulaşabilirsiniz.

Yüksek erişilebilirlik için bir kurulum yapılandırmak isterseniz, topluluk katkılı [Helm Chart’lar](https://helm.sh/) ve YAML dosyaları ile Dify’yi Kubernetes üzerinde dağıtabilirsiniz.

- [@LeoQuote tarafından Helm Chart](https://github.com/douban/charts/tree/master/charts/dify)
- [@BorisPolonsky tarafından Helm Chart](https://github.com/BorisPolonsky/dify-helm)
- [@magicsong tarafından Helm Chart](https://github.com/magicsong/ai-charts)
- [@Winson-030 tarafından YAML dosyası](https://github.com/Winson-030/dify-kubernetes)
- [@wyy-holding tarafından YAML dosyası](https://github.com/wyy-holding/dify-k8s)

#### Dağıtım için Terraform Kullanımı

Tek tıkla Dify’yi Bulut Platformuna dağıtmak için [terraform](https://www.terraform.io/) kullanın

##### Azure Global

- [@nikawang tarafından Azure Terraform](https://github.com/nikawang/dify-azure-terraform)

##### Google Cloud

- [@sotazum tarafından Google Cloud Terraform](https://github.com/DeNA/dify-google-cloud-terraform)

#### Dağıtım için AWS CDK Kullanımı

Dify’yi AWS’ye [CDK](https://aws.amazon.com/cdk/) ile dağıtın

##### AWS

- [@KevinZhao tarafından AWS CDK](https://github.com/aws-samples/solution-for-deploying-dify-on-aws)

## Katkıda Bulunma

Koda katkıda bulunmak isteyenler için [Katkı Rehberi](https://github.com/langgenius/dify/blob/main/CONTRIBUTING.md) dokümanımıza bakabilirsiniz.
Aynı zamanda, Dify’yi sosyal medyada, etkinliklerde ve konferanslarda paylaşarak destek olmayı değerlendirin.

> Dify’yi Mandarin veya İngilizce dışında başka dillere çevirmeye yardımcı olacak katkıcılar arıyoruz. Yardım etmek istiyorsanız, daha fazla bilgi için [i18n README](https://github.com/langgenius/dify/blob/main/web/i18n/README.md) dosyasına bakabilir ve [Discord Topluluk Sunucumuzun](https://discord.gg/8Tpq4AcN9c) `global-users` kanalında bize yorum bırakabilirsiniz.

## Topluluk & iletişim

- [GitHub Discussion](https://github.com/langgenius/dify/discussions). En uygun: geri bildirim paylaşımı ve soru sorma.
- [GitHub Issues](https://github.com/langgenius/dify/issues). En uygun: Dify.AI kullanırken karşılaştığınız hatalar ve özellik önerileri. [Katkı Rehberimize](https://github.com/langgenius/dify/blob/main/CONTRIBUTING.md) bakın.
- [Discord](https://discord.gg/FngNHpbcY7). En uygun: uygulamalarınızı paylaşmak ve toplulukla takılmak.
- [X(Twitter)](https://twitter.com/dify_ai). En uygun: uygulamalarınızı paylaşmak ve toplulukla takılmak.

**Katkıda Bulunanlar**

<a href="https://github.com/langgenius/dify/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=langgenius/dify" />
</a>

## Yıldız Geçmişi

[![Star History Chart](https://api.star-history.com/svg?repos=langgenius/dify&type=Date)](https://star-history.com/#langgenius/dify&Date)

## Güvenlik Bildirimi

Gizliliğinizi korumak için lütfen güvenlik sorunlarını GitHub’da paylaşmaktan kaçının. Sorularınızı security@dify.ai adresine gönderin, size daha ayrıntılı bir yanıt vereceğiz.

## Lisans

Bu depo, temelde Apache 2.0 olan ve birkaç ek kısıtlamaya sahip [Dify Açık Kaynak Lisansı](LICENSE) ile sunulmaktadır.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---