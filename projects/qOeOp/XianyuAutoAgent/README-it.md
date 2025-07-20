<div align="right">
  <details>
    <summary >🌐 Lingua</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# 🚀 Xianyu AutoAgent - Sistema Intelligente di Assistenza Clienti per Xianyu

[![Java Version](https://img.shields.io/badge/java21%2B-blue)](https://www.python.org/) [![LLM Powered](https://img.shields.io/badge/LLM-powered-FF6F61)](https://platform.openai.com/)

Soluzione AI progettata appositamente per la piattaforma Xianyu, per garantire la presenza automatica 7×24 ore su Xianyu, supportando decisioni collaborative multi-esperto, negoziazione intelligente e conversazioni contestuali.

## 🎮 Playground - Prova Rapida (versione senza configurazione)

Non è richiesto alcun ambiente locale o impostazione di Secrets! **Basta inserire i parametri tramite l'interfaccia web di GitHub Actions** per avviare il bot Xianyu con un solo click.

### Come si usa
1. **Forka questo repository** → Clicca il pulsante `Fork` in alto a destra
2. **Avvia l'Action**:
   - Vai nella scheda `Actions` del tuo repository
   - Seleziona il workflow **`🚀 Run Service`**
   - Clicca sul pulsante **`Run workflow`** e inserisci i parametri:
      - `API Key`: Incolla la tua API Key del modello LLM (es. Aliyun DashScope)
      - `Cookies`: Incolla la stringa completa dei cookie della versione web di Xianyu
3. **Consulta i log di esecuzione**:
   - Dopo l'avvio il bot monitorerà automaticamente i messaggi di Xianyu
   - Nei log delle Actions cerca `🤖 Reply:` per vedere la cronologia delle conversazioni

### Note importanti
⚠️ Attenzione ai limiti di esecuzione temporanea:
- Esecuzione predefinita **30 minuti** (limite per account GitHub gratuito)
- Le informazioni sensibili (come i Cookie) **non verranno salvate**, valide solo per la sessione corrente

<div align="center">
  <img src="https://raw.githubusercontent.com/qOeOp/XianyuAutoAgent/main/./screenshots/workflow.png" width="400px" alt="workflow">
</div>

## 🌟 Caratteristiche principali

### Motore di dialogo intelligente
| Modulo         | Implementazione tecnica    | Caratteristiche chiave                                         |
| -------------- | ------------------------- | -------------------------------------------------------------- |
| Contesto       | Memorizzazione cronologia | Gestione leggera della memoria, cronologia completa come input LLM |
| Instradamento  | Prompt LLM+regole         | Riconoscimento intenzioni tramite prompt → Assegnazione dinamica agli agenti esperti, supporto a più scenari (negoziazione/tecnico/customer care) |

### Matrice delle funzionalità aziendali
| Modulo     | Implementato                        | In programma                     |
| ---------- | ----------------------------------- | ------------------------------- |
| Motore     | ✅ Risposta automatica LLM<br>✅ Gestione contesto | 🔄 Miglioramento analisi sentimenti    |
| Negoziazione| ✅ Strategia di sconto a scaglioni         | 🔄 Funzione di comparazione prezzi      |
| Supporto   | ✅ Integrazione ricerca web                | 🔄 Miglioramento knowledge base RAG     |

## 🚴 Guida rapida

### Requisiti di sistema
- JDK 21+
- Maven 3.9.10+

### Passaggi per l'installazione

```bash
1. 克隆仓库
git clone https://github.com/qOeOp/XianyuAutoAgent.git
cd XianyuAutoAgent

2. 配置环境变量
- AI_DASHSCOPE_API_KEY : 阿里云大模型API-KEY
- COOKIES_STR : 闲鱼网页端Cookie

3. 执行命令
mvn spring-boot:run
注意：默认使用的模型是通义千问，如需使用其他API，请自行修改application.yml文件中的模型地址和模型名称；
COOKIES_STR自行在闲鱼网页端获取cookies(网页端F12打开控制台，选择Network，点击Fetch/XHR,点击一个请求，查看cookies)

4. (可选)创建提示词文件src/main/resources/*-prompt.txt
```
## 🤝 Partecipa e contribuisci

Sono benvenuti suggerimenti tramite Issue o contributi di codice tramite PR, si prega di seguire le [linee guida per i contributi](https://contributing.md/)



## 🛡 Avvertenze

⚠️ Attenzione: **Questo progetto è solo a scopo di apprendimento e comunicazione. In caso di violazione del copyright, contattare l'autore per la rimozione.**

Data la natura particolare del progetto, il team di sviluppo potrebbe in qualsiasi momento **interrompere gli aggiornamenti** o **eliminare il progetto**.


## 🧸 Ringraziamenti speciali

Questo progetto è stato ricostruito sulla base dei seguenti progetti open source:
- [XianyuAutoAgent](https://github.com/shaxiu/XianyuAutoAgent) - Sistema intelligente di assistenza clienti per Xianyu, sviluppato da [@shaxiu](https://github.com/shaxiu) e [@cv-cat](https://github.com/cv-cat)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---