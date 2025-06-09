<img src="https://github.com/user-attachments/assets/47d67430-386d-4675-82ad-d4734d3262d9" width=128 height=128>

# TensorZero

**TensorZero menciptakan loop umpan balik untuk mengoptimalkan aplikasi LLM — mengubah data produksi menjadi model yang lebih cerdas, lebih cepat, dan lebih murah.**

1. Integrasikan gateway model kami
2. Kirim metrik atau umpan balik
3. Optimalkan prompt, model, dan strategi inferensi
4. Saksikan LLM Anda meningkat seiring waktu

TensorZero menyediakan **flywheel data & pembelajaran untuk LLM** dengan menyatukan:

- [x] **Inferensi:** satu API untuk semua LLM, dengan overhead P99 <1ms
- [x] **Observabilitas:** inferensi & umpan balik → database Anda
- [x] **Optimasi:** dari prompt hingga fine-tuning dan RL
- [x] **Evaluasi:** membandingkan prompt, model, strategi inferensi
- [x] **Eksperimen:** A/B testing, routing, fallback bawaan

---

<p align="center">
  <b><a href="https://www.tensorzero.com/" target="_blank">Website</a></b>
  ·
  <b><a href="https://www.tensorzero.com/docs" target="_blank">Dokumentasi</a></b>
  ·
  <b><a href="https://www.x.com/tensorzero" target="_blank">Twitter</a></b>
  ·
  <b><a href="https://www.tensorzero.com/slack" target="_blank">Slack</a></b>
  ·
  <b><a href="https://www.tensorzero.com/discord" target="_blank">Discord</a></b>
  <br>
  <br>
  <b><a href="https://www.tensorzero.com/docs/quickstart" target="_blank">Quick Start (5menit)</a></b>
  ·
  <b><a href="https://www.tensorzero.com/docs/gateway/tutorial" target="_blank">Tutorial Lengkap</a></b>
  ·
  <b><a href="https://www.tensorzero.com/docs/gateway/deployment" target="_blank">Panduan Deployment</a></b>
  ·
  <b><a href="https://www.tensorzero.com/docs/gateway/api-reference" target="_blank">Referensi API</a></b>
  ·
  <b><a href="https://www.tensorzero.com/docs/gateway/deployment" target="_blank">Referensi Konfigurasi</a></b>
</p>

---

<table>
  <tr>
    <td width="30%" valign="top"><b>Apa itu TensorZero?</b></td>
    <td width="70%" valign="top">TensorZero adalah framework open-source untuk membangun aplikasi LLM kelas produksi. TensorZero menyatukan gateway LLM, observabilitas, optimasi, evaluasi, dan eksperimen.</td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>Apa yang membedakan TensorZero dari framework LLM lainnya?</b></td>
    <td width="70%" valign="top">
      1. TensorZero memungkinkan Anda mengoptimalkan aplikasi LLM kompleks berdasarkan metrik produksi dan umpan balik manusia.<br>
      2. TensorZero mendukung kebutuhan aplikasi LLM skala industri: latensi rendah, throughput tinggi, type safety, self-hosted, GitOps, kustomisasi, dll.<br>
      3. TensorZero menyatukan seluruh stack LLMOps, menciptakan manfaat berlipat ganda. Sebagai contoh, evaluasi LLM dapat digunakan untuk fine-tuning model bersama AI judge.
    </td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>Bisakah saya menggunakan TensorZero dengan ___?</b></td>
    <td width="70%" valign="top">Bisa. Semua bahasa pemrograman utama didukung. Anda dapat menggunakan TensorZero dengan klien Python kami, SDK OpenAI apa pun, atau HTTP API kami.</td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>Apakah TensorZero siap produksi?</b></td>
    <td width="70%" valign="top">Bisa. Berikut studi kasus: <b><a href="https://www.tensorzero.com/blog/case-study-automating-code-changelogs-at-a-large-bank-with-llms">Otomatisasi Changelog Kode di Bank Besar dengan LLM</a></b></td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>Berapa biaya TensorZero?</b></td>
    <td width="70%" valign="top">Tidak ada. TensorZero 100% self-hosted dan open-source. Tidak ada fitur berbayar.</td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>Siapa yang membangun TensorZero?</b></td>
    <td width="70%" valign="top">Tim teknis kami terdiri dari mantan maintainer Rust compiler, peneliti machine learning (Stanford, CMU, Oxford, Columbia) dengan ribuan sitasi, dan chief product officer dari startup decacorn. Kami didukung oleh investor yang sama dengan proyek open-source terkemuka (misal ClickHouse, CockroachDB) dan lab AI (misal OpenAI, Anthropic).</td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>Bagaimana saya memulai?</b></td>
    <td width="70%" valign="top">Anda dapat mengadopsi TensorZero secara bertahap. <b><a href="https://www.tensorzero.com/docs/quickstart">Quick Start</a></b> kami membawa Anda dari wrapper OpenAI standar ke aplikasi LLM siap produksi dengan observabilitas dan fine-tuning hanya dalam 5 menit.</td>
  </tr>
</table>

---

## Fitur

### 🌐 LLM Gateway

> **Integrasi dengan TensorZero sekali dan akses semua penyedia LLM utama.**

<table>
  <tr></tr> <!-- flip highlight order -->
  <tr>
    <td width="50%" align="center" valign="middle"><b>Penyedia Model</b></td>
    <td width="50%" align="center" valign="middle"><b>Fitur</b></td>
  </tr>
  <tr>
    <td width="50%" align="left" valign="top">
      <p>
        Gateway TensorZero mendukung secara native:
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
          Butuh penyedia lain?
          Penyedia Anda kemungkinan besar didukung karena TensorZero terintegrasi dengan <b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/openai-compatible">API yang kompatibel dengan OpenAI (misal Ollama)</a></b>.
          </em>
      </p>
    </td>
    <td width="50%" align="left" valign="top">
      <p>
        Gateway TensorZero mendukung fitur-fitur canggih seperti:
      </p>
      <ul>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/retries-fallbacks">Retries & Fallbacks</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations">Optimasi Waktu Inferensi</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/prompt-templates-schemas">Template & Skema Prompt</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/tutorial#experimentation">Eksperimen (A/B Testing)</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/configuration-reference">Configuration-as-Code (GitOps)</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/batch-inference">Inferensi Batch</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/multimodal-inference">Inferensi Multimodal (VLMs)</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-caching">Caching Inferensi</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/metrics-feedback">Metrik & Umpan Balik</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/episodes">Alur Kerja LLM Multi-Langkah (Episodes)</a></b></li>
        <li><em>& masih banyak lagi...</em></li>
      </ul>
      <p>
        Gateway TensorZero ditulis dalam Rust 🦀 dengan fokus pada <b>performa</b> (&lt;1ms p99 latency overhead @ 10k QPS).
        Lihat <b><a href="https://www.tensorzero.com/docs/gateway/benchmarks">Benchmark</a></b>.<br>
      </p>
      <p>
        Anda dapat menjalankan inferensi menggunakan <b>klien TensorZero</b> (direkomendasikan), <b>klien OpenAI</b>, atau <b>HTTP API</b>.
      </p>
    </td>
  </tr>
</table>

<br>

<details open>
<summary><b>Pemakaian: Python &mdash; Klien TensorZero (Direkomendasikan)</b></summary>

Anda dapat mengakses penyedia mana pun menggunakan klien Python TensorZero.

1. `pip install tensorzero`
2. Opsional: Siapkan konfigurasi TensorZero.
3. Jalankan inferensi:

```python
from tensorzero import TensorZeroGateway  # atau AsyncTensorZeroGateway


with TensorZeroGateway.build_embedded(clickhouse_url="...", config_file="...") as client:
    response = client.inference(
        model_name="openai::gpt-4o-mini",
        # Coba penyedia lain dengan mudah: "anthropic::claude-3-7-sonnet-20250219"
        input={
            "messages": [
                {
                    "role": "user",
                    "content": "Tulis haiku tentang kecerdasan buatan.",
                }
            ]
        },
    )
```

Lihat **[Quick Start](https://www.tensorzero.com/docs/quickstart)** untuk informasi lebih lanjut.

</details>

<details>
<summary><b>Pemakaian: Python &mdash; Klien OpenAI</b></summary>

Anda dapat mengakses penyedia mana pun menggunakan klien Python OpenAI dengan TensorZero.

1. `pip install tensorzero`
2. Opsional: Siapkan konfigurasi TensorZero.
3. Jalankan inferensi:

```python
from openai import OpenAI  # atau AsyncOpenAI
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
    # Coba penyedia lain dengan mudah: "tensorzero::model_name::anthropic::claude-3-7-sonnet-20250219"
    messages=[
        {
            "role": "user",
            "content": "Tulis sebuah haiku tentang kecerdasan buatan.",
        }
    ],
)
```

Lihat **[Quick Start](https://www.tensorzero.com/docs/quickstart)** untuk informasi lebih lanjut.

</details>

<details>
<summary><b>Penggunaan: JavaScript / TypeScript (Node) &mdash; OpenAI Client</b></summary>

Anda dapat mengakses penyedia apa pun menggunakan OpenAI Node client dengan TensorZero.

1. Deploy `tensorzero/gateway` menggunakan Docker.
   **[Petunjuk lengkap →](https://www.tensorzero.com/docs/gateway/deployment)**
2. Siapkan konfigurasi TensorZero.
3. Jalankan inferensi:

```ts
import OpenAI from "openai";

const client = new OpenAI({
  baseURL: "http://localhost:3000/openai/v1",
});

const response = await client.chat.completions.create({
  model: "tensorzero::model_name::openai::gpt-4o-mini",
  // Coba penyedia lain dengan mudah: "tensorzero::model_name::anthropic::claude-3-7-sonnet-20250219"
  messages: [
    {
      role: "user",
      content: "Tulis sebuah haiku tentang kecerdasan buatan.",
    },
  ],
});
```

Lihat **[Quick Start](https://www.tensorzero.com/docs/quickstart)** untuk informasi lebih lanjut.

</details>

<details>
<summary><b>Penggunaan: Bahasa & Platform Lain &mdash; HTTP API</b></summary>

TensorZero mendukung hampir semua bahasa pemrograman atau platform melalui HTTP API-nya.

1. Deploy `tensorzero/gateway` menggunakan Docker.
   **[Petunjuk lengkap →](https://www.tensorzero.com/docs/gateway/deployment)**
2. Opsional: Siapkan konfigurasi TensorZero.
3. Jalankan inferensi:

```bash
curl -X POST "http://localhost:3000/inference" \
  -H "Content-Type: application/json" \
  -d '{
    "model_name": "openai::gpt-4o-mini",
    "input": {
      "messages": [
        {
          "role": "user",
          "content": "Tulis sebuah haiku tentang kecerdasan buatan."
        }
      ]
    }
  }'
```

Lihat **[Quick Start](https://www.tensorzero.com/docs/quickstart)** untuk informasi lebih lanjut.

</details>

<br>

### 📈 Optimasi LLM

> **Kirim metrik produksi dan umpan balik manusia untuk dengan mudah mengoptimalkan prompt, model, dan strategi inferensi Anda &mdash; menggunakan UI atau secara terprogram.**

#### Optimasi Model

Optimalkan model sumber tertutup dan sumber terbuka menggunakan fine-tuning terawasi (SFT) dan fine-tuning preferensi (DPO).

<table>
  <tr></tr> <!-- flip highlight order -->
  <tr>
    <td width="50%" align="center" valign="middle"><b>Fine-tuning Terawasi &mdash; UI</b></td>
    <td width="50%" align="center" valign="middle"><b>Fine-tuning Preferensi (DPO) &mdash; Jupyter Notebook</b></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/cf7acf66-732b-43b3-af2a-5eba1ce40f6f"></td>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/a67a0634-04a7-42b0-b934-9130cb7cdf51"></td>
  </tr>
</table>

#### Optimasi Waktu Inferensi

Tingkatkan performa dengan memperbarui prompt Anda secara dinamis dengan contoh relevan, menggabungkan respons dari banyak inferensi, dan lainnya.

<table>
  <tr></tr> <!-- flip highlight order -->
  <tr>
    <td width="50%" align="center" valign="middle"><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations#best-of-n-sampling">Best-of-N Sampling</a></b></td>
    <td width="50%" align="center" valign="middle"><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations#mixture-of-n-sampling">Mixture-of-N Sampling</a></b></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/c0edfa4c-713c-4996-9964-50c0d26e6970"></td>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/75b5bf05-4c1f-43c4-b158-d69d1b8d05be"></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations#dynamic-in-context-learning-dicl">Dynamic In-Context Learning (DICL)</a></b></td>
    <td width="50%" align="center" valign="middle"><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations#chain-of-thought-cot">Chain-of-Thought (CoT)</a></b></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/d8489e92-ce93-46ac-9aab-289ce19bb67d"></td>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/ea13d73c-76a4-4e0c-a35b-0c648f898311" height="320"></td>
  </tr>
</table>

_Lebih banyak fitur segera hadir..._

<br>

#### Optimasi Prompt

Optimalkan prompt Anda secara terprogram menggunakan teknik optimasi berbasis riset.

<table>
  <tr></tr> <!-- flip highlight order -->
  <tr>
    <td width="50%" align="center" valign="middle"><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations#best-of-n-sampling">MIPROv2</a></b></td>
    <td width="50%" align="center" valign="middle"><b><a href="https://github.com/tensorzero/tensorzero/tree/main/examples/gsm8k-custom-recipe-dspy">Integrasi DSPy</a></b></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/d81a7c37-382f-4c46-840f-e6c2593301db" alt="MIPROv2 diagram"></td>
    <td width="50%" align="center" valign="middle">
      TensorZero hadir dengan beberapa resep optimasi, tetapi Anda juga dapat dengan mudah membuat sendiri.
      Contoh ini menunjukkan cara mengoptimalkan fungsi TensorZero menggunakan tool arbitrary — di sini, DSPy, pustaka populer untuk prompt engineering otomatis.
    </td>
  </tr>
</table>

_Lebih banyak fitur segera hadir..._

<br>

### 🔍 Observabilitas LLM

> **Perbesar untuk debug panggilan API individual, atau perkecil untuk memonitor metrik di seluruh model dan prompt dari waktu ke waktu &mdash; semua menggunakan UI TensorZero open-source.**

<table>
  <tr></tr> <!-- flip highlight order -->
  <tr>
    <td width="50%" align="center" valign="middle"><b>Observabilitas » Inferensi</b></td>
    <td width="50%" align="center" valign="middle"><b>Observabilitas » Fungsi</b></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/2cc3cc9a-f33f-4e94-b8de-07522326f80a"></td>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/00ae6605-8fa0-4efd-8238-ae8ea589860f"></td>
  </tr>
</table>

<br>

### 📊 Evaluasi LLM

> **Bandingkan prompt, model, dan strategi inferensi menggunakan TensorZero Evaluations &mdash; dengan dukungan heuristik dan LLM judges.**

<table>
  <tr></tr> <!-- flip highlight order -->
  <tr>
    <td width="50%" align="center" valign="middle"><b>Evaluasi » UI</b></td>
    <td width="50%" align="center" valign="middle"><b>Evaluasi » CLI</b></td>
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

> **Saksikan LLM menjadi lebih baik dalam ekstraksi data secara real-time dengan TensorZero!**
>
> **[Dynamic in-context learning (DICL)](https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations#dynamic-in-context-learning-dicl)** adalah optimasi inferensi waktu nyata yang kuat dan tersedia langsung di TensorZero.
> Fitur ini meningkatkan performa LLM dengan secara otomatis menggabungkan contoh historis yang relevan ke dalam prompt, tanpa perlu fine-tuning model.

https://github.com/user-attachments/assets/4df1022e-886e-48c2-8f79-6af3cdad79cb

## Rekayasa LLM dengan TensorZero

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

1. **[TensorZero Gateway](https://www.tensorzero.com/docs/gateway/)** adalah gateway model berkinerja tinggi yang ditulis dalam Rust 🦀 yang menyediakan antarmuka API terpadu untuk semua penyedia LLM utama, memungkinkan integrasi lintas platform dan fallback tanpa hambatan.
2. Gateway ini menangani inferensi berbasis skema terstruktur dengan overhead latensi P99 &lt;1ms (lihat **[Benchmarks](https://www.tensorzero.com/docs/gateway/benchmarks)**) serta observabilitas bawaan, eksperimen, dan **[optimasi waktu inferensi](https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations)**.
3. Gateway juga mengumpulkan metrik hilir dan umpan balik terkait inferensi tersebut, dengan dukungan kelas satu untuk sistem LLM multi-langkah.
4. Semua data disimpan di gudang data ClickHouse yang Anda kendalikan untuk analitik real-time, skalabel, dan ramah pengembang.
5. Seiring waktu, **[TensorZero Recipes](https://www.tensorzero.com/docs/recipes)** memanfaatkan dataset terstruktur ini untuk mengoptimalkan prompt dan model Anda: jalankan resep siap pakai untuk alur kerja umum seperti fine-tuning, atau buat sendiri dengan fleksibilitas penuh menggunakan bahasa dan platform apa pun.
6. Fitur eksperimen gateway dan orkestrasi GitOps memungkinkan Anda beriterasi dan melakukan deploy dengan percaya diri, baik untuk satu LLM maupun ribuan LLM.

Tujuan kami adalah membantu para engineer membangun, mengelola, dan mengoptimalkan generasi berikutnya dari aplikasi LLM: sistem yang belajar dari pengalaman nyata.
Baca lebih lanjut tentang **[Visi & Roadmap](https://www.tensorzero.com/docs/vision-roadmap/)** kami.

## Mulai

**Mulailah membangun hari ini.**
**[Quick Start](https://www.tensorzero.com/docs/quickstart)** menunjukkan betapa mudahnya mengatur aplikasi LLM dengan TensorZero.
Jika Anda ingin mendalami lebih jauh, **[Tutorial](https://www.tensorzero.com/docs/gateway/tutorial)** mengajarkan cara membangun chatbot sederhana, email copilot, sistem RAG cuaca, dan pipeline ekstraksi data terstruktur.

**Punya pertanyaan?**
Tanyakan pada kami di **[Slack](https://www.tensorzero.com/slack)** atau **[Discord](https://www.tensorzero.com/discord)**.

**Menggunakan TensorZero di tempat kerja?**
Email kami di **[hello@tensorzero.com](mailto:hello@tensorzero.com)** untuk mengatur kanal Slack atau Teams dengan tim Anda (gratis).

**Bergabunglah bersama kami.**
Kami sedang **[membuka lowongan di NYC](https://www.tensorzero.com/jobs)**.
Kami juga menyambut **[kontribusi open-source](https://github.com/tensorzero/tensorzero/blob/main/CONTRIBUTING.md)**!

## Contoh

Kami sedang mengerjakan serangkaian **contoh lengkap yang dapat dijalankan** yang menggambarkan flywheel data & pembelajaran TensorZero.

> **[Mengoptimalkan Ekstraksi Data (NER) dengan TensorZero](https://github.com/tensorzero/tensorzero/tree/main/examples/data-extraction-ner)**
>
> Contoh ini menunjukkan cara menggunakan TensorZero untuk mengoptimalkan pipeline ekstraksi data.
> Kami mendemonstrasikan teknik seperti fine-tuning dan dynamic in-context learning (DICL).
> Pada akhirnya, model GPT-4o Mini yang dioptimalkan mampu mengungguli GPT-4o dalam tugas ini — dengan biaya dan latensi yang jauh lebih rendah — menggunakan sejumlah kecil data pelatihan.

> **[Agentic RAG — Multi-Hop Question Answering dengan LLM](https://github.com/tensorzero/tensorzero/tree/main/examples/rag-retrieval-augmented-generation/simple-agentic-rag/)**
>
> Contoh ini menunjukkan cara membangun agen retrieval multi-hop menggunakan TensorZero.
> Agen secara iteratif mencari di Wikipedia untuk mengumpulkan informasi, dan memutuskan kapan ia memiliki cukup konteks untuk menjawab pertanyaan kompleks.

> **[Menulis Haiku untuk Memuaskan Juri dengan Preferensi Tersembunyi](https://github.com/tensorzero/tensorzero/tree/main/examples/haiku-hidden-preferences)**
>
> Contoh ini melakukan fine-tuning pada GPT-4o Mini untuk menghasilkan haiku yang disesuaikan dengan selera tertentu.
> Anda akan melihat "data flywheel in a box" TensorZero beraksi: varian yang lebih baik menghasilkan data yang lebih baik, dan data yang lebih baik menghasilkan varian yang lebih baik.
> Kemajuan dapat diamati dengan melakukan fine-tuning LLM beberapa kali.

> **[Meningkatkan Kemampuan Catur LLM dengan Best-of-N Sampling](https://github.com/tensorzero/tensorzero/tree/main/examples/chess-puzzles/)**
>
> Contoh ini menunjukkan bagaimana best-of-N sampling dapat secara signifikan meningkatkan kemampuan LLM dalam bermain catur dengan memilih langkah paling menjanjikan dari beberapa opsi yang dihasilkan.

> **[Meningkatkan Penalaran Matematika dengan Resep Kustom untuk Automated Prompt Engineering (DSPy)](https://github.com/tensorzero/tensorzero/tree/main/examples/gsm8k-custom-recipe-dspy)**
>
> TensorZero menyediakan sejumlah resep optimasi siap pakai yang mencakup alur kerja rekayasa LLM yang umum.
> Namun Anda juga dapat dengan mudah membuat resep dan alur kerja sendiri!
> Contoh ini menunjukkan cara mengoptimalkan fungsi TensorZero menggunakan alat arbitrer — di sini, DSPy.

_& masih banyak lagi yang sedang dalam pengembangan!_

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---