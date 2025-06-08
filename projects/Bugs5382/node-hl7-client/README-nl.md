# Node HL7 Client

> Een pure TypeScript HL7-client voor Node.js die naadloze communicatie met HL7-servers mogelijk maakt.

`node-hl7-client` is een lichtgewicht, afhankelijkheidsvrije bibliotheek gebouwd voor hoogwaardige communicatie met HL7-brokers/servers. Het ondersteunt het verzenden van correct geformatteerde HL7-berichten, het verwerken van antwoorden en het werken met zowel enkele als gebatchte HL7-berichtindelingen (MSH, BHS en FHS).

## ✨ Functionaliteiten

* ⚡ **Geen Externe Afhankelijkheden** – Ultiem snelle prestaties zonder overbodige ballast.
* 🔁 **Automatisch Herverbinden & Opnieuw Proberen** – Handelt onderbrekingen in de verbinding automatisch af.
* 🧠 **TypeScript + Getypeerde Definities** – Volledig getypeerd voor moderne ontwikkelomgevingen.
* 🤝 **Companion Package Beschikbaar** – Gebruik samen met [`node-hl7-server`](https://www.npmjs.com/package/node-hl7-server) voor een complete HL7-oplossing.
* 💻 **Platformonafhankelijke Ondersteuning** – Werkt op Windows, macOS en Linux.
* 🧭 **Standaardgebaseerd** – Getypeerde builders garanderen dat MSH-, BHS- en FHS-segmenten voldoen aan HL7.org-specificaties.

## 📦 Installeren

```bash
npm install node-hl7-client
```

## 📚 Wat is inbegrepen?

* **HL7 Client** – Maakt verbinding met een externe HL7-server, verzendt berichten en verwerkt antwoorden.
* **HL7 Parser** – Parseert ruwe HL7-berichtstrings naar toegankelijke segmenten.
* **HL7 Builder** – Bouwt geldige HL7-berichten, batches of complete HL7-batchbestanden.

## 🧾 Inhoudsopgave

1. [Definities van Trefwoorden](#keyword-definitions)
2. [Documentatie](#documentation)
3. [Erkenningen](#acknowledgements)
4. [Licentie](#license)

## Definities van Trefwoorden

Dit NPM-pakket is ontworpen ter ondersteuning van medische applicaties met mogelijke impact op patiëntenzorg en diagnoses. Deze documentatie, samen met het bijbehorende pakket [node-hl7-server](https://www.npmjs.com/package/node-hl7-server), gebruikt de volgende gestandaardiseerde definities voor duidelijkheid en interoperabiliteit:

Trefwoorden als **"MOET"**, **"MAG NIET"**, **"VEREIST"**, **"ZAL"**, **"ZAL NIET"**, **"MOETEN"**, **"MOET NIET"**, **"AANBEVOLEN"**, **"MAG"** en **"OPTIONEEL"** worden consequent in de documentatie gebruikt. Deze termen behouden hun betekenis, ook wanneer ze niet met hoofdletters zijn geschreven.

* **MOET** – Dit woord, of de termen **"VEREIST"** of **"ZAL"**, duidt op een absolute vereiste van de specificatie.
* **MAG NIET** – Deze uitdrukking, of de uitdrukking **"ZAL NIET"**, duidt op een absolute verbodenheid volgens de specificatie.
* **MOETEN** – Dit woord, of het bijvoeglijk naamwoord **"AANBEVOLEN"**, betekent dat er in bepaalde omstandigheden geldige redenen kunnen zijn om een bepaald punt te negeren, maar de volledige implicaties moeten worden begrepen en zorgvuldig worden afgewogen alvorens dit te doen.
* **MOET NIET** – Deze uitdrukking, of de uitdrukking **"NIET AANBEVOLEN"**, betekent dat er geldige redenen kunnen zijn in specifieke omstandigheden wanneer het gedrag acceptabel of zelfs nuttig is. De volledige implicaties moeten worden begrepen en de situatie zorgvuldig worden afgewogen voor implementatie.
* **MAG** – Dit woord, of het bijvoeglijk naamwoord **"OPTIONEEL"**, betekent dat het item daadwerkelijk optioneel is. Implementaties die een bepaalde optie niet bevatten MOETEN nog steeds samenwerken met die welke dat wel doen, zij het mogelijk met beperkte functionaliteit. Evenzo MOETEN implementaties die een optie bevatten samenwerken met die welke dat niet doen (behalve uiteraard voor de specifieke functionaliteit die door de optie wordt geleverd).

## 📖 Documentatie

Volledige API-documentatie, gebruiksvoorbeelden en geavanceerde configuraties zijn beschikbaar op de projectsite:
🔗 [https://bugs5382.github.io/node-hl7-client/](https://bugs5382.github.io/node-hl7-client/)

## 🙏 Erkenningen

* [`node-rabbitmq-client`](https://github.com/cody-greene/node-rabbitmq-client) – Inspiratie voor verbindingslogica.
* [`artifacthealth/hl7parser`](https://github.com/artifacthealth/hl7parser) – Ontwerpreferentie voor parser en builder.
* Mijn vrouw en dochtertje – voor hun liefde, geduld en inspiratie.


## 📄 Licentie

MIT © [LICENSE](LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---