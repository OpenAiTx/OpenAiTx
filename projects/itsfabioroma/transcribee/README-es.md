# transcribee 🐝

**Transcriptor de código abierto para macOS para YouTube, Instagram Reels, TikTok y medios locales — evoluciona una base de conocimiento autoorganizada.**

```bash
transcribee "https://youtube.com/watch?v=..."
transcribee "https://instagram.com/reel/..."
transcribee "https://vt.tiktok.com/..."
transcribee ~/Downloads/podcast.mp3
```
Con el tiempo, tu carpeta `~/Documents/transcripts/` evoluciona naturalmente en una biblioteca personal:


```
transcripts/
├── AI-Research/
│   ├── ilya-sutskever-agi-2024/
│   └── anthropic-constitutional-ai/
├── Startups/
│   ├── ycombinator-how-to-get-users/
│   └── pmarca-founder-mode/
└── Health/
    └── huberman-sleep-optimization/
```

Cada transcripción está etiquetada por hablante y lista para pegarse en ChatGPT, Claude o cualquier LLM.

## Por qué 🍯

Consumo mucho contenido en video — YouTube, Instagram, TikTok, podcasts, entrevistas. Quería:
- Hacer preguntas sobre videos en LLMs
- Tener todo ese conocimiento buscable y organizado
- No hacer ningún trabajo manual para mantenerlo

transcribee hace exactamente eso. Transcribe una vez, el conocimiento permanece para siempre.

## Funcionalidades 🪻

- **Transcribe** YouTube, Instagram Reels, TikTok y archivos locales de audio/video
- **Diarios de hablantes** — identifica diferentes oradores
- **Auto-categoriza** transcripciones usando Claude basado en el contenido
- **Construye una biblioteca de conocimiento** que se organiza sola con el tiempo

## Usar con OpenClaw 🤖

transcribee está disponible como una habilidad de [OpenClaw](https://github.com/openclaw/openclaw). Solo pide a tu agente que transcriba cualquier video de YouTube:

> "Transcribe este video: https://youtube.com/watch?v=..."

### Instalar la habilidad

```bash
# Install from ClawHub (recommended)
openclaw skills install transcribee

# Or clone manually
git clone https://github.com/itsfabioroma/transcribee.git ~/.openclaw/workspace/skills/transcribee
```

Asegúrate de tener las dependencias instaladas (`brew install yt-dlp ffmpeg`) y las claves API configuradas.

## Inicio Rápido 🪺

```bash
# Install dependencies (macOS)
brew install yt-dlp ffmpeg
pnpm install

# Configure API keys
cp .env.example .env
# Add your ElevenLabs + Anthropic API keys to .env

# Transcribe anything
transcribee "https://youtube.com/watch?v=..."
transcribee "https://instagram.com/reel/..."
transcribee "https://vt.tiktok.com/..."
transcribee ~/Downloads/podcast.mp3
transcribee ~/Videos/interview.mp4
```

### Alias de shell (recomendado)

Agregar a `~/.zshrc`:

```bash
alias transcribee="noglob /path/to/transcribee/transcribe.sh"
```

## Salida 🍯

Cada transcripción se guarda en `~/Documents/transcripts/{category}/{title}/`:

| Archivo | Para qué sirve |
|------|---------------|
| `transcript.txt` | Transcripción con etiquetas de orador — **pégalo en tu LLM** |
| `metadata.json` | Información del video, idioma, tema detectado automáticamente |

### JSON sin procesar (opcional)

Para usuarios avanzados que necesitan marcas de tiempo y puntuaciones de confianza a nivel de palabra:

```bash
transcribee --raw "https://youtube.com/watch?v=..."
```

Esto añade `transcript-raw.json` con la respuesta completa de ElevenLabs.

## Cómo funciona 🐝

1. Descarga audio de YouTube (yt-dlp) o extrae de vídeo local (ffmpeg)
2. Transcribe con ElevenLabs (`scribe_v1_experimental` con diarización de hablantes)
3. Claude analiza contenido y estructura de la biblioteca existente
4. Auto-categoriza en la carpeta correcta
5. Guarda archivos de transcripción con metadatos

## Requisitos

- macOS (probado en Sonoma)
- Node.js 18+
- [yt-dlp](https://github.com/yt-dlp/yt-dlp) — `brew install yt-dlp`
- [ffmpeg](https://ffmpeg.org/) — `brew install ffmpeg`
- [Clave API de ElevenLabs](https://elevenlabs.io/) — para transcripción
- [Clave API de Anthropic](https://anthropic.com/) — para auto-categorización

## Formatos soportados

| Tipo | Formatos |
|------|---------|
| Audio | mp3, m4a, wav, ogg, flac |
| Vídeo | mp4, mkv, webm, mov, avi |
| URLs | youtube.com, youtu.be, instagram.com/reel, tiktok.com |

---

*bzz bzz* 🐝


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-31

---