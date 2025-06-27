# Gemini CLI

[![Gemini CLI CI](https://github.com/google-gemini/gemini-cli/actions/workflows/ci.yml/badge.svg)](https://github.com/google-gemini/gemini-cli/actions/workflows/ci.yml)

![Gemini CLI Screenshot](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/assets/gemini-screenshot.png)

Deze repository bevat de Gemini CLI, een command-line AI workflow-tool die verbinding maakt met je
tools, je code begrijpt en je workflows versnelt.

Met de Gemini CLI kun je:

- Grote codebases opvragen en bewerken, binnen en buiten Gemini's 1M token contextvenster.
- Nieuwe apps genereren vanuit PDF's of schetsen, met behulp van Gemini's multimodale mogelijkheden.
- Operationele taken automatiseren, zoals pull requests opvragen of complexe rebases uitvoeren.
- Tools en MCP-servers gebruiken om nieuwe mogelijkheden toe te voegen, waaronder [mediageneratie met Imagen,
  Veo of Lyria](https://github.com/GoogleCloudPlatform/vertex-ai-creative-studio/tree/main/experiments/mcp-genmedia)
- Je zoekopdrachten onderbouwen met de [Google Search](https://ai.google.dev/gemini-api/docs/grounding)
  tool, ingebouwd in Gemini.

## Snelstart

1. **Vereisten:** Zorg ervoor dat je [Node.js versie 18](https://nodejs.org/en/download) of hoger hebt geïnstalleerd.
2. **Start de CLI:** Voer het volgende commando uit in je terminal:

   ```bash
   npx https://github.com/google-gemini/gemini-cli
   ```

   Of installeer het met:

   ```bash
   npm install -g @google/gemini-cli
   gemini
   ```

3. **Kies een kleurthema**
4. **Authenticeren:** Meld je aan met je persoonlijke Google-account wanneer hierom wordt gevraagd. Hiermee krijg je tot 60 modelaanvragen per minuut en 1.000 modelaanvragen per dag via Gemini.

Je bent nu klaar om de Gemini CLI te gebruiken!

### Voor geavanceerd gebruik of verhoogde limieten:

Als je een specifiek model wilt gebruiken of meer aanvragen wilt doen, kun je een API-sleutel gebruiken:

1. Genereer een sleutel via [Google AI Studio](https://aistudio.google.com/apikey).
2. Stel deze in als een omgevingsvariabele in je terminal. Vervang `YOUR_API_KEY` door jouw gegenereerde sleutel.

   ```bash
   export GEMINI_API_KEY="YOUR_API_KEY"
   ```

Voor andere authenticatiemethoden, waaronder Google Workspace-accounts, zie de [authenticatie](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/cli/authentication.md) gids.

## Voorbeelden

Als de CLI draait, kun je beginnen met het interactief gebruiken van Gemini vanuit je shell.

Je kunt een project starten vanuit een nieuwe directory:

```sh
cd nieuw-project/
gemini
> Schrijf een Gemini Discord-bot die vragen beantwoordt met behulp van een FAQ.md-bestand dat ik zal aanleveren
```

Of werken met een bestaand project:

```sh
git clone https://github.com/google-gemini/gemini-cli
cd gemini-cli
gemini
> Geef me een samenvatting van alle wijzigingen die gisteren zijn doorgevoerd
```

### Volgende stappen

- Leer hoe je kunt [bijdragen of bouwen vanaf de bron](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/CONTRIBUTING.md).
- Ontdek de beschikbare **[CLI Commando's](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/cli/commands.md)**.
- Als je problemen ondervindt, bekijk dan de **[Probleemoplossingsgids](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/troubleshooting.md)**.
- Voor meer uitgebreide documentatie, zie de [volledige documentatie](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/index.md).
- Bekijk enkele [populaire taken](#populaire-taken) voor meer inspiratie.

### Probleemoplossing

Raadpleeg de [probleemoplossingsgids](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/troubleshooting.md) als je problemen ondervindt.

## Populaire taken

### Een nieuwe codebase verkennen

Begin door met `cd` naar een bestaande of nieuw-gekloneerde repository te gaan en voer `gemini` uit.

```text
> Beschrijf de belangrijkste onderdelen van de architectuur van dit systeem.
```

```text
> Welke beveiligingsmechanismen zijn er aanwezig?
```

### Werken met je bestaande code

```text
> Implementeer een eerste concept voor GitHub issue #123.
```

```text
> Help me deze codebase migreren naar de nieuwste versie van Java. Begin met een plan.
```

### Je workflows automatiseren

Gebruik MCP-servers om je lokale systeemtools te integreren met je enterprise samenwerkingssuite.

```text
> Maak een slide deck met de githistorie van de afgelopen 7 dagen, gegroepeerd op feature en teamlid.
```

```text
> Maak een full-screen webapp voor een wanddisplay om onze meest bekeken GitHub-issues te tonen.
```

### Interactie met je systeem

```text
> Converteer alle afbeeldingen in deze directory naar png en hernoem ze met datums uit de exif-gegevens.
```

```text
> Organiseer mijn PDF-facturen per uitgavenmaand.
```

## Servicevoorwaarden en Privacyverklaring

Voor details over de servicevoorwaarden en privacyverklaring die van toepassing zijn op jouw gebruik van Gemini CLI, zie de [Servicevoorwaarden en Privacyverklaring](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/tos-privacy.md).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---