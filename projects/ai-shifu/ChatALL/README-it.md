<div align="center">
  <img src="https://raw.githubusercontent.com/ai-shifu/ChatALL/main/src/assets/logo-cover.png" width=256></img>
  <p><strong>Chatta con TUTTI i Bot AI Contemporaneamente, Scopri il Migliore</strong></p>

[Deutsch](README_DE-DE.md) | English | [Español](README_ES-ES.md) | [Français](README_FR-FR.md) | [Italian](README_IT-IT.md) | [日本語](README_JA-JP.md) | [한국어](README_KO-KR.md) | [Русский](README_RU-RU.md) | [Tiếng Việt](README_VI-VN.md) | [简体中文](README_ZH-CN.md)

[![Open in GitHub Codespaces](https://github.com/codespaces/badge.svg)](https://codespaces.new/ai-shifu/ChatALL)

</div>

## Screenshot

![Screenshot](https://raw.githubusercontent.com/ai-shifu/ChatALL/main/screenshots/screenshot-1.png?raw=true)

## Caratteristiche

I bot AI basati su Large Language Models (LLMs) sono straordinari. Tuttavia, il loro comportamento può essere casuale e diversi bot eccellono in compiti differenti. Se vuoi la migliore esperienza, non provarli uno per uno. ChatALL (nome cinese: 齐叨) può inviare prompt a diversi bot AI contemporaneamente e aiutarti a scoprire i risultati migliori. Tutto ciò che devi fare è [scaricare, installare](https://github.com/ai-shifu/ChatALL/releases) e chiedere.

### Ti riconosci?

Gli utenti tipici di ChatALL sono:

- 🤠**Esperti di LLM**, che vogliono trovare le migliori risposte o creazioni dagli LLM.
- 🤓**Ricercatori di LLM**, che vogliono confrontare intuitivamente i punti di forza e di debolezza dei vari LLM in diversi ambiti.
- 😎**Sviluppatori di applicazioni LLM**, che vogliono effettuare rapidamente il debug dei prompt e trovare i modelli base più performanti.

### Bot supportati

| Bot AI                                                                         | Web Access  | API         | Note                                         |
| ------------------------------------------------------------------------------ | ----------- | ----------- | -------------------------------------------- |
| [360 AI Brain](https://ai.360.cn/)                                             | Sì          | No API      |                                              |
| [Baidu ERNIE](https://yiyan.baidu.com/)                                        | No          | Sì          |                                              |
| [Character.AI](https://character.ai/)                                          | Sì          | No API      |                                              |
| [ChatGLM2 6B & 130B](https://chatglm.cn/)                                      | Sì          | No API      | Nessun login richiesto                       |
| [ChatGPT](https://chatgpt.com)                                             | Sì          | Sì          | Navigazione Web, incluso Azure OpenAI service|
| [Claude](https://www.anthropic.com/claude)                                     | Sì          | Sì          |                                              |
| [Code Llama](https://ai.meta.com/blog/code-llama-large-language-model-coding/) | Sì          | No API      |                                              |
| [Cohere Aya 23](https://cohere.com/blog/aya23)                                 | No          | Sì          |                                              |
| [Cohere Command R Models](https://cohere.com/command)                          | No          | Sì          |                                              |
| [Copilot](https://copilot.microsoft.com/)                                      | Sì          | No API      |                                              |
| [Dedao Learning Assistant](https://ai.dedao.cn/)                               | Prossimamente| No API      |                                              |
| [Falcon 180B](https://huggingface.co/tiiuae/falcon-180B-chat)                  | Sì          | No API      |                                              |
| [Gemini](https://gemini.google.com/)                                           | Sì          | Sì          |                                              |
| [Gemma 2B & 7B](https://blog.google/technology/developers/gemma-open-models/)  | Sì          | No API      |                                              |
| [Gradio](https://gradio.app/)                                                  | Sì          | No API      | Per modelli Hugging Face space/self-hosted   |
| [Groq Cloud](https://console.groq.com/docs/models)                             | No          | Sì          |                                              |
| [HuggingChat](https://huggingface.co/chat/)                                    | Sì          | No API      |                                              |
| [iFLYTEK SPARK](http://xinghuo.xfyun.cn/)                                      | Sì          | Prossimamente|                                              |
| [Kimi](https://kimi.moonshot.cn/)                                              | Sì          | No API      |                                              |
| [Llama 2 13B & 70B](https://ai.meta.com/llama/)                                | Sì          | No API      |                                              |
| [MOSS](https://moss.fastnlp.top/)                                              | Sì          | No API      |                                              |
| [Perplexity](https://www.perplexity.ai/)                                       | Sì          | No API      |                                              |
| [Phind](https://www.phind.com/)                                                | Sì          | No API      |                                              |
| [Pi](https://pi.ai)                                                            | Sì          | No API      |                                              |
| [Poe](https://poe.com/)                                                        | Sì          | Prossimamente|                                              |
| [SkyWork](https://neice.tiangong.cn/)                                          | Sì          | Prossimamente|                                              |
| [Tongyi Qianwen](http://tongyi.aliyun.com/)                                    | Sì          | Prossimamente|                                              |
| [Vicuna 13B & 33B](https://lmsys.org/blog/2023-03-30-vicuna/)                  | Sì          | No API      | Nessun login richiesto                       |
| [WizardLM 70B](https://github.com/nlpxucan/WizardLM)                           | Sì          | No API      |                                              |
| [xAI Grok](https://x.ai)                                                       | No          | Sì          |                                              |
| [YouChat](https://you.com/)                                                    | Sì          | No API      |                                              |
| [You](https://you.com/)                                                        | Sì          | No API      |                                              |
| [Zephyr](https://huggingface.co/spaces/HuggingFaceH4/zephyr-chat)              | Sì          | No API      |                                              |

Altri in arrivo. Vota i tuoi bot preferiti in [questi thread](https://github.com/ai-shifu/ChatALL/labels/more%20LLMs).

### Nota sull'affidabilità dei bot connessi al web

I bot AI connessi al web (quelli contrassegnati con "Web Access") sono intrinsecamente meno affidabili e spesso presentano problemi di stabilità, poiché i fornitori di servizi aggiornano regolarmente le loro interfacce web e le misure di sicurezza. Queste connessioni web si basano sull'ingegneria inversa e sono difficili da mantenere, spesso smettendo di funzionare improvvisamente. Per un'esperienza affidabile, consigliamo vivamente di utilizzare bot che offrono accesso tramite API quando possibile.

### Altre funzionalità

- Modalità di prompt rapido: invia il prompt successivo senza attendere il completamento della richiesta precedente
- Salva la cronologia delle chat localmente, proteggi la tua privacy
- Evidenzia la risposta che preferisci, elimina quelle indesiderate
- Abilita/disabilita qualsiasi bot in qualsiasi momento
- Passa da una, due o tre colonne di visualizzazione
- Aggiornamento automatico all'ultima versione
- Modalità scura (contributo di @tanchekwei)
- Tasti rapidi. Premi <kbd>Ctrl</kbd> + <kbd>/</kbd> per conoscerli tutti (contributo di @tanchekwei)
- Chat multiple (contributo di @tanchekwei)
- Impostazione proxy (contributo di @msaong)
- Gestione prompt (contributo di @tanchekwei)
- Supporta più lingue (Cinese, Inglese, Tedesco, Francese, Russo, Vietnamita, Coreano, Giapponese, Spagnolo, Italiano)
- Supporta Windows, macOS e Linux

Funzionalità pianificate:

Se vuoi, puoi contribuire a queste funzionalità.

- [ ] Distribuire il front-end su GitHub Pages

## Privacy

Tutta la cronologia delle chat, le impostazioni e i dati di accesso vengono salvati localmente sul tuo computer.

ChatALL raccoglie dati anonimi di utilizzo per aiutarci a migliorare il prodotto. Include:

- Quali bot AI sono stati utilizzati e quanto è lungo il prompt. Non include il contenuto del prompt.
- Quanto è lunga la risposta e quale risposta viene eliminata/evidenziata. Non include il contenuto della risposta.

## Prerequisiti

ChatALL è un client, non un proxy. Pertanto, devi:

1. Disporre di account funzionanti e/o token API per i bot.
2. Avere connessioni di rete affidabili verso i bot.

## Download / Installazione

Scarica da https://github.com/ai-shifu/ChatALL/releases

### Su Windows

Basta scaricare il file \*-win.exe e procedere con l'installazione.

### Su macOS

Per Mac con Apple Silicon (CPU M1, M2), scarica il file \*-mac-arm64.dmg.

Per altri Mac, scarica il file \*-mac-x64.dmg.

Se utilizzi [Homebrew](https://brew.sh/), puoi anche installarlo con:

```bash
brew install --cask chatall
```

### Su Linux

Distribuzioni basate su Debian: scarica il file .deb, fai doppio clic e installa il software.
Distribuzioni basate su Arch: puoi clonare ChatALL dall'AUR [qui](https://aur.archlinux.org/packages/chatall-bin). Puoi installarlo manualmente oppure usando un AUR helper come yay o paru.
Altre distribuzioni: scarica il file .AppImage, rendilo eseguibile, e goditi l'esperienza click-to-run. Puoi anche usare [AppimageLauncher](https://github.com/TheAssassin/AppImageLauncher).

## Risoluzione problemi

Se incontri problemi durante l'utilizzo di ChatALL, puoi provare i seguenti metodi per risolverli:

1. **Aggiorna** - premi <kbd>Ctrl</kbd> + <kbd>R</kbd> o <kbd>⌘</kbd> + <kbd>R</kbd>.
2. **Riavvia** - esci da ChatALL e avvialo nuovamente.
3. **Esegui nuovamente il login** - clicca sul pulsante delle impostazioni in alto a destra, poi clicca sul link di login/logout corrispondente per accedere nuovamente al sito.
4. **Crea una nuova chat** - clicca sul pulsante `Nuova Chat` e invia di nuovo il prompt.

Se nessuno dei metodi sopra funziona, puoi provare a **resettare ChatALL**. Nota che questa operazione eliminerà tutte le tue impostazioni e la cronologia dei messaggi.

Puoi resettare ChatALL eliminando le seguenti cartelle:

- Windows: `C:\Users\<user>\AppData\Roaming\chatall\`
- Linux: `/home/<user>/.config/chatall/`
- macOS: `/Users/<user>/Library/Application Support/chatall/`

Se il problema persiste, [segnala un problema](https://github.com/ai-shifu/ChatALL/issues).

## Per sviluppatori

### Contribuire un Bot

[La guida](https://github.com/ai-shifu/ChatALL/wiki/%E5%A6%82%E4%BD%95%E6%B7%BB%E5%8A%A0%E4%B8%80%E4%B8%AA%E6%96%B0%E7%9A%84-AI-%E5%AF%B9%E8%AF%9D%E6%9C%BA%E5%99%A8%E4%BA%BA) può esserti utile.

### Esegui

```bash
npm install
npm run electron:serve
```

### Build

Build per la tua piattaforma attuale:

```bash
npm run electron:build
```

Build per tutte le piattaforme:

```bash
npm run electron:build -- -wml --x64 --arm64
```

## Crediti

### Collaboratori

<a href="https://github.com/ai-shifu/ChatALL/graphs/contributors">
  <img src="https://raw.githubusercontent.com/ai-shifu/ChatALL/main/https://contrib.rocks/image?repo=ai-shifu/ChatALL" />
</a>

### Altri

- GPT-4 ha contribuito a gran parte del codice
- ChatGPT, Copilot e Google hanno fornito molte soluzioni (in ordine di importanza)
- Ispirato da [ChatHub](https://github.com/chathub-dev/chathub). Massimo rispetto!

## Sponsor

Se ti piace questo progetto, considera:

[![ko-fi](https://ko-fi.com/img/githubbutton_sm.svg)](https://ko-fi.com/F1F8KZJGJ)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-22

---