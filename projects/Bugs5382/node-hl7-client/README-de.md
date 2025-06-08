# Node HL7 Client

> Ein reiner TypeScript HL7-Client für Node.js, der nahtlose Kommunikation mit HL7-Servern ermöglicht.

`node-hl7-client` ist eine leichtgewichtige, abhängigkeitsfreie Bibliothek, die für eine leistungsstarke Kommunikation mit HL7-Brokern/Servern entwickelt wurde. Sie unterstützt das Senden korrekt formatierter HL7-Nachrichten, das Verarbeiten von Antworten sowie das Arbeiten mit einzelnen und gebündelten HL7-Nachrichtenformaten (MSH, BHS und FHS).

## ✨ Funktionen

* ⚡ **Keine externen Abhängigkeiten** – Ultraschnelle Performance ohne Ballast.
* 🔁 **Automatische Wiederverbindung & Wiederholung** – Verbindungsunterbrechungen werden automatisch behandelt.
* 🧠 **TypeScript + Typisierte Definitionen** – Vollständig typisiert für moderne Entwicklungsumgebungen.
* 🤝 **Begleitpaket verfügbar** – Verwenden Sie es zusammen mit [`node-hl7-server`](https://www.npmjs.com/package/node-hl7-server) für eine vollständige HL7-Lösung.
* 💻 **Plattformübergreifende Unterstützung** – Funktioniert unter Windows, macOS und Linux.
* 🧭 **Standardbasiert** – Typisierte Builder stellen sicher, dass MSH-, BHS- und FHS-Segmente den HL7.org-Spezifikationen entsprechen.

## 📦 Installation

```bash
npm install node-hl7-client
```

## 📚 Enthalten

* **HL7-Client** – Verbindet sich mit einem entfernten HL7-Server, sendet Nachrichten und verarbeitet Antworten.
* **HL7-Parser** – Parst rohe HL7-Nachrichtenstrings in zugängliche Segmente.
* **HL7-Builder** – Erstellt gültige HL7-Nachrichten, Batches oder vollständige HL7-Batch-Dateien.

## 🧾 Inhaltsverzeichnis

1. [Begriffsdefinitionen](#keyword-definitions)
2. [Dokumentation](#documentation)
3. [Danksagungen](#acknowledgements)
4. [Lizenz](#license)

## Begriffsdefinitionen

Dieses NPM-Paket ist für medizinische Anwendungen konzipiert, die potenziellen Einfluss auf die Patientenversorgung und Diagnosen haben. Diese Dokumentation sowie das zugehörige Paket [node-hl7-server](https://www.npmjs.com/package/node-hl7-server) verwenden die folgenden standardisierten Definitionen zur Klarheit und Interoperabilität:

Begriffe wie **"MUSS"**, **"DARF NICHT"**, **"ERFORDERLICH"**, **"SOLL"**, **"SOLL NICHT"**, **"SOLLTE"**, **"SOLLTE NICHT"**, **"EMPFOHLEN"**, **"KANN"** und **"OPTIONAL"** werden durchgängig in der Dokumentation verwendet. Diese Begriffe behalten ihre Bedeutung auch dann, wenn sie nicht in Großbuchstaben geschrieben sind.

* **MUSS** – Dieses Wort, oder die Begriffe **"ERFORDERLICH"** oder **"SOLL"**, kennzeichnen eine absolute Anforderung der Spezifikation.
* **DARF NICHT** – Dieser Ausdruck, oder der Ausdruck **"SOLL NICHT"**, kennzeichnet ein absolutes Verbot gemäß der Spezifikation.
* **SOLLTE** – Dieses Wort, oder das Adjektiv **"EMPFOHLEN"**, bedeutet, dass es in bestimmten Fällen triftige Gründe geben kann, einen Punkt zu ignorieren, die vollen Konsequenzen aber verstanden und sorgfältig abgewogen werden müssen.
* **SOLLTE NICHT** – Dieser Ausdruck, oder der Ausdruck **"NICHT EMPFOHLEN"**, bedeutet, dass es in bestimmten Fällen triftige Gründe geben kann, wenn das Verhalten akzeptabel oder sogar nützlich ist. Die vollen Konsequenzen sollten verstanden und der Fall sorgfältig abgewogen werden, bevor implementiert wird.
* **KANN** – Dieses Wort, oder das Adjektiv **"OPTIONAL"**, bedeutet, dass der Punkt tatsächlich optional ist. Implementierungen, die eine bestimmte Option nicht enthalten, MÜSSEN trotzdem mit denen interoperabel sein, die sie enthalten, wenn auch möglicherweise mit eingeschränkter Funktionalität. Ebenso MÜSSEN Implementierungen, die eine Option enthalten, mit denen interoperabel sein, die sie nicht enthalten (außer natürlich für das spezifische Merkmal, das die Option bietet).

## 📖 Dokumentation

Vollständige API-Dokumentation, Anwendungsbeispiele und erweiterte Konfigurationen finden Sie auf der Projektseite:
🔗 [https://bugs5382.github.io/node-hl7-client/](https://bugs5382.github.io/node-hl7-client/)

## 🙏 Danksagungen

* [`node-rabbitmq-client`](https://github.com/cody-greene/node-rabbitmq-client) – Inspiration für die Verbindungstechnik.
* [`artifacthealth/hl7parser`](https://github.com/artifacthealth/hl7parser) – Design-Referenz für Parser und Builder.
* Meiner Frau und meiner kleinen Tochter – für ihre Liebe, Geduld und Inspiration.

## 📄 Lizenz

MIT © [LICENSE](LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---