<div align="right">
  <details>
    <summary >🌐 Dil</summary>
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

Claude Kodunu bash betiği olarak yeniden yazıldı. ~1.500 satır. Sıfır npm paketi.

## Neden

Orijinal Claude Kodu ~380.000 satır TypeScript ve 266 npm bağımlılığına sahip. Bu ise aynı temel işi sadece `curl` ve `jq` ile bash üzerinde yapıyor.


## Özellikler

- **Gerçek zamanlı akış** FIFO borusu üzerinden — metin Claude tarafından üretildikçe görüntülenir
- **6 araç**: Bash, Oku, Düzenle, Yaz, Glob, Grep
- **Araç zincirleme** — tur başına en fazla 25 araç çağrısı
- **İzin isteme** — güvenli olmayan komutlar çalıştırılmadan önce sorar (`e/h/t`)
- **CLAUDE.md yükleme** — dizin ağacında CLAUDE.md dosyalarından proje talimatlarını okur
- **Git farkındalığı** — dal, durum ve son commit'ler sistem isteminde
- **Oturum kaydet/devam et** — çıkışta otomatik kaydeder, `--resume <id>` ile devam eder
- **Geri alma ile tekrar deneme** — 429/529 oran limitlerinde üssel tekrar deneme
- **Maliyet takibi** — her tur ve oturum toplamı
- **Döndürücü** — orijinal döndürücü fiilleriyle (Clauding, Flibbertigibbeting, vb.)
- **Slash komutları** — `/help`, `/cost`, `/model`, `/clear`, `/save`, `/resume`, `/commit`, `/diff`
- **Boru modu** — `echo "bunu açıkla" | ./claude.sh`

## Kurulum

```bash
git clone https://github.com/jdcodes1/claude.sh.git
cd claude.sh
chmod +x claude.sh
```

## Bağımlılıklar

- `curl`
- `jq`
- Opsiyonel: Daha iyi arama için `rg` (ripgrep)
- Opsiyonel: Düzenleme aracı için `python3`

Çalışma zamanı sürümleri `.tool-versions` içinde sabitlenmiştir. Bunları [mise](https://mise.jdx.dev/) ile kurun:

```bash
mise install
```

## Kullanım

```bash
export ANTHROPIC_API_KEY="sk-ant-..."
./claude.sh
```

### Ortam Değişkenleri

| Değişken | Varsayılan | Açıklama |
| --- | --- | --- |
| `ANTHROPIC_API_KEY` | (gerekli) | Anthropic API anahtarınız |
| `CLAUDE_MODEL` | `claude-sonnet-4-6` | Kullanılacak model |
| `CLAUDE_MAX_TOKENS` | `8192` | Maksimum çıktı token sayısı |
| `ANTHROPIC_API_URL` | `https://api.anthropic.com` | API temel URL'si |
| `CLAUDE_SH_PERMISSIONS` | `ask` | İzin modu: `ask`, `allow` veya `deny` |

### Komutlar

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

### Bir Oturumu Devam Ettir

```bash
# List saved sessions
./claude.sh
> /resume

# Resume by number
> /resume 1

# Resume from CLI
./claude.sh --resume 20240101-120000-12345
```

## Mimari

```txt
claude.sh          # Main REPL loop, slash commands, process_turn()
lib/
  api.sh           # Anthropic API client, SSE streaming via FIFO, retry
  json.sh          # Message construction, session persistence, CLAUDE.md, git context
  tools.sh         # 6 tool implementations + permission system
  tui.sh           # ANSI colors, spinner, display helpers
```

## Nasıl Çalışır

1. Kullanıcı girdisini oku
2. JSON isteğini `jq` ile oluştur (mesajlar, araçlar, sistem istemi)
3. Yanıtı bir FIFO borusu üzerinden `curl` ile akışla
4. SSE olaylarını satır satır ayrıştır, metin değişimlerini gerçek zamanlı yazdır
5. tool_use blokları geldiğinde, araçları çalıştır
6. Araç sonuçlarını mesaj olarak geri gönder
7. Claude araç çağırmayı bırakana kadar döngüye devam et

## Karşılaştırma

| | claude.sh | Claude Kod (TypeScript) |
| --- | --- | --- |
| Kod satırı | ~1.500 | ~380.000 |
| Bağımlılıklar | curl, jq | 266 npm paketi |
| İkili boyutu | 0 (betik) | ~200MB node_modules |
| Başlangıç süresi | Anında | ~500ms |

### Test

Testler [bats](https://github.com/bats-core/bats-core) (Bash Otomatik Test Sistemi) kullanır:

```bash
bats test/
```

## License

[MIT](LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-14

---