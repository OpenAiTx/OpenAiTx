<div align="right">
  <details>
    <summary >🌐 Lingua</summary>
    <div>
      <div align="center">
        <p>Le seguenti traduzioni sono state generate automaticamente tramite IA. Si prega di notare che potrebbero includere inesattezze o fare riferimento a versioni precedenti di questo readme.</p>
        <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

In Player Episode Preview
====================
## 📄 Informazioni
Questo plugin aggiunge una lista degli episodi al video player, che ti permette di vedere l’anteprima di ogni episodio della serie TV senza dover uscire dal player.

Questa modifica supporta i seguenti client:
* [Jellyfin Web Client](https://github.com/jellyfin/jellyfin-web)
* [Jellyfin Media Player](https://github.com/jellyfin/jellyfin-media-player) (JMP) Desktop Client

## ✨ Funzionalità
* Elenca tutti gli episodi di una stagione
* Passa da una stagione all'altra
* Mostra il titolo dell'episodio, la descrizione, la miniatura e il progresso di riproduzione
* Mostra dettagli dell'episodio come il ranking della community
* Segna gli episodi come riprodotti o preferiti
* Avvia un nuovo episodio
* Dovrebbe funzionare con temi personalizzati

## 📸 Anteprima
<img src="https://github.com/Namo2/InPlayerEpisodePreview/blob/master/Images/preview.gif" width="550" height="450">

Tema utilizzato: (SkinManager) Kaleidochromic
<br>
Questa anteprima non mostra i nuovi pulsanti per segnare un episodio come completato o preferito.

## 🔧 Installazione

### Client Web Jellyfin (Server)

> [!NOTE]
> Si raccomanda vivamente di avere installato almeno la versione v2.2.1.0 di [file-transformation](https://github.com/IAmParadox27/jellyfin-plugin-file-transformation). Aiuta ad evitare problemi di permessi durante la modifica di index.html in qualsiasi tipo di installazione!
<details open>
<summary> Vedi istruzioni... </summary>

1. Aggiungi il manifest `https://raw.githubusercontent.com/Namo2/InPlayerEpisodePreview/master/manifest.json` come repository di plugin Jellyfin al tuo server.
2. Installa il plugin `InPlayerEpisodePreview` dal repository.
3. Riavvia il server Jellyfin.
</details>

### Client Desktop Jellyfin Media Player (JMP) (Deprecato)
<details>
<summary> Vedi istruzioni... </summary>

**Deprecato dalla versione JMP [1.11.0](https://github.com/jellyfin/jellyfin-media-player/releases/tag/v1.11.0)**

Poiché il nuovo client JMP utilizza il player web corrente direttamente dal server, non è più necessario apportare modifiche dirette al codice del client.

Questo è il metodo raccomandato per installare lo script sul client desktop.
Se non ti senti a tuo agio nel modificare direttamente il file nativeshell.js (passi da 3 a 6), puoi invece scaricare la versione completa, che include già lo script aggiunto al file nativeshell.js.
Non è ancora chiaro se potrebbero esserci problemi potenziali sostituendo il file nativeshell.js con quello della release, quindi si consiglia di seguire tutti i passaggi sottostanti.

1. Scarica l'ultima release [JMP](https://github.com/Namo2/InPlayerEpisodePreview/releases/download/v1.1.0.0/inPlayerEpisodePreview-1.1.0.0-jmp.zip) oppure [JMP-full](https://github.com/Namo2/InPlayerEpisodePreview/releases/download/v1.1.0.0/inPlayerEpisodePreview-1.1.0.0-jmp-full.zip) (include già lo script aggiunto al file nativeshell.js)
2. Estrai il file zip nella directory di Jellyfin (ad esempio C:\Program Files\Jellyfin\Jellyfin Media Player)
3. All'interno della directory Jellyfin segui il percorso della cartella "web-client\extension"
4. Apri il file "nativeshell.js" con un editor di testo.
5. All'interno del file trova la sezione `const plugins = [];`. Aggiungi una nuova riga all'inizio della lista e incolla `'inPlayerEpisodePreviewPlugin',`. La sezione dovrebbe ora apparire simile a questa:
```javascript
const plugins = [
    'inPlayerEpisodePreviewPlugin',
    'mpvVideoPlayer',
    'mpvAudioPlayer',
    'jmpInputPlugin',
    'jmpUpdatePlugin',
    'jellyscrubPlugin',
    'skipIntroPlugin'
];
```
6. Salva il file e riavvia il client JMP.
</details>

## 💡 Risoluzione dei problemi

### 1. Il pulsante di anteprima non è visibile
Questo è molto probabilmente dovuto a permessi errati per il file `index.html`.

<details>
<summary> Vedi una lista di possibili soluzioni... </summary>

#### 1.1 Evita questo problema utilizzando il plugin [file-transformation](https://github.com/IAmParadox27/jellyfin-plugin-file-transformation).

#### 1.2 Cambia il proprietario all'interno di un container docker
Se stai eseguendo jellyfin in un container docker, puoi cambiare il proprietario con il seguente comando
(sostituisci jellyfin con il nome del tuo container, user e group con l'utente e il gruppo del tuo container):
```
docker exec -it --user root jellyfin chown user:group /jellyfin/jellyfin-web/index.html && docker restart jellyfin
```
Puoi eseguire questo come un processo cron all'avvio del sistema.
(Grazie a [muisje](https://github.com/muisje) per aver aiutato con [questa](https://github.com/Namo2/InPlayerEpisodePreview/issues/49#issue-2825745530) soluzione)

#### 1.3 Modifica della proprietà su un’installazione Windows
1. Vai su: `C:\Program Files\Jellyfin\Server\jellyfin-web\`
2. Clicca con il tasto destro su `index.html` → `Proprietà` → `Scheda Sicurezza` → Clicca su `Modifica`
3. Seleziona il tuo utente dall’elenco e seleziona la casella di permesso Scrittura.
4. Riavvia sia il server che il client.
   (Grazie a [xeuc](https://github.com/xeuc) per [questa](https://github.com/Namo2/InPlayerEpisodePreview/issues/49#issuecomment-2746136069) soluzione)

Se nessuna delle soluzioni sopra funziona, consulta le vecchie segnalazioni. Ad esempio [qui](https://github.com/Namo2/InPlayerEpisodePreview/issues/10) o [qui](https://github.com/Namo2/InPlayerEpisodePreview/issues/49).
</details>

<br/>
<br/>
Se riscontri un errore che non riesci a risolvere da solo, sentiti libero di aprire una segnalazione.
<br/>Tieni presente che ogni sistema è diverso e ciò può portare a comportamenti inaspettati, quindi aggiungi quante più informazioni possibili.
<br/>I log di Jellyfin e i log della console del browser (prefissati come [InPlayerEpisodePreview]) sono sempre utili.

## Crediti
La struttura del plugin è basata e ispirata al plugin [Jellyscrub](https://github.com/nicknsy/jellyscrub) di [NickNSY](https://github.com/nicknsy).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-15

---