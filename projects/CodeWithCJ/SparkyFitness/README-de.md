# SparkyFitness – Selbstgehostete Alternative zu MyFitnessPal

SparkyFitness ist eine umfassende Fitness-Tracking- und Management-Anwendung, die Nutzern hilft, ihre Ernährung, ihr Training und ihre Körpermaße zu überwachen. Sie bietet Werkzeuge zur täglichen Fortschrittsverfolgung, Zielsetzung und aussagekräftigen Berichten, um einen gesunden Lebensstil zu unterstützen.

## ✨ Funktionen

### 🍎 Ernährungstracking

* **Tägliche Mahlzeiten protokollieren**
* **Eigene Lebensmittel und Kategorien erstellen und verwalten**
* **Zusammenfassungen ansehen und Trends mit interaktiven Diagrammen analysieren**

### 💪 Trainingserfassung

* **Workouts aufzeichnen**
* **Umfangreiche Übungsdatenbank durchsuchen und durchsuchen**
* **Fitnessfortschritte im Zeitverlauf verfolgen**

### 💧 Überwachung der Wasseraufnahme

* **Tägliche Hydrationsziele verfolgen**
* **Schnelles, einfaches Wasserprotokollieren**

### 📏 Körpermaße

* **Körpermetriken erfassen** (z.B. Gewicht, Taille, Arme)
* **Eigene Messarten hinzufügen**
* **Fortschritt mit Diagrammen visualisieren**

### 🎯 Zielsetzung

* **Fitness- und Ernährungsziele setzen und verwalten**
* **Fortschritte im Zeitverlauf verfolgen**

### 🗓️ Tägliche Check-Ins

* **Tägliche Aktivität überwachen**
* **Mit Gewohnheitstracking konsequent bleiben**

### 🤖 KI-Ernährungscoach (SparkyAI)

* **Essen, Training, Körperdaten und Schritte per Chat protokollieren**
* **Essensbilder hochladen, um Mahlzeiten automatisch zu erfassen**
* **Beinhaltet Chatverlauf und persönliche Beratung**

### 🔒 Benutzer-Authentifizierung & Profile

* **Sicheres Log-in-System**
* **Zwischen Benutzerprofilen wechseln**
* **Unterstützung für Familienzugang und Verwaltung**

### 📊 Umfassende Berichte

* **Zusammenfassungen für Ernährung und Körpermetriken generieren**
* **Langfristige Trends über Wochen oder Monate verfolgen**

### 🎨 Anpassbare Themes

* **Zwischen hellem und dunklem Modus wechseln**
* **Mit minimaler, ablenkungsfreier Oberfläche gestaltet**

### Brauchen Sie Hilfe?
* **Treten Sie Discord bei**
  https://discord.gg/vcnMT5cPEA
* **Im Forum diskutieren**


![image](https://github.com/user-attachments/assets/ccc7f34e-a663-405f-a4d4-a9888c3197bc)


## 🚀 Erste Schritte

Um die SparkyFitness-Anwendung auf Ihrem lokalen Rechner auszuführen, gehen Sie wie folgt vor:

### Voraussetzungen

*   **Supabase-Projekt**: Sie benötigen ein eingerichtetes Supabase-Projekt.
    *   **Neues Projekt bei Supabase erstellen**: Gehen Sie zu [Supabase](https://app.supabase.com/) und erstellen Sie ein neues Projekt. (Alternativ können Sie auch ein lokales Supabase-Projekt einrichten.)
    *   Holen Sie sich die Supabase-Projekt-URL und den Anon Key aus den Projekteinstellungen (API-Bereich).
    *   **Wichtiger Hinweis zur Supabase-Authentifizierung:** Aktualisieren Sie Ihre URL-Konfiguration in den Supabase-Authentifizierungseinstellungen, sodass sie Ihrer Domain entspricht. Dies ist entscheidend, damit Ihre Domain funktioniert und Sie Einladungs-E-Mails zum Anmelden erhalten. Supabase bietet umfangreiche Sicherheitsfunktionen und Optionen für Single Sign-On (SSO) von Drittanbietern – konfigurieren Sie diese nach den Bedürfnissen Ihres Projekts.
    *   Automatisierte DB-Bereitstellung auf Supabase funktioniert nicht mit IPV4, wenn Sie die kostenlose Version von Supabase nutzen. Sie müssen Ihr Netzwerk auf eine IPV6-Verbindung umstellen. Andernfalls schlägt die Datenbankmigration fehl und Sie müssen sie manuell bereitstellen.


### Installation

1.  **Umgebungsvariablen konfigurieren:**
    Erstellen Sie eine `.env`-Datei im privaten Ordner. Wenn Sie Portainer verwenden, erstellen Sie sie direkt dort.
    Fügen Sie Ihre Supabase-Zugangsdaten hinzu:
    ```
    VITE_SUPABASE_URL="IHRE_SUPABASE_PROJEKT_URL"
    VITE_SUPABASE_ANON_KEY="IHR_SUPABASE_ANON_KEY"
    SUPABASE_PROJECT_REF="IHRE_SUPABASE_PROJECT_REF"    
    ```

2.  **Mit Docker Compose starten:**
    Docker-Images herunterladen und die Dienste starten:
    ```sh
```markdown
    docker compose pull
    docker compose up -d
    ```

3.  **Zugriff auf die Anwendung:**
    Sobald die Dienste laufen, öffne SparkyFitness in deinem Webbrowser unter:
    ```
    http://localhost:3000
    ```

4.  **KI-Chatbot – Optionale Konfiguration:**
    Um die volle Funktionalität des KI-Chatbots zu aktivieren, einschließlich sicherer API-Schlüssel-Speicherung und Datenbankzugriff, befolge diese Schritte:

    *   **Konfiguriere `AI_API_ENCRYPTION_KEY`:** Erstelle ein Secret unter "Supabase -> Edge Functions" -> "Environment Variables". Dieser Schlüssel wird verwendet, um deine KI-Schlüssel bei der Speicherung in Supabase zu verschlüsseln.

    *   **Generiere `SUPABASE_ACCESS_TOKEN`:**
        1.  Greife auf deine Docker-Konsole zu.
        2.  Führe `supabase login` aus und authentifiziere dich mit der bereitgestellten URL.
        3.  Rufe das Zugriffstoken mit `cat ~/.supabase/access-token` ab.
        4.  Aktualisiere deine `docker-compose.yml` oder die Portainer-Konfiguration mit diesem Token, um neu zu deployen.
        5.  Nach dem Redeployment melde dich bei SparkyFitness an und konfiguriere den KI-Dienst mit deinem bevorzugten Anbieter.
     

### Manuelle Bereitstellung von DB & Funktionen zu Supabase
**Methode 1:**  
**Falls du keine IPV6-Netzwerkverbindung aktiviert hast, wird die DB-Migration fehlschlagen, da die kostenlose Version von Supabase keine direkte IPV4-Verbindung unterstützt.**

   1. Lade das neueste Release herunter und entpacke es auf deinem PC.
   2. Navigiere in den Projektordner. Docker muss laufen.
   3. Führe die folgenden Befehle aus. (Das Bereitstellen der Funktionen ist nur für die KI-Konfiguration erforderlich. Falls du keinen ChatBOT benötigst, kannst du diesen Schritt überspringen)
``
      supabase login  
      supabase link  
      supabase db push  
      supabase functions deploy chat   
``
Starte Docker Compose erneut. Die Frontend-App wird dann funktionieren.

**Methode 2:**  
   1. Lade das neueste Release herunter und entpacke es auf deinem PC.  
   2. Navigiere in den Projektordner.  
   3. Gehe zu supabase/migrations. Kopiere die SQL-Anweisungen und führe sie nacheinander in Supabase --> Projekt --> SQL Editor in aufsteigender Reihenfolge aus.  
   4. [Optional] Wiederhole dies für supabase/functions/chat, falls du den KI-ChatBOT benötigst. Kopiere die index.js und führe sie in Supabase --> Projekt --> Edge Function --> Neue Funktion bereitstellen aus.  
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-04

---