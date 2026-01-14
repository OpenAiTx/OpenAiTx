
<div align="right">
  <details>
    <summary >🌐 Lingua</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Calendario Familiare Smart Home Fai-da-te (Clone Skylight)

![Calendario Sklylight](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/assets/main_view.jpeg)
![DIY Skylight](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/assets/sky2.png)

## 📖 Introduzione

Mia moglie è stata recentemente bombardata sui social media da pubblicità di calendari smart home (Skylight, Cozyla, Hearth) ed era pronta a spendere oltre $300 per uno. Prima di darle il via libera, le ho chiesto di darmi la possibilità di fare una ricerca.
Mi sono reso conto che la maggior parte offriva funzionalità simili ma differiva notevolmente nel prezzo. Soprattutto, non vedevo nessuna funzione eccezionale che non potessi implementare in **Home Assistant**.

**L'Obiettivo:** Un calendario touchscreen da banco, approvato dal WAF (Wife Acceptance Factor), che si integra profondamente nella nostra smart home senza costi mensili.

## 💡 Perché fai-da-te?

Scegliere la strada del fai-da-te con Home Assistant ha offerto diversi vantaggi rispetto all'acquisto di un display Skylight/Hearth:

* **Nessun costo mensile:** Si evitano abbonamenti per funzionalità "premium".
* **Integrazione totale:** Comunica con le nostre luci, le faccende (Grocy) e i sensori di presenza.
* **Hardware usato:** Ho riutilizzato un Mini PC e un monitor standard.
* **Privacy:** Nessun vincolo con il fornitore o rischio di chiusura dell'azienda.

## 🛠 Scelta dell'hardware

Attualmente il sistema è progettato per mostrare la dashboard su qualsiasi display HD (1920x1080).

Nel mio caso, era necessario che "sembrasse" Skylight, fosse touchscreen, da banco e potesse essere spostato in diverse posizioni. Perciò ho scelto l'hardware descritto di seguito.
Tuttavia, il tuo caso potrebbe essere diverso e richiedere adattamenti, ad esempio se vuoi visualizzarlo su un tablet o altro dispositivo.

L'hardware che ho usato inizialmente l'ho scelto in base a quanto detto sopra, con la speranza di poter estendere la funzionalità usando webcam, altoparlante e microfono. Col senno di poi probabilmente ora lo costruirei diversamente, visto che non ho avuto tempo di occuparmi di queste idee hardware aggiuntive.

* **Monitor:** [HP Engage Touchscreen da 15 pollici](https://computers.woot.com/offers/hp-engage-16t-fhd-monitor). L'ho scelto rispetto ai monitor portatili generici perché include **altoparlante, webcam e microfono** integrati, permettendo in futuro il controllo vocale o le videochiamate.
* **Computer:** Un vecchio Mini PC (NUC/Tiny PC) con Windows/Linux in modalità Kiosk, oppure un Raspberry Pi 4.~~

## ✨ Funzionalità

* **Vista familiare & individuale:** Attiva/disattiva i calendari dei singoli membri della famiglia.
* **Sincronizzazione bidirezionale:** Modifica eventi dallo schermo o dai nostri telefoni (Google Calendar).
* **Popup "Aggiungi evento":** Un'interfaccia personalizzata per aggiungere eventi a calendari specifici direttamente dallo schermo.
* **Meteo & Data:** Intestazione bella e consultabile a colpo d'occhio.
* **Responsive:** Regola automaticamente il numero di giorni mostrati in base alla larghezza dello schermo (Mobile vs Desktop).

---

## ⚙️ Guida all’installazione

*Nota: Questa configurazione utilizza un **Pacchetto YAML** per creare automaticamente tutti gli helper, script e variabili necessari. Non è necessario crearli manualmente.*



### 1. Prerequisiti (HACS)

Devi avere [HACS](https://hacs.xyz/) installato. Installa le seguenti integrazioni **Frontend**:

* `week-planner-card`
* `bubble-card`
* `config-template-card`
* `card-mod`
* `better-moment-card`
* `weather-card`
* `browser_mod` (Necessario per il funzionamento dei popup)
* `layout-card` (Necessario per la visualizzazione delle Sezioni)
* `button-card` (Necessario per il popup di aggiunta evento)

### 2. Il Backend (La Mente)

1. Apri il tuo file `configuration.yaml` in Home Assistant.
2. Assicurati di aver aggiunto questa riga sotto `homeassistant:` per abilitare i pacchetti:

   ```yaml
   homeassistant:
     packages: !include_dir_named packages
   ```

3. Crea una cartella chiamata `packages` nella directory di configurazione di HA (se non ne hai già una).
4. Scarica [packages/family_calendar.yaml](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/packages/family_calendar.yaml) da questo repository.
5. Metti il file all'interno della tua cartella `packages/`.
6. **Riavvia Home Assistant**.

### 3. I Calendari

Puoi usare **Google Calendars** oppure **Calendari Locali**.

#### Opzione A: Calendario Locale (La più semplice)

Nota: questo non è stato testato dato che uso esclusivamente Google Calendars

1. Vai su **Impostazioni > Dispositivi & Servizi**.
2. Aggiungi l'integrazione **Local Calendar**.
3. Crea calendari con questi nomi esatti: `Alice`, `Bob`, `Charlie`, `Daisy`, `Family`.
    * *Se usi questi nomi, il codice funziona subito!*

#### Opzione B: Google Calendar

1. Apri `packages/family_calendar.yaml`.
2. Scorri fino allo script `add_google_calendar_event`.
3. Aggiorna la voce `calendar_map` puntando alle tue vere entità Google:

    ```yaml
    calendar_map:
      "Alice": "calendar.alice_gmail_com"
      "Bob": "calendar.bob_work_account"
    ```

#### Impostazione delle Festività

A seguito degli aggiornamenti di Home Assistant, le festività ora si aggiungono tramite interfaccia grafica:

1. Vai su **Impostazioni > Dispositivi e Servizi > Aggiungi Integrazione > Holiday**.
2. Seleziona il tuo paese.
3. Controlla l'ID dell'entità (es. `calendar.holidays`). Se è diverso da quello predefinito, aggiornalo nello YAML della dashboard.

### 4. La Dashboard (L’Aspetto)

1. Crea una nuova Vista Dashboard (Imposta Tipo Vista su **Sezioni**).
2. Copia il codice da [dashboard.yaml](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/dashboard.yaml).
3. **Personalizza:**
   * **Cerca & Sostituisci:** Sostituisci `person.alice` con le entità reali dei membri della tua famiglia.
   * **Meteo:** Sostituisci `weather.home` con il tuo provider meteo.
   * **Sfondo:** Aggiorna l’URL dell’immagine in fondo allo yaml.

### Passaggio 5: Il Tema (Opzionale)

Per ottenere l’aspetto del font specifico (Ovo):

1. Assicurati che nel tuo `configuration.yaml` sia presente questa riga sotto `frontend:`

   ```yaml
   frontend:
     themes: !include_dir_merge_named themes
   ```

2. Crea una cartella chiamata `themes` nella tua directory di configurazione.
3. Scarica [themes/skylight.yaml](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/themes/skylight.yaml) e posizionalo in quella cartella.
4. Riavvia Home Assistant.
5. Vai al tuo Profilo (icona utente in basso a sinistra) e cambia il **Tema** in `Skylight`.
NOTA: Il tema non è esaustivo, quindi tienilo presente

---

## 📐 Come Funziona (Dietro le quinte)

### Logica di Filtraggio

La `week-planner-card` non supporta nativamente la possibilità di nascondere calendari specifici al volo. Per risolvere questo, ho usato **Input Texts** che agiscono come filtri Regex.

* Quando clicchi sul pulsante di una persona, il filtro viene alternato tra `.*` (Mostra tutto) e `^$` (Non mostra nulla).
* La `config-template-card` inietta dinamicamente queste variabili nella scheda calendario.

### Script di Creazione Evento

Il popup "Aggiungi Evento" utilizza un unico script che gestisce la logica per più persone e tipi di evento (Tutto il giorno vs Orario specifico).

```yaml
# Simplified Logic Example
target_calendar: "{{ calendar_map.get(states('input_select.calendar_select')) }}"

choose:
  - conditions: "All Day Event is ON"
    action: calendar.create_event (start_date, end_date)
  - conditions: "All Day Event is OFF"
    action: calendar.create_event (start_date_time, end_date_time)
```

## NOTE

Il mio post originale aveva solo lo scopo di fornire una panoramica generale su come procedere e permettere alle persone di adattare il codice alle proprie esigenze specifiche.

In particolare, ho fatto questo perché ogni display e ogni esigenza sono diversi. Non posso sviluppare per tutte le dimensioni possibili di display, dashboard, ecc. Quindi è stato costruito per funzionare con il display che ho menzionato o con qualsiasi altro (1920x1080), ma dovrebbe essere modificabile per altri.

Parlando di display, inizialmente ho suggerito quello perché era in offerta su Woot ed era un modo molto economico per ottenere un display touchscreen all’epoca. Ora potrebbe non essere più così, quindi usa qualsiasi display funzioni per te. Tablet, touchscreen, telefono, qualunque cosa. La cosa principale che dovrai modificare è la dashboard.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-14

---