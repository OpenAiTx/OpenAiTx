
<div align="right">
  <details>
    <summary >🌐 Lingua</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# AI Partner Chat

Un progetto Claude Skills che rende l’IA il tuo partner di conversazione personalizzato.

## Introduzione al progetto

AI Partner Chat offre un’esperienza di conversazione personalizzata e contestuale integrando il profilo utente, il profilo AI e note personali vettorializzate. Questa skill permette all’IA di ricordare e citare i tuoi pensieri, preferenze e basi di conoscenza precedenti, creando un’interazione più coerente e personalizzata.

## Funzionalità principali

### 🎭 Sistema doppio di profili
- **Profilo utente**: definisci il tuo background, competenze, interessi e preferenze di comunicazione
- **Profilo AI**: personalizza il ruolo, lo stile comunicativo e la modalità di interazione dell’AI

### 📝 Ricerca intelligente delle note
- Indicizza automaticamente le tue note Markdown
- Ricerca in modo intelligente i record storici rilevanti in base al contenuto della conversazione
- Cita in modo naturale i tuoi pensieri e le tue note passate durante la conversazione

### 💬 Conversazione personalizzata
- Genera risposte personalizzate in base al tuo profilo e alle tue note
- Mantiene la coerenza contestuale della conversazione
- Cita i tuoi pensieri in modo naturale, come farebbe un amico, invece di un robot che “consulta i record”

## Scenari d’uso

Quando hai bisogno di:
- Comunicazione personalizzata, non risposte generiche
- Risposte contestuali, con l’AI che ricorda il tuo background
- L’AI che ricorda e cita i tuoi pensieri e note precedenti
- Esperienza conversazionale continua, non ogni volta una nuova partenza

## Installazione e utilizzo

### Installazione della skill

Copia questo progetto nella cartella `.claude/skills/` del tuo workspace:

```
<你的项目根目录>/
└── .claude/
    └── skills/
        └── ai-partner-chat/    # 本技能包
            ├── assets/
            ├── scripts/
            ├── SKILL.md
            └── README.md
```

### Utilizzo delle competenze

In Claude Code, invia il seguente comando per abilitare questa funzione:

```
遵循 ai-partner-chat 对话
```

L'agente AI farà automaticamente:
- Leggerà la configurazione delle skill e le istruzioni
- Creerà la struttura di directory necessaria (`notes/`, `config/`, `vector_db/`, ecc.)
- Eseguirà l'inizializzazione secondo le tue esigenze

### Processo di inizializzazione

#### Metodo 1: lascia che l'AI crei e configuri automaticamente

Al primo utilizzo, comunica direttamente all'AI:

```
我刚刚在 notes 里放入了对应的笔记，请根据笔记内容，进行向量化；并基于笔记内容，推测并更新 user-persona.md，以及最适合我的 ai-persona.md
```

L'agente AI può:
1. Analizzare i contenuti degli appunti nella directory `notes/`
2. Suddividere intelligentemente e creare un database vettoriale secondo il formato delle note
3. Deducere il tuo background e le tue preferenze dai contenuti delle note
4. Generare e aggiornare automaticamente `config/user-persona.md`
5. Raccomandare e creare `config/ai-persona.md` sulla base delle tue caratteristiche

#### Modalità 2: Configurazione manuale del profilo

Se desideri definire tu stesso il profilo:
1. L'agente AI creerà automaticamente i file del profilo dai modelli nella directory `config/`
2. Puoi modificare manualmente questi file per personalizzare il profilo
3. Poi informa l'AI di procedere all'elaborazione vettoriale

### Inizia la conversazione

Dopo la configurazione, per ogni utilizzo basta inviare:

```
遵循 ai-partner-chat 对话
```
L'AI farà quanto segue:
- Leggerà il tuo profilo per comprendere il tuo background
- Recupererà le note storiche rilevanti
- Genererà risposte personalizzate e consapevoli del contesto

## Struttura del progetto

### Struttura del pacchetto di competenze (situata in `.claude/skills/ai-partner-chat/`)


```
ai-partner-chat/
├── assets/              # 画像模板
│   ├── user-persona-template.md
│   └── ai-persona-template.md
├── scripts/             # 核心脚本
│   ├── chunk_schema.py
│   ├── vector_indexer.py
│   ├── vector_utils.py
│   └── requirements.txt
├── SKILL.md            # 技能详细文档（AI agent 会读取此文件）
└── README.md           # 本文件
```

### Directory dei dati utente (situata nella directory principale del progetto)

L'agente AI creerà la seguente struttura nella directory principale del tuo progetto:

```
<项目根目录>/
├── notes/              # 你的笔记（由你或 AI agent 创建）
├── config/             # 画像配置（由 AI agent 创建）
│   ├── user-persona.md
│   └── ai-persona.md
├── vector_db/          # 向量数据库（由 AI agent 创建）
└── venv/               # Python 虚拟环境（由 AI agent 创建）
```

**Importante**: I dati utente sono separati dai pacchetti di competenze, facilitando backup e migrazione.

## Flusso di lavoro

1. **Caricamento del profilo**: Lettura del profilo utente e del profilo AI, per comprendere il contesto dell’interazione
2. **Recupero delle note**: In base alla richiesta dell’utente, vengono recuperate dal database vettoriale le note più rilevanti
3. **Costruzione del contesto**: Integrazione delle informazioni del profilo, delle note correlate e della cronologia delle conversazioni
4. **Generazione della risposta**: Creazione di una risposta personalizzata e naturale basata sul contesto

## Punti di forza

### 🤖 Suddivisione intelligente AI Agent
Il sistema analizza il formato effettivo di ogni nota e genera dinamicamente la strategia di suddivisione più adatta, invece di usare modelli predefiniti. Questo significa che qualsiasi formato di nota riceverà la migliore elaborazione possibile.

### 🎯 Citazione naturale
L’AI richiama le tue informazioni passate in modo naturale, integrandole fluentemente nella conversazione senza affermazioni come "secondo i record".

### 📦 Indipendenza dei dati
Tutti i tuoi dati (note, profili, database vettoriali) sono archiviati nella directory principale del progetto, rendendo facile il backup, la migrazione o la condivisione tra diverse competenze.

## Best practice

### Progettazione del profilo
- **Specifico e chiaro**: Un profilo vago porta a risposte generiche
- **Inclusione di esempi**: Mostra il modello di interazione desiderato nel profilo AI
- **Aggiornamento periodico**: Ottimizza il profilo in base alla qualità delle conversazioni

### Gestione delle note
- **Formato libero**: Il sistema si adatta a qualsiasi struttura di nota
- **Contenuto ricco**: Note approfondite migliorano l’efficacia del recupero
- **Aggiornamento tempestivo**: Ricorda di aggiungere le nuove note all’indice

### Esperienza conversazionale
- **Citazione naturale**: Cita le note solo quando sono veramente rilevanti
- **Mantieni la fluidità**: Non lasciare che la citazione interrompa il ritmo naturale della conversazione
- **Focus sulla qualità**: Dai priorità a connessioni significative piuttosto che alla quantità

## Manutenzione e aggiornamento

### Aggiungi una nuova nota
Dopo aver inserito una nuova nota nella directory `notes/`, informa l’AI:

```
我刚刚在 notes 里添加了新笔记，请更新向量数据库
```

L'agente AI analizzerà automaticamente le nuove note e aggiornerà l'indice.

### Aggiornare il profilo
Puoi modificare direttamente i file del profilo nella directory `config/`, oppure dire all'AI:

```
请根据我最近的笔记内容，更新 user-persona.md 和 ai-persona.md
```

### Ricostruisci l'indice
Quando la struttura delle note subisce cambiamenti significativi, informa l’AI:

```
请重新初始化向量数据库
```

L'agente AI analizzerà nuovamente tutte le note e ricostruirà l'indice.

## Avvertenze

- **Primo avvio**: al primo avvio, l'agente AI scaricherà automaticamente il modello di embedding (circa 4,3GB), si prega di attendere con pazienza
- **Ambiente Python**: l'agente AI creerà automaticamente un ambiente virtuale e installerà le dipendenze necessarie
- **Archiviazione dati**: tutti i dati (note, profili, database di vettori) sono archiviati nella directory principale del progetto, non all'interno della directory del pacchetto di skill
- **Posizione della skill**: assicurarsi che il pacchetto di skill sia nella directory `.claude/skills/ai-partner-chat/`

## Maggiori informazioni

Per la documentazione tecnica dettagliata e le istruzioni d'uso, consultare il file `SKILL.md`.

---

Lascia che l'AI diventi un vero partner di conversazione che ti conosce, non solo uno strumento.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-15

---