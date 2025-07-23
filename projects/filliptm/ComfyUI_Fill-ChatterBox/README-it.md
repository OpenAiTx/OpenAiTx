<div align="right">
  <details>
    <summary >🌐 Lingua</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# ComfyUI_Fill-ChatterBox

Se ti piace questo progetto, considera di supportarmi su Patreon!
<p align="left">
  <a href="https://www.patreon.com/c/Machinedelusions">
    <img src="https://raw.githubusercontent.com/filliptm/ComfyUI_Fill-ChatterBox/main/assets/Patreon.png" width="150px" alt="Patreon">
  </a>
</p>

Un'estensione custom node per ComfyUI che aggiunge funzionalità di text-to-speech (TTS) e conversione vocale (VC) utilizzando la libreria Chatterbox.
Supporta un MASSIMO di 40 secondi. Ho provato a rimuovere questa limitazione, ma il modello si degrada notevolmente con durate superiori, quindi rimane.

![Esempio ChatterBox](https://raw.githubusercontent.com/filliptm/ComfyUI_Fill-ChatterBox/main/web/image.png)

## Installazione

1. Clona questo repository nella tua directory custom_nodes di ComfyUI:

   ```bash
   cd /path/to/ComfyUI/custom_nodes
   git clone https://github.com/filliptm/ComfyUI_Fill-ChatterBox.git
   ```
2. Installa le dipendenze di base:

   ```bash
   pip install -r ComfyUI_Fill-ChatterBox/requirements.txt
   ```
3. (Opzionale) Installa il supporto per la filigrana:

   ```bash
   pip install resemble-perth
   ```
   **Nota**: Il pacchetto `resemble-perth` potrebbe avere problemi di compatibilità con Python 3.12+. Se si verificano errori di importazione, i nodi funzioneranno comunque senza watermarking.


## Utilizzo

### Nodo Text-to-Speech (FL Chatterbox TTS)
- Aggiungi il nodo "FL Chatterbox TTS" al tuo workflow
- Configura l'input di testo e i parametri (esagerazione, cfg_weight, temperatura)
- Facoltativamente fornisci un prompt audio per il voice cloning

### Nodo Voice Conversion (FL Chatterbox VC)
- Aggiungi il nodo "FL Chatterbox VC" al tuo workflow
- Collega l'audio di input e la voce di destinazione
- Entrambi i nodi supportano il fallback su CPU in caso di errori CUDA

## Registro delle modifiche

### 24/06/2025
- Aggiunto parametro seed a entrambi i nodi TTS e VC per generazione riproducibile
- Intervallo seed: da 0 a 4.294.967.295 (intero a 32 bit)
- Permette output audio coerente per debug e controllo dei workflow
- Reso opzionale il watermarking Perth per correggere problemi di compatibilità con Python 3.12+
- Ora i nodi funzionano senza watermarking se l'importazione di resemble-perth fallisce

### 31/05/2025
- Aggiunto caricamento modello persistente e funzionalità barra di caricamento
- Aggiunto supporto Mac (da testare, quindi scrivetemi pure)
- Rimossa la libreria chatterbox-tts e implementato codice di inferenza nativo.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-23

---