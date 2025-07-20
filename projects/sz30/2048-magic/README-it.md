<div align="right">
  <details>
    <summary >🌐 Altre Lingue</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>


[English](https://raw.githubusercontent.com/sz30/2048-magic/main/README.md) | [简体中文](https://raw.githubusercontent.com/sz30/2048-magic/main/README.zh-CN.md) | [繁體中文](https://raw.githubusercontent.com/sz30/2048-magic/main/README.zh-TW.md)

# 🎮 2048++

Una versione migliorata del classico gioco 2048, ora con ancora più funzionalità divertenti! Questo è un piccolo progetto che ho realizzato nel mio tempo libero—spero che ti porti un po' di gioia!

## 🎯 Introduzione al Gioco

2048 è un gioco semplice ma coinvolgente di fusione di numeri. Su una griglia 4x4, scorri in alto, in basso, a sinistra o a destra per unire le tessere con lo stesso numero. L'obiettivo? Raggiungere 2048 (ma puoi continuare per punteggi ancora più alti)!

**Come si gioca:**
- Usa i tasti freccia o WASD per muovere le tessere.
- Quando due tessere con lo stesso numero si scontrano, si fondono in una sola.
- Dopo ogni mossa, apparirà casualmente un nuovo 2 o 4 in una casella vuota.
- Il gioco termina quando non ci sono più mosse disponibili.

## ✨ Funzionalità Speciali

### 1. Funzione Annulla
- Hai fatto una mossa sbagliata? Nessun problema!
- Basta premere il pulsante "Annulla" per tornare indietro di un passo.
- Puoi annullare tutte le volte che vuoi, fino all'inizio della partita.
- Non lasciare mai che un errore rovini la tua partita!

### 2. Modalità Cheat Segreta
- Inserisci la sequenza magica: ←←→→ →→←← (sinistra, sinistra, destra, destra, destra, destra, sinistra, sinistra)
- Tutte le tessere si trasformeranno magicamente in 128!
- È un Easter egg, solo per divertimento.
- Consiglio: Barare è divertente, ma non esagerare! 😉

## 🎯 Demo

🎯 Gioca qui: [2048.765431.xyz](https://2048.765431.xyz/)
<img width="1279" alt="demo" src="https://github.com/user-attachments/assets/0df2c956-b6d9-4371-a916-f6ac3ae642be" />



## 📁 Struttura del Progetto
```
2048/
├── static/
│ ├── css/
│ │ └── styles.css # Game styles
│ └── js/
│ └── script.js # Frontend game logic
├── index.html # Main game page
└── 2048.py # Backend server
```
**Descrizione dei file:**
- `2048.py`: Server backend scritto con Flask, gestisce la logica di gioco e le richieste API.
- `script.js`: Logica di gioco frontend, comprese mosse, animazioni e funzionalità speciali.
- `styles.css`: Stili del gioco, per assicurare un aspetto gradevole e reattivo.
- `index.html`: La pagina principale che unisce tutto insieme.

## 🚀 Per iniziare

**Metodo 1: Scarica la release**
1. Scarica l’ultima release.
2. Assicurati di avere installato Python 3.x.
3. Installa le dipendenze: `pip install flask`
4. Avvia: `python 2048.py`
5. Apri il browser e vai su: [http://localhost:9969](http://localhost:9969)

**Metodo 2: Clona da GitHub**
```bash
git clone https://github.com/sz30/2048.git
cd 2048
pip install flask
python 2048.py
```
## 🎨 Personalizzazione

Vuoi renderlo tuo? Modifica `styles.css` per un nuovo aspetto, oppure immergiti in `script.js` per cambiare il gameplay. Tutto il codice è ben commentato per facilitare la personalizzazione!

## 📝 Licenza

Licenza GPL-2.0

## 🤝 Contributi

Ancora in aggiornamento! Segnalazioni e Pull Request sono super benvenute—rendiamo insieme questo gioco ancora più fantastico!


## 🙏 Ringraziamenti

Grazie ai seguenti sponsor per aver supportato questo progetto:
- [IDC.REST](https://idc.rest/) che fornisce il server
- [Serv00](https://www.serv00.com/) che fornisce il server

---
_Ultimo aggiornamento: Giu. 2025_



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---