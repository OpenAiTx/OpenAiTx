
<div align="right">
  <details>
    <summary >🌐 Lingua</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>


# 🎬 Strumento per il download batch di video yt-dlp (Supporto Windows / Linux)

> Script di download video one-click basato su [yt-dlp](https://github.com/yt-dlp/yt-dlp), ispirato dalla [condivisione del grande NodeSeek](https://www.nodeseek.com/post-334093-2#15).
> Supporta il download singolo e batch di video, compatibile con Windows e le principali distribuzioni Linux (Debian / Ubuntu / Alpine / CentOS).

---

## ✨ Caratteristiche principali

* 📥 **Avvio con un clic**: nessuna configurazione manuale richiesta, basta seguire le istruzioni per iniziare il download
* 🍪 **Supporto Cookie personalizzati**: utile per scaricare video che richiedono login (⚠️ Funzionalità non ancora verificata, potrebbero esserci bug)
* 📂 **Supporto per directory di output personalizzata**: salva facilmente nella cartella desiderata
* 📃 **Supporto per download multipli**: legge automaticamente i link dal file `urls.txt` per il download
* ⚙️ **Installazione automatica delle dipendenze**: installazione automatica di `yt-dlp` e `ffmpeg` su Linux

---

## 🖼️ Anteprima screenshot

| Esempio 1                                                                  | Esempio 2                                                                  |
| ---------------------------------------------------------------------- | ---------------------------------------------------------------------- |
| ![Esempio 1](https://img.uutv.dpdns.org/file/1746720584399_1000193433.jpg) | ![Esempio 2](https://img.uutv.dpdns.org/file/1746720581006_1000193434.jpg) |
| ![Esempio 3](https://img.uutv.dpdns.org/file/1746720588978_1000193428.jpg) | ![Esempio 4](https://img.uutv.dpdns.org/file/1746720587272_1000193427.jpg) |

---

## 🪟 Guida all’uso su Windows

1. Scarica i seguenti file:

   * [`yt-dlp.exe`](https://github.com/yt-dlp/yt-dlp)
   * [`ffmpeg` versione Windows](https://www.gyan.dev/ffmpeg/builds/ffmpeg-git-full.7z)

2. Dopo l’estrazione, posiziona i seguenti file nella stessa cartella (ad esempio nella cartella `yt-dlp`):

   * `yt-dlp.exe`
   * `ffmpeg.exe`
   * `ffprobe.exe`
   * `yt-dlp.bat` (file script)

3. Fai doppio clic su `yt-dlp.bat` e segui le istruzioni per scaricare i video.
4. Modifica config/config.ini per cambiare la configurazione predefinita

---

## 🐧 Guida all’uso su Linux (lo script più recente del maestro lion include anche uno script con funzioni identiche)

**Sistemi supportati**: Debian / Ubuntu / Alpine / CentOS

Distribuisci o aggiorna ed esegui con un solo clic:

```bash
bash -c "$(curl -fsSL https://raw.githubusercontent.com/nodeloc666/yt-dlp-script/main/install.sh)"
```

Per la disinstallazione:

```bash
bash -c "$(curl -fsSL https://raw.githubusercontent.com/nodeloc666/yt-dlp-script/main/uninstall.sh)"
```

---

## 📱 Consigli per l'uso su Android

1. Usa l'app [Seal](https://github.com/JunkFood02/Seal) per sperimentare le funzionalità di `yt-dlp` su Android.
2. Anche installando Debian su termux è possibile scaricare, ma non è necessario farlo, Seal è molto comodo da usare

---

## ⚠️ Avvertenze

1. **Modalità download batch**: Lo script leggerà automaticamente il file `config\urls.txt` nella directory corrente, un link video per riga. Se il file non esiste, verrà creato automaticamente.
2. **Avviso uso risorse**: Sui dispositivi con poca memoria evitare di scaricare contemporaneamente più video di grandi dimensioni, o impostare un numero troppo alto di thread concorrenti.
3. **Nota speciale per CentOS**: Poiché l'ambiente è piuttosto particolare, non è stato ancora completamente testato, si consiglia l'uso solo in ambienti non di produzione. Gli altri sistemi principali sono stati verificati e funzionano.
4. Piccolo bug su Linux: lo script verifica la presenza delle dipendenze ogni volta che si torna alla homepage, principio del "finché funziona va bene", non ho voglia di sistemarlo
5. Piccolo bug su Windows: quando da altre pagine si torna alla homepage e si effettua una nuova scelta, l'opzione di default potrebbe non funzionare e il processo va in loop, capacità limitate, non sono riuscito a correggerlo
Due soluzioni:
    1. Uscire e riavviare lo script
    2. Non usare le scelte predefinite, selezionare sempre il numero

---

## 📄 Licenza

Questo progetto segue la [Licenza MIT](https://opensource.org/licenses/MIT).

---


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-08

---