
<div align="right">
  <details>
    <summary >🌐 Bahasa</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# claude.sh

Claude Code ditulis ulang sebagai skrip bash. ~1.500 baris. Tanpa paket npm.

## Mengapa

Claude Code asli sekitar ~380.000 baris TypeScript dengan 266 dependensi npm. Ini melakukan pekerjaan inti yang sama dalam bash hanya dengan `curl` dan `jq`.

## Fitur

- **Streaming real-time** melalui pipa FIFO — teks muncul saat Claude menghasilkannya
- **6 alat**: Bash, Read, Edit, Write, Glob, Grep
- **Rangkaian alat** — hingga 25 panggilan alat per giliran
- **Permintaan izin** — meminta sebelum menjalankan perintah yang tidak aman (`y/n/a`)
- **Pemuat CLAUDE.md** — membaca instruksi proyek dari file CLAUDE.md di pohon direktori
- **Konteks Git-aware** — cabang, status, dan commit terbaru di prompt sistem
- **Simpan/Lanjutkan sesi** — otomatis simpan saat keluar, lanjutkan dengan `--resume <id>`
- **Coba ulang dengan backoff** — retry eksponensial pada batas rate 429/529
- **Pelacakan biaya** — total per giliran dan sesi
- **Spinner** — dengan kata kerja spinner asli (Clauding, Flibbertigibbeting, dll.)
- **Perintah Slash** — `/help`, `/cost`, `/model`, `/clear`, `/save`, `/resume`, `/commit`, `/diff`
- **Mode Pipe** — `echo "jelaskan ini" | ./claude.sh`

## Instal

```bash
git clone https://github.com/jdcodes1/claude.sh.git
cd claude.sh
chmod +x claude.sh
```

## Ketergantungan

- `curl`
- `jq`
- Opsional: `rg` (ripgrep) untuk pencarian yang lebih baik
- Opsional: `python3` untuk alat edit

Versi runtime dikunci di `.tool-versions`. Instal dengan [mise](https://mise.jdx.dev/):

```bash
mise install
```

## Penggunaan

```bash
export ANTHROPIC_API_KEY="sk-ant-..."
./claude.sh
```

### Variabel Lingkungan

| Variabel | Default | Deskripsi |
| --- | --- | --- |
| `ANTHROPIC_API_KEY` | (wajib) | Kunci API Anthropic Anda |
| `CLAUDE_MODEL` | `claude-sonnet-4-6` | Model yang digunakan |
| `CLAUDE_MAX_TOKENS` | `8192` | Maksimum token keluaran |
| `ANTHROPIC_API_URL` | `https://api.anthropic.com` | URL dasar API |
| `CLAUDE_SH_PERMISSIONS` | `ask` | Mode perizinan: `ask`, `allow`, atau `deny` |

### Perintah

```txt
/help      — Show help
/cost      — Show session cost
/model     — Show/change model
/clear     — Clear conversation
/save      — Save current session
/resume    — List/resume saved sessions
/commit    — Auto-generate a git commit
/diff      — Show git diff
/quit      — Exit
```

### Melanjutkan Sesi

```bash
# List saved sessions
./claude.sh
> /resume

# Resume by number
> /resume 1

# Resume from CLI
./claude.sh --resume 20240101-120000-12345
```

## Arsitektur

```txt
claude.sh          # Main REPL loop, slash commands, process_turn()
lib/
  api.sh           # Anthropic API client, SSE streaming via FIFO, retry
  json.sh          # Message construction, session persistence, CLAUDE.md, git context
  tools.sh         # 6 tool implementations + permission system
  tui.sh           # ANSI colors, spinner, display helpers
```

## Cara Kerjanya

1. Membaca input pengguna
2. Membangun permintaan JSON dengan `jq` (pesan, alat, prompt sistem)
3. Meneruskan respons melalui `curl` lewat pipa FIFO
4. Mengurai event SSE baris per baris, mencetak delta teks secara real-time
5. Ketika blok tool_use datang, jalankan alat-alatnya
6. Masukkan hasil alat kembali sebagai pesan
7. Ulangi hingga Claude berhenti memanggil alat

## Perbandingan

| | claude.sh | Claude Code (TypeScript) |
| --- | --- | --- |
| Baris kode | ~1.500 | ~380.000 |
| Ketergantungan | curl, jq | 266 paket npm |
| Ukuran biner | 0 (script) | ~200MB node_modules |
| Waktu mulai | Instan | ~500ms |

### Pengujian

Pengujian menggunakan [bats](https://github.com/bats-core/bats-core) (Bash Automated Testing System):

```bash
bats test/
```

## License

[MIT](LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-14

---