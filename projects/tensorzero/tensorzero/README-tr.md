<img src="https://github.com/user-attachments/assets/47d67430-386d-4675-82ad-d4734d3262d9" width=128 height=128>

# TensorZero

**TensorZero, üretim verilerini daha akıllı, daha hızlı ve daha ucuz modellere dönüştürerek LLM uygulamalarını optimize etmek için bir geri besleme döngüsü oluşturur.**

1. Model ağ geçidimizi entegre edin
2. Metrik veya geri bildirim gönderin
3. İstemleri, modelleri ve çıkarım stratejilerini optimize edin
4. LLM’lerinizin zamanla gelişimini izleyin

LLM’ler için **veri & öğrenme döngüsü** sağlar; aşağıdakileri birleştirir:

- [x] **Çıkarım:** tüm LLM’ler için tek bir API, <1ms P99 ek gecikme ile
- [x] **Gözlemlenebilirlik:** çıkarım & geri bildirim → veritabanınıza
- [x] **Optimizasyon:** istemden ince ayara ve RL’e kadar
- [x] **Değerlendirmeler:** istemleri, modelleri, çıkarım stratejilerini karşılaştırın
- [x] **Deney:** yerleşik A/B testi, yönlendirme, yedekler

---

<p align="center">
  <b><a href="https://www.tensorzero.com/" target="_blank">Web Sitesi</a></b>
  ·
  <b><a href="https://www.tensorzero.com/docs" target="_blank">Dokümantasyon</a></b>
  ·
  <b><a href="https://www.x.com/tensorzero" target="_blank">Twitter</a></b>
  ·
  <b><a href="https://www.tensorzero.com/slack" target="_blank">Slack</a></b>
  ·
  <b><a href="https://www.tensorzero.com/discord" target="_blank">Discord</a></b>
  <br>
  <br>
  <b><a href="https://www.tensorzero.com/docs/quickstart" target="_blank">Hızlı Başlangıç (5dk)</a></b>
  ·
  <b><a href="https://www.tensorzero.com/docs/gateway/tutorial" target="_blank">Kapsamlı Eğitim</a></b>
  ·
  <b><a href="https://www.tensorzero.com/docs/gateway/deployment" target="_blank">Dağıtım Rehberi</a></b>
  ·
  <b><a href="https://www.tensorzero.com/docs/gateway/api-reference" target="_blank">API Referansı</a></b>
  ·
  <b><a href="https://www.tensorzero.com/docs/gateway/deployment" target="_blank">Yapılandırma Referansı</a></b>
</p>

---

<table>
  <tr>
    <td width="30%" valign="top"><b>TensorZero nedir?</b></td>
    <td width="70%" valign="top">TensorZero, üretim kalitesinde LLM uygulamaları geliştirmek için açık kaynaklı bir çerçevedir. Bir LLM ağ geçidi, gözlemlenebilirlik, optimizasyon, değerlendirmeler ve deneyi birleştirir.</td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>TensorZero diğer LLM çerçevelerinden nasıl farklıdır?</b></td>
    <td width="70%" valign="top">
      1. TensorZero, karmaşık LLM uygulamalarını üretim metrikleri ve insan geri bildirimi ile optimize etmenizi sağlar.<br>
      2. TensorZero, endüstriyel ölçekli LLM uygulamalarının ihtiyaçlarını destekler: düşük gecikme, yüksek aktarım hızı, tip güvenliği, kendi sunucunuzda barındırma, GitOps, özelleştirilebilirlik vb.<br>
      3. TensorZero, tüm LLMOps yığınını birleştirerek bileşik faydalar sunar. Örneğin, LLM değerlendirmeleri, AI hakemleriyle birlikte modellerin ince ayarı için kullanılabilir.
    </td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>TensorZero'yu ___ ile kullanabilir miyim?</b></td>
    <td width="70%" valign="top">Evet. Tüm büyük programlama dilleri desteklenmektedir. TensorZero'yu Python istemcimizle, herhangi bir OpenAI SDK'sı ile veya HTTP API ile kullanabilirsiniz.</td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>TensorZero üretim için hazır mı?</b></td>
    <td width="70%" valign="top">Evet. İşte bir vaka çalışması: <b><a href="https://www.tensorzero.com/blog/case-study-automating-code-changelogs-at-a-large-bank-with-llms">Büyük Bir Bankada Kod Değişiklik Günlüklerinin LLM'lerle Otomasyonu</a></b></td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>TensorZero'nun maliyeti nedir?</b></td>
    <td width="70%" valign="top">Hiçbir şey. TensorZero tamamen kendi sunucunuzda barındırılır ve açık kaynaktır. Ücretli özellik yoktur.</td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>TensorZero'yu kim geliştiriyor?</b></td>
    <td width="70%" valign="top">Teknik ekibimizde eski bir Rust derleyici bakıcısı, binlerce atıfı olan makine öğrenimi araştırmacıları (Stanford, CMU, Oxford, Columbia) ve bir decacorn girişimin ürün direktörü yer alıyor. ClickHouse, CockroachDB gibi lider açık kaynak projeleri ve OpenAI, Anthropic gibi AI laboratuvarlarıyla aynı yatırımcılar tarafından destekleniyoruz.</td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>Nasıl başlayabilirim?</b></td>
    <td width="70%" valign="top">TensorZero'yu kademeli olarak benimseyebilirsiniz. <b><a href="https://www.tensorzero.com/docs/quickstart">Hızlı Başlangıç</a></b> rehberimiz, sade bir OpenAI sarmalayıcıdan gözlemlenebilirlik ve ince ayar ile üretime hazır bir LLM uygulamasına sadece 5 dakikada geçmenizi sağlar.</td>
  </tr>
</table>

---

## Özellikler

### 🌐 LLM Ağ Geçidi

> **TensorZero ile bir kez entegre olun ve tüm büyük LLM sağlayıcılarına erişin.**

<table>
  <tr></tr> <!-- flip highlight order -->
  <tr>
    <td width="50%" align="center" valign="middle"><b>Model Sağlayıcılar</b></td>
    <td width="50%" align="center" valign="middle"><b>Özellikler</b></td>
  </tr>
  <tr>
    <td width="50%" align="left" valign="top">
      <p>
        TensorZero Ağ Geçidi yerel olarak şunları destekler:
      </p>
      <ul>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/anthropic">Anthropic</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/aws-bedrock">AWS Bedrock</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/aws-sagemaker">AWS SageMaker</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/azure">Azure OpenAI Service</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/deepseek">DeepSeek</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/fireworks">Fireworks</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/gcp-vertex-ai-anthropic">GCP Vertex AI Anthropic</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/gcp-vertex-ai-gemini">GCP Vertex AI Gemini</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/google-ai-studio-gemini">Google AI Studio (Gemini API)</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/hyperbolic">Hyperbolic</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/mistral">Mistral</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/openai">OpenAI</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/together">Together</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/vllm">vLLM</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/xai">xAI</a></b></li>
      </ul>
      <p>
        <em>
          Başka bir şeye mi ihtiyacınız var?
          Sağlayıcınız muhtemelen destekleniyordur çünkü TensorZero <b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/openai-compatible">herhangi bir OpenAI uyumlu API (örn. Ollama)</a></b> ile entegre olur.
        </em>
      </p>
    </td>
    <td width="50%" align="left" valign="top">
      <p>
        TensorZero Ağ Geçidi aşağıdaki gelişmiş özellikleri destekler:
      </p>
      <ul>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/retries-fallbacks">Yeniden Denemeler & Yedekler</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations">Çıkarım Zamanı Optimizasyonları</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/prompt-templates-schemas">İstem Şablonları & Şemalar</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/tutorial#experimentation">Deney (A/B Testi)</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/configuration-reference">Kod Olarak Yapılandırma (GitOps)</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/batch-inference">Toplu Çıkarım</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/multimodal-inference">Çok Modlu Çıkarım (VLM'ler)</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-caching">Çıkarım Önbellekleme</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/metrics-feedback">Metrikler & Geri Bildirim</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/episodes">Çok Adımlı LLM İş Akışları (Bölümler)</a></b></li>
        <li><em>& daha fazlası...</em></li>
      </ul>
      <p>
        TensorZero Ağ Geçidi, <b>performans</b> odaklı olarak Rust 🦀 ile yazılmıştır (&lt;1ms p99 gecikme ek yükü @ 10k QPS).
        <b><a href="https://www.tensorzero.com/docs/gateway/benchmarks">Kıyaslamalar</a></b>'a bakın.<br>
      </p>
      <p>
        Çıkarımı <b>TensorZero istemcisi</b> (önerilir), <b>OpenAI istemcisi</b> veya <b>HTTP API</b> ile çalıştırabilirsiniz.
      </p>
    </td>
  </tr>
</table>

<br>

<details open>
<summary><b>Kullanım: Python &mdash; TensorZero İstemcisi (Önerilir)</b></summary>

TensorZero Python istemcisi ile herhangi bir sağlayıcıya erişebilirsiniz.

1. `pip install tensorzero`
2. İsteğe bağlı: TensorZero yapılandırmasını kurun.
3. Çıkarım çalıştırın:

```python
from tensorzero import TensorZeroGateway  # veya AsyncTensorZeroGateway


with TensorZeroGateway.build_embedded(clickhouse_url="...", config_file="...") as client:
    response = client.inference(
        model_name="openai::gpt-4o-mini",
        # Diğer sağlayıcıları kolayca deneyin: "anthropic::claude-3-7-sonnet-20250219"
        input={
            "messages": [
                {
                    "role": "user",
                    "content": "Yapay zeka hakkında bir haiku yaz.",
                }
            ]
        },
    )
```

Daha fazla bilgi için **[Hızlı Başlangıç](https://www.tensorzero.com/docs/quickstart)**'a bakın.

</details>

<details>
<summary><b>Kullanım: Python &mdash; OpenAI İstemcisi</b></summary>

TensorZero ile OpenAI Python istemcisi kullanarak herhangi bir sağlayıcıya erişebilirsiniz.

1. `pip install tensorzero`
2. İsteğe bağlı: TensorZero yapılandırmasını kurun.
3. Çıkarım çalıştırın:

```python
from openai import OpenAI  # veya AsyncOpenAI
from tensorzero import patch_openai_client

client = OpenAI()
patch_openai_client(
    client,
    clickhouse_url="http://chuser:chpassword@localhost:8123/tensorzero",
    config_file="config/tensorzero.toml",
    async_setup=False,
)

response = client.chat.completions.create(
    model="tensorzero::model_name::openai::gpt-4o-mini",
    # Diğer sağlayıcıları kolayca deneyin: "tensorzero::model_name::anthropic::claude-3-7-sonnet-20250219"
    messages=[
        {
            "role": "user",
            "content": "Yapay zeka hakkında bir haiku yaz.",
        }
    ],
)
```

Daha fazla bilgi için **[Hızlı Başlangıç](https://www.tensorzero.com/docs/quickstart)** bölümüne bakın.

</details>

<details>
<summary><b>Kullanım: JavaScript / TypeScript (Node) &mdash; OpenAI İstemcisi</b></summary>

TensorZero ile OpenAI Node istemcisini kullanarak herhangi bir sağlayıcıya erişebilirsiniz.

1. Docker kullanarak `tensorzero/gateway` dağıtın.
   **[Detaylı talimatlar →](https://www.tensorzero.com/docs/gateway/deployment)**
2. TensorZero yapılandırmasını kurun.
3. Çıkarım çalıştırın:

```ts
import OpenAI from "openai";

const client = new OpenAI({
  baseURL: "http://localhost:3000/openai/v1",
});

const response = await client.chat.completions.create({
  model: "tensorzero::model_name::openai::gpt-4o-mini",
  // Diğer sağlayıcıları kolayca deneyin: "tensorzero::model_name::anthropic::claude-3-7-sonnet-20250219"
  messages: [
    {
      role: "user",
      content: "Yapay zeka hakkında bir haiku yaz.",
    },
  ],
});
```

Daha fazla bilgi için **[Hızlı Başlangıç](https://www.tensorzero.com/docs/quickstart)** bölümüne bakın.

</details>

<details>
<summary><b>Kullanım: Diğer Diller & Platformlar &mdash; HTTP API</b></summary>

TensorZero, HTTP API'si ile neredeyse her programlama dili veya platformunu destekler.

1. Docker kullanarak `tensorzero/gateway` dağıtın.
   **[Detaylı talimatlar →](https://www.tensorzero.com/docs/gateway/deployment)**
2. Opsiyonel: TensorZero yapılandırmasını kurun.
3. Çıkarım çalıştırın:

```bash
curl -X POST "http://localhost:3000/inference" \
  -H "Content-Type: application/json" \
  -d '{
    "model_name": "openai::gpt-4o-mini",
    "input": {
      "messages": [
        {
          "role": "user",
          "content": "Yapay zeka hakkında bir haiku yaz."
        }
      ]
    }
  }'
```

Daha fazla bilgi için **[Hızlı Başlangıç](https://www.tensorzero.com/docs/quickstart)** bölümüne bakın.

</details>

<br>

### 📈 LLM Optimizasyonu

> **Üretim metriklerini ve insan geri bildirimlerini göndererek istemlerinizi, modellerinizi ve çıkarım stratejilerinizi kolayca optimize edin — UI veya programatik olarak.**

#### Model Optimizasyonu

Kapalı kaynak ve açık kaynak modelleri, denetimli ince ayar (SFT) ve tercih ince ayarı (DPO) ile optimize edin.

<table>
  <tr></tr> <!-- flip highlight order -->
  <tr>
    <td width="50%" align="center" valign="middle"><b>Denetimli İnce Ayar &mdash; UI</b></td>
    <td width="50%" align="center" valign="middle"><b>Tercih İnce Ayarı (DPO) &mdash; Jupyter Notebook</b></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/cf7acf66-732b-43b3-af2a-5eba1ce40f6f"></td>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/a67a0634-04a7-42b0-b934-9130cb7cdf51"></td>
  </tr>
</table>

#### Çıkarım Zamanı Optimizasyonu

İstemlerinizi ilgili örneklerle dinamik olarak güncelleyerek, birden fazla çıkarımdan gelen yanıtları birleştirerek ve daha fazlasını yaparak performansı artırın.

<table>
  <tr></tr> <!-- flip highlight order -->
  <tr>
    <td width="50%" align="center" valign="middle"><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations#best-of-n-sampling">N'in En İyisi Örnekleme</a></b></td>
    <td width="50%" align="center" valign="middle"><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations#mixture-of-n-sampling">N Karışımı Örnekleme</a></b></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/c0edfa4c-713c-4996-9964-50c0d26e6970"></td>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/75b5bf05-4c1f-43c4-b158-d69d1b8d05be"></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations#dynamic-in-context-learning-dicl">Dinamik Bağlam İçi Öğrenme (DICL)</a></b></td>
    <td width="50%" align="center" valign="middle"><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations#chain-of-thought-cot">Düşünce Zinciri (CoT)</a></b></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/d8489e92-ce93-46ac-9aab-289ce19bb67d"></td>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/ea13d73c-76a4-4e0c-a35b-0c648f898311" height="320"></td>
  </tr>
</table>

_Daha fazlası yakında..._

<br>

#### İstem Optimizasyonu

Araştırma odaklı optimizasyon tekniklerini kullanarak istemlerinizi programatik olarak optimize edin.

<table>
  <tr></tr> <!-- flip highlight order -->
  <tr>
    <td width="50%" align="center" valign="middle"><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations#best-of-n-sampling">MIPROv2</a></b></td>
    <td width="50%" align="center" valign="middle"><b><a href="https://github.com/tensorzero/tensorzero/tree/main/examples/gsm8k-custom-recipe-dspy">DSPy Entegrasyonu</a></b></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/d81a7c37-382f-4c46-840f-e6c2593301db" alt="MIPROv2 diagram"></td>
    <td width="50%" align="center" valign="middle">
      TensorZero birkaç optimizasyon tarifiyle birlikte gelir, fakat kolayca kendi tarifinizi de oluşturabilirsiniz.
      Bu örnekte, TensorZero fonksiyonunu keyfi bir araç — burada, otomatik istem mühendisliği için popüler bir kütüphane olan DSPy — ile nasıl optimize edebileceğiniz gösterilmektedir.
    </td>
  </tr>
</table>

_Daha fazlası yakında..._

<br>

### 🔍 LLM Gözlemlenebilirliği

> **Bireysel API çağrılarını hata ayıklamak için yakınlaştırın veya zaman içinde modeller ve istemler arası metrikleri izlemek için uzaklaştırın — hepsi açık kaynaklı TensorZero UI ile.**

<table>
  <tr></tr> <!-- flip highlight order -->
  <tr>
    <td width="50%" align="center" valign="middle"><b>Gözlemlenebilirlik » Çıkarım</b></td>
    <td width="50%" align="center" valign="middle"><b>Gözlemlenebilirlik » Fonksiyon</b></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/2cc3cc9a-f33f-4e94-b8de-07522326f80a"></td>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/00ae6605-8fa0-4efd-8238-ae8ea589860f"></td>
  </tr>
</table>

<br>

### 📊 LLM Değerlendirmeleri

> **TensorZero Değerlendirmeleri ile istemleri, modelleri ve çıkarım stratejilerini karşılaştırın — sezgisel kurallar ve LLM hakemleri desteğiyle.**

<table>
  <tr></tr> <!-- flip highlight order -->
  <tr>
    <td width="50%" align="center" valign="middle"><b>Değerlendirme » UI</b></td>
    <td width="50%" align="center" valign="middle"><b>Değerlendirme » CLI</b></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/f4bf54e3-1b63-46c8-be12-2eaabf615699"></td>
    <td width="50%" align="left" valign="middle">
<pre><code class="language-bash">docker compose run --rm evaluations \
  --evaluation-name extract_data \
  --dataset-name hard_test_cases \
  --variant-name gpt_4o \
  --concurrency 5</code></pre>
<pre><code class="language-bash">Run ID: 01961de9-c8a4-7c60-ab8d-15491a9708e4
Number of datapoints: 100
██████████████████████████████████████ 100/100
exact_match: 0.83 ± 0.03
semantic_match: 0.98 ± 0.01
item_count: 7.15 ± 0.39</code></pre>
    </td>
  </tr>
</table>

## Demo

> **TensorZero ile LLM'lerin gerçek zamanlı veri çıkarımında nasıl daha iyi hale geldiğini izleyin!**
>
> **[Dinamik bağlamsal öğrenme (DICL)](https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations#dynamic-in-context-learning-dicl)**, TensorZero ile kutudan çıkar çıkmaz sunulan güçlü bir çıkarım zamanı optimizasyonudur.
> Model ince ayarı gerektirmeden, geçmişten alınan ilgili örnekleri otomatik olarak isteme dahil ederek LLM performansını artırır.

https://github.com/user-attachments/assets/4df1022e-886e-48c2-8f79-6af3cdad79cb

## TensorZero ile LLM Mühendisliği

<br>
<p align="center" >
  <a href="https://www.tensorzero.com/docs">
    <picture>
      <source media="(prefers-color-scheme: light)" srcset="https://github.com/user-attachments/assets/34a92c18-242e-4d76-a99c-861283de68a6">
      <source media="(prefers-color-scheme: dark)" srcset="https://github.com/user-attachments/assets/e8bc699b-6378-4c2a-9cc1-6d189025e270">
      <img alt="TensorZero Flywheel" src="https://github.com/user-attachments/assets/34a92c18-242e-4d76-a99c-861283de68a6" width=720>
    </picture>
  </a>
</p>
<br>

1. **[TensorZero Gateway](https://www.tensorzero.com/docs/gateway/)**, Rust ile yazılmış yüksek performanslı bir model geçididir 🦀 ve tüm büyük LLM sağlayıcıları için birleşik bir API arayüzü sunar; böylece platformlar arası entegrasyon ve yedekleme işlemleri sorunsuzca gerçekleşir.
2. Yapılandırılmış şema tabanlı çıkarımı &lt;1ms P99 gecikme ek yüküyle (**[Kıyaslamalar](https://www.tensorzero.com/docs/gateway/benchmarks)** bölümüne bakınız), yerleşik gözlemlenebilirlik, deneyler ve **[çıkarım zamanı optimizasyonları](https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations)** ile birlikte yönetir.
3. Ayrıca, bu çıkarımlara ilişkin aşağı akış metrikleri ve geri bildirimleri toplar; çok adımlı LLM sistemleri için birinci sınıf destek sunar.
4. Her şey, gerçek zamanlı, ölçeklenebilir ve geliştirici dostu analizler için sizin kontrolünüzde olan bir ClickHouse veri ambarında saklanır.
5. Zamanla, **[TensorZero Tarifleri](https://www.tensorzero.com/docs/recipes)** bu yapılandırılmış veri setini istemlerinizi ve modellerinizi optimize etmek için kullanır: ince ayar gibi yaygın iş akışları için önceden hazırlanmış tarifleri çalıştırabilir veya istediğiniz dil ve platformda tamamen esnek, kendi tariflerinizi oluşturabilirsiniz.
6. Son olarak, geçidin deney ve GitOps orkestrasyonu özellikleri, ister tek bir LLM ister binlerce LLM ile çalışıyor olun, güvenle yineleme ve dağıtım yapmanızı sağlar.

Amacımız, mühendislerin gerçek dünya deneyiminden öğrenebilen yeni nesil LLM uygulamalarını inşa etmelerine, yönetmelerine ve optimize etmelerine yardımcı olmaktır.
**[Vizyon & Yol Haritası](https://www.tensorzero.com/docs/vision-roadmap/)** hakkında daha fazla bilgi edinin.

## Başlarken

**Bugün geliştirmeye başlayın.**
**[Hızlı Başlangıç](https://www.tensorzero.com/docs/quickstart)**, TensorZero ile bir LLM uygulamasının nasıl kolayca kurulacağını gösteriyor.
Daha derine inmek isterseniz, **[Eğitim](https://www.tensorzero.com/docs/gateway/tutorial)** bölümünde basit bir sohbet botu, e-posta asistanı, hava durumu RAG sistemi ve yapılandırılmış veri çıkarım hattı nasıl oluşturulur öğrenebilirsiniz.

**Sorularınız mı var?**
Bize **[Slack](https://www.tensorzero.com/slack)** veya **[Discord](https://www.tensorzero.com/discord)** üzerinden ulaşabilirsiniz.

**TensorZero'yu işyerinde mi kullanıyorsunuz?**
Ekibinizle birlikte Slack veya Teams kanalı kurmak için bize **[hello@tensorzero.com](mailto:hello@tensorzero.com)** adresinden e-posta gönderebilirsiniz (ücretsizdir).

**Bizimle çalışın.**
**[NYC'de işe alım yapıyoruz](https://www.tensorzero.com/jobs)**.
Ayrıca **[açık kaynak katkılarını](https://github.com/tensorzero/tensorzero/blob/main/CONTRIBUTING.md)** da memnuniyetle karşılıyoruz!

## Örnekler

TensorZero'nun veri & öğrenme döngüsünü gösteren **tam çalışır örnekler** serisi üzerinde çalışıyoruz.

> **[TensorZero ile Veri Çıkarımını (NER) Optimize Etmek](https://github.com/tensorzero/tensorzero/tree/main/examples/data-extraction-ner)**
>
> Bu örnek, bir veri çıkarım hattının TensorZero ile nasıl optimize edileceğini gösteriyor.
> İnce ayar ve dinamik bağlamsal öğrenme (DICL) gibi teknikleri gösteriyoruz.
> Sonuçta, optimize edilmiş bir GPT-4o Mini modeli, bu görevde GPT-4o'yu — çok daha düşük maliyet ve gecikmeyle — az miktarda eğitim verisi kullanarak geride bırakıyor.

> **[Ajan Tabanlı RAG — LLM'lerle Çok Aşamalı Soru Yanıtlama](https://github.com/tensorzero/tensorzero/tree/main/examples/rag-retrieval-augmented-generation/simple-agentic-rag/)**
>
> Bu örnek, TensorZero kullanarak çok aşamalı bir bilgi getirme ajanının nasıl oluşturulacağını gösteriyor.
> Ajan, karmaşık bir soruya yanıt vermek için yeterli bağlamı topladığını düşündüğünde, Wikipedia'da yinelemeli olarak arama yapar.

> **[Gizli Tercihlere Sahip Bir Hakemi Tatmin Etmek İçin Haiku Yazmak](https://github.com/tensorzero/tensorzero/tree/main/examples/haiku-hidden-preferences)**
>
> Bu örnek, GPT-4o Mini'nin belirli bir zevke göre haiku üretmesi için ince ayar yapılmasını gösteriyor.
> TensorZero'nun "kutuda veri döngüsü"nü çalışırken göreceksiniz: daha iyi varyantlar daha iyi veri, daha iyi veri daha iyi varyantlar getirir.
> LLM'i birden fazla kez ince ayar yaparak ilerlemeyi göreceksiniz.

> **[Best-of-N Örnekleme ile LLM Satranç Yeteneğini Artırmak](https://github.com/tensorzero/tensorzero/tree/main/examples/chess-puzzles/)**
>
> Bu örnek, birden fazla oluşturulan seçeneğin arasından en umut verici hamleleri seçerek best-of-N örneklemenin LLM'in satranç oynama yeteneğini nasıl önemli ölçüde artırabileceğini gösteriyor.

> **[Otomatik İstem Mühendisliği (DSPy) için Özel Tarif ile Matematiksel Akıl Yürütmeyi Geliştirmek](https://github.com/tensorzero/tensorzero/tree/main/examples/gsm8k-custom-recipe-dspy)**
>
> TensorZero, yaygın LLM mühendisliği iş akışlarını kapsayan birçok önceden hazırlanmış optimizasyon tarifi sunar.
> Ancak kendi tariflerinizi ve iş akışlarınızı da kolayca oluşturabilirsiniz!
> Bu örnek, TensorZero işlevinin burada DSPy adlı herhangi bir araç kullanılarak nasıl optimize edileceğini gösteriyor.

_& çok daha fazlası yolda!_

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---