<p align="right">
   <strong>İngilizce</strong> | <a href="https://raw.githubusercontent.com/Portkey-AI/gateway/main/.github/README.cn.md">中文</a> | <a href="https://raw.githubusercontent.com/Portkey-AI/gateway/main/.github/README.jp.md">日本語</a>
</p>

<div align="center">

<a href="https://portkey.sh/report-github"><img src="https://raw.githubusercontent.com/siddharthsambharia-portkey/Portkey-Product-Images/refs/heads/main/LLM%20Report%20Campaign%20Frame.png"></img></a>
<br>

# AI Gateway
#### 1 hızlı ve kullanıcı dostu API ile 250+ LLM'e yönlendirme

<img src="https://cfassets.portkey.ai/sdk.gif" width="550px" alt="Portkey AI Gateway Demo showing LLM routing capabilities" style="margin-left:-35px">

[Belgeler](https://portkey.wiki/gh-1) | [Kurumsal](https://portkey.wiki/gh-2) | [Barındırılan Gateway](https://portkey.wiki/gh-3) | [Değişiklik Günlüğü](https://portkey.wiki/gh-4) | [API Referansı](https://portkey.wiki/gh-5)


[![Lisans](https://img.shields.io/github/license/Ileriayo/markdown-badges)](https://raw.githubusercontent.com/Portkey-AI/gateway/main/LICENSE)
[![Discord](https://img.shields.io/discord/1143393887742861333)](https://portkey.wiki/gh-6)
[![Twitter](https://img.shields.io/twitter/url/https/twitter/follow/portkeyai?style=social&label=Follow%20%40PortkeyAI)](https://portkey.wiki/gh-7)
[![npm sürümü](https://badge.fury.io/js/%40portkey-ai%2Fgateway.svg)](https://portkey.wiki/gh-8)
[![Better Stack Rozeti](https://uptime.betterstack.com/status-badges/v1/monitor/q94g.svg)](https://portkey.wiki/gh-9)

<a href="https://us-east-1.console.aws.amazon.com/cloudformation/home?region=us-east-1#/stacks/quickcreate?stackName=portkey-gateway&templateURL=https://portkey-gateway-ec2-quicklaunch.s3.us-east-1.amazonaws.com/portkey-gateway-ec2-quicklaunch.template.yaml"><img src="https://img.shields.io/badge/Deploy_to_EC2-232F3E?style=for-the-badge&logo=amazonwebservices&logoColor=white" alt="AWS EC2'ye Dağıt" width="105"/></a> [![Ask DeepWiki](https://deepwiki.com/badge.svg)](https://deepwiki.com/Portkey-AI/gateway)
</div>

<br/>

[**AI Gateway**](https://portkey.wiki/gh-10), 1600'den fazla dil, görsel, ses ve görüntü modeline hızlı, güvenilir ve güvenli yönlendirme için tasarlanmıştır. Hafif, açık kaynaklı ve kurumsal kullanıma hazır bir çözümdür ve herhangi bir dil modeliyle 2 dakikadan kısa sürede entegre olmanızı sağlar.

- [x] **Yıldırım hızında** (<1ms gecikme) ve küçük boyutlu (122kb)
- [x] **Savaşta test edilmiş**, her gün 10 milyardan fazla token işleniyor
- [x] **Kurumsal hazır**; gelişmiş güvenlik, ölçeklenebilirlik ve özel dağıtımlar

<br>

#### AI Gateway ile neler yapabilirsiniz?
- Herhangi bir LLM ile 2 dakikadan kısa sürede entegre olun - [Hızlı Başlangıç](#quickstart-2-mins)
- **[Otomatik tekrar denemeler](https://portkey.wiki/gh-11)** ve **[yedekler](https://portkey.wiki/gh-12)** ile kesintileri önleyin
- **[Yük dengeleme](https://portkey.wiki/gh-13)** ve **[koşullu yönlendirme](https://portkey.wiki/gh-14)** ile AI uygulamalarınızı ölçeklendirin
- **[Guardrails](https://portkey.wiki/gh-15)** ile AI dağıtımlarınızı koruyun
- **[Çok modlu yetenekler](https://portkey.wiki/gh-16)** ile metnin ötesine geçin
- Son olarak, **[ajan tabanlı iş akışı](https://portkey.wiki/gh-17)** entegrasyonlarını keşfedin

<br><br>

> [!İPUCU]
> Bu repoyu yıldızlamak daha fazla geliştiricinin AI Gateway'i keşfetmesine yardımcı olur 🙏🏻
>
> ![star-2](https://github.com/user-attachments/assets/53597dce-6333-4ecc-a154-eb05532954e4)
> 
<br>


<br>

## Hızlı Başlangıç (2 dakika)

### 1. AI Gateway'inizi Kurun

```bash
# Gateway'i yerelde çalıştırın (Node.js ve npm gerektirir)
npx @portkey-ai/gateway
```
> Gateway şu adreste çalışıyor: `http://localhost:8787/v1`
> 
> Gateway Konsolu şu adreste çalışıyor: `http://localhost:8787/public/`

<sup>
Dağıtım rehberleri:
&nbsp; <a href="https://portkey.wiki/gh-18"><img height="12" width="12" src="https://cfassets.portkey.ai/logo/dew-color.svg" /> Portkey Cloud (Önerilir)</a>
&nbsp; <a href="https://raw.githubusercontent.com/Portkey-AI/gateway/main/docs/installation-deployments.md#docker"><img height="12" width="12" src="https://cdn.simpleicons.org/docker/3776AB" /> Docker</a>
&nbsp; <a href="https://raw.githubusercontent.com/Portkey-AI/gateway/main/docs/installation-deployments.md#nodejs-server"><img height="12" width="12" src="https://cdn.simpleicons.org/node.js/3776AB" /> Node.js</a>
&nbsp; <a href="https://raw.githubusercontent.com/Portkey-AI/gateway/main/docs/installation-deployments.md#cloudflare-workers"><img height="12" width="12" src="https://cdn.simpleicons.org/cloudflare/3776AB" /> Cloudflare</a>
&nbsp; <a href="https://raw.githubusercontent.com/Portkey-AI/gateway/main/docs/installation-deployments.md#replit"><img height="12" width="12" src="https://cdn.simpleicons.org/replit/3776AB" /> Replit</a>
&nbsp; <a href="https://raw.githubusercontent.com/Portkey-AI/gateway/main/docs/installation-deployments.md"> Diğerleri...</a>

</sup>

### 2. İlk isteğinizi yapın

<!-- <details open>
<summary>Python Örneği</summary> -->
```python
# pip install -qU portkey-ai

from portkey_ai import Portkey

# OpenAI uyumlu istemci
client = Portkey(
    provider="openai", # veya 'anthropic', 'bedrock', 'groq', vb.
    Authorization="sk-***" # sağlayıcı API anahtarı
)

# AI Gateway'iniz üzerinden bir istek gönderin
client.chat.completions.create(
    messages=[{"role": "user", "content": "Hava nasıl?"}],
    model="gpt-4o-mini"
)
```



<sup>Desteklenen Kütüphaneler:
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/javascript/3776AB" /> JS](https://portkey.wiki/gh-19)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/python/3776AB" /> Python](https://portkey.wiki/gh-20)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/gnubash/3776AB" /> REST](https://portkey.sh/gh-84)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/openai/3776AB" /> OpenAI SDK'ları](https://portkey.wiki/gh-21)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/langchain/3776AB" /> Langchain](https://portkey.wiki/gh-22)
&nbsp; [LlamaIndex](https://portkey.wiki/gh-23)
&nbsp; [Autogen](https://portkey.wiki/gh-24)
&nbsp; [CrewAI](https://portkey.wiki/gh-25)
&nbsp; [Daha fazla..](https://portkey.wiki/gh-26)
</sup>

Gateway Konsolu'nda (`http://localhost:8787/public/`) tüm yerel loglarınızı tek bir yerde görebilirsiniz.

<img src="https://github.com/user-attachments/assets/362bc916-0fc9-43f1-a39e-4bd71aac4a3a" width="400" />


### 3. Yönlendirme & Guardrails
LLM gateway'deki `Config`ler, yönlendirme kuralları oluşturmanıza, güvenilirlik eklemenize ve guardrails ayarlamanıza olanak tanır.
```python
config = {
  "retry": {"attempts": 5},

  "output_guardrails": [{
    "default.contains": {"operator": "none", "words": ["Apple"]},
    "deny": True
  }]
}

# Konfigürasyonu istemciye ekleyin
client = client.with_options(config=config)

client.chat.completions.create(
    model="gpt-4o-mini",
    messages=[{"role": "user", "content": "Rastgele Apple veya Bat yanıtla"}]
)

# Bu, guardrail "Apple" içeren tüm yanıtları reddettiği için daima "Bat" olarak yanıt döner. Retry konfigürasyonu ise 5 kez tekrar dener ve sonra vazgeçer.
```
<div align="center">
<img src="https://portkey.ai/blog/content/images/size/w1600/2024/11/image-15.png" width=600 title="Portkey'in AI gateway'i üzerinden istek akışı, tekrar denemeler ve guardrails ile" alt="Portkey'in AI gateway'i üzerinden istek akışı, tekrar denemeler ve guardrails ile"/>
</div>

AI gateway'inizde configler ile çok daha fazlasını yapabilirsiniz. [Örneklere atla  →](https://portkey.wiki/gh-27)

<br/>

### Kurumsal Sürüm (Özel dağıtımlar)

<sup>

[<img height="12" width="12" src="https://cfassets.portkey.ai/amazon-logo.svg" /> AWS](https://portkey.wiki/gh-28)
&nbsp; [<img height="12" width="12" src="https://cfassets.portkey.ai/azure-logo.svg" /> Azure](https://portkey.wiki/gh-29)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/googlecloud/3776AB" /> GCP](https://portkey.wiki/gh-30)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/redhatopenshift/3776AB" /> OpenShift](https://portkey.wiki/gh-31)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/kubernetes/3776AB" /> Kubernetes](https://portkey.wiki/gh-85)

</sup>

LLM Gateway'in [kurumsal sürümü](https://portkey.wiki/gh-86), **organizasyon yönetimi**, **yönetişim**, **güvenlik** ve [daha fazlası](https://portkey.wiki/gh-87) için gelişmiş yetenekler sunar. [Özellik Karşılaştırmasını Görüntüle →](https://portkey.wiki/gh-32)

Desteklenen platformlar için kurumsal dağıtım mimarisi burada mevcuttur - [**Kurumsal Özel Bulut Dağıtımları**](https://portkey.wiki/gh-33)

<a href="https://portkey.sh/demo-13"><img src="https://portkey.ai/blog/content/images/2024/08/Get-API-Key--5-.png" height=50 alt="Kurumsal AI gateway demo randevusu al" /></a><br/>


<br>

<hr>

### AI Engineering Hours

AI Gateway uygulamanıza başlamak için her Cuma (08:00 PT) haftalık topluluk çağrılarına katılın! [Her Cuma düzenleniyor](https://portkey.wiki/gh-35)

<a href="https://portkey.wiki/gh-35"><img width="500" src="https://github.com/user-attachments/assets/c2885699-f197-4289-b819-21eb839fbae1" /></a>

Toplantı tutanakları [burada yayınlanıyor](https://portkey.wiki/gh-36).


<hr>

### Prod'da LLM'ler '25

90+ bölge ve 650+ ekipte, 2 trilyondan fazla token analizinden elde edilen içgörüler. Bu rapordan bekleyebilecekleriniz:
- AI benimsenmesini ve LLM sağlayıcı büyümesini şekillendiren trendler.
- Hızı, maliyeti ve güvenilirliği optimize etmek için karşılaştırmalar.
- Üretim seviyesinde AI sistemlerini ölçeklendirmek için stratejiler.

<a href="https://portkey.sh/report-github"><img width="500" src="https://raw.githubusercontent.com/siddharthsambharia-portkey/Portkey-Product-Images/refs/heads/main/LLM%20Report%20Campaign%20Image.png" /></a>

<a href="https://portkey.sh/report-github">**Raporu Edinin**</a>
<hr>


## Temel Özellikler
### Güvenilir Yönlendirme
- <a href="https://portkey.wiki/gh-37">**Yedek Sağlayıcılar (Fallbacks)**</a>: LLM gateway kullanarak başarısız isteklerde başka bir sağlayıcıya veya modele otomatik geçiş yapın. Yedekleme tetiklenecek hata türlerini belirleyebilirsiniz. Uygulamanızın güvenilirliğini artırır.
- <a href="https://portkey.wiki/gh-38">**Otomatik Yeniden Denemeler**</a>: Başarısız istekleri otomatik olarak 5 defaya kadar yeniden deneyin. Üstel bekleme stratejisi, ağ aşırı yüklenmesini önlemek için deneme aralıklarını ayarlar.
- <a href="https://portkey.wiki/gh-39">**Yük Dengeleme**</a>: Yüksek erişilebilirlik ve en iyi performans için LLM isteklerini birden fazla API anahtarı veya AI sağlayıcısına ağırlıklarla dağıtın.
- <a href="https://portkey.wiki/gh-40">**İstek Zaman Aşımı**</a>: Ayrıntılı istek zaman aşımları belirleyerek düzensiz LLM’leri ve gecikmeleri yönetin, belirlenen süreyi aşan isteklerin otomatik olarak sonlandırılmasını sağlayın.
- <a href="https://portkey.wiki/gh-41">**Çok Modlu LLM Gateway**</a>: Birden fazla sağlayıcıdan görsel, ses (metinden konuşmaya & konuşmadan metne) ve görüntü üretim modellerini, tanıdık OpenAI imzası ile çağırın.
- <a href="https://portkey.wiki/gh-42">**Gerçek Zamanlı API’ler**</a>: OpenAI tarafından sunulan gerçek zamanlı API’leri entegre websocket sunucusu üzerinden çağırın.

### Güvenlik & Doğruluk
- <a href="https://portkey.wiki/gh-88">**Korumalar (Guardrails)**</a>: LLM giriş ve çıkışlarınızı belirlediğiniz kontrollerle doğrulayın. Güvenlik ve doğruluk standartlarına uyum sağlamak için 40’tan fazla önceden tanımlı koruma seçebilirsiniz. <a href="https://portkey.wiki/gh-43">Kendi korumalarınızı getirebilir</a> ya da <a href="https://portkey.wiki/gh-44">birçok partnerimizden</a> seçim yapabilirsiniz.
- [**Güvenli Anahtar Yönetimi**](https://portkey.wiki/gh-45): Kendi anahtarlarınızı kullanın veya anında sanal anahtarlar oluşturun.
- [**Rol Tabanlı Erişim Kontrolü**](https://portkey.wiki/gh-46): Kullanıcılarınız, çalışma alanlarınız ve API anahtarlarınız için ayrıntılı erişim kontrolü.
- <a href="https://portkey.wiki/gh-47">**Uyumluluk & Veri Gizliliği**</a>: AI gateway, SOC2, HIPAA, GDPR ve CCPA uyumludur.

### Maliyet Yönetimi
- [**Akıllı önbellekleme**](https://portkey.wiki/gh-48): LLM’lerden gelen yanıtları önbelleğe alarak maliyetleri azaltın ve gecikmeyi iyileştirin. Basit ve anlamsal* önbellekleme desteklenir.
- [**Kullanım analizleri**](https://portkey.wiki/gh-49): Yapay zeka ve LLM kullanımınızı izleyin ve analiz edin; istek hacmi, gecikme, maliyetler ve hata oranları dahil.
- [**Sağlayıcı optimizasyonu***](https://portkey.wiki/gh-89): Kullanım eğilimleri ve fiyatlandırma modellerine göre otomatik olarak en uygun maliyetli sağlayıcıya geçiş yapar.

### İşbirliği & İş Akışları
- <a href="https://portkey.ai/docs/integrations/agents">**Agent Desteği**</a>: Popüler agent framework’leri ile sorunsuz entegre olarak karmaşık AI uygulamaları oluşturun. Gateway, [Autogen](https://portkey.wiki/gh-50), [CrewAI](https://portkey.wiki/gh-51), [LangChain](https://portkey.wiki/gh-52), [LlamaIndex](https://portkey.wiki/gh-53), [Phidata](https://portkey.wiki/gh-54), [Control Flow](https://portkey.wiki/gh-55) ve hatta [Özel Agentlar](https://portkey.wiki/gh-56) ile entegre çalışır.
- [**Prompt Şablon Yönetimi***](https://portkey.wiki/gh-57): Prompt şablonlarınızı evrensel bir prompt playground üzerinden işbirliğiyle oluşturun, yönetin ve versiyonlayın.
<br/><br/>

<sup>
*&nbsp;Sadece barındırılan ve kurumsal sürümlerde mevcuttur
</sup>

<br>

## Tarif Defterleri (Cookbooks)

### ☄️ Trend Olanlar
- [Nvidia NIM](/cookbook/providers/nvidia.ipynb) modellerini AI Gateway ile kullanın
- [CrewAI Agentlarını](/cookbook/monitoring-agents/CrewAI_with_Telemetry.ipynb) Portkey ile izleyin!
- [En İyi 10 LMSYS Modelini](/cookbook/use-cases/LMSYS%20Series/comparing-top10-LMSYS-models-with-Portkey.ipynb) AI Gateway ile karşılaştırın.

### 🚨 En Yeniler
* [Nemotron kullanarak Sentetik Veri Kümesi Oluşturun](/cookbook/use-cases/Nemotron_GPT_Finetuning_Portkey.ipynb)
* [LLM Gateway’i Vercel’in AI SDK’sı ile kullanın](/cookbook/integrations/vercel-ai.md)
* [Llama Agentlarını Portkey’in LLM Gateway’i ile izleyin](/cookbook/monitoring-agents/Llama_Agents_with_Telemetry.ipynb)

[Tüm tarif defterlerini görüntüle →](https://portkey.wiki/gh-58)
<br/><br/>

## Desteklenen Sağlayıcılar

Gateway entegrasyonlarını [45+ sağlayıcı](https://portkey.wiki/gh-59) ve [8+ agent framework](https://portkey.wiki/gh-90) ile keşfedin.

|                                                                                                                            | Sağlayıcı                                                                                      | Destek | Akış |
| -------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | ------- | ------ |
| <img src="docs/images/openai.png" width=35 />                                                                              | [OpenAI](https://portkey.wiki/gh-60)                           | ✅       | ✅      |
| <img src="docs/images/azure.png" width=35>                                                                                 | [Azure OpenAI](https://portkey.wiki/gh-61)               | ✅       | ✅      |
| <img src="docs/images/anyscale.png" width=35>                                                                              | [Anyscale](https://portkey.wiki/gh-62) | ✅       | ✅      |
| <img src="https://upload.wikimedia.org/wikipedia/commons/2/2d/Google-favicon-2015.png" width=35>                           | [Google Gemini](https://portkey.wiki/gh-63)             | ✅       | ✅      |
| <img src="docs/images/anthropic.png" width=35>                                                                             | [Anthropic](https://portkey.wiki/gh-64)                     | ✅       | ✅      |
| <img src="docs/images/cohere.png" width=35>                                                                                | [Cohere](https://portkey.wiki/gh-65)                           | ✅       | ✅      |
| <img src="https://assets-global.website-files.com/64f6f2c0e3f4c5a91c1e823a/654693d569494912cfc0c0d4_favicon.svg" width=35> | [Together AI](https://portkey.wiki/gh-66)                 | ✅       | ✅      |
| <img src="https://www.perplexity.ai/favicon.svg" width=35>                                                                 | [Perplexity](https://portkey.wiki/gh-67)                | ✅       | ✅      |
| <img src="https://docs.mistral.ai/img/favicon.ico" width=35>                                                               | [Mistral](https://portkey.wiki/gh-68)                      | ✅       | ✅      |
| <img src="https://docs.nomic.ai/img/nomic-logo.png" width=35>                                                              | [Nomic](https://portkey.wiki/gh-69)                             | ✅       | ✅      |
| <img src="https://files.readme.io/d38a23e-small-studio-favicon.png" width=35>                                              | [AI21](https://portkey.wiki/gh-91)                                    | ✅       | ✅      |
| <img src="https://platform.stability.ai/small-logo-purple.svg" width=35>                                                   | [Stability AI](https://portkey.wiki/gh-71)               | ✅       | ✅      |
| <img src="https://deepinfra.com/_next/static/media/logo.4a03fd3d.svg" width=35>                                            | [DeepInfra](https://portkey.sh/gh-92)                               | ✅       | ✅      |
| <img src="https://ollama.com/public/ollama.png" width=35>                                                                  | [Ollama](https://portkey.wiki/gh-72)                           | ✅       | ✅      |
| <img src="https://novita.ai/favicon.ico" width=35>                                                                         | [Novita AI](https://portkey.wiki/gh-73)                              | ✅       | ✅      | `/chat/completions`, `/completions` |


> [Desteklenen 200+ modelin tam listesini buradan görüntüleyin](https://portkey.wiki/gh-74)
<br>

<br>

## Agentlar
Gateway, popüler agent framework’leriyle sorunsuz entegre olur. [Dokümantasyonu buradan okuyun](https://portkey.wiki/gh-75).


| Framework | 200+ LLM Çağrısı | Gelişmiş Yönlendirme | Önbellekleme | Kayıt & İzleme* | Gözlemlenebilirlik* | Prompt Yönetimi* |
|------------------------------|--------|-------------|---------|------|---------------|-------------------|
| [Autogen](https://portkey.wiki/gh-93)    | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [CrewAI](https://portkey.wiki/gh-94)             | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [LangChain](https://portkey.wiki/gh-95)             | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [Phidata](https://portkey.wiki/gh-96)             | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [Llama Index](https://portkey.wiki/gh-97)             | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [Control Flow](https://portkey.wiki/gh-98) | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [Kendi Agentınızı Oluşturun](https://portkey.wiki/gh-99) | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |

<br>

*[Barındırılan uygulamada](https://portkey.wiki/gh-76) mevcuttur. Ayrıntılı dokümantasyon için [buraya tıklayın](https://portkey.wiki/gh-100).


## Gateway Kurumsal Sürüm
AI uygulamanızı <ins>daha güvenilir</ins> ve <ins>geleceğe uyumlu</ins> hale getirirken, tam <ins>veri güvenliği</ins> ve <ins>gizliliği</ins> sağlayın.

✅&nbsp; Güvenli Anahtar Yönetimi - rol tabanlı erişim kontrolü ve izleme için <br>
✅&nbsp; Basit & Anlamsal Önbellekleme - tekrar eden sorgulara daha hızlı yanıt verip maliyetten tasarruf için <br>
✅&nbsp; Erişim Kontrolü & Gelen Kuralar - hangi IP’lerin ve coğrafyaların dağıtımlarınıza bağlanabileceğini kontrol edin <br>
✅&nbsp; Kişisel Veri Maskeleme - taleplerinizdeki hassas verileri otomatik olarak kaldırarak istenmeyen ifşayı önleyin <br>
✅&nbsp; SOC2, ISO, HIPAA, GDPR Uyumlulukları - en iyi güvenlik uygulamaları için <br>
✅&nbsp; Profesyonel Destek - ve özellik önceliklendirmesi ile <br>

[Kurumsal dağıtımlar için görüşme planlayın](https://portkey.sh/demo-13)

<br>


## Katkıda Bulunmak

Katkıda bulunmanın en kolay yolu, `good first issue` etiketi ile işaretlenmiş bir konuyu seçmektir 💪. Katkı kurallarını [buradan okuyabilirsiniz](/.github/CONTRIBUTING.md).

Hata bildirimi? [Buradan gönderin](https://portkey.wiki/gh-78) | Özellik isteği? [Buradan gönderin](https://portkey.wiki/gh-78)


### Topluluk ile Başlangıç
Her Cuma (08:00 PT) düzenlediğimiz haftalık AI Engineering Hour etkinliklerimize katılın:
- Diğer katkıcılar ve topluluk üyeleriyle tanışın
- Gelişmiş Gateway özelliklerini ve uygulama desenlerini öğrenin
- Deneyimlerinizi paylaşın ve destek alın
- Son geliştirme önceliklerinden haberdar olun

[Bir sonraki oturuma katılın →](https://portkey.wiki/gh-101) | [Toplantı notları](https://portkey.wiki/gh-102)

<br>

## Topluluk

Dünyanın dört bir yanındaki büyüyen topluluğumuza katılın, yardım, fikir ve AI üzerine tartışmalara katılın.

- Resmi [Blogumuzu](https://portkey.wiki/gh-78) görüntüleyin
- [Discord](https://portkey.wiki/community) üzerinden bizimle sohbet edin
- [Twitter](https://portkey.wiki/gh-79) üzerinden takip edin
- [LinkedIn](https://portkey.wiki/gh-80) üzerinden bağlantı kurun
- [Japonca dökümantasyonu](./.github/README.jp.md) okuyun
- [YouTube](https://portkey.wiki/gh-103)’da bizi ziyaret edin
- [Geliştirici topluluğumuza](https://portkey.wiki/gh-82) katılın
<!-- - Soruları #portkey etiketiyle [Stack Overflow’da](https://stackoverflow.com/questions/tagged/portkey) sorun -->

![Rubeus Social Share (4)](https://github.com/Portkey-AI/gateway/assets/971978/89d6f0af-a95d-4402-b451-14764c40d03f)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---