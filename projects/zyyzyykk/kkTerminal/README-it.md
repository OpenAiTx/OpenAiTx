# kkTerminal

> kkTerminal, un terminale per la connessione Web SSH  
> Autore: [zyyzyykk](https://github.com/zyyzyykk/)  
> Codice Sorgente: https://github.com/zyyzyykk/kkTerminal  
> Indirizzo Docker Hub: https://hub.docker.com/repository/docker/zyyzyykk/kkterminal/general  
> Anteprima: https://ssh.kkbpro.com/  
> Data aggiornamento: 2025-03-15  
>

<p align="center"><a href="https://ssh.kkbpro.com/" target="_blank" rel="noopener noreferrer"><img width="100" src="https://kkbapps.oss-cn-shanghai.aliyuncs.com/logo/terminal.png" alt="kkTerminal"></a></p>

<p align="center">
  <a href="https://hub.docker.com/repository/docker/zyyzyykk/kkterminal/general"><img src="https://img.shields.io/docker/pulls/zyyzyykk/kkterminal?logo=docker" alt="Docker Image"></a>
  <a href="https://www.oracle.com/cn/java/technologies/downloads/#java8-windows"><img src="https://img.shields.io/badge/jdk-1.8-orange?logo=openjdk&logoColor=%23e3731c" alt="JDK Version"></a>
  <a href="https://spring.io/projects/spring-boot"><img src="https://img.shields.io/badge/springboot-2.7.15-green?color=6db33f&logo=springboot" alt="SpringBoot Version"></a>
  <a href="https://cn.vuejs.org/"><img src="https://img.shields.io/badge/vue-3.x-green?color=42b883&logo=vue.js" alt="Vue Version"></a>
  <a href="https://www.apache.org/licenses/"><img src="https://img.shields.io/badge/licence-Apache-red?logo=apache&logoColor=%23D22128" alt="Apache Licence"></a>
  <a href="https://github.com/zyyzyykk/kkTerminal"><img src="https://img.shields.io/github/stars/zyyzyykk/kkterminal" alt="GitHub"></a>
</p>
<p align="center">English ｜ <a href="https://raw.githubusercontent.com/zyyzyykk/kkTerminal/master/doc/zh_CN/README.md" >简体中文</a></p>

### ⚡ Integrazione rapida

Utilizzando il tag `iframe` nelle pagine HTML per una rapida integrazione:

```html
<iframe src="https://ssh.kkbpro.com/" height="400px" width="600px" ></iframe>
```

### 🐳 Deploy con Docker

1. Scarica l'immagine:

```bash
docker pull zyyzyykk/kkterminal
```

2. Crea ed esegui un container per il mapping della porta: `-p porta:3000`

```bash
docker run -d --name kkterminal -p 3000:3000 zyyzyykk/kkterminal
```

3. Personalizza la scritta artistica: `-e TITLE="ArtWord"`

```bash
docker run -d --name kkterminal -p 3000:3000 -e TITLE="kkbpro" zyyzyykk/kkterminal
```

4. Accesso dal browser: `http://ip-server:3000/`

### 🛸 Anteprima

Visita il seguente sito web: https://ssh.kkbpro.com/

![Connect](https://kkbapps.oss-cn-shanghai.aliyuncs.com/terminal/3.6.0/en/Connect.png)

![Preference](https://kkbapps.oss-cn-shanghai.aliyuncs.com/terminal/3.6.0/en/Preference.png)

![File](https://kkbapps.oss-cn-shanghai.aliyuncs.com/terminal/3.6.0/en/File.png)

![Editor](https://kkbapps.oss-cn-shanghai.aliyuncs.com/terminal/3.6.0/en/Editor.png)

[**Altre Anteprime dei Moduli**](https://raw.githubusercontent.com/zyyzyykk/kkTerminal/master/doc/en_US/MODULE.md)

### 💡 Descrizione delle Funzionalità

1. kkTerminal è un terminale per la connessione Web SSH. Clicca sull'icona del terminale in alto a sinistra e seleziona le impostazioni di connessione per stabilire una connessione SSH

2. Supporta l'utilizzo dei tag `iframe` nelle pagine web per una rapida integrazione in siti di terze parti

3. Supporta la personalizzazione della configurazione del terminale tramite [Parametri URL](https://raw.githubusercontent.com/zyyzyykk/kkTerminal/master/doc/en_US/PARAMS.md)

4. Supporta l'internazionalizzazione e il cambio lingua tra cinese e inglese

5. Supporta il deploy locale su PC, all'avvio apre automaticamente la finestra del browser

6. Supporta la dimensione adattiva della finestra e l'input cinese

7. Supporta impostazioni preferenze personalizzate, permettendo agli utenti di scegliere colore di sfondo/colore primo piano, dimensione font, stile del cursore, abilitare TCode per il terminale, ecc

8. Supporta il riavvio: si riavvia automaticamente dopo la modifica delle impostazioni di connessione SSH o delle preferenze personalizzate, oppure può essere riavviato manualmente dopo la disconnessione SSH

9. Supporta copia e incolla:

   - Copia: Come nel terminale `Git`, selezionando il testo viene copiato automaticamente

   - Incolla: Come nel terminale `Cmd`, tasto destro per incollare (richiede permessi del browser)


9. Supporta la gestione dei file, apri il Modulo Gestione File per visualizzare, decomprimere, caricare e scaricare file/cartelle

10. Supporta operazioni tramite tasti di scelta rapida come selezione multipla/tutti i file, copia e incolla, taglia, cambio selezione, apertura, ecc

11. Supporta la navigazione e la modifica dei file, modifica il file e salvalo su un server remoto usando `ctrl+s`

12. Supporta [TCode (Terminal Code)](https://raw.githubusercontent.com/zyyzyykk/kkTerminal/master/doc/en_US/TCODE.md), che può realizzare Workflow automatizzati simili a script Shell tramite TCode personalizzato

13. Supporta funzioni di registrazione delle operazioni e sincronizzazione cloud

14. Supporta le funzioni Cooperate, Monitor e Docker

### 👨‍💻 Storico aggiornamenti

##### zyyzyykk/kkterminal:3.6.0: latest

- Aggiunta funzione Advance Cooperate
- Aggiunta funzione Advance Monitor
- Aggiunta funzione Advance Docker
- Ottimizzazione volume di packaging & visualizzazione pagina web

##### zyyzyykk/kkterminal:3.5.6:

- Supporta più parametri URL
- Aggiunge editor per testo & percentuale dimensione immagini
- Ottimizzazione visualizzazione pagina web

##### zyyzyykk/kkterminal:3.5.3:

- Aggiunto parametro URL per personalizzare la configurazione del terminale
- Correzione bug del riavvio multi finestra
- Aggiunte funzioni di registrazione operazioni e sincronizzazione cloud
- Refactoring di alcune logiche di codice

[**Storico Aggiornamenti**](https://raw.githubusercontent.com/zyyzyykk/kkTerminal/master/doc/en_US/UPDATE.md)

### 🧬 Architettura

```markdown
+---------+     http      +-------------+    ssh     +---------------+
| browser | <===========> | kk Terminal | <========> | remote server |
+---------+   websocket   +-------------+    sftp    +---------------+
Vue + Xterm              SpringBoot + SSHJ                Linux OS    
```

### 🏘️ Informazioni su questo progetto

Gentili Utenti,

Mi dispiace annunciare che, a causa di tempo ed energie limitate, non potrò più occuparmi della manutenzione di `kkTerminal` in futuro.

Se siete interessati a `kkTerminal` o desiderate continuare la manutenzione, vi prego di contattarmi o aprire una issue.

Se trovate bug o desiderate sviluppare nuove funzionalità, aprite una issue.

Infine, grazie per il vostro supporto a `kkTerminal` e spero sinceramente che `kkTerminal` possa davvero esservi utile.

Cordiali saluti,

[zyyzyykk](https://github.com/zyyzyykk/)

2025.03.15

### 🌟 Stelle

[![Stars](https://starchart.cc/zyyzyykk/kkTerminal.svg?variant=adaptive)](https://starchart.cc/zyyzyykk/kkTerminal)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---