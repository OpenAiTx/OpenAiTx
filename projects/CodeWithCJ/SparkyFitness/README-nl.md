# SparkyFitness - Zelfgehost alternatief voor MyFitnessPal

SparkyFitness is een uitgebreide applicatie voor fitnessregistratie en -beheer, ontworpen om gebruikers te helpen hun voeding, oefeningen en lichaamsmetingen bij te houden. Het biedt tools voor dagelijkse voortgangsregistratie, het stellen van doelen en inzichtelijke rapportages ter ondersteuning van een gezonde levensstijl.


## ✨ Functies

### 🍎 Voedingsregistratie

* **Log je dagelijkse maaltijden**
* **Maak en beheer aangepaste voedingsmiddelen en categorieën**
* **Bekijk samenvattingen en analyseer trends met interactieve grafieken**

### 💪 Oefeningregistratie

* **Registreer je trainingen**
* **Blader door en zoek in een uitgebreide oefeningsdatabase**
* **Volg je fitnessvoortgang in de tijd**

### 💧 Waterinname Monitoren

* **Volg dagelijkse hydratatiedoelen**
* **Eenvoudige, snelle waterregistratie**

### 📏 Lichaamsmetingen

* **Registreer lichaamsstatistieken** (bijv. gewicht, taille, armen)
* **Voeg aangepaste meettypes toe**
* **Visualiseer voortgang via grafieken**

### 🎯 Doelstellingen Instellen

* **Stel en beheer fitness- en voedingsdoelen**
* **Volg voortgang in de tijd**

### 🗓️ Dagelijkse Check-Ins

* **Monitor dagelijkse activiteit**
* **Blijf consequent met gewoonteregistratie**

### 🤖 AI Voedingscoach (SparkyAI)

* **Log voeding, oefening, lichaamsstatistieken en stappen via chat**
* **Upload voedselafbeeldingen om maaltijden automatisch te registreren**
* **Inclusief chatgeschiedenis en persoonlijke begeleiding**

### 🔒 Gebruikersauthenticatie & Profielen

* **Veilig inlogsysteem**
* **Schakel tussen gebruikersprofielen**
* **Ondersteuning voor gezinsbeheer en toegang**

### 📊 Uitgebreide Rapportages

* **Genereer samenvattingen voor voeding en lichaamsmetingen**
* **Volg langetermijntrends over weken of maanden**

### 🎨 Aanpasbare Thema's

* **Schakel tussen licht- en donkermodus**
* **Ontworpen met een minimale, afleidingsvrije interface**

### Hulp Nodig?
* **Word lid van discord**
  https://discord.gg/vcnMT5cPEA
* **Plaats een bericht in de discussie**


![image](https://github.com/user-attachments/assets/ccc7f34e-a663-405f-a4d4-a9888c3197bc)


## 🚀 Aan de slag

Om de SparkyFitness-applicatie op je lokale machine te laten draaien, volg je deze stappen:

### Vereisten

*   **Supabase Project**: Je hebt een Supabase-project nodig dat is opgezet.
    *   **Maak een nieuw project aan op Supabase**: Ga naar [Supabase](https://app.supabase.com/) en maak een nieuw project aan. (Je kunt ook proberen een lokaal Supabase-project op te zetten indien gewenst.)
    *   Verkrijg je Supabase Project URL en Anon Key vanuit je projectinstellingen (API-sectie).
    *   **Belangrijke Opmerking over Supabase Authenticatie:** Werk je URL-configuratie bij in de Supabase Authenticatie-instellingen zodat deze overeenkomt met je domein. Dit is cruciaal voor het functioneren van je domein en het ontvangen van e-mailuitnodigingen voor aanmelding. Supabase biedt uitgebreide beveiligingsopties en third-party SSO; configureer deze naar de behoeften van je project.
    *   Geautomatiseerde DB-deployment naar Supabase werkt niet met IPV4 als je de gratis versie van Supabase gebruikt. Je moet daarom je netwerk instellen op een IPV6-verbinding. Anders zal de DB-migratie mislukken en moet je handmatig deployen.       


    

### Installatie

1.  **Configureer Omgevingsvariabelen:**
    Maak een `.env`-bestand aan in de private map. Als je Portainer gebruikt, maak het bestand daar direct aan.
    Voeg je Supabase-gegevens toe:
    ```
    VITE_SUPABASE_URL="JOUW_SUPABASE_PROJECT_URL"
    VITE_SUPABASE_ANON_KEY="JOUW_SUPABASE_ANON_KEY"
    SUPABASE_PROJECT_REF="JOUW_SUPABASE_PROJECT_REF"    
    ```

2.  **Draaien met Docker Compose:**
    Haal de Docker-images op en start de services:
    ```sh
```markdown
    docker compose pull
    docker compose up -d
    ```

3.  **Toegang tot de Applicatie:**
    Zodra de services actief zijn, kun je SparkyFitness openen in je webbrowser op:
    ```
    http://localhost:3000
    ```

4.  **AI Chatbot - Optionele Configuratie:**
    Om de volledige functionaliteit van de AI Chatbot mogelijk te maken, inclusief veilige API-sleutelopslag en database-toegang, volg je deze stappen:

    *   **Configureer `AI_API_ENCRYPTION_KEY`:** Genereer een geheim in "Supabase -> Edge Functions" -> "Environment Variables". Deze sleutel wordt gebruikt voor het versleutelen van je AI-sleutels wanneer deze binnen Supabase worden opgeslagen.

    *   **Genereer `SUPABASE_ACCESS_TOKEN`:**
        1.  Open je Docker-console.
        2.  Voer `supabase login` uit en authenticeer via de opgegeven URL.
        3.  Haal het toegangstoken op door `cat ~/.supabase/access-token` uit te voeren.
        4.  Werk je `docker-compose.yml` of Portainer-configuratie bij met dit token om opnieuw te deployen.
        5.  Na herdeploy, log in bij SparkyFitness en configureer de AI-service met je gewenste provider.
     

### Handmatige Deploy van DB & Functies naar Supabase
**Methode 1:  
**Als je geen IPV6-netwerkverbinding hebt ingeschakeld, zal DB-migratie mislukken omdat de gratis versie van Supabase geen directe IPV4-verbinding ondersteunt.

   1. Download de laatste release en pak deze uit op je PC.
   2. Navigeer naar de projectmap. Docker moet actief zijn.
   3. Voer onderstaande commando's uit. (functions deploy is alleen nodig voor AI-configuratie. Als je geen ChatBOT nodig hebt, kun je deze stap overslaan)
``
      supabase login  
      supabase link  
      supabase db push  
      supabase functions deploy chat   
``
Herstart Docker compose. De frontend-app zal beginnen te werken.

**Methode 2:  
   1. Download de laatste release en pak deze uit op je PC.  
   2. Navigeer naar de projectmap.  
   3. Ga naar supabase/migrations. Kopieer de SQL-statements en voer ze één voor één uit in Supabase-->Project-->SQL Editor in ASC-volgorde.  
   4. [Optioneel] Doe hetzelfde voor supabase/functions/chat als je een AI ChatBOT nodig hebt. Kopieer index.js en voer deze uit in Supabase-->Project-->Edge Function-->Deploy new function.  
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-04

---