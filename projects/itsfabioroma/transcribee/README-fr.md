# transcribee 🐝

**Transcripteur macOS open source pour YouTube, Instagram Reels, TikTok et les médias locaux — fait évoluer une base de connaissances auto-organisée.**

```bash
transcribee "https://youtube.com/watch?v=..."
transcribee "https://instagram.com/reel/..."
transcribee "https://vt.tiktok.com/..."
transcribee ~/Downloads/podcast.mp3
```

Avec le temps, votre dossier `~/Documents/transcripts/` évolue naturellement en une bibliothèque personnelle :

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
Chaque transcription est étiquetée par locuteur et prête à être collée dans ChatGPT, Claude ou tout autre LLM.

## Pourquoi 🍯

Je consomme beaucoup de contenu vidéo — YouTube, Instagram, TikTok, podcasts, interviews. Je voulais :
- Poser des questions sur les vidéos dans les LLM
- Avoir toutes ces connaissances consultables et organisées
- Ne faire aucun travail manuel pour les maintenir

transcribee fait exactement cela. Transcrivez une fois, la connaissance reste pour toujours.

## Fonctionnalités 🪻

- **Transcrit** YouTube, Instagram Reels, TikTok, et fichiers audio/vidéo locaux
- **Diarisation des locuteurs** — identifie les différents intervenants
- **Auto-catégorise** les transcriptions avec Claude selon le contenu
- **Construit une bibliothèque de connaissances** qui s’organise avec le temps

## Utiliser avec OpenClaw 🤖

transcribee est disponible comme compétence [OpenClaw](https://github.com/openclaw/openclaw). Demandez simplement à votre agent de transcrire n’importe quelle vidéo YouTube :

> « Transcris cette vidéo : https://youtube.com/watch?v=... »

### Installer la compétence


```bash
# Install from ClawHub (recommended)
openclaw skills install transcribee

# Or clone manually
git clone https://github.com/itsfabioroma/transcribee.git ~/.openclaw/workspace/skills/transcribee
```

Assurez-vous d'avoir les dépendances installées (`brew install yt-dlp ffmpeg`) et les clés API configurées.

## Démarrage rapide 🪺

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

### Alias shell (recommandé)

Ajouter à `~/.zshrc` :

```bash
alias transcribee="noglob /path/to/transcribee/transcribe.sh"
```

## Sortie 🍯

Chaque transcription est enregistrée dans `~/Documents/transcripts/{category}/{title}/` :

| Fichier | À quoi ça sert |
|---------|----------------|
| `transcript.txt` | Transcription avec étiquettes des intervenants — **collez ceci dans votre LLM** |
| `metadata.json` | Infos vidéo, langue, thème détecté automatiquement |

### JSON brut (optionnel)

Pour les utilisateurs avancés qui ont besoin des horodatages et scores de confiance au niveau des mots :

```bash
transcribee --raw "https://youtube.com/watch?v=..."
```

Cela ajoute `transcript-raw.json` avec la réponse complète d’ElevenLabs.

## Comment ça fonctionne 🐝

1. Télécharge l’audio depuis YouTube (yt-dlp) ou extrait d’une vidéo locale (ffmpeg)
2. Transcrit avec ElevenLabs (`scribe_v1_experimental` avec diarisation des locuteurs)
3. Claude analyse le contenu et la structure existante de la bibliothèque
4. Auto-catégorise dans le bon dossier
5. Sauvegarde les fichiers de transcription avec les métadonnées

## Exigences

- macOS (testé sur Sonoma)
- Node.js 18+
- [yt-dlp](https://github.com/yt-dlp/yt-dlp) — `brew install yt-dlp`
- [ffmpeg](https://ffmpeg.org/) — `brew install ffmpeg`
- [Clé API ElevenLabs](https://elevenlabs.io/) — pour la transcription
- [Clé API Anthropic](https://anthropic.com/) — pour l’auto-catégorisation

## Formats pris en charge

| Type | Formats |
|------|---------|
| Audio | mp3, m4a, wav, ogg, flac |
| Vidéo | mp4, mkv, webm, mov, avi |
| URLs | youtube.com, youtu.be, instagram.com/reel, tiktok.com |

---

*bzz bzz* 🐝


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-31

---