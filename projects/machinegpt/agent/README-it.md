![2](https://github.com/user-attachments/assets/a18257a3-a678-4fd4-bf77-750dab4d99bb)

# Agent

Un framework AI agent Python ad alta velocità e autosufficiente che sfrutta l’SDK Python di OpenAI per interpretare comandi in linguaggio naturale, generare ed eseguire codice dinamicamente e gestire il proprio ambiente di runtime senza attriti. Offre installazione automatica delle dipendenze, configurazione sicura dell’ambiente, logging strutturato e un’interfaccia plugin minimalista per integrare potenti strumenti Python—tutto sotto la licenza permissiva Apache 2.0.

## ⭐ Storico delle stelle

<p align="center">
  <a href="https://star-history.com/#machinegpt/agent&Date">
    <img alt="Star History Chart" src="https://api.star-history.com/svg?repos=machinegpt/agent&type=Date&theme=dark" onerror="this.src='https://api.star-history.com/svg?repos=machinegpt/agent&type=Date'" />
  </a>
</p>


## 🔧 Configurazione dell’ambiente

### Ambiente virtuale Python
Prima di configurare il progetto, è consigliato creare un ambiente virtuale. Segui questi passaggi:

Scopri di più sugli ambienti virtuali: [Guida al packaging di Python](https://packaging.python.org/en/latest/guides/installing-using-pip-and-virtual-environments/)

Crea e attiva un ambiente virtuale:

**Windows:**

```
py -m venv .venv
.venv\Scripts\activate
```

**macOS/Linux:**
```
python3 -m venv .venv
source .venv/bin/activate
```

### Configurazione del progetto
Questo progetto richiede una chiave API OpenAI per funzionare. Per fornirla, crea un file .env nella directory principale con il seguente contenuto:
```
OPENAI_API_KEY=
```
In alternativa, puoi copiare il file .env.example fornito e aggiornare la chiave:
```
cp .env.example .env
```

## 🧠 Avvio
Per avviare l’agente, esegui semplicemente:
```
git clone https://github.com/machinegpt/agent.git
cd agent

python machine.py
```

## ✨ Contributi

Contributi, suggerimenti, segnalazioni di bug e correzioni sono benvenuti!

Per nuove funzionalità, componenti o estensioni, apri una issue e discuti prima di inviare una PR.

## 💖 Questo progetto esiste nello stato attuale grazie a tutte le persone che contribuiscono
<a href="https://github.com/machinegpt/agent/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=machinegpt/agent" />
</a>

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-04

---