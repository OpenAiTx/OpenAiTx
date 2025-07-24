# CCU-Jack

CCU-Jack bietet einen einfachen und sicheren **REST**- und **MQTT**-basierten Zugriff auf die Datenpunkte der Zentrale (CCU) des [Hausautomations-Systems](http://de.wikipedia.org/wiki/Hausautomation) HomeMatic der Firma [eQ-3](http://www.eq-3.de/). Er implementiert dafür das [Very Easy Automation Protocol](https://github.com/mdzio/veap), welches von vielen Programmiersprachen leicht verwendet werden kann, und das [MQTT-Protokoll](https://de.wikipedia.org/wiki/MQTT), welches im Internet-of-Things weit verbreitet ist. Zudem können mit den genannten Protokollen auch Fremdgeräte an die CCU angebungen werden.

Folgende Ziele verfolgt der CCU-Jack:

**Der CCU-Jack soll anderen Applikationen einen einfachen Zugriff auf die Datenpunkte der CCU ermöglichen.** Beispielsweise werden für den Zugriff auf eine CCU mit HM-, HM-Wired- und HM-IP-Geräten insgesamt 9 Netzwerkverbindung, teilweise als Rückkanal und mit unterschiedlichen Protokollen, benötigt. Zudem sind die Netzwerkschnittstellen der CCU unverschlüsselt, wodurch sie nicht in der Firewall der CCU freigeschaltet werden sollten. Der CCU-Jack standardisiert den Zugriff auf alle Geräte und Systemvariablen mit einem einheitlichen Protokoll und über eine verschlüsselte Verbindung.

**Zudem sollen möglichst einfach Fremdgeräte (z.B. WLAN-Steckdosen) an die CCU angebunden und mit dieser automatisiert werden.** Angebundenen Fremdgeräte werden auf der CCU wie originale HM-Geräte dargestellt. Sie können über die Web-UI der CCU genauso bedient und beobachtet werden. Zudem können sie ohne Einschränkungen in CCU-Programmen verwendet werden.

**Mehrere CCUs und andere Automatisierungsgeräte mit MQTT-Server können über den CCU-Jack untereinander vernetzt werden und Wertänderungen austauschen.** Dafür stellt der CCU-Jack eine MQTT-Bridge zur Verfügung. CCUs können auch mit einem MQTT-Server in der Cloud verbunden werden.

Funktional ist der CCU-Jack eine Alternative zum [XML-API Add-On](https://github.com/jens-maus/XML-API). Das XML-API Add-On wird seit längerer Zeit nicht mehr weiter entwickelt und enthält nicht behobene Fehler und Sicherheitslücken. Zudem kann der CCU-Jack die Kombination der zwei Add-Ons [hm2mqtt](https://github.com/owagner/hm2mqtt) und [Mosquitto](https://github.com/hobbyquaker/ccu-addon-mosquitto) ersetzen. Das Add-On hm2mqtt wird ebenfalls seit längerer Zeit nicht mehr weiter entwickelt.

Bezügliche der Anbindung von Fremdgeräten ersetzt der CCU-Jack viele komplizierte und aufwändige Lösungen und bietet gleichzeitig mehr Funktionaliät.

# Anwenderhandbuch

Alle Informationen für Anwender (z.B. Installation, Konfiguration) sind im [**Anwenderhandbuch**](https://github.com/mdzio/ccu-jack/wiki) zu finden. Dies sollte vor der Installation gelesen werden!

# Download

Die offiziell herausgegeben Versionen vom CCU-Jack sind rechts unter [Releases](https://github.com/mdzio/ccu-jack/releases) zu finden.

Vorabversionen, die dem letzten Entwicklungsstand entsprechen, sind unter [Actions](https://github.com/mdzio/ccu-jack/actions) zu finden. Dort einen _Workflow_ auswählen, und dann ist der Download für alle Plattformen unter _Artifacts_ zu finden. Diese Versionen enthalten schon früh neue Funktionalitäten oder Fehlerbehebungen. Allerdings sind sie nicht getestet!

# Umfeld vom CCU-Jack

Im Zusammenhang mit dem CCU-Jack sind weitere Projekt von anderen entstanden:
* [CCU-Jack to HomeAssistant](https://github.com/kaistraube/ccujack_homeassistant) (Anbindung der HomeMatic CCU an HomeAssistant über den CCU-Jack)
* [node-red-contrib-ccu-jack](https://github.com/ptweety/node-red-contrib-ccu-jack) (Anbindung der HomeMatic CCU an Node-RED über den CCU-Jack)
* [ngx-ccu-jack-client](https://github.com/pottio/ngx-ccu-jack-client) (Integration des CCU-Jacks in Angular-Anwendung)

# Entwicklung

## Bauen aus den Quellen

Der CCU-Jack ist in der [Programmiersprache Go](https://golang.org/) geschrieben. Alle Distributionen des CCU-Jacks können sehr einfach und schnell auf allen möglichen Plattformen (u.a. Windows, Linux, MacOS) gebaut werden. Dafür in einem beliebigen Verzeichnis das Git-Repository klonen, oder die Quellen hinein kopieren. Danach in diesem Verzeichnis eine Kommandozeile öffnen, und folgende Befehle eingeben:
```
cd build
go run .
```
In dem Hauptverzeichnis werden dann alle Distributionen gebaut.

Für die Entwicklung bietet sich die Entwicklungsumgebug [Visual Studio Code](https://code.visualstudio.com/) an. Einfach das Hauptverzeichnis öffnen. Die nötigen Extensions werden automatisch zur Installation angeboten.

## Mitwirkung

Mitwirkende sind natürlich gerne gesehen. Sei es für die Dokumentation, das Testen, den Support im [HomeMatic-Forum](https://homematic-forum.de/forum/viewtopic.php?f=41&t=53553), die Fehlerbehebung oder die Implementierung neuer Funktionalität. Für Code-Beiträge ist die Lizenz (GPL v3) zu beachten. Code-Beiträge sollten immer auf einem neuen Branch separat vom `master`-Branch entwickelt werden.

## Autoren

* [Mathias Dz.](https://github.com/mdzio)
* [martgras](https://github.com/martgras) (Raspberry Pi 4, Zertifikatsbehandlung)
* [twendt](https://github.com/twendt) (BIN-RPC für CUxD)
* [Theta Gamma](https://github.com/ThetaGamma) (Docker-Image)

## Lizenz und Haftungsausschluss

Lizenz und Haftungsausschluss sind in der Datei [LICENSE.txt](https://raw.githubusercontent.com/mdzio/ccu-jack/master/LICENSE.txt) zu finden.
