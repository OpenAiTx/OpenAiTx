
# mcp-chat

<div align="right">
  <details>
    <summary >🌐 Bahasa</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=as">অসমীয়া</
      </div>
    </div>
  </details>

</div>

Klien MCP Generik Sumber Terbuka untuk pengujian & evaluasi server dan agen mcp

<p align="center">
  <img width="600" src="https://raw.githubusercontent.com/Flux159/mcp-chat/refs/heads/main/mcpchat.svg">
</p>

## Mulai Cepat

Pastikan bahwa Anda telah mengekspor `ANTHROPIC_API_KEY` di lingkungan Anda atau di file .env pada root proyek. Anda dapat memperoleh API key dengan mendaftar di [halaman kunci Anthropic Console](https://console.anthropic.com/settings/keys).

Contoh penggunaan sederhana yang memunculkan prompt chat interaktif dengan server MCP filesystem dari CLI:

```shell
npx mcp-chat --server "npx -y @modelcontextprotocol/server-filesystem /Users/$USER/Desktop"
```

Ini akan membuka prompt obrolan yang dapat Anda gunakan untuk berinteraksi dengan server dan mengobrol dengan LLM.

## Konfigurasi

Anda juga dapat langsung menentukan claude_desktop_config.json Anda (Mac):

```shell
npx mcp-chat --config "~/Library/Application Support/Claude/claude_desktop_config.json"
```

Atau (Windows):

```shell
npx mcp-chat --config "%APPDATA%\Claude\claude_desktop_config.json"
```

## Web mode

https://github.com/user-attachments/assets/b7e8a648-8084-4955-8cdf-fc6eb141572e

You can also run mcp-chat in web mode by specifying the `--web` flag (make sure to have `ANTHROPIC_API_KEY` exported in your environment):

```shell
npx mcp-chat --web
```

Dalam mode web, Anda dapat memulai obrolan baru, mengirim pesan ke model, dan mengonfigurasi server mcp secara dinamis melalui UI - tidak perlu menentukan melalui command line. Selain itu, obrolan yang dibuat melalui Web UI akan disimpan di ~/.mcpchats/chats sama seperti obrolan yang dibuat melalui CLI.

## Fitur

- [x] Jalankan melalui CLI dalam mode interaktif atau langsung kirim prompt dengan `-p`
- [x] Mode web untuk mengobrol dengan model melalui antarmuka web `--web`
- [x] Terhubung ke server MCP apa pun (JS, Python, Docker) di produksi atau selama pengembangan
- [x] Pilih model dengan `-m`
- [x] Kustomisasi prompt sistem dengan `--system`
- [x] Menyimpan riwayat obrolan beserta pengaturan di `~/.mcpchat/chats` termasuk obrolan web
- [x] Simpan dan pulihkan perintah di `~/.mcpchat/history`
- [x] Lihat output dan argumen tool call langsung di obrolan untuk membantu debug server mcp

## Penggunaan CLI

Jalankan prompt melalui CLI dengan flag `-p`:

```shell
npx mcp-chat --server "npx mcp-server-kubernetes" -p "List the pods in the default namespace"
```

Ini menjalankan prompt dengan kubernetes mcp-server & keluar setelah respons diterima di stdout.

Pilih model untuk mengobrol melalui CLI dengan flag `-m`:

```shell
npx mcp-chat --server "npx mcp-server-kubernetes" -m "claude-3.5"
```

Menggunakan model `claude-3.5` untuk melakukan percakapan. Perlu dicatat bahwa saat ini hanya model Anthropic yang didukung.

Prompt sistem khusus:

Flag `--system` dapat digunakan untuk menentukan prompt sistem:

```shell
npx mcp-chat --system "Explain the output to the user in pirate speak." --server "npx mcp-server-kubernetes" -p "List the pods in the default namespace"
```

## Variabel ENV

Mcp-chat mendukung penerusan variabel lingkungan (env vars) ke server mcp. Namun, ini tidak distandarisasi dalam spesifikasi mcp dan klien lain mungkin tidak melakukan ini dengan nilai variabel lingkungan yang dinamis - baca lebih lanjut [di sini](https://github.com/Flux159/mcp-server-kubernetes/issues/148#issuecomment-2950181666) tentang klien mcp stdio standar.

```shell
KUBECONFIG="~/.kube/config" npx mcp-chat --server "npx mcp-server-kubernetes"
```

## Untuk pengembang mcp-servers

Anda dapat memasukkan build lokal dari python atau node mcp-server untuk mengujinya dengan mcp-chat:

Node JS:

```shell
# Directly executing built script
npx mcp-chat --server "/path/to/mcp-server-kubernetes/dist/index.js"
# Using node / bun
npx mcp-chat --server "node /path/to/mcp-server-kubernetes/dist/index.js"
```

Python:

```shell
# Python: Using uv
npx mcp-chat --server "uv --directory /path/to/mcp-server-weather/ run weather.py"
# Using python / python3 - make sure to run in venv or install deps globally
npx mcp-chat --server "/path/to/mcp-server-weather/weather.py"
```

## Pengembangan

Instal dependensi & jalankan CLI:

```shell
git clone https://github.com/Flux159/mcp-chat
bun install
bun run dev
```
Untuk mengembangkan mcp-chat sambil terhubung ke mcp-server, buatlah build & jalankan CLI dengan flag server:


```shell
npm run build && node dist/index.js --server "npx mcp-server-kubernetes" -p "List the pods in the default namespace"
```

Pengujian:

```shell
bun run test
```

Bangunan:

```shell
bun run build
```

Penerbitan:

```shell
bun run publish
```

Mempublikasikan Docker:

```shell
bun run dockerbuild
```

### Struktur Proyek

```
├── src/
│   ├── index.ts            # Main client implementation & CLI params
│   ├── constants.ts        # Default constants
│   ├── interactive.ts      # Interactive chat prompt handling & logic
├── test/                   # Test files
│   ├── cli.test.ts         # Test CLI params
│   ├── config.test.ts      # Test config file parsing
```

## Mempublikasikan rilis baru

Buka halaman [rilis](https://github.com/Flux159/mcp-chat/releases), klik "Draft New Release", klik "Choose a tag" dan buat tag baru dengan mengetik nomor versi baru menggunakan format semver "v{major}.{minor}.{patch}". Kemudian, tulis judul rilis "Release v{major}.{minor}.{patch}" dan deskripsi / changelog jika perlu lalu klik "Publish Release".

Ini akan membuat tag baru yang akan memicu pembuatan rilis baru melalui workflow cd.yml. Setelah berhasil, rilis baru akan dipublikasikan ke npm. Perlu dicatat bahwa tidak perlu memperbarui versi package.json secara manual, karena workflow akan otomatis memperbarui nomor versi di file package.json & mendorong commit ke main.

## Lisensi

[Lisensi MIT](https://github.com/Flux159/mcp-chat/blob/main/LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-16

---