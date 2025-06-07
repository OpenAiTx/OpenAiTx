# Prompt flow

[![Python package](https://img.shields.io/pypi/v/promptflow)](https://pypi.org/project/promptflow/)
[![Python](https://img.shields.io/pypi/pyversions/promptflow.svg?maxAge=2592000)](https://pypi.python.org/pypi/promptflow/)
[![PyPI - Downloads](https://img.shields.io/pypi/dm/promptflow)](https://pypi.org/project/promptflow/)
[![CLI](https://img.shields.io/badge/CLI-reference-blue)](https://microsoft.github.io/promptflow/reference/pf-command-reference.html)
[![vsc extension](https://img.shields.io/visual-studio-marketplace/i/prompt-flow.prompt-flow?logo=Visual%20Studio&label=Extension%20)](https://marketplace.visualstudio.com/items?itemName=prompt-flow.prompt-flow)

[![Doc](https://img.shields.io/badge/Doc-online-green)](https://microsoft.github.io/promptflow/index.html)
[![Issue](https://img.shields.io/github/issues/microsoft/promptflow)](https://github.com/microsoft/promptflow/issues/new/choose)
[![Discussions](https://img.shields.io/github/discussions/microsoft/promptflow)](https://github.com/microsoft/promptflow/issues/new/choose)
[![CONTRIBUTING](https://img.shields.io/badge/Contributing-8A2BE2)](https://github.com/microsoft/promptflow/blob/main/CONTRIBUTING.md)
[![License: MIT](https://img.shields.io/github/license/microsoft/promptflow)](https://github.com/microsoft/promptflow/blob/main/LICENSE)

> Selamat bergabung bersama kami untuk membuat prompt flow menjadi lebih baik dengan
> berpartisipasi dalam [diskusi](https://github.com/microsoft/promptflow/discussions),
> membuka [isu](https://github.com/microsoft/promptflow/issues/new/choose),
> mengirimkan [PR](https://github.com/microsoft/promptflow/pulls).

**Prompt flow** adalah rangkaian alat pengembangan yang dirancang untuk mempermudah siklus pengembangan end-to-end aplikasi AI berbasis LLM, mulai dari ideasi, pembuatan prototipe, pengujian, evaluasi hingga penerapan produksi dan pemantauan. Ini membuat rekayasa prompt jauh lebih mudah dan memungkinkan Anda membangun aplikasi LLM dengan kualitas produksi.

Dengan prompt flow, Anda dapat:

- **Membuat dan mengembangkan flow secara iteratif**
    - Membuat [flow](https://microsoft.github.io/promptflow/concepts/concept-flows.html) yang dapat dijalankan yang menghubungkan LLM, prompt, kode Python, dan [tools](https://microsoft.github.io/promptflow/concepts/concept-tools.html) lainnya.
    - Debug dan iterasi flow Anda, terutama [menelusuri interaksi dengan LLM](https://microsoft.github.io/promptflow/how-to-guides/tracing/index.html) dengan mudah.
- **Evaluasi kualitas dan performa flow**
    - Mengevaluasi kualitas dan performa flow Anda dengan dataset yang lebih besar.
    - Integrasikan pengujian dan evaluasi ke dalam sistem CI/CD Anda untuk memastikan kualitas flow Anda.
- **Siklus pengembangan yang efisien untuk produksi**
    - Deploy flow Anda ke platform serving yang Anda pilih atau integrasikan ke basis kode aplikasi Anda dengan mudah.
    - (Opsional namun sangat direkomendasikan) Berkolaborasi dengan tim Anda menggunakan versi cloud dari [Prompt flow di Azure AI](https://learn.microsoft.com/en-us/azure/machine-learning/prompt-flow/overview-what-is-prompt-flow?view=azureml-api-2).

------

## Instalasi

Untuk memulai dengan cepat, Anda dapat menggunakan lingkungan pengembangan yang sudah disediakan. **Klik tombol di bawah ini** untuk membuka repo di GitHub Codespaces, lalu lanjutkan membaca readme!

[![Open in GitHub Codespaces](https://github.com/codespaces/badge.svg)](https://codespaces.new/microsoft/promptflow?quickstart=1)

Jika Anda ingin memulai di lingkungan lokal, instal paket berikut terlebih dahulu:

Pastikan Anda memiliki lingkungan python, direkomendasikan `python>=3.9, <=3.11`.

```sh
pip install promptflow promptflow-tools
```

## Mulai Cepat ⚡

**Buat chatbot dengan prompt flow**

Jalankan perintah untuk menginisiasi prompt flow dari template chat, ini akan membuat folder bernama `my_chatbot` dan menghasilkan file yang diperlukan di dalamnya:

```sh
pf flow init --flow ./my_chatbot --type chat
```

**Siapkan koneksi untuk API key Anda**

Untuk OpenAI key, buat koneksi dengan menjalankan perintah berikut, menggunakan file `openai.yaml` di folder `my_chatbot`, yang menyimpan OpenAI key Anda (timpa key dan nama dengan --set untuk menghindari perubahan file yaml):

```sh
pf connection create --file ./my_chatbot/openai.yaml --set api_key=<your_api_key> --name open_ai_connection
```

Untuk Azure OpenAI key, buat koneksi dengan menjalankan perintah berikut, menggunakan file `azure_openai.yaml`:

```sh
pf connection create --file ./my_chatbot/azure_openai.yaml --set api_key=<your_api_key> api_base=<your_api_base> --name open_ai_connection
```

**Chat dengan flow Anda**

Di dalam folder `my_chatbot`, terdapat file `flow.dag.yaml` yang merangkum flow, termasuk input/output, node, koneksi, dan model LLM, dll

> Perhatikan bahwa di node `chat`, kita menggunakan koneksi bernama `open_ai_connection` (ditentukan di field `connection`) dan model `gpt-35-turbo` (ditentukan di field `deployment_name`). Field deployment_name digunakan untuk menentukan model OpenAI, atau resource deployment Azure OpenAI.

Berinteraksilah dengan chatbot Anda dengan menjalankan: (tekan `Ctrl + C` untuk mengakhiri sesi)

```sh
pf flow test --flow ./my_chatbot --interactive
```

**Nilai inti: memastikan "Kualitas Tinggi” dari prototipe hingga produksi**

Jelajahi [**tutorial 15-menit**](https://raw.githubusercontent.com/microsoft/promptflow/main/examples/tutorials/flow-fine-tuning-evaluation/promptflow-quality-improvement.md) kami yang membimbing Anda melalui tuning prompt ➡ pengujian batch ➡ evaluasi, semuanya dirancang untuk memastikan kualitas tinggi siap produksi.

Langkah Selanjutnya! Lanjutkan ke bagian **Tutorial**  👇 untuk mempelajari lebih dalam tentang prompt flow.

## Tutorial 🏃‍♂️

Prompt flow adalah alat yang dirancang untuk **membangun aplikasi LLM berkualitas tinggi**, proses pengembangan di prompt flow mengikuti langkah berikut: mengembangkan flow, meningkatkan kualitas flow, deploy flow ke produksi.

### Kembangkan aplikasi LLM Anda sendiri

#### Ekstensi VS Code

Kami juga menyediakan ekstensi VS Code (desainer flow) untuk pengalaman pengembangan flow interaktif dengan UI.

<img src="https://raw.githubusercontent.com/microsoft/promptflow/main/docs/media/readme/vsc.png" alt="vsc" width="1000"/>

Anda dapat menginstalnya dari <a href="https://marketplace.visualstudio.com/items?itemName=prompt-flow.prompt-flow">visualstudio marketplace</a>.

#### Mendalami pengembangan flow

[Memulai dengan prompt flow](https://raw.githubusercontent.com/microsoft/promptflow/main/docs/how-to-guides/quick-start.md): Panduan langkah demi langkah untuk menjalankan flow pertama Anda.

### Belajar dari use case

[Tutorial: Chat dengan PDF](https://github.com/microsoft/promptflow/blob/main/examples/tutorials/e2e-development/chat-with-pdf.md): Tutorial end-to-end tentang cara membangun aplikasi chat berkualitas tinggi dengan prompt flow, termasuk pengembangan flow dan evaluasi dengan metrik.
> Contoh lainnya dapat ditemukan [di sini](https://microsoft.github.io/promptflow/tutorials/index.html#samples). Kami menyambut kontribusi use case baru!

### Setup untuk kontributor

Jika Anda tertarik untuk berkontribusi, silakan mulai dengan panduan setup pengembang kami: [dev_setup.md](https://raw.githubusercontent.com/microsoft/promptflow/main/docs/dev/dev_setup.md).

Langkah Selanjutnya! Lanjutkan ke bagian **Contributing**  👇 untuk berkontribusi pada prompt flow.

## Kontribusi

Proyek ini menyambut kontribusi dan saran. Sebagian besar kontribusi mengharuskan Anda menyetujui
Contributor License Agreement (CLA) yang menyatakan bahwa Anda memiliki hak untuk, dan benar-benar,
memberikan kami hak untuk menggunakan kontribusi Anda. Untuk detailnya, kunjungi https://cla.opensource.microsoft.com.

Ketika Anda mengirimkan pull request, bot CLA akan secara otomatis menentukan apakah Anda perlu memberikan
CLA dan menandai PR dengan tepat (misal, status check, komentar). Ikuti saja instruksi yang diberikan bot.
Anda hanya perlu melakukannya sekali di seluruh repo yang menggunakan CLA kami.

Proyek ini telah mengadopsi [Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/).
Untuk informasi lebih lanjut lihat [Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/) atau
hubungi [opencode@microsoft.com](mailto:opencode@microsoft.com) untuk pertanyaan atau komentar tambahan.

## Merek Dagang

Proyek ini mungkin mengandung merek dagang atau logo untuk proyek, produk, atau layanan. Penggunaan resmi atas merek dagang atau logo Microsoft tunduk pada dan harus mengikuti
[Microsoft's Trademark & Brand Guidelines](https://www.microsoft.com/en-us/legal/intellectualproperty/trademarks/usage/general).
Penggunaan merek dagang atau logo Microsoft dalam versi modifikasi dari proyek ini tidak boleh menimbulkan kebingungan atau mengesankan sponsor dari Microsoft.
Penggunaan merek dagang atau logo pihak ketiga tunduk pada kebijakan pihak ketiga tersebut.

## Kode Etik

Proyek ini telah mengadopsi
[Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/).
Untuk informasi lebih lanjut lihat
[Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/)
atau hubungi [opencode@microsoft.com](mailto:opencode@microsoft.com)
untuk pertanyaan atau komentar tambahan.

## Pengumpulan Data

Perangkat lunak ini dapat mengumpulkan informasi tentang Anda dan penggunaan perangkat lunak dan
mengirimkannya ke Microsoft jika dikonfigurasi untuk mengaktifkan telemetri.
Microsoft dapat menggunakan informasi ini untuk menyediakan layanan dan meningkatkan produk serta layanan kami.
Anda dapat mengaktifkan telemetri seperti dijelaskan di repositori.
Ada juga beberapa fitur dalam perangkat lunak yang dapat memungkinkan Anda dan Microsoft
mengumpulkan data dari pengguna aplikasi Anda. Jika Anda menggunakan fitur ini, Anda
harus mematuhi hukum yang berlaku, termasuk memberikan pemberitahuan yang sesuai kepada
pengguna aplikasi Anda bersama dengan salinan pernyataan privasi Microsoft.
Pernyataan privasi kami terletak di
https://go.microsoft.com/fwlink/?LinkID=824704. Anda dapat mempelajari lebih lanjut tentang pengumpulan
dan penggunaan data dalam dokumentasi bantuan dan pernyataan privasi kami. Penggunaan Anda atas perangkat lunak
berarti Anda menyetujui praktik-praktik ini.

### Konfigurasi Telemetri

Pengumpulan telemetri diaktifkan secara default.

Untuk menonaktifkan, silakan jalankan `pf config set telemetry.enabled=false` untuk mematikannya.

## Lisensi

Hak Cipta (c) Microsoft Corporation. Hak cipta dilindungi undang-undang.

Dilicensekan di bawah lisensi [MIT](LICENSE).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---