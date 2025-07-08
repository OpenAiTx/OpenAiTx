# Spegel – Reflecteer het web via AI

Herschrijft automatisch websites naar markdown, geoptimaliseerd voor weergave in de terminal.
Lees de introductieblogpost [hier](https://simedw.com/2025/06/23/introducing-spegel/)

Dit is een proof-of-concept, bugs zijn te verwachten, maar voel je vrij om een issue of pull request in te dienen.

## Screenshot
Soms wil je niet iemands hele levensverhaal lezen om bij een recept te komen
![Recept Voorbeeld](https://simedw.com/2025/06/23/introducing-spegel/images/recipe_example.png)


## Installatie

Vereist Python 3.11+

```
pip install spegel
```
of kloon de repo en installeer in bewerkbare modus

```bash
# Kloon en ga naar de directory
$ git clone <repo-url>
$ cd spegel

# Installeer afhankelijkheden en de CLI
$ pip install -e .
```

## API-sleutels
Spegel ondersteunt momenteel alleen Gemini 2.5 Flash. Om dit te gebruiken moet je je API-sleutel in de omgeving zetten

```
GEMINI_API_KEY=...
```


## Gebruik

### Start de browser

```bash
spegel                # Start met welkomstscherm
spegel bbc.com        # Open direct een URL
```

Of, equivalent:

```bash
python -m spegel      # Start met welkomstscherm
python -m spegel bbc.com
```

### Basisbediening
- `/`         – URL-invoer openen
- `Tab`/`Shift+Tab` – Links doorlopen
- `Enter`     – Geselecteerde link openen
- `e`         – LLM-prompt voor huidige weergave bewerken
- `b`         – Teruggaan
- `q`         – Afsluiten

## Instellingen bewerken

Spegel laadt instellingen uit een TOML-configuratiebestand. Je kunt weergaven, prompts en UI-opties aanpassen.

**Zoekvolgorde configuratiebestand:**
1. `./.spegel.toml` (huidige directory)
2. `~/.spegel.toml`
3. `~/.config/spegel/config.toml`

Om instellingen te bewerken:
1. Kopieer het voorbeeldconfiguratiebestand:
   ```bash
   cp example_config.toml .spegel.toml
   # of maak ~/.spegel.toml aan
   ```
2. Bewerk `.spegel.toml` in je favoriete editor.

Voorbeeldfragment:
```toml
[settings]
default_view = "terminal"
app_title = "Spegel"

[[views]]
id = "raw"
name = "Raw View"
prompt = ""

[[views]]
id = "terminal"
name = "Terminal"
prompt = "Transformeer deze webpagina tot de perfecte terminal-browse-ervaring! ..."
```

---

Voor meer informatie, bekijk de code of open een issue!

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---