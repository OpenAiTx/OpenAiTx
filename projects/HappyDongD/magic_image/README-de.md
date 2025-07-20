<div align="right">
  <details>
    <summary >🌐 Sprache</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# Magische KI-Bildgenerierung

<div align="right">中文 | <a href="README-EN.md">English</a></div>

[![License](https://img.shields.io/badge/License-Apache%202.0-blue.svg)](https://opensource.org/licenses/Apache-2.0)
[![Next.js](https://img.shields.io/badge/Next.js-14-black.svg)](https://nextjs.org/)
[![TypeScript](https://img.shields.io/badge/TypeScript-5.0-blue.svg)](https://www.typescriptlang.org/)
[![Tailwind CSS](https://img.shields.io/badge/Tailwind%20CSS-3.0-38B2AC.svg)](https://tailwindcss.com/)

Eine auf Next.js basierende KI-Bildgenerierungsanwendung mit folgenden Hauptfunktionen:
- 🎨 Unterstützung mehrerer KI-Modelle (Sora, DALL-E, GPT usw.) und Hinzufügen benutzerdefinierter Modelle
- 🖼️ Text-zu-Bild und Bild-zu-Bild Funktionen, unterstützt Multi-Bild-Referenz und Bereichsbearbeitung
- 🔐 Alle Daten und API-Schlüssel werden lokal gespeichert, um die Privatsphäre zu schützen
- 💻 Unterstützung für Web- und Desktop-App-Paketierung, plattformübergreifend nutzbar

## Online-Erlebnis

Zugriffsadresse: [https://image-front-eight.vercel.app/](https://image-front-eight.vercel.app/)

### Screenshots der Anwendung

<div align="center">
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/4.png" alt="应用截图4" width="800" style="margin-bottom: 20px"/>
      <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/5.png" alt="应用截图4" width="800" style="margin-bottom: 20px"/>
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/0.png" alt="应用截图1" width="800" style="margin-bottom: 20px"/>
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/1.png" alt="应用截图2" width="800" style="margin-bottom: 20px"/>
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/2.png" alt="应用截图3" width="800" style="margin-bottom: 20px"/>
</div>

## Funktionsmerkmale

- 🎨 Unterstützung mehrerer KI-Modelle
  - GPT Sora_Image Modell
  - GPT 4o_Image Modell
  - GPT Image 1 Modell
  - DALL-E 3 Modell
  - 🆕 Benutzerdefinierte Modelle (Unterstützt Hinzufügen privater Modelle)
- ✍️ Text-zu-Bild-Funktion
  - Unterstützung für benutzerdefinierte Prompts
  - Auswahl des Bildverhältnisses möglich
  - Unterstützung verschiedener Bildgrößen
- 🖼️ Bild-zu-Bild-Funktion
  - Unterstützung der Bildbearbeitung
  - Bereichsmaskenbearbeitung möglich
  - Anpassung der Bildqualität
  - Multi-Bild-Referenz (gleichzeitiges Hochladen mehrerer Bilder)
- 🔒 Datensicherheit
  - Alle generierten Bilder und der Verlauf werden nur lokal im Browser gespeichert
  - Unterstützung für benutzerdefinierte API-Proxy-Adressen
  - Unterstützung für API-Key-Konfiguration
- 📱 UI-Design
  - Moderne Benutzeroberfläche
  - Flüssige Interaktion
  - Anzeige im Markdown-Format
  - Code-Highlighting-Unterstützung
- 🖥️ Plattformübergreifende Unterstützung
  - Paketierung als Desktop-Anwendung möglich (Windows, macOS, Linux)
  - Offline-Nutzung möglich (API-Schnittstelle erforderlich)

## Technologiestack

- Next.js 14
- TypeScript
- Tailwind CSS
- shadcn/ui
- React
- Tauri (Desktop-App-Paketierung)

## Lokale Entwicklung

1. Projekt klonen

```bash
git clone https://github.com/HappyDongD/magic_image.git
cd magic_image
```
2. Abhängigkeiten installieren

```bash
npm install
# 或
yarn install
# 或
pnpm install
```
3. Starten des Entwicklungsservers

```bash
npm run dev
# 或
yarn dev
# 或
pnpm dev
```
4. Besuchen Sie [http://localhost:3000](http://localhost:3000)

## Desktop-Anwendungspaketierung

Dieses Projekt verwendet Tauri für das Packen von Desktop-Anwendungen und unterstützt Windows-, macOS- und Linux-Systeme.

### Vorbereitung der Umgebung

Vor dem Packen der Desktop-Anwendung müssen folgende Abhängigkeiten installiert werden:

1. **Rust installieren**:
   - Besuchen Sie [https://www.rust-lang.org/tools/install](https://www.rust-lang.org/tools/install)
   - Folgen Sie den Anweisungen zur Installation von Rust und Cargo

2. **Systemabhängigkeiten**:
   - **Windows**: Installieren Sie [Visual Studio C++ Build Tools](https://visualstudio.microsoft.com/visual-cpp-build-tools/)
   - **macOS**: Installieren Sie die Xcode Command Line Tools (`xcode-select --install`)
   - **Linux**: Installieren Sie die entsprechenden Abhängigkeiten, siehe [Tauri Dokumentation](https://tauri.app/v1/guides/getting-started/prerequisites)

### Entwicklungsmodus


```bash
# 安装 Tauri CLI
npm install -D @tauri-apps/cli

# 启动桌面应用开发模式
npm run tauri:dev
```
### Erstellen von Desktop-Anwendungen


```bash
# 构建桌面应用安装包
npm run desktop
```
Nach dem erfolgreichen Build findest du das Installationspaket für das entsprechende System im Verzeichnis `src-tauri/target/release/bundle`.

## Vercel Deployment

1. Forke dieses Projekt in deinen GitHub-Account

2. Erstelle ein neues Projekt auf [Vercel](https://vercel.com)

3. Importiere dein GitHub-Repository

4. Klicke auf Deploy

## Anleitung zur Nutzung

1. Beim ersten Start muss ein API-Schlüssel konfiguriert werden
   - Klicke oben rechts auf „Schlüssel-Einstellungen“
   - Gib den API-Schlüssel und die Basisadresse ein
   - Klicke auf Speichern
   - Alternativ kann die Konfiguration auch schnell über URL-Parameter erfolgen:

     ```
     http://localhost:3000?url=你的API地址&apikey=你的API密钥
     ```
     例如：
     ```
     http://localhost:3000?url=https%3A%2F%2Fapi.example.com&apikey=sk-xxx
     ```
     Hinweis: Spezielle Zeichen in der URL müssen URL-codiert werden

2. Auswahl des Generierungsmodus
   - Text-zu-Bild: Erzeugt ein Bild anhand einer Textbeschreibung
   - Bild-zu-Bild: Bild hochladen und bearbeiten

3. Generierungsparameter einstellen
   - KI-Modell auswählen (integriertes oder benutzerdefiniertes Modell)
   - Bildseitenverhältnis festlegen
   - Bildqualität anpassen (nur im Bild-zu-Bild-Modus)

4. Verwaltung benutzerdefinierter Modelle
   - Klicken Sie auf das Einstellungssymbol neben dem Modell-Auswahlfeld
   - Neues Modell hinzufügen: Modellname, Modellwert eingeben und Modelltyp wählen
   - Modell bearbeiten: Klicken Sie auf die Bearbeiten-Schaltfläche eines bestehenden Modells
   - Modell löschen: Klicken Sie auf die Löschen-Schaltfläche eines bestehenden Modells
   - Modell auswählen: Klicken Sie auf das Pluszeichen eines Modells, um es sofort zu nutzen

5. Erläuterung der Modelltypen
   - DALL-E Format: Verwendet die Bildgenerierungs-API (/v1/images/generations)
   - OpenAI Format: Verwendet die Chat-API (/v1/chat/completions)

6. Bild generieren
   - Prompt eingeben
   - Auf die Schaltfläche „Bild generieren“ klicken
   - Auf die Fertigstellung warten

7. Bildverwaltung
   - Verlauf ansehen
   - Generierte Bilder herunterladen
   - Bestehende Bilder bearbeiten

## Hinweise

- Alle generierten Bilder und der Verlauf werden nur im lokalen Browser gespeichert
- Nutzung des Inkognito-Modus oder Gerätewechsel führen zu Datenverlust
- Bitte laden Sie wichtige Bilder rechtzeitig herunter und sichern Sie sie
- API-Konfigurationen werden sicher in Ihrem Browser gespeichert und nicht auf den Server hochgeladen
- HTTPS-Websites blockieren das Laden von HTTP-Ressourcen, die App wandelt HTTP-APIs automatisch in HTTPS um

## Beitragshinweise

Issues und Pull Requests zur Verbesserung des Projekts sind willkommen.

## Lizenz

Dieses Projekt steht unter der [Apache License 2.0](https://www.apache.org/licenses/LICENSE-2.0).

Gemäß der Lizenz dürfen Sie:
- ✅ Kommerzielle Nutzung: Sie dürfen die Software kommerziell nutzen
- ✅ Modifikation: Sie dürfen den Quellcode ändern
- ✅ Weiterverbreitung: Sie dürfen die Software verbreiten
- ✅ Private Nutzung: Sie dürfen die Software privat verwenden
- ✅ Patentlizenz: Diese Lizenz enthält auch eine Patentlizenz

Sie müssen jedoch folgende Bedingungen einhalten:
- 📝 Lizenz- und Urheberrechtshinweis: Sie müssen die originale Lizenz und den Copyright-Hinweis beifügen
- 📝 Änderungshinweis: Sie müssen wesentliche Änderungen am Originalcode kenntlich machen
- 📝 Markenhinsweis: Sie dürfen keine Marken der Beitragenden verwenden

---

## Spendieren Sie mir einen Kaffee

Falls Ihnen dieses Projekt geholfen hat, können Sie mir gerne einen Kaffee spendieren ☕️

<div align="center">
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/wechat-pay.jpg" alt="WeChat-Bezahlcode" width="300" />
  <p>Spendieren Sie mir einen Kaffee</p>
</div>

## Kontakt

Wenn Sie Fragen oder Anregungen haben, können Sie mich gerne per WeChat kontaktieren:

<div align="center">
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/wechat-connect.jpg" alt="WeChat-Kontaktinformation" width="300" />
  <p>Scannen Sie den QR-Code, um mich auf WeChat hinzuzufügen</p>
</div>



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---