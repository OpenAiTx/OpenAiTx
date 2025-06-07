<picture>
  <source media="(prefers-color-scheme: dark)" srcset="https://raw.githubusercontent.com/velopack/velopack/develop/artwork/velopack-white.svg">
  <img alt="Velopack Logo" src="https://raw.githubusercontent.com/velopack/velopack/develop/artwork/velopack-black.svg" width="400">
</picture>

---

[![Nuget](https://img.shields.io/nuget/v/Velopack?style=flat-square&logo=nuget&logoColor=white)](https://www.nuget.org/packages/Velopack/)
[![Discord](https://img.shields.io/badge/chat-Discord-5865F2?style=flat-square&logo=discord&logoColor=white)](https://discord.gg/M6he8ZPAAJ)
[![Build](https://img.shields.io/github/actions/workflow/status/velopack/velopack/build.yml?branch=develop&style=flat-square&logo=github&logoColor=white)](https://github.com/velopack/velopack/actions)
[![Codecov](https://img.shields.io/codecov/c/github/velopack/velopack?style=flat-square&logo=codecov&logoColor=white)](https://app.codecov.io/gh/velopack/velopack)
[![License](https://img.shields.io/github/license/velopack/velopack?style=flat-square)](https://github.com/velopack/velopack/blob/develop/LICENSE)


Velopack ist ein Installations- und Auto-Update-Framework für plattformübergreifende Anwendungen. Es ist meinungsstark, extrem einfach zu bedienen und benötigt keine Konfiguration. Mit nur einem Befehl können Sie eine installierbare Anwendung erstellen – blitzschnell auch für Ihre Nutzer.

## Funktionen

- 😍 **Keine Konfiguration** – Velopack übernimmt Ihr Compiler-Output und erzeugt Installer, Updates, Delta-Pakete und selbstaktualisierende Portable-Pakete mit nur einem Befehl.
- 🎯 **Plattformübergreifend** – Velopack unterstützt das Paketieren für **Windows**, **OSX** und **Linux**, sodass Sie eine Lösung für alle Ziele verwenden können.
- 🚀 **Automatische Migrationen** – Wenn Sie von anderen bekannten Frameworks (z.B. [Squirrel](https://github.com/Squirrel/Squirrel.Windows)) kommen, kann Velopack Ihre Anwendung automatisch migrieren.
- ⚡️ **Blitzschnell** – Velopack ist in Rust für native Performance geschrieben. Delta-Pakete sorgen dafür, dass Ihr Nutzer nur die Änderungen zwischen den Versionen herunterlädt.
- 📔 **Sprachunabhängig** – Mit Unterstützung für C#, C++, JS, Rust und mehr. Verwenden Sie eine vertraute API für Updates, unabhängig von der Sprache Ihres Projekts.

https://github.com/velopack/velopack/assets/1287295/0ff1bea7-15ed-42ae-8bdd-9519f1033432

## Dokumentation
- 📖 [Dokumentation lesen](https://docs.velopack.io/)
- ⚡ [Schnellstart-Anleitungen](https://docs.velopack.io/category/quick-start)
- 🕶️ [Beispiel-Apps ansehen](https://docs.velopack.io/category/sample-apps)
- 📺 [Website & Demo ansehen](https://velopack.io/)

## Community
- ❓ Stellen Sie Fragen, erhalten Sie Support oder diskutieren Sie Ideen auf [Discord](https://discord.gg/CjrCrNzd3F)
- 🗣️ Melden Sie Fehler oder schlagen Sie Features vor auf [GitHub Issues](https://github.com/velopack/velopack/issues)

## Mitwirken
- 💬 Kommen Sie auf [Discord](https://discord.gg/CjrCrNzd3F), um an Entwicklerdiskussionen teilzunehmen
- 🚦 Lesen Sie unseren [Beitrag-Guide](https://docs.velopack.io/category/contributing)

## Erfahrungsberichte 
Ich habe jetzt meine extern ausgerichtete Anwendung mit Velopack im Einsatz. Ich bin sehr beeindruckt. Es scheint hervorragend zu funktionieren und ist sowohl beim initialen Build als auch beim Upgraden der Software auf dem Rechner des Endnutzers deutlich schneller als Squirrel. Es ist erstaunlich und der beste Installer, den ich in über 30 Jahren Entwicklung verwendet habe. Vielen Dank! Ihr macht großartige Arbeit!
[- Stefan (Discord)](https://discord.com/channels/767856501477343282/767856501477343286/1195642674078830613)

Ich wollte einfach mal ein großes Dankeschön sagen. Ich habe in den letzten Jahren Clowd.Squirrel benutzt, weil Squirrel.Windows für mich nicht funktionierte. Bin heute zufällig wieder in das Repository gegangen, um nach Dokumentation zu suchen, und habe die Veröffentlichung von Velopack entdeckt. Was für eine Überraschung! Es funktioniert fantastisch und ist so viel schneller, wow! Nochmals vielen Dank, die Arbeit, die in Clowd.Squirrel und Velopack geflossen ist, ist überwältigend. Es wird sehr geschätzt.
[- Kizari (Discord)](https://discord.com/channels/767856501477343282/767856501477343286/1200837489640878180)

Ich habe viele Installer-Frameworks benutzt und Velopack ist mit Abstand das Beste. Alles funktioniert wie von Zauberhand: Sie starten den Installer, und die App ist einfach offen und einsatzbereit. Updates werden in etwa 2 Sekunden angewendet und neu gestartet, ohne UAC-Abfragen. Der Prozess zur Erstellung des Installers ist unkompliziert und lässt sich leicht mit Code Signing integrieren, und das Kommandozeilen-Tool macht das Hochladen Ihrer Updater-Dateien einfach. Sie müssen keine separaten Installer-Skripte in irgendeiner seltsamen Sprache schreiben; Sie können alle diese Hooks in Ihre Hauptanwendung integrieren! Der Support ist ebenfalls phänomenal; jedes meiner Anliegen wurde adressiert. Das ist die Zukunft der Desktop-Installer.
[- RandomEngy (Discord)](https://discord.com/channels/767856501477343282/947444323765583913/1200897478036299861)

Ich bin extrem beeindruckt von der Performance von Velopack beim Erstellen von Releases sowie beim Prüfen und Anwenden von Updates. Es ist deutlich schneller als andere Tools. Die vpk CLI ist intuitiv und einfach zu implementieren, selbst bei meiner komplexen Build-Pipeline. Dank Velopack konnte ich meinen Workflow optimieren und wertvolle Zeit sparen. Es ist ein fantastisches Tool, das ich sehr empfehlen kann!
[- khdc (Discord)](https://discord.com/channels/767856501477343282/947444323765583913/1216460920696344576)


---

Powered By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---