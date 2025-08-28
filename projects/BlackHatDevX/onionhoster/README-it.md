<details align="right">
<summary>🌐 Lingua</summary>

[English](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=en) | [简体中文](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=zh-CN) | [繁體中文](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=zh-TW) | [日本語](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=ja) | [한국어](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=ko) | [हिन्दी](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=hi) | [ไทย](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=th) | [Français](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=fr) | [Deutsch](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=de) | [Español](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=es) | [Italiano](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=it) | [Русский](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=ru) | [Português](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=pt) | [Nederlands](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=nl) | [Polski](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=pl) | [العربية](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=ar) | [فارسی](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=fa) | [Türkçe](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=tr) | [Tiếng Việt](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=vi) | [Bahasa Indonesia](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=id) | [অসমীয়া](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=as)
</details>

# OnionHoster v2.2

> **Lo strumento definitivo per l’hosting di servizi nascosti Tor** - Distribuisci i tuoi progetti web sul dark web in pochi minuti!
> 
[![Versione](https://img.shields.io/badge/version-2.2-brightgreen.svg)](https://github.com/BlackHatDevX/onionhoster)
[![Piattaforma](https://img.shields.io/badge/platform-Linux%20%7C%20macOS-blue.svg)](https://github.com/BlackHatDevX/onionhoster)
[![Licenza](https://img.shields.io/badge/license-MIT-green.svg)](https://github.com/BlackHatDevX/onionhoster)

<img width="1023" height="551" alt="ChatGPT Image Aug 27, 2025, 03_32_08 PM (1)-modified" src="https://github.com/user-attachments/assets/92b6e834-2d4f-4cc7-8f77-82b9bafba8a5" />


---

## 🚀 Cos’è OnionHoster?

OnionHoster è un potente script bash multipiattaforma che trasforma qualsiasi progetto web in un servizio nascosto Tor con un solo comando. Che tu stia ospitando un’app Next.js, un backend Flask o un sito statico, OnionHoster gestisce automaticamente tutta la complessa configurazione di Tor.

### ✨ Perché scegliere OnionHoster?

- **🔧 Zero Configurazione** - Funziona subito con qualsiasi progetto web
- **🌍 Multipiattaforma** - Supporta Linux, macOS e le principali distribuzioni
- **⚡ Configurazione One-Click** - Da zero a servizio nascosto in meno di 2 minuti
- **🔄 Aggiornamenti Automatici** - Il controllo aggiornamenti integrato ti mantiene al passo
- **💾 Backup & Ripristino** - Non perdere mai i tuoi indirizzi onion
- **🎯 UI Professionale** - Interfaccia colorata e bellissima con menu intuitivi

---
## Anteprima

[![IMAGE ALT TEXT HERE](https://github.com/user-attachments/assets/4b35dfb0-0059-4cc5-99c7-a5b9467a385d)](https://www.youtube.com/watch?v=oPvhA54Tp8w)


# ⚠️ Attenzione: OnionHoster NON è uno strumento magico per l’anonimato — segui le best practice o rischi la deanominizzazione

**Rafforzamento del sistema**

* Esegui il servizio all’interno di una VM o container per isolare.

* Mantieni il sistema operativo e i pacchetti aggiornati.
* Disabilita servizi/porte non necessari affinché solo il traffico Tor entri/esca.

**Pratiche OpSec**

* Non usare la stessa macchina per account o attività personali.
* Evita di esporre metadati identificativi (nomi file, intestazioni, messaggi di errore).
* Presta attenzione ai log — cosa registri, per quanto tempo li conservi, e se trapelano informazioni.

**Igiene della rete**

* Non collegare il tuo servizio nascosto alla tua identità o dominio clearnet.
* Usa un firewall per assicurarti che non ci siano perdite accidentali fuori da Tor.
* Prendi in considerazione proxy inversi per ulteriore isolamento.

**Test e Monitoraggio**

* Usa torsocks o il Browser Tor per verificare che il tuo servizio sia raggiungibile solo tramite il suo indirizzo `.onion`.
* Testa regolarmente la presenza di perdite (ad esempio, se la tua app tenta di accedere al clearnet).

**Consapevolezza dei casi d’uso**

* Per uso amatoriale/test/educativo: quanto sopra di solito è sufficiente.
* Per anonimato reale ad alto rischio (giornalisti, informatori, attivisti): è necessaria una sicurezza operativa più profonda e un’attenta analisi delle minacce, perché un solo errore può de-anonimizzarti.


---
## 🎯 Perfetto per

- **Sviluppatori** che vogliono testare le loro app su Tor
- **Difensori della privacy** che ospitano servizi anonimi (
- **Ricercatori** che studiano tecnologie del dark web
- **Aziende** che necessitano di soluzioni di hosting anonime
- **Appassionati** che esplorano la rete Tor

---

## 🚀 Avvio rapido

### Prerequisiti
- Accesso root/sudo
- Connessione a Internet
- Qualsiasi progetto web (HTML, Next.js, Flask, ecc.)

### Installazione e utilizzo

```bash
# 1. Clone the repository
git clone https://github.com/BlackHatDevX/onionhoster.git

# 2. Navigate to the directory
cd onionhoster

# 3. Make the script executable
chmod +x onionhoster.sh

# 4. Run with sudo
sudo bash onionhoster.sh
```

**Ecco fatto!** 🎉

Riceverai il progetto completo OnionHoster che include:
- Lo script principale `onionhoster.sh`
- Un template professionale `index.html` da ospitare
- Tutta la documentazione ed esempi

Lo script eseguirà automaticamente:
- Rilevamento del sistema operativo
- Installazione di tutte le dipendenze necessarie (Tor, Apache, ecc.)
- Configurazione dei servizi Tor
- Presentazione di un menu intuitivo

---

## 🎮 Panoramica delle funzionalità

### 🌐 Opzioni di hosting
- **HTML statico** - Ospita qualsiasi file `index.html`
- **Port Forwarding** - Inoltra verso qualsiasi porta locale dell'applicazione
- **App dinamiche** - Supporto per Next.js, Flask, Node.js e altro

### 🛠️ Strumenti di gestione
- **Controllo dei servizi** - Avvia, ferma e gestisci il tuo servizio nascosto
- **Backup & Ripristino** - Backup e ripristino sicuro dei tuoi domini onion
- **Aggiornamento URL** - Genera nuovi indirizzi onion quando necessario
- **Monitoraggio stato** - Verifica la salute e lo stato del servizio

### 🔄 Aggiornamenti intelligenti
- **Rilevamento automatico** - Trova automaticamente l’ultima versione
- **Aggiornamento con un click** - Aggiorna con una sola opzione dal menu
- **Aggiornamenti sicuri** - Nessun rischio di perdita della configurazione

---

## 📱 Sistemi operativi supportati

| OS | Gestore pacchetti | Stato |
|----|-------------------|---------|
| **Ubuntu/Debian** | `apt-get` | ✅ Supporto completo |
| **CentOS/RHEL** | `yum` | ✅ Supporto completo |
| **Fedora** | `dnf` | ✅ Supporto completo |
| **Arch Linux** | `pacman` | ✅ Supporto completo |
| **macOS** | `brew` | ✅ Supporto completo |

---

## 🎯 Casi d'Uso

### 🏠 Progetti Personali
- Ospita il tuo portfolio in modo anonimo
- Testa applicazioni web privatamente
- Condividi contenuti senza rivelare la tua identità

### 🏢 Applicazioni Aziendali
- Portali di assistenza clienti anonimi
- Sistemi di comunicazione interna sicuri
- Siti web aziendali orientati alla privacy

### 🔬 Ricerca & Sviluppo
- Ricerca sulla tecnologia dark web
- Sviluppo di strumenti per la privacy
- Test di servizi anonimi

---

## 📖 Utilizzo Dettagliato

### Opzioni del Menu Principale

1. **Ospita index.html** - Servi un file HTML statico
2. **Reindirizza alla porta dell'applicazione** - Proxy verso qualsiasi servizio locale
3. **Backup dominio tor** - Salva la tua configurazione onion
4. **Ripristina dominio tor** - Ripristina dal backup
5. **Visualizza dominio tor attuale** - Vedi il tuo indirizzo onion attivo
6. **Aggiorna dominio tor** - Genera un nuovo indirizzo onion
7. **Verifica aggiornamenti** - Aggiorna all'ultima versione
8. **Stato del Web Server** - Monitora la salute del servizio
9. **Informazioni su OnionHoster** - Informazioni su versione e funzionalità

### Esempio di flusso di lavoro

```bash
# Start the service
sudo ./onionhoster.sh

# Choose option 1 to host index.html
# Your onion address will be displayed
# Access it via Tor Browser or similar
```

---

## 🔧 Configurazione Avanzata

### Inoltro Porta Personalizzato
```bash
# Forward your Next.js app running on port 3000
# The script will handle all Tor configuration automatically
```

### Gestione del Backup
```bash
# Automatic backups are stored in ~/onion_backups/
# Each backup includes your onion keys and configuration
```
---

## 🛡️ Funzionalità di Sicurezza

- **Configurazione Automatica di Tor** - Impostazioni sicure pronte all'uso
- **Permessi dei File Corretti** - Proprietà e accesso ai file sicuri
- **Isolamento dei Servizi** - Ogni servizio nascosto funziona in modo indipendente
- **Nessun Log dei Dati** - Le tue attività restano private

---

## 🚨 Note Importanti

- **Accesso Root Necessario** - I servizi Tor richiedono configurazione a livello di sistema
- **Rete Tor** - Il tuo servizio sarà accessibile tramite Tor Browser
- **Indirizzi Onion** - Ogni servizio riceve un indirizzo `.onion` unico
- **Backup Regolari** - Gli indirizzi onion cambiano al rinnovo

---

## 🤝 Contribuire

Accogliamo con piacere i contributi! Che si tratti di:
- 🐛 Segnalazioni di bug
- 💡 Richieste di funzionalità
- 📝 Miglioramenti alla documentazione
- 🔧 Contributi al codice

**Per iniziare:**
1. Effettua il fork del repository
2. Crea un branch per la funzione
3. Apporta le tue modifiche
4. Invia una pull request

---

## 📄 Licenza

Questo progetto è distribuito sotto licenza MIT - vedi il file [LICENSE](LICENSE) per i dettagli.


---

## 🙏 Ringraziamenti

- **Tor Project** - Per la straordinaria rete di anonimato
- **Community Open Source** - Per i continui miglioramenti
- **Utenti & Collaboratori** - Per feedback e suggerimenti

---

## 🔗 Link

- **GitHub**: [https://github.com/BlackHatDevX/onionhoster](https://github.com/BlackHatDevX/onionhoster)
- **Problemi**: [https://github.com/BlackHatDevX/onionhoster/issues](https://github.com/BlackHatDevX/onionhoster/issues)
- **Discussioni**: [https://github.com/BlackHatDevX/onionhoster/discussions](https://github.com/BlackHatDevX/onionhoster/discussions)

---

## ⭐ Metti una Stella al Progetto

Se OnionHoster ti è utile, per favore metti una stella! Ci motiva a continuare a migliorare e aiuta altri a scoprire questo strumento.

---

**Pronto per diventare anonimo?** 🕵️‍♂️

```bash
git clone https://github.com/BlackHatDevX/onionhoster.git
cd onionhoster
sudo bash onionhoster.sh
```

*Il tuo viaggio verso l'hosting anonimo inizia ora!* 🚀


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-28

---