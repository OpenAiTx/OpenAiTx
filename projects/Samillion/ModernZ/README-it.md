<h1 align="center">ModernZ - Un'elegante OSC Alternativa per mpv</h1>

Un OSC elegante e moderno per [mpv](https://mpv.io/), questo progetto è un fork di ModernX progettato per migliorare la funzionalità aggiungendo più caratteristiche, il tutto preservando gli standard fondamentali dell'OSC di mpv.

![ModernZ-OSC](https://raw.githubusercontent.com/Samillion/ModernZ/main/assets/f6854de6-1d57-4b2f-848e-7197933b71aa)

<p align="center">
    <a href="#installation"><strong>Installazione »</strong></a>
  <br>
  <a href="#configuration">Configurazione</a>
  ·
  <a href="#controls">Controlli</a>
  ·
  <a href="#interactive-menus">Menu Interattivi</a>
  ·
  <a href="#translations">Lingua OSC</a>
  ·
  <a href="#extras">Script Extra</a>
</p>

## Caratteristiche

- 🎨 Interfaccia moderna e personalizzabile [[opzioni](#configuration)]
- 📷 Modalità Visualizzatore Immagini con controlli di zoom [[dettagli](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/IMAGE_VIEWER.md)]
- 🎛️ Pulsanti: download, playlist, controllo velocità, screenshot, pin, loop, cache e altro. [[dettagli](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/CONTROLS.md)]
- 📄 Menu interattivi per playlist, sottotitoli, capitoli, tracce audio e dispositivi audio [[dettagli](#interactive-menus)]
- 🌐 Supporto multilingue con integrazione JSON [locale](#translations)
- ⌨️ Controlli configurabili [[dettagli](#controls)]
- 🖼️ Anteprime miniature video con [thumbfast](https://github.com/po5/thumbfast)

## Personalizzazione

Puoi cambiare il tema delle icone in `fluent` o `material` per adattarlo al tuo gusto e stile utilizzando l'opzione `icon_theme` nel tuo `modernz.conf`

![modernz_fluent](https://raw.githubusercontent.com/Samillion/ModernZ/main/assets/3aafac8c-a13f-4840-8119-739523eb7a8e)

![modernz_material](https://raw.githubusercontent.com/Samillion/ModernZ/main/assets/e5ad6d06-f071-42ef-9210-296d95906d94)

Non sei un fan dei pulsanti e testi bianchi? Hai il controllo completo per personalizzare colori e layout dei pulsanti per riflettere perfettamente il tuo stile.

![modernz_osc_controls_top](https://raw.githubusercontent.com/Samillion/ModernZ/main/assets/9e3df3af-d3ea-41bb-8c9a-9bf64c1d895a)

![modernz_osc_controls_bottom](https://raw.githubusercontent.com/Samillion/ModernZ/main/assets/d4e56bf5-ce7b-44e9-90a3-e27e922dd6bd)

Consulta la sezione [Personalizzazione Colori](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/USER_OPTS.md#colors-and-style) nella guida alla configurazione per dettagli su come personalizzare colori e pulsanti.

## Menu Interattivi

ModernZ supporta la console/select integrata di mpv ([v0.40+](https://github.com/mpv-player/mpv/releases/tag/v0.40.0)) per playlist, sottotitoli, navigazione capitoli e altro.

[![preview_menus](https://raw.githubusercontent.com/Samillion/ModernZ/main/assets/4b7a3139-81f1-409b-98f5-f090a81d5ee6)](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/INTERACTIVE_MENUS.md)

## Installazione

1. **Disabilita l'OSC Stock**

   - Aggiungi `osc=no` nel tuo `mpv.conf`

2. **Copia i File**

   - Posiziona `modernz.lua` nella cartella scripts di mpv
   - Posiziona `fluent-system-icons.ttf` e `material-design-icons.ttf` nella cartella fonts di mpv
   - (OPZIONALE) Posiziona `thumbfast.lua` nella cartella scripts di mpv

3. **Percorsi**

   ```
   Linux:   ~/.config/mpv/
   Windows: C:/Users/%username%/AppData/Roaming/mpv/
   macOS:   ~/Library/Application Support/mpv/
   ```

4. **Struttura Cartelle** [[manuale mpv](https://mpv.io/manual/master/#files)]
   ```
   mpv/
   ├── fonts/
   │   ├── fluent-system-icons.ttf
   │   └── material-design-icons.ttf
   ├── script-opts/
   │   └── modernz.conf
   └── scripts/
   	   ├── modernz.lua
   	   └── thumbfast.lua (opzionale)
   ```

## Configurazione

1. Crea `modernz.conf` nella cartella `/script-opts` per personalizzare le impostazioni

   - [Scarica il modernz.conf di default](https://raw.githubusercontent.com/Samillion/ModernZ/main/modernz.conf)

2. Esempio di configurazione breve:

   ```EditorConfig
   # Colore barra di ricerca (formato esadecimale)
   seekbarfg_color=#B7410E

   # Opzioni interfaccia
   playlist_button=no
   title=${media-title}
   scalewindowed=1.0
   window_top_bar=auto
   ```

Per una lista completa delle opzioni, [consulta la lista dettagliata qui](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/USER_OPTS.md).

## Controlli

### Interazioni Pulsanti

- Click sinistro: Azione primaria
- Click destro: Azione secondaria
- Click centrale/Shift+Click sinistro: Azione alternativa

> [!NOTE]
> Il click centrale esegue la stessa funzione di `Shift+click sinistro`, permettendo l'uso con una sola mano

Per una lista completa delle interazioni, consulta la [Guida alle Interazioni dei Pulsanti](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/CONTROLS.md).

### Scorciatoie da Tastiera

ModernZ non imposta scorciatoie di default per evitare conflitti con la tua configurazione attuale. Puoi aggiungerle in `input.conf` se preferisci:

```
w   script-binding modernz/progress-toggle           # Attiva/disattiva barra di progresso
x   script-message-to modernz osc-show               # Mostra OSC
y   script-message-to modernz osc-visibility cycle   # Cambia modalità di visibilità
z   script-message-to modernz osc-idlescreen         # Attiva/disattiva schermo inattivo
```

## Traduzioni

ModernZ è attualmente disponibile in inglese, ma puoi facilmente cambiarlo nella tua lingua preferita! Ecco come:

1. **Scarica il pacchetto locale:**

Prendi il file [modernz-locale.json](https://raw.githubusercontent.com/Samillion/ModernZ/main/extras/locale/modernz-locale.json) da questo repository. Questo file contiene le traduzioni per varie lingue.

2. **Aggiungi le locale a mpv:**

Copia il file `modernz-locale.json` scaricato nella cartella `/script-opts` di mpv.

3. **Scegli la tua lingua:**

Ci sono due modi per impostare la lingua preferita:

- **Consigliato:** Usa il file `modernz.conf`

  ```ini
  # Esempio di configurazione in modernz.conf
  # Imposta la lingua in Cinese Semplificato
  language=zh
  ```

- **Alternativo:** Modifica lo script `modernz.lua`

  Apri `modernz.lua` e trova la sezione `user_opts` all'inizio. Cambia il valore `language` con il codice della lingua preferita:

  ```lua
  local user_opts = {
      -- Generale
      language = "en",  -- Cambia questo con il codice lingua preferito
      ...
  }
  ```

**Serve Altro?**

Per una lista completa delle lingue disponibili, linee guida per contributi e documentazione approfondita sulle traduzioni, visita il [TRANSLATIONS.md](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/TRANSLATIONS.md).

## Extra

I seguenti script sono scritti e mantenuti da me, sentiti libero di usarli se ti sono utili.

- [Pause-Indicator-Lite](https://raw.githubusercontent.com/Samillion/ModernZ/main/extras/pause-indicator-lite) - Uno script semplice che mostra un indicatore in pausa

- [ytdlAutoFormat](https://github.com/Samillion/mpv-ytdlautoformat) - Uno script mpv semplice per cambiare automaticamente `ytdl-format` (yt-dlp) per domini specifici.

- [BoxtoWide](https://github.com/Samillion/mpv-boxtowide) - Uno script mpv semplice per cambiare automaticamente il rapporto d'aspetto 4:3 di file/stream video a 16:9.

Per ulteriori script utili, consulta la [mpv User Scripts Wiki](https://github.com/mpv-player/mpv/wiki/User-Scripts). Offre una vasta gamma di script contribuiti dalla comunità per migliorare la tua esperienza mpv.

## Storia

- [Samillion/ModernZ](https://github.com/Samillion/ModernZ)
  - fork da [dexeonify/ModernX](https://github.com/dexeonify/mpv-config/blob/main/scripts/modernx.lua)
    - fork da [cyl0/ModernX](https://github.com/cyl0/ModernX)
    - fork da [maoiscat/mpv-osc-modern](https://github.com/maoiscat/mpv-osc-modern)

**Perché un altro fork?**

- Per aggiungere molte funzionalità in: [Personalizzazione Colori](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/USER_OPTS.md#colors-and-style), [Opzioni](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/USER_OPTS.md) e [Integrazione Locale](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/TRANSLATIONS.md)
- Per integrare console e select nell'osc, ispirando mpv ad applicarlo nell'osc stock. [rif. [#1](https://github.com/mpv-player/mpv/pull/15016), [#2](https://github.com/mpv-player/mpv/pull/15031)]
- Per aggiungere un layout dedicato per le immagini. [[dettagli](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/IMAGE_VIEWER.md)]
- Per rifare completamente il progetto per rispettare gli standard dell'osc stock di mpv, garantendo compatibilità
- Per eliminare vecchi bug e ridondanze nel codice
    - Questo permette ad altri fork `Modern` di usare ModernZ come base, come [zydezu/ModernX](https://github.com/zydezu/ModernX). [[Riferimento](https://github.com/zydezu/ModernX/releases/tag/0.3.9)]

In sostanza, per mantenere e rivitalizzare l'origine `modern-osc`.
Detto questo, ModernZ utilizza ancora parti del codice vecchio, e ogni autore e contributore di fork precedenti e attuali merita credito (incluso l'osc stock di mpv), ecco perché sono menzionati in dettaglio.

#### Crediti:

- Font: UI Fluent System Icons [[dettagli](https://github.com/microsoft/fluentui-system-icons)] [[file font](https://raw.githubusercontent.com/Samillion/ModernZ/main/fluent-system-icons.ttf)]
- Font modificato da [Xurdejl](https://github.com/Xurdejl) per l'uso su ModernZ osc
- [mpv](https://github.com/mpv-player/mpv) e il loro [osc.lua](https://github.com/mpv-player/mpv/blob/master/player/lua/osc.lua), poiché ModernZ osc è stato rielaborato sugli standard dell'osc stock e applica aggiornamenti da esso
- Tutte le origini osc moderne e i loro fork come menzionato nella [storia](#history)
- Tutti i [contributori](https://github.com/Samillion/ModernZ/graphs/contributors), tester e utenti che hanno aiutato direttamente o indirettamente con ModernZ osc ❤️

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---