# ProxyAsLocalModel

Proxy API LLM jarak jauh sebagai model Lokal. Khususnya berfungsi untuk menggunakan LLM kustom di JetBrains AI Assistant.

Didukung oleh Ktor dan kotlinx.serialization. Terima kasih atas fitur tanpa refleksi mereka.

## Cerita dari proyek ini

Saat ini, JetBrains AI Assistant menyediakan paket gratis dengan kuota yang sangat terbatas. Saya mencobanya dan kuota saya cepat habis.

Saya sudah membeli token API LLM lain, seperti Gemini dan Qwen. Jadi saya mulai berpikir untuk menggunakannya di AI Assistant. Sayangnya, hanya model lokal dari LM Studio dan Ollama yang didukung. Maka saya mulai mengerjakan aplikasi proxy ini yang memproxy API LLM pihak ketiga sebagai API LM Studio dan Ollama agar saya bisa menggunakannya di IDE JetBrains saya.

Ini hanyalah tugas sederhana, jadi saya mulai menggunakan SDK resmi sebagai klien dan menulis server Ktor sederhana yang menyediakan endpoint seperti LM Studio dan Ollama. Masalah muncul ketika saya mencoba mendistribusikannya sebagai image native GraalVM. SDK Java resmi menggunakan terlalu banyak fitur dinamis, sehingga sulit untuk dikompilasi menjadi image native, bahkan dengan tracing agent. Jadi saya memutuskan untuk mengimplementasikan klien sederhana untuk API chat completion streaming sendiri menggunakan Ktor dan kotlinx.serialization yang keduanya tanpa refleksi, fungsional, dan bergaya DSL.

Seperti yang Anda lihat, aplikasi ini didistribusikan sebagai fat runnable jar dan image native GraalVM, yang membuatnya lintas platform dan cepat untuk dijalankan.

Pengembangan aplikasi ini memberi saya kepercayaan diri pada Kotlin/Ktor/kotlinx.serialization. Dunia Kotlin lebih banyak menggunakan pemrograman fungsional dan lebih sedikit refleksi, sehingga lebih cocok untuk image native GraalVM, dengan waktu startup yang lebih cepat dan penggunaan memori yang lebih sedikit.

## Saat ini didukung

Proxy dari: OpenAI, Claude, DashScope (Alibaba Qwen), Gemini, Deepseek, Mistral, SiliconFlow.

Proxy sebagai: LM Studio, Ollama.

Hanya API chat completion streaming.
## Cara Penggunaan

Aplikasi ini adalah server proxy, didistribusikan sebagai fat runnable jar dan GraalVM native image (Windows x64).

Jalankan aplikasi, dan Anda akan melihat pesan bantuan:

```
2025-05-02 10:43:53 INFO  Help - Sepertinya Anda menjalankan program untuk pertama kalinya di sini.
2025-05-02 10:43:53 INFO  Help - File konfigurasi default telah dibuat di your_path\config.yml dengan anotasi skema.
2025-05-02 10:43:53 INFO  Config - Pemantau file konfigurasi dimulai di your_path\config.yml
2025-05-02 10:43:53 INFO  LM Studio Server - LM Studio Server dimulai pada 1234
2025-05-02 10:43:53 INFO  Ollama Server - Ollama Server dimulai pada 11434
2025-05-02 10:43:53 INFO  Model List - Daftar model dimuat dengan: []
```

Kemudian Anda dapat mengedit file konfigurasi untuk mengatur server proxy Anda.

## File Konfigurasi

File konfigurasi ini secara otomatis dimuat ulang (hot-reload) saat Anda mengubahnya. Hanya bagian server yang terpengaruh yang akan diperbarui.

Saat pertama kali menghasilkan file konfigurasi, file tersebut akan dibuat dengan anotasi skema. Ini akan memberikan fitur pelengkapan dan pemeriksaan di editor Anda.
## Contoh file konfigurasi

```yaml
# $schema: https://github.com/Stream29/ProxyAsLocalModel/raw/master/config_v3.schema.json
lmStudio:
  port: 1234 # Ini adalah nilai default
  enabled: true # Ini adalah nilai default
  host: 0.0.0.0 # Ini adalah nilai default
  path: /your/path # Akan ditambahkan sebelum endpoint asli, nilai default adalah kosong
ollama:
  port: 11434 # Ini adalah nilai default
  enabled: true # Ini adalah nilai default
  host: 0.0.0.0 # Ini adalah nilai default
  path: /your/path # Akan ditambahkan sebelum endpoint asli, nilai default adalah kosong
client:
  socketTimeout: 1919810 # Long.MAX_VALUE adalah nilai default, dalam milidetik
  connectionTimeout: 1919810 # Long.MAX_VALUE adalah nilai default, dalam milidetik
  requestTimeout: 1919810 # Long.MAX_VALUE adalah nilai default, dalam milidetik
  retry: 3 # Ini adalah nilai default
  delayBeforeRetry: 1000 # Ini adalah nilai default, dalam milidetik

apiProviders:
  OpenAI:
    type: OpenAi
    baseUrl: https://api.openai.com/v1
    apiKey: <your_api_key>
    modelList:
      - gpt-4o
  Claude:
    type: Claude
    apiKey: <your_api_key>
    modelList:
      - claude-3-7-sonnet
  Qwen:
    type: DashScope
    apiKey: <your_api_key>
    modelList: # Ini adalah nilai default
      - qwen-max
      - qwen-plus
      - qwen-turbo
      - qwen-long
  DeepSeek:
    type: DeepSeek
    apiKey: <your_api_key>
    modelList: # Ini adalah nilai default
      - deepseek-chat
      - deepseek-reasoner
  Mistral:
    type: Mistral
    apiKey: <your_api_key>
    modelList: # Ini adalah nilai default
      - codestral-latest
      - mistral-large
  SiliconFlow:
    type: SiliconFlow
    apiKey: <your_api_key>
    modelList:
      - Qwen/Qwen3-235B-A22B
      - Pro/deepseek-ai/DeepSeek-V3
      - THUDM/GLM-4-32B-0414
  OpenRouter:
    type: OpenRouter
    apiKey: <your_api_key>
    modelList:
      - openai/gpt-4o
  Gemini:
    type: Gemini
    apiKey: <your_api_key>
    modelList:
      - gemini-2.5-flash-preview-04-17
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-10

---