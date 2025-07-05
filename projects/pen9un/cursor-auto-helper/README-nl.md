<h1 align="center">Welkom bij&nbsp;&nbsp;Cursor Auto Helper 👋</h1>
<p>
  <img alt="Version" src="https://img.shields.io/badge/version-2.3.0-blue.svg?cacheSeconds=2592000" />
  <img alt="License: MIT" src="https://img.shields.io/badge/License-MIT-yellow.svg" />
  <img alt="Cursor Version" src="https://img.shields.io/badge/Cursor-0.48.x%20%E8%87%B3%201.0.0-blue.svg" />
</p>

> Cursor automatische voortzettings-tool, Cursor automatisch opnieuw proberen, Cursor automatisch bevestigen, Cursor gebruiksstatistieken, Cursor verbeterde tools, Cursor hulpprogramma, Cursor automatiseringstool, Cursor thema-instellingen, Cursor Auto Continue Tool, Cursor Auto Retry Tool, Cursor Auto Confirm Tool, Cursor Usage Statistics Tool, Cursor Efficiency Tool, Cursor Automation Tool, Cursor Theme Settings, Cursor after 25 tool calls, Cursor Tool Call Limit🔧🤖🚀
> 

## 🏠 [Homepage](https://github.com/pen9un/cursor-auto-helper)

Cursor Auto Helper is een speciaal voor Cursor IDE ontwikkelde automatiserings- en verbetertool, waarmee je in real-time het gebruik kunt weergeven, automatisch het limiet van 25 gesprekken, netwerkverbindingsfouten, bevestigingsprompts en andere scenario's kunt afhandelen, zodat jouw ontwikkelervaring nog soepeler verloopt.

**Video demonstratie:** [Cursor Auto Helper Demovideo](https://www.bilibili.com/video/BV1cajKzCEzv/)

Als de prompts van hoge kwaliteit zijn en de projectbehoeften goed zijn gepland, kan dit programma Cursor een project volledig automatisch laten voltooien zonder menselijke tussenkomst.

> 🔒 **Versiecompatibiliteit**: Momenteel ontwikkeld en getest op Cursor 0.49.6 en Cursor 1.0.0, theoretisch compatibel met Cursor 0.48.x - 1.0.0.

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/cursor-auto-helper.png" alt="cursor-auto-helper" />

## 📖 Changelog

- 2025-06-01 Versie v2.3 uitgebracht, Cursor thema-instellingen toegevoegd, stabiliteit van code-injectie geoptimaliseerd, gebruiksweergave gecorrigeerd conform officiële opmaak
- 2025-05-21 Versie v2.1 uitgebracht, architectuur herbouwd, multiplatform ondersteuning toegevoegd, real-time gebruiksweergave toegevoegd, etc.
- 2025-04-25 Voltooiing van versie v1.0, automatische afhandeling van limiet van 25 gesprekken, netwerkverbindingsfouten, bevestigingsprompts en andere scenario's
- 2025-04-20 Project gestart

## 🌟 Cursor Auto Helper Best Practices

Let op: onderstaande documentatie kan worden gegenereerd met behulp van AI-hulpmiddelen zoals Cursor, en dient handmatig te worden gecontroleerd en aangepast.

**STAP 1:** Gedetailleerd ontwerp van systeemeisen voor het project (hoe duidelijker de eisen, hoe hoger de projectkwaliteit), schrijf hoogwaardige projectontwikkelingsprompts in **SYSTEM.md**

**STAP 2:** Gebruik **SYSTEM.md** om een hoogwaardige systeemontwikkelingsontwerpdocument **DESIGN.md** te genereren

**STAP 3:** Gebruik **SYSTEM.md** en **DESIGN.md** om een hoogwaardige ontwikkelplanningsdocument **TODOLIST.md** te genereren

**STAP 4:** Gebruik **Cursor Auto Helper**, wijs **SYSTEM.md**, **DESIGN.md**, **TODOLIST.md** toe, gebruik automatische voortzettingsfeedback-prompts zodat Cursor automatisch volgens het ontwikkelplan doorgaat met het project totdat het is voltooid

**Cursor Auto Helper automatische voortzettingsfeedback prompt:**

```
@SYSTEM.md @DESIGN.md @TODOLIST.md Voer de verdere ontwikkeling strikt uit volgens het ontwikkelplan in TODOLIST en werk TODOLIST real-time bij. Na elke voltooide taak moet je mij vragen "Wil je doorgaan?", totdat het project is voltooid en je "Project is voltooid" teruggeeft.
```

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/guide.png" alt="guide" />

## 🚀 Gebruiksaanwijzing

Geef gerust een ster als je het project waardeert. Bij vragen kun je een [Issue](https://github.com/pen9un/cursor-auto-helper/issues) indienen.

### 📝 Toelichting op het configuratiebestand

Het configuratiebestand `config.ini` **is bedoeld voor het aanpassen van geautomatiseerd gedrag** (kan naar wens worden ingesteld en getest), en ondersteunt de volgende configuratie-opties:

#### Basisconfiguratie
```ini
[common]
log_enable = true     # Logboek inschakelen, stel in op false als je geen logboek wilt bijhouden

[cursor]
path = C:\Path\To\Cursor.exe  # Installatiepad van Cursor IDE, het programma zoekt automatisch naar het Cursor-pad, als het niet gevonden wordt, kun je het hier aanpassen
```

#### Automatische actieconfiguratie
Elke automatische actie gebruikt het voorvoegsel `actionnaam.` en ondersteunt de volgende velden:

- `type`: actietype
  - `click`: klik op knop
  - `input_and_submit`: invoeren en verzenden

- `text` / `text_list`: overeenkomende tekstinhoud
  - `text`: enkele tekenreeks
  - `text_list`: meerdere tekenreeksen gescheiden door |, als een van de items op de pagina voorkomt wordt de actie getriggerd

- `button_selector`: CSS-selector van de knop die moet worden aangeklikt (alleen nodig bij `click`)
- `button_text`: tekstinhoud van de knop (optioneel, voor verdere specificatie)
- `input_box_selector`: CSS-selector van het invoerveld (vereist bij `input_and_submit`)
- `input_content`: in te voeren tekst
- `submit_btn_selector`: CSS-selector van de verzendknop
- `delay`: vertraging voor uitvoering van de actie (in milliseconden), handig om te wachten op rendering van de pagina

##### Configuratievoorbeeld
```ini
[auto_actions]
# Automatisch opnieuw proberen bij verbindingsfout
action_retry.type = "click"
action_retry.text = "Connection failed. If the problem persists, please check your internet connection or VPN"
action_retry.button_selector = "div.anysphere-secondary-button"
action_retry.button_text = "Try again"
action_retry.delay = 3000

# na 25 tool calls
action_continue.type = "input_and_submit"
action_continue.text_list = "agent after 25 tool calls"
action_continue.input_box_selector = ".full-input-box.undefined"
action_continue.input_content = "请继续"
action_continue.submit_btn_selector = ".codicon-arrow-up-two"
action_continue.delay = 1000

# Automatisch bevestigen om door te gaan
action_need_continue.type = "input_and_submit"
action_need_continue.text_list = "是否需要|是否继续|需要我|请告诉我"
action_need_continue.input_box_selector = ".full-input-box.undefined"
action_need_continue.input_content = "请继续后续开发，并实时记录更新开发进度"
action_need_continue.submit_btn_selector = ".codicon-arrow-up-two"
action_need_continue.delay = 1000
```

> **Let op:**
> 1. De naam van elke action (zoals `action_retry`, `action_continue`) is aanpasbaar, maar alle veldprefixen van dezelfde action moeten gelijk zijn
> 2. Het is aan te raden om CSS-selectors met de browser devtools te bepalen voor nauwkeurigheid
> 3. Het programma moet opnieuw worden opgestart nadat het configuratiebestand is aangepast om wijzigingen toe te passen

## 🎯 Toepassingsscenario's

### 💼 Lange dialoogontwikkeling
- Automatische afhandeling van de limiet van 25 dialogen, ondersteunt continue lange dialoogontwikkeling, automatische voortzetting van dialoogprocessen, verhoogt ontwikkel-efficiëntie.

### 👥 Onstabiel netwerk
- Automatische detectie van netwerkproblemen, slim opnieuw proberen te verbinden, automatisch herstellen van de dialoog, waarborgt continuïteit in ontwikkeling.

### 🏢 Bevestigingsscenario's
- Slimme herkenning van bevestigingsprompts, automatische afhandeling van bevestigingen, vermindert handmatige tussenkomst.

### 📚 Gebruikmonitoring
- Realtime statistieken van het aantal dialogen, monitoring van Cursor-gebruik, registratie van gebruiksdata, optimalisatie van efficiëntie.

Weergave gebruik in terminal:

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/cursor-auto-helper-1.png" alt="cursor-auto-helper-1" />

Weergave gebruik in Cursor IDE:

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/cursor-auto-helper-logs.png" alt="cursor-auto-helper-logs" />

## 🌟Functiebeschrijving

### 🤖Automatisch doorgaan met lange dialogen
- Automatische afhandeling van de Cursor-limiet van 25 dialogen, ondersteunt meermaals opeenvolgende dialogen.

### 🎨 Automatisch opnieuw proberen te verbinden
- Automatische detectie van netwerkverbindingsfouten, slim opnieuw proberen, realtime monitoring van de verbindingsstatus.

### 📱 Automatische bevestigingsprompts
- Slimme herkenning van verschillende bevestigingsscenario's, automatische afhandeling van bevestigingspop-ups.
- Ondersteunt aanpasbare bevestigingsinhoud en reacties, vermindert handmatige tussenkomst.
- Flexibele regelconfiguratie, passend voor diverse ontwikkelprocessen.

### 🛍️ Gebruikstatistieken
- Realtime telling van het aantal dialogen en gebruik, automatische gegevensregistratie.
- Visualisatie van gebruiksdata, gemakkelijk voor analyse en optimalisatie.
- Ondersteunt gekleurde logweergave in terminal en IDE-gebruikspanel, verhoogt bruikbaarheid.

### 💡 Logsystem
- Loggen op meerdere niveaus (DEBUG/INFO/SUCCESS/WARNING/ERROR/CRITICAL), kleuruitvoer in terminal.
- Logbestanden worden automatisch per datum aangemaakt, ondersteunt bestandsregistratie en drag-and-drop paneelweergave.
- Realtime panelen vergemakkelijken monitoring en terugkijken voor ontwikkelaars.

### 🔒 Versiecompatibiliteit en prestatie-optimalisatie
- Ontwikkeld op basis van Cursor 0.49.6, kernfunctionaliteit volledig getest.
- Geoptimaliseerd voor specifieke versies, voortdurende opvolging van Cursor-versie-updates.
- Hoge stabiliteit, goede compatibiliteit, geschikt voor productieomgevingen.

## 🔮Effectweergave

### 🤖 Automatisch doorgaan met dialogen

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/auto-continue.png" alt="auto-continue" />

### 🚀 Cursor automatisch voltooien programmaweergave

Van projectvereisten tot volledige implementatie, het hele proces zonder handmatige tussenkomst:

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/auto-complete.png" alt="auto-complete" />

## 🤝Auteur

👤 **pen9un**

* Website: https://github.com/pen9un/
* Github: [@pen9un](https://github.com/pen9un)

## ❤️Steun

Als je dit project nuttig vindt, geef dan gerust een gratis ⭐️⭐️

## ✨Star History

[![Star History Chart](https://api.star-history.com/svg?repos=pen9un/cursor-auto-helper&type=Date)](https://star-history.com/#pen9un/cursor-auto-helper&Date)

## 💹 Bezoekstatistieken

![Visitor Count](https://profile-counter.glitch.me/pen9un/count.svg) 


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-05

---