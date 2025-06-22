<div align="center">
  <img src="https://raw.githubusercontent.com/ai-shifu/ChatALL/main/src/assets/logo-cover.png" width=256></img>
  <p><strong>Chat dengan SEMUA Bot AI Secara Bersamaan, Temukan yang Terbaik</strong></p>

[Deutsch](README_DE-DE.md) | English | [Español](README_ES-ES.md) | [Français](README_FR-FR.md) | [Italian](README_IT-IT.md) | [日本語](README_JA-JP.md) | [한국어](README_KO-KR.md) | [Русский](README_RU-RU.md) | [Tiếng Việt](README_VI-VN.md) | [简体中文](README_ZH-CN.md)

[![Open in GitHub Codespaces](https://github.com/codespaces/badge.svg)](https://codespaces.new/ai-shifu/ChatALL)

</div>

## Tangkapan Layar

![Screenshot](https://raw.githubusercontent.com/ai-shifu/ChatALL/main/screenshots/screenshot-1.png?raw=true)

## Fitur

Bot AI berbasis Large Language Models (LLMs) sangat luar biasa. Namun, perilaku mereka bisa acak dan setiap bot unggul pada tugas yang berbeda. Jika Anda ingin pengalaman terbaik, jangan coba satu per satu. ChatALL (nama Cina: 齐叨) dapat mengirim prompt ke beberapa bot AI secara bersamaan, membantu Anda menemukan hasil terbaik. Yang perlu Anda lakukan hanyalah [unduh, instal](https://github.com/ai-shifu/ChatALL/releases) dan bertanya.

### Apakah ini Anda?

Pengguna ChatALL yang tipikal adalah:

- 🤠**Guru LLM**, yang ingin menemukan jawaban atau kreasi terbaik dari LLM.
- 🤓**Peneliti LLM**, yang ingin membandingkan secara intuitif kekuatan dan kelemahan berbagai LLM di bidang yang berbeda.
- 😎**Pengembang aplikasi LLM**, yang ingin dengan cepat debug prompt dan menemukan model dasar dengan performa terbaik.

### Bot yang Didukung

| Bot AI                                                                         | Akses Web   | API         | Catatan                                        |
| ------------------------------------------------------------------------------ | ----------- | ----------- | ---------------------------------------------- |
| [360 AI Brain](https://ai.360.cn/)                                             | Ya          | Tidak Ada   |                                                |
| [Baidu ERNIE](https://yiyan.baidu.com/)                                        | Tidak       | Ya          |                                                |
| [Character.AI](https://character.ai/)                                          | Ya          | Tidak Ada   |                                                |
| [ChatGLM2 6B & 130B](https://chatglm.cn/)                                      | Ya          | Tidak Ada   | Tidak perlu login                              |
| [ChatGPT](https://chatgpt.com)                                                 | Ya          | Ya          | Web Browsing, Azure OpenAI service termasuk    |
| [Claude](https://www.anthropic.com/claude)                                     | Ya          | Ya          |                                                |
| [Code Llama](https://ai.meta.com/blog/code-llama-large-language-model-coding/) | Ya          | Tidak Ada   |                                                |
| [Cohere Aya 23](https://cohere.com/blog/aya23)                                 | Tidak       | Ya          |                                                |
| [Cohere Command R Models](https://cohere.com/command)                          | Tidak       | Ya          |                                                |
| [Copilot](https://copilot.microsoft.com/)                                      | Ya          | Tidak Ada   |                                                |
| [Dedao Learning Assistant](https://ai.dedao.cn/)                               | Segera      | Tidak Ada   |                                                |
| [Falcon 180B](https://huggingface.co/tiiuae/falcon-180B-chat)                  | Ya          | Tidak Ada   |                                                |
| [Gemini](https://gemini.google.com/)                                           | Ya          | Ya          |                                                |
| [Gemma 2B & 7B](https://blog.google/technology/developers/gemma-open-models/)  | Ya          | Tidak Ada   |                                                |
| [Gradio](https://gradio.app/)                                                  | Ya          | Tidak Ada   | Untuk model Hugging Face space/self-deployed   |
| [Groq Cloud](https://console.groq.com/docs/models)                             | Tidak       | Ya          |                                                |
| [HuggingChat](https://huggingface.co/chat/)                                    | Ya          | Tidak Ada   |                                                |
| [iFLYTEK SPARK](http://xinghuo.xfyun.cn/)                                      | Ya          | Segera      |                                                |
| [Kimi](https://kimi.moonshot.cn/               )                               | Ya          | Tidak Ada   |                                                |
| [Llama 2 13B & 70B](https://ai.meta.com/llama/)                                | Ya          | Tidak Ada   |                                                |
| [MOSS](https://moss.fastnlp.top/)                                              | Ya          | Tidak Ada   |                                                |
| [Perplexity](https://www.perplexity.ai/)                                       | Ya          | Tidak Ada   |                                                |
| [Phind](https://www.phind.com/)                                                | Ya          | Tidak Ada   |                                                |
| [Pi](https://pi.ai)                                                            | Ya          | Tidak Ada   |                                                |
| [Poe](https://poe.com/)                                                        | Ya          | Segera      |                                                |
| [SkyWork](https://neice.tiangong.cn/)                                          | Ya          | Segera      |                                                |
| [Tongyi Qianwen](http://tongyi.aliyun.com/)                                    | Ya          | Segera      |                                                |
| [Vicuna 13B & 33B](https://lmsys.org/blog/2023-03-30-vicuna/)                  | Ya          | Tidak Ada   | Tidak perlu login                              |
| [WizardLM 70B](https://github.com/nlpxucan/WizardLM)                           | Ya          | Tidak Ada   |                                                |
| [xAI Grok](https://x.ai)                                                       | Tidak       | Ya          |                                                |
| [YouChat](https://you.com/)                                                    | Ya          | Tidak Ada   |                                                |
| [You](https://you.com/)                                                        | Ya          | Tidak Ada   |                                                |
| [Zephyr](https://huggingface.co/spaces/HuggingFaceH4/zephyr-chat)              | Ya          | Tidak Ada   |                                                |

Akan terus bertambah. Upvote bot favorit Anda di [isu-isu ini](https://github.com/ai-shifu/ChatALL/labels/more%20LLMs).

### Catatan tentang Keandalan Bot Terkoneksi Web

Bot AI terkoneksi web (yang bertanda "Akses Web") secara inheren kurang dapat diandalkan dan sering mengalami masalah stabilitas, karena penyedia layanan secara berkala memperbarui antarmuka web dan langkah keamanan mereka. Koneksi berbasis web ini mengandalkan rekayasa balik dan sulit dipelihara, serta sering kali rusak secara tak terduga. Untuk pengalaman yang lebih andal, kami sangat menyarankan menggunakan bot yang menyediakan akses API jika memungkinkan.

### Fitur Lain

- Mode quick-prompt: kirim prompt berikutnya tanpa menunggu permintaan sebelumnya selesai
- Simpan riwayat chat secara lokal, lindungi privasi Anda
- Sorot respons yang Anda suka, hapus yang buruk
- Aktif/nonaktifkan bot kapan saja
- Beralih antara tampilan satu, dua, atau tiga kolom
- Pembaruan otomatis ke versi terbaru
- Mode gelap (kontribusi oleh @tanchekwei)
- Tombol pintas. Tekan <kbd>Ctrl</kbd> + <kbd>/</kbd> untuk melihat semuanya (kontribusi oleh @tanchekwei)
- Banyak percakapan (kontribusi oleh @tanchekwei)
- Pengaturan proxy (kontribusi oleh @msaong)
- Manajemen prompt (kontribusi oleh @tanchekwei)
- Mendukung banyak bahasa (Cina, Inggris, Jerman, Prancis, Rusia, Vietnam, Korea, Jepang, Spanyol, Italia)
- Mendukung Windows, macOS, dan Linux

Fitur yang direncanakan:

Silakan berkontribusi pada fitur-fitur ini.

- [ ] Deploy front-end ke GitHub Pages

## Privasi

Seluruh riwayat chat, pengaturan, dan data login disimpan secara lokal di komputer Anda.

ChatALL mengumpulkan data penggunaan anonim untuk membantu kami meningkatkan produk. Termasuk:

- Bot AI mana yang digunakan dan berapa panjang prompt-nya. Tidak termasuk isi prompt.
- Seberapa panjang respons, dan respons mana yang dihapus/disorot. Tidak termasuk isi respons.

## Prasyarat

ChatALL adalah klien, bukan proxy. Oleh karena itu, Anda harus:

1. Memiliki akun aktif dan/atau token API untuk bot.
2. Memiliki koneksi jaringan yang andal ke bot.

## Unduh / Instal

Unduh dari https://github.com/ai-shifu/ChatALL/releases

### Di Windows

Cukup unduh file \*-win.exe dan lanjutkan proses instalasi.

### Di macOS

Untuk Mac Apple Silicon (CPU M1, M2), unduh file \*-mac-arm64.dmg.

Untuk Mac lainnya, unduh file \*-mac-x64.dmg.

Jika Anda menggunakan [Homebrew](https://brew.sh/), Anda juga dapat menginstalnya dengan:

```bash
brew install --cask chatall
```

### Di Linux

Distribusi berbasis Debian: Unduh file .deb, klik dua kali, dan instal perangkat lunak.
Distribusi berbasis Arch: Anda dapat meng-clone ChatALL dari AUR [di sini](https://aur.archlinux.org/packages/chatall-bin). Anda bisa menginstalnya secara manual atau menggunakan AUR helper seperti yay atau paru.
Distribusi lain: Unduh file .AppImage, jadikan executable, dan nikmati pengalaman klik-untuk-jalankan. Anda juga dapat menggunakan [AppimageLauncher](https://github.com/TheAssassin/AppImageLauncher).

## Pemecahan Masalah

Jika Anda mengalami masalah saat menggunakan ChatALL, Anda dapat mencoba metode berikut untuk mengatasinya:

1. **Refresh** - tekan <kbd>Ctrl</kbd> + <kbd>R</kbd> atau <kbd>⌘</kbd> + <kbd>R</kbd>.
2. **Restart** - keluar dari ChatALL dan jalankan kembali.
3. **Login ulang** - klik tombol pengaturan di pojok kanan atas, lalu klik tautan login/logout yang sesuai untuk login ulang ke situs web.
4. **Buat chat baru** - klik tombol `New Chat` dan kirim prompt lagi.

Jika semua cara di atas tidak berhasil, Anda dapat mencoba **reset ChatALL**. Perlu diketahui bahwa ini akan menghapus semua pengaturan dan riwayat pesan Anda.

Anda dapat me-reset ChatALL dengan menghapus direktori berikut:

- Windows: `C:\Users\<user>\AppData\Roaming\chatall\`
- Linux: `/home/<user>/.config/chatall/`
- macOS: `/Users/<user>/Library/Application Support/chatall/`

Jika masalah berlanjut, silakan [ajukan isu](https://github.com/ai-shifu/ChatALL/issues).

## Untuk Pengembang

### Kontribusi Bot

[Panduan ini](https://github.com/ai-shifu/ChatALL/wiki/%E5%A6%82%E4%BD%95%E6%B7%BB%E5%8A%A0%E4%B8%80%E4%B8%AA%E6%96%B0%E7%9A%84-AI-%E5%AF%B9%E8%AF%9D%E6%9C%BA%E5%99%A8%E4%BA%BA) dapat membantu Anda.

### Menjalankan

```bash
npm install
npm run electron:serve
```

### Build

Build untuk platform Anda saat ini:

```bash
npm run electron:build
```

Build untuk semua platform:

```bash
npm run electron:build -- -wml --x64 --arm64
```

## Kredit

### Kontributor

<a href="https://github.com/ai-shifu/ChatALL/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=ai-shifu/ChatALL" />
</a>

### Lainnya

- GPT-4 berkontribusi pada sebagian besar kode
- ChatGPT, Copilot, dan Google menyediakan banyak solusi (berdasarkan urutan)
- Terinspirasi dari [ChatHub](https://github.com/chathub-dev/chathub). Hormat kami!

## Sponsor

Jika Anda menyukai proyek ini, pertimbangkan untuk:

[![ko-fi](https://ko-fi.com/img/githubbutton_sm.svg)](https://ko-fi.com/F1F8KZJGJ)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-22

---