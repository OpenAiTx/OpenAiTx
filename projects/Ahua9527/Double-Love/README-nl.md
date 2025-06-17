# Double Love

<div align="center">

[![GitHub license](https://img.shields.io/github/license/Ahua9527/Double-Love)](https://github.com/Ahua9527/Double-Love/blob/main/LICENSE)
![GitHub stars](https://img.shields.io/github/stars/Ahua9527/Double-Love)

🎬 Liefde tussen frames, dubbele efficiëntie

[//]: # (Easter egg verstopt in de code)
<!Double Love：Laat elk shot mijn onuitgesproken frame rate verbergen -->

[English](./README.en.md) · 简体中文 · [Online demo](https://double-love.ahua.space)

</div>

Double Love biedt geautomatiseerde en gestandaardiseerde verwerking van metadata voor script supervisors. Ondersteunt offline gebruik. Door batchverwerking en lokale verwerking wordt naadloze integratie met Adobe Premiere, Silverstack en DTG Slate gerealiseerd om metadata consistentie te garanderen. Verhoogt de efficiëntie van de postproductieworkflow aanzienlijk.

## ✨ Functies

- 🎬 Ondersteuning voor filmindustrie workflows
- 📝 Slimme normalisatie van metadata
- ⚡ Directe lokale verwerking zonder vertraging
- 🧩 Naadloze integratie met Adobe Premiere

## 🚀 Snel aan de slag

### Basisworkflow

1. Script supervisor registratie: gebruik DTG Slate om interactieve script supervisor sheets te genereren
2. Gegevensbeheer: importeer script supervisor data via Silverstack Lab
3. Exporteren van bestanden: genereer Adobe Premiere Pro XML
4. Gestandaardiseerde verwerking: optimaliseer slim met Double Love

Voorbeeld:
- Invoer-xml: `UnitA_304_20250127.xml`
- Uitvoer-xml: `UnitA_304_20250127_Double_LOVE.xml`

### Gedetailleerd voorbeeld

#### Bestandsnaam optimalisatie
- Het programma verwerkt automatisch de formaten van scenenummer, shotnummer en take-nummer
- Voegt automatisch voorloopnullen toe aan cijfers
- Verwerkt automatisch hoofdlettergebruik
- Verwijdert automatisch overtollige underscores

#### Clipnaam regels

De verwerkte clipnaam volgt het volgende formaat:
```
{projectprefix}{scene}_{shot}_{take}{camera}{rating}
```

- `prefix`: Aangeprefereerde prefix (optioneel)
- `scene`: Scenenummer (3 cijfers, bijv. 001)
- `shot`: Shotnummer (2 cijfers, bijv. 01)
- `take`: Take-nummer (2 cijfers, bijv. 01)
- `camera`: Cameracode (kleine letter, bijv. a)
- `Rating`: Waardering (ok/kp/ng)

#### Waarderingsverwerking
- `Circle` → `ok`
- `KEEP` → `kp`
- `NG` → `ng`

#### DIT Informatie
- Voegt automatisch DIT-informatie toe: 'DIT: 哆啦Ahua 🌱'
- Indien verwijderen gewenst, graag zelf aanpassen😁😁

#### Voorbeeld aangepaste prefix

1. Stel prefix in op "PROJECT_A_":
   - Invoerbestand: `A304C007_250123G3`
   - Uitvoerbestand: `PROJECT_A_004_01_07a_kp`

2. Geen prefix ingesteld:
   - Invoerbestand: `A304C007_250123G3`
   - Uitvoerbestand: `004_01_07a_kp`

#### Voorbeeld sequentieresolutie-instelling

1. FHD-resolutie (standaard):
   - Breedte: 1920
   - Hoogte: 1080   
2. DCI 2K-resolutie (aangepast):
   - Breedte: 2048
   - Hoogte: 1080   

#### Voorbeeld batchverwerking

1. Upload meerdere bestanden tegelijk:
   ```
   UnitA_304_20250123.xml
   UnitA_305_20250124.xml
   UnitA_306_20250125.xml
   ```

2. Na verwerking ontvangt u:
   ```
   UnitA_304_20250123_Double_LOVE.xml
   UnitA_305_20250124_Double_LOVE.xml
   UnitA_306_20250125_Double_LOVE.xml
   ```

## 🛠️ Technologiestack

- React 18
- TypeScript
- Vite
- Tailwind CSS
- Lucide Icons
- PWA Support

## 📦 Installatie en gebruik

1. Project klonen

```bash
git clone https://github.com/Ahua9527/Double-Love.git
cd Double-Love
```

2. Afhankelijkheden installeren

```bash
npm install
```

3. Lokale ontwikkeling

```bash
npm run dev
```

4. Project bouwen

```bash
npm run build
```

## 🔒 Veiligheidsinformatie

- Alle bestandsverwerking gebeurt lokaal in de browser, er wordt niets geüpload naar de server
- Ondersteunt een maximale bestandsgrootte van 50MB
- Alleen XML-bestanden worden ondersteund

## 🌈 Ontwikkelaarsinformatie

### Projectstructuur

```
Double-Love/
├── src/
│   ├── components/     # React componenten
│   ├── context/        # React Context
│   ├── utils/          # Hulpfuncties
│   ├── styles/         # Stylesheets
│   └── App.tsx         # Hoofdapplicatiecomponent
├── public/             # Statische bestanden
└── ...configuratiebestanden
```

## 📃 Licentie

[MIT License](LICENSE)

## 🤝 Richtlijnen voor bijdragen

Issues en Pull Requests zijn van harte welkom!

## 👨‍💻 Auteur

哆啦Ahua🌱

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-17

---