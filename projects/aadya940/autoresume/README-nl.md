<p align="center">
  <img src="https://raw.githubusercontent.com/aadya940/autoresume/main/main_app/frontend/public/autoresume-logo.png" alt="autoResume Logo" title="autoResume Logo" width="180"/>
</p>

<h1 align="center">autoResume</h1>

<p align="center">
  <b>Open‑source cv-bouwer, plak je links, bewerk handmatig en laat AI helpen met het verfijnen, bijwerken en afstemmen van je cv.</b>
</p>

---

### Hoe gebruik je dit?

[Medium Blog Link](https://medium.com/@aadyachinubhai/autoresume-copy-and-paste-links-its-that-simple-8e50e6d155a1)

De blog is verouderd wat betreft de gebruikersinterface en het gebruikte sjabloon.

## Functies

- <b>Eenvoudig Link Importeren:</b> Plak links van websites en bouw snel een PDF-cv.
- <b>Handmatige Editor Inbegrepen:</b> Verfijn of bouw je cv vanaf nul met een ingebouwde code-editor.
- <b>Slimme Suggesties:</b> Deel feedback of nieuwe links, en smartedits helpen je cv te verfijnen en bij te werken.
- <b>Afgestemd op Banen:</b> Plak een functiebeschrijving en ontvang aanbevelingen om je cv af te stemmen.
- <b>LaTeX-kwaliteit:</b> Alle cv’s worden gegenereerd met LaTeX voor een nette, professionele lay-out.
- <b>Directe Voorvertoning:</b> Bekijk je cv direct als PDF.
- <b>Eenvoudig Resetten:</b> Maak je cv in één klik leeg en begin opnieuw.
- <b>Lokaal:</b> Draait volledig op je eigen machine via Docker.

---

## Aan de slag

### Vereisten
- [Docker](https://www.docker.com/get-started)
- [Docker Compose](https://docs.docker.com/compose/)

### Installatie

1. Clone de repository:
   ```bash
   git clone https://github.com/aadya940/autoresume.git
   cd autoresume
   ```
2. Bouw en start de app:
   ```bash
   docker compose up --build
   ```
3. Open de apps:
   
   [_http://localhost:5173_](http://localhost:5173)
---

## Gebruik

1. Open autoResume in je browser.
2. Klik op het :gear: icoon, plak je [GOOGLE API KEY](https://aistudio.google.com/) en je e-mailadres.
3. Plak links naar je professionele informatie (bijv. Github, persoonlijke website, enz.).
4. Voeg optioneel feedback of een link naar een vacature toe voor verdere aanpassing.
5. Klik op <b>Genereer cv</b> en laat de AI de rest doen!

---

## Licentie

Dit project is gelicentieerd onder de Apache 2.0-licentie.

## Bijdragen Gids

### Frontend
- Implementeer React-componenten in de map `frontend/src/components/`
- We gebruiken Chakra UI om componenten te implementeren.
- Importeer en gebruik je componenten in `frontend/src/App.jsx`

### Backend
- Implementeer API-routes in de map `backend/src/routes/`
- Voeg AI-functionaliteit toe in de map `backend/src/ai/`
- We gebruiken de `black` code formatter voor Python-code
- Houd route handlers schoon en logica gescheiden

### Algemene Richtlijnen
- Maak een nieuwe branch voor je feature/fix: `git checkout -b jouw-branch-naam`
- Schrijf duidelijke commit-berichten
- Test je wijzigingen voordat je een PR indient

### Wijzigingen Indienen
1. Maak een Pull Request
2. Vermeld in je PR-beschrijving:
   - Welke wijzigingen je hebt gemaakt
   - Waarom je ze hebt gemaakt
   - Eventuele relevante screenshots of testresultaten
   - Eventuele breaking changes of migratiestappen die nodig zijn

We waarderen je bijdragen en zullen je PR zo snel mogelijk beoordelen!

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-07

---