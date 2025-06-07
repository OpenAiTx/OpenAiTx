## ***HAFTUNGSAUSSCHLUSS***

Ich bin **nicht verantwortlich** für jeglichen Missbrauch, Misshandlungen oder unethische Handlungen, die mit den hier aufgeführten Tools oder Methoden begangen werden. **OSINT ist eine neutrale Technik** – jeder kann sie nutzen, und jeder kann zum Ziel werden.

Hinweis: Einige Domains (z.B. `exposed.lol`) könnten abgelaufen sein. Siehe die kuratierte Liste oder alternative Links.

## Vorschläge

Öffne ein [Issue](https://github.com/airborne-commando/OPSEC-OSINT-Tools/issues) für Vorschläge oder Feedback.

## Warum?

Menschen vertrauen dem Internet zu sehr. In der heutigen Welt gibt es praktisch keinen Unterschied zwischen online und offline – Wahrheit und Fiktion verschwimmen. Diese README existiert, um das Bewusstsein zu schärfen. Klone sie, forke sie, remixe sie oder mache sogar eine [Rentry](https://rentry.co/)-Seite daraus. Verbreite das Wissen, wie du möchtest.

Kann man mit diesen Methoden das Verhalten einer Person vorhersagen? Nicht genau; Menschen sind manchmal unvorhersehbar.

# OSINT/OPSEC Tools

Eine Liste von OSINT/OPSEC-Tools, die ich erstellt, geforkt und/oder verwendet habe. Lassen Sie uns zunächst die Definitionen besprechen.

## Inhaltsverzeichnis
1. [OPSEC](#operations-security-ist-ein-systematischer-prozess-zur)
   - [How to OPSEC](#how-to-opsec)
      - [Smoke Screen und Fehlinformationen](#Smoke-Screen-und-misinfo) 
2. [Open Source Intelligence (OSINT)](#open-source-intelligence-osint)
3. [Wer nutzt Open-Source Intelligence (OSINT)?](#wer-nutzt-open-source-intelligence-osint)
4. [Quellen von OSINT](#quellen-von-osint)
5. [OSINT-Profiling](#digital-profiling-osint-profiling)
6. [Closed Sourced](#closed-sourced-info)
7. [Reale Beispiele für OSINT](#real-world-examples-of-osint)
   - [2016 Luftschlag-Koordination](#in-the-year-2016-a-basket-weaving-image-board-used-osint-to-pay-some-supposed-terrorist-a-vist-from-a-govt-in-russia-resulting-in-airstrikes)
   - [2017 Shia LaBeouf Protest](#in-2017-shia-labeouf-had-a-protest-due-to-trumps-election-this-resulted-in-a-basket-weaving-image-board-using-osint-and-sky-patterns-to-figure-out-where-a-flag-is)
8. [Tools](#tools)
      - [Toolchain-Empfehlungen](#toolchain-recommendations)
9. [Personensuchtools (in den USA)](#people-search-tools-in-the-states)
10. [Graue Literatur](#grey-literature)
11. [Geleakte Daten](#breached-data)
12. [Soziale Medien](#social-media)
13. [Self OSINT](#toolchain-self-osint)
14. [Kuratierten Listen](#curated-lists)
16. [Archivtools](#archive-tools-that-ive-made)

## (Operations Security) ist ein systematischer Prozess zur:
1. Identifizierung
2. Schutz und Kontrolle kritischer Informationen

Es ist eine Sicherheitsdisziplin und eine betriebliche Funktion, die einen kontinuierlichen Zyklus umfasst:
* Identifizierung kritischer Informationen und Indikatoren (CII)
  * Kritische Informationen und Indikatoren sind wesentliche Bestandteile der Operations Security und dienen dem Schutz sensibler Daten, die von Gegnern ausgenutzt werden könnten. Kritische Informationen umfassen nicht klassifizierte oder kontrolliert nicht klassifizierte Informationen über Aktivitäten, Absichten, Fähigkeiten oder Einschränkungen, die Gegnern einen Vorteil verschaffen könnten. Indikatoren sind beobachtbare Aktionen oder Informationsfragmente, die kritische Details über Operationen verraten, wie z.B. plötzliche Verfahrensänderungen oder erhöhte Sicherheitsmaßnahmen. Der Schutz dieser Informationen beinhaltet die Identifizierung von Schwachstellen und die Umsetzung von Gegenmaßnahmen, um eine unbefugte Offenlegung zu verhindern.
* Analyse potenzieller Bedrohungen und Schwachstellen
* Risikobewertung
* Entwicklung von Gegenmaßnahmen zum Schutz der CII

wird verwendet, um Informationen und Aktivitäten vor Gegnern zu schützen. Es hilft, sensible Informationen zu identifizieren und zu schützen, die einem Gegner einen Vorteil verschaffen könnten. OPSEC-Prinzipien können im Alltag angewendet werden, z.B. indem man keine persönlichen Daten wie Geburtsdatum, Adresse, E-Mail oder Telefonnummer teilt.

**Beispiele für OPSEC-Fehler:**
* Zu viele persönliche Informationen online preisgeben
   * [Chris Chan](https://www.youtube.com/playlist?list=PLABqEYq6H3vpCmsmyUnHnfMOeAnjBdSNm)
   * [suspectAGB](https://opsecfail.github.io/blog.html?filecase=suspectAGB)

* Verwaiste Social-Media-Konten online lassen
* Interaktion mit Zielen in sozialen Medien
   * [w0rmer](https://opsecfail.github.io/blog.html?filecase=w0rmer)
   * [darknetdiaries](https://darknetdiaries.com/transcript/63/)

* [Beispiele für gutes und schlechtes OPSEC sowie etwas OSINT.](https://github.com/airborne-commando/OPSEC-OSINT-Tools/blob/main/examples.md)

OPSEC ergänzt andere Sicherheitsdisziplinen, ersetzt sie aber nicht.

### How to OPSEC:

* **Verwenden Sie Dienste, die Ihre Identität verbergen können:**
---

| **Kategorie**                | **Tool/Technik**         | **Beschreibung**                                                              | **Vorteile**                                    | **Nachteile/Einschränkungen**                |
|-----------------------------|--------------------------|-------------------------------------------------------------------------------|------------------------------------------------|----------------------------------------------|
| **Verschlüsselte Messenger**| [Telegram](https://telegram.org/)                | Cloud-basierter Messenger mit optionaler E2E ("Secret Chats")                 | Weit verbreitet, viele Funktionen              | Standardmäßig keine E2E; speichert Daten auf Servern; benötigt Telefonnummer |
|                             | [Simplex](https://simplex.chat/)                 | Keine Nutzerkennungen (nicht einmal Zufallsnummern)                           | Maximale Metadaten-Privatsphäre                | Weniger nutzerfreundlich; kleines Netzwerk   |
|                             | [Signal](https://signal.org/download/)                  | Standardmäßig E2E-verschlüsselt; minimale Metadaten                           | Goldstandard für Privatsphäre; gerichtsresistent| Benötigt Telefonnummer                      |
| **Anonymitätsnetzwerke**    | [Tor](https://www.torproject.org/)                     | Leitet Traffic über verschlüsselte Knoten zur IP-Verschleierung               | Kostenlos; robust gegen Tracking               | Langsam; häufige CAPTCHAs                   |
|                             | [Mullvad VPN](https://mullvad.net/en)             | No-Logs-VPN, akzeptiert Monero (XMR)                                          | Starke Privatsphäre; anonyme Zahlungen         | VPN kann schlechte OPSEC-Gewohnheiten nicht beheben |
| **Kryptowährung**           | [Monero (XMR)](https://www.getmonero.org/)            | Nicht nachverfolgbare Kryptowährung                                           | Private Transaktionen                          | Mining/Node nötig für vollständige Anonymität + Zeit |
| **Identitätsmanagement**    | Einzigartige Benutzernamen | Für jede Seite andere Zugangsdaten                                            | Verhindert Korrelationen                       | Ohne Passwortmanager schwer zu verwalten     |
|                             | Text-Spinner            | Umschreiben von Text zur Erkennungsumgehung                                   | Umgeht Plagiats-/Identitätslinking             | Klingt evtl. unnatürlich                    |
|                             | KI-generierte Gesichter | Gefälschte Profilbilder (z.B. ThisPersonDoesNotExist.com)                     | Verbirgt echte Identität                       | Kann künstlich aussehen                     |
| **Self-OSINT**              | Opt-Out-Anleitungen      | Persönliche Daten bei People-Search-Seiten entfernen                          | Verringert digitalen Fußabdruck                | Zeitaufwändig; nicht alle Seiten akzeptieren Anträge kostenlos |
| **OPSEC-Ressourcen**        | Schlechte OPSEC-Beispiele| [Liste von Fehlern](https://github.com/airborne-commando/OPSEC-OSINT-Tools/blob/main/badopsec.md) | Aus Fehlern anderer lernen                     | N/A                                         |
|                             | Gute OPSEC-Praktiken     | [Leitfaden](https://github.com/airborne-commando/OPSEC-OSINT-Tools/blob/main/good-opsec.md) | Umsetzbare Tipps                               | Erfordert Disziplin                         |
| **Tool-Listen**             | OPSEC Tools              | [Kuratiert](https://github.com/airborne-commando/OPSEC-OSINT-Tools/blob/main/opsec.md) | Umfassende Ressource                           | Muss aktuell gehalten werden                |

---

### **Wichtige Erkenntnisse**  
1. **Messenger**:  
   - **Signal** ODER **Simplex** > **Telegram** für Privatsphäre.  

   - Merke: E2E ≠ totale Anonymität (Metadaten-Leaks/Gewohnheiten zählen).


2. **Anonymität**:  
   - **Tor** + **Mullvad VPN** + **XMR** = mehrschichtiger Schutz.  
   - Vermeide Logins in persönliche Konten während der Nutzung.
   - Fallstrick: TOR und Mullvad getrennt nutzen für maximale Anonymität, nutze eine [Virtuelle Maschine](https://github.com/airborne-commando/OPSEC-OSINT-Tools/blob/main/opsec.md#virtualization) für VPNs und TOR auf einer anderen (oder dem Host).

3. **Identität**:  
   - **Einzigartige Nutzernamen** + **KI-Gesichter** + **Text-Spinner** = schwerer nachzuverfolgen.  

4. **Self-Audit**:  
   - Regelmäßig **Opt-Out** bei Datenbrokern und **OSINT über sich selbst** betreiben.  

5. **OPSEC-Mindset**:  
   - Folge **[guten OPSEC-Regeln](https://github.com/airborne-commando/OPSEC-OSINT-Tools/blob/main/good-opsec.md)** und vermeide **[schlechte Gewohnheiten](https://github.com/airborne-commando/OPSEC-OSINT-Tools/blob/main/badopsec.md)**.


**Hinweis**:

Mit TOR ist der Tor-Browser gemeint, VPN wie Virtuelles Privates Netzwerk (z.B. Mullvad; andere geprüfte Anbieter möglich); XMR ist Monero Coin, eine Privacy Coin.

Siehe Wikipedia für weitere Infos:
1. [VPN](https://de.wikipedia.org/wiki/Virtual_Private_Network)
   - [VPN-Dienst](https://de.wikipedia.org/wiki/VPN-Dienst)
2. [TOR](https://de.wikipedia.org/wiki/Tor_(Netzwerk))
3. [XMR](https://de.wikipedia.org/wiki/Monero)

--- 

### **Profi-Tipps**  
- **Signal-Workaround**: Zur Registrierung eine Wegwerfnummer (z.B. Google Voice) verwenden.    
- **Monero-Mining**: Lokalen Node betreiben, um Nachverfolgung durch Exchanges zu vermeiden.  

Für alle Details siehe die **[OPSEC Tools Liste](https://github.com/airborne-commando/OPSEC-OSINT-Tools/blob/main/opsec.md)**.

## Smoke Screen und Fehlinformationen

Eine Smoke-Screen-Operation im Kontext von OSINT (Open Source Intelligence) bezeichnet gezielte Maßnahmen, um wahre Aktivitäten, Absichten oder Identitäten vor OSINT-Analysten zu verschleiern, zu täuschen oder zu maskieren. Der Begriff stammt aus militärischer Taktik, bei der eine Nebelwand Bewegungen oder Positionen verdeckt. Im Cyber- und Informationsumfeld ist das Konzept auf digitale Umgebungen übertragen. Mehr dazu [hier](https://github.com/airborne-commando/OPSEC-OSINT-Tools/blob/main/smokescreen-misinfo.md).

## Open Source Intelligence (OSINT)

**<div align="center">Was ist das, wie wird es genutzt und warum ist es wichtig:</div>**

- OSINT ist das Sammeln und Analysieren von Informationen aus öffentlichen Quellen zur Erfüllung spezifischer Informationsbedarfe. OSINT wird von Behörden und Unternehmen für verschiedene Zwecke genutzt, darunter:

  - Aufklärung
  - Cybercrime-Ermittlungen
  - Markttrendanalyse
  - Markenpositionierung
  - Risikobewertung für Organisationen
  - Verstehen von Akteuren, Taktiken und Zielen
  - Sammeln von Echtzeitinformationen
  - Informierte Entscheidungen treffen
  - Frühwarnungen zu potenziellen Bedrohungen erhalten

## Wer nutzt Open-Source Intelligence (OSINT)?

- Nationale Sicherheits- und Geheimdienste, Strafverfolgungsbehörden, Unternehmen, Cybersecurity- und Cybercrime-Gruppen, Datenschutzbewusste, NGOs

  - Die CIA, Defense Intelligence Agency (DIA) und das Office of the Director of National Intelligence (ODNI) nutzen OSINT.
  - OSINT kann Bürger (privat oder öffentlich) vor Identitätsdiebstahl, sexueller Gewalt und Missbrauch schützen.
  - OSINT kann Wettbewerber überwachen, neue Märkte untersuchen und Marketingaktivitäten planen.
  - OSINT kann Informationen zu bestimmten Zielen online sammeln.
  - OSINT kann prüfen, wie Außenstehende in eigene Systeme eindringen könnten.
  - OSINT kann zur Selbstüberprüfung für die Privatsphäre genutzt werden.
  - Bellingcat, das Center for Information Resilience und Oryx nutzen OSINT.
  - Und Sie! Ja, auch Sie können OSINT nutzen.

## Quellen von OSINT
OSINT kann Informationen aus verschiedenen Quellen sammeln, darunter:
- [Öffentliche Regierungsdaten](https://www.opendatasoft.com/en/glossary/public-data/)

  - Öffentliche Daten sind alle von Behörden frei zugänglich gemachten Informationen. Sie sind gemeinfrei. Offene Daten sind eine Untermenge davon, strukturiert und gepflegt. Öffentliche Daten können schwer auffindbar sein oder (im Falle von Behörden) eine Anfrage nach dem Informationsfreiheitsgesetz erfordern.

- [Fach- und wissenschaftliche Publikationen](https://www.lawinsider.com/dictionary/academic-publication)

  - Wissenschaftliche Publikationen sind Veröffentlichungen von Abstracts, Artikeln oder Papers in Zeitschriften oder auf Konferenzen/Seminaren.


- [Kommerzielle Daten](https://www.lawinsider.com/dictionary/commercial-data)

  - Kommerzielle Daten sind alle Daten und Informationen zu identifizierten oder identifizierbaren Personen, die Kunden oder Interessenten von Produkten/Dienstleistungen sind oder waren.

- [Graue Literatur](https://browse.welch.jhmi.edu/c.php?g=1195274)

  - Graue Literatur ist "Information auf allen Ebenen von Regierung, Wissenschaft, Wirtschaft und Industrie in elektronischer und gedruckter Form, die nicht von kommerziellen Verlagen kontrolliert wird, d.h. wo das Publizieren nicht die Hauptaufgabe der erstellenden Stelle ist."
   
  - Graue Literatur kann für Recherchen nützlich sein, erfordert aber andere Suchstrategien, da sie oft nicht in gängigen Forschungsdatenbanken indexiert wird.

### Reale Beispiele für OSINT

## Im Jahr 2016 nutzte ein Imageboard OSINT, um angeblichen Terroristen einen [Besuch durch eine russische Regierung zu bescheren, was zu Luftangriffen führte.](https://imgur.com/pol-helps-coordinate-airstrike-on-moderate-syrian-rebels-N7DwWP1)

- [Ein Video zu den Ereignissen](https://www.youtube.com/watch?v=OR6epSP_Xlw)

  - 2016, während des syrischen Bürgerkriegs, versuchten verschiedene Rebellenfraktionen – manche mit guten, manche mit bösen Absichten – Präsident Assad zu stürzen. Das Chaos ermöglichte Terrorgruppen das Wachstum, sodass die USA Rebellen unterstützten und Russland Assad. Ein anonymer Nutzer auf 4chans "Syria General"-Board (SG) behauptete, eine Rebellengruppe habe ein YouTube-Video mit ihrem geheimen Lager gepostet. Die Gruppe, mit Al-Qaida in Verbindung, wurde zum Ziel. Ein bekannter 4chan-Nutzer, Ivan Sirenko, mit Kontakten zum russischen Militär, erhielt die Koordinaten von der Community und tweetete sie ans russische Verteidigungsministerium – was zu einem Luftschlag führte. Zwei Monate später postete die Gruppe erneut ein Video mit einem neuen Lager, das 4chan erneut lokalisierte und Ivan für einen weiteren Luftschlag übermittelte.

UPDATE: Es war ein extrem komplexer Krieg, in den 4chan verwickelt war; das Hauptproblem war, dass die Gruppe ihre Trainingsorte mit Geokoordinaten ins Internet stellte – schlechte OPSEC.

## 2017 hatte Shia LaBeouf einen Protest nach Trumps Wahl; dies führte dazu, dass ein Imageboard OSINT und [Himmelsmuster nutzte, um den Standort einer Flagge zu finden.](https://www.vice.com/en/article/4chan-does-first-good-thing-pulls-off-the-heist-of-the-century1/)

- 2017 gelang es 4chan-Nutzern, Shia LaBeoufs "He Will Not Divide Us"-Protestflagge zu finden und auszutauschen. Nur mit dem Livestream analysierten sie Flugrouten, Sternbilder und einen Tweet, um die Flagge in Greeneville, Tennessee zu orten. Ein lokaler Troll hupte, bis der Ton im Livestream zu hören war – so wurde die exakte Position gefunden. Die Flagge wurde gegen eine Trump-Mütze ausgetauscht.

## Digitales Profiling (OSINT-Profiling). 

Digitales Profiling und Verhaltensanalyse sind mächtige Methoden, um Personen anhand ihrer Online-Aktivitäten und digitalen Spuren zu verstehen. Viele dieser Methoden können Sie auch selbst anwenden, wenn Sie strukturiert vorgehen.

Mehr dazu im [OSINT-Profiling](https://github.com/airborne-commando/OPSEC-OSINT-Tools/blob/main/OSINT-profiling.md)

## Closed Sourced Info

- [HUMINT](https://github.com/airborne-commando/OPSEC-OSINT-Tools/blob/main/HUMINT.md)

**HUMINT kann offen (z.B. Interviews, Befragungen, diplomatische Berichte) oder verdeckt (z.B. Spionage, geheime Überwachung) gesammelt werden.**

**Käufe bei Datenbrokern können als Closed Source gelten, wenn Infos nicht frei verfügbar sind, ES SEI DENN sie werden über die [Kuratierten Listen](#curated-lists) ODER die [Toolchain](#toolchain-self-osint) für Self-OSINT gefunden.**

## Tools

---

| **Kategorie**              | **Tool**                  | **Link**                                                                 | **Funktion**                                                                   | **Einschränkungen/Hinweise**                                                     |
|----------------------------|--------------------------|-------------------------------------------------------------------------|--------------------------------------------------------------------------------|----------------------------------------------------------------------------------|
| **Suchmaschinenabfragen**  | Google-FU                | [GitHub](https://github.com/airborne-commando/GoogleFU-improved)        | Erweiterte Google Dorks für gezielte Suchen                                    | Rate-Limits, evtl. CAPTCHAs                                                      |
| **Biometrische Analyse**   | Facecheck.ID             | [GitHub](https://github.com/vin3110/facecheck.id-results-extractor)     | Reverse-Bildsuche, um Paywalls zu umgehen                                      | Tampermonkey nötig; extrahiert nur Quelllinks                                     |
| **Username/Email-Suche**   | Blackbird                | [GitHub](https://github.com/p1ngul1n0/blackbird)                        | Schnelle plattformübergreifende Username/Email-Suche                           | Nur CLI; leichtgewichtig                                                         |
|                            | Crow (GUI für Blackbird) | [GitHub](https://github.com/airborne-commando/crow)                     | GUI-Version von Blackbird                                                      | Gleiche Funktion wie CLI                                                          |
|                            | Sherlock                 | [GitHub](https://github.com/sherlock-project/sherlock)                  | Umfassende Username-Suche auf 300+ Seiten                                      | False Positives (z.B. Imgur); CLI-basiert                                         |
|                            | No-Shit-Sherlock (GUI)   | [GitHub](https://github.com/airborne-commando/no-shit-sherlock)         | GUI für Sherlock                                                               | Erbt Sherlock-Einschränkungen                                                     |
|                            | Maigret                  | [GitHub](https://github.com/soxoj/maigret)                              | Findet Username-Verbindungen (Sherlock-Fork)                                   | Fokus auf Profil-Verlinkungen                                                      |
|                            | Maigret-Night (GUI)      | [GitHub](https://github.com/airborne-commando/maigret-night)            | GUI für Maigret                                                                | Wie Maigret CLI                                                                  |
|                            | Holehe                   | [GitHub](https://github.com/megadose/holehe)                            | Prüft Email-Nutzung auf vielen Seiten                                          | Imgur False Positives; CLI-basiert                                                |
| **Email-Komprimittierung** | Hudson Rock Extractor    | [GitHub](https://github.com/airborne-commando/hudsonrock-search-extractor)| Manueller Email-Leak-Checker (Flask)                                         | Nicht automatisiert; manuelle Eingabe                                              |
| **Geolokalisierung**       | Google Maps              | [maps.google.com](https://maps.google.com/)                             | Standorte/Orte bestimmen, Landmarken vergleichen                               | Nur öffentliche Daten; keine OSINT-Funktionen                                     |
| **Allgemeines OSINT**      | OSINT Rocks              | [osint.rocks](https://osint.rocks/)                                     | Multi-Tool: Hudson Rock, Holehe, GHunt (Gmail), Telefon/Domain/Username Lookup | Web-basiert; kombiniert mehrere Tools                                             |

---

### **Wichtige Erkenntnisse & Pro-Tipps**

1. **False Positives**:  
   - **Sherlock/Holehe**: Imgur liefert oft falsche Ergebnisse – manuell prüfen.  
   - **Facecheck.ID**: Extrahiert Links, analysiert aber keine Bilder; mit [Pimeyes (10 Suchen)](https://pimeyes.com/en) oder anderen (siehe Punkt 6) abgleichen.

2. **GUI vs. CLI**:  
   - **CLI-Tools (Blackbird, Sherlock, Maigret)**: Schneller, aber technisches Know-how nötig.  
   - **GUI-Wrapper (Crow, No-Shit-Sherlock)**: Einsteigerfreundlich; gleiche Logik.

3. **Email-Untersuchungen**:  
   - Kombiniere **Holehe** (Account-Erkennung) + **Hudson Rock Extractor** (Leak-Daten) für umfassende Überprüfung; siehe [**Toolchain-Empfehlungen**](#Toolchain-Recommendations).  
   - Für Gmail-spezifisches OSINT: **GHunt** (über OSINT Rocks).  

4. **Geolokalisierung**:  
   - Mit **Google Maps Street View** Adressen/Orte aus anderen Tools (z.B. ClustrMaps) verifizieren.  

5. **OPSEC-Hinweise**:  
   - **Rate-Limits**: Tools wie Google-FU können geblockt werden – nutze Proxies/VPNs.  
   - **Legalität**: Kein Scraping privater Daten ohne Einwilligung (z.B. Facebook Pro).  

6. **Biometrische Analyse**: Ergänze deine biometrische Analyse durch:
 - faceonlive.com (3 oder 4 Suchlimit, evtl. TOR nötig)
 - lenso.ai 

Danach Bild in neuem Tab öffnen, speichern oder in facecheck.id ziehen und vergleichen (siehe Schritt 1).

---

### **Toolchain-Empfehlungen**
- **Schnelle Username-Suche**: Crow (GUI für Tiefe) → Maigret (GUI für Tiefe) → Sherlock (CLI für Tiefe).  
- **Email-Leaks**: Have I Been Pwned → Pentester (halbgratis) → OSINT Rocks (Hudson Rock/Holehe) → LOLArchiver.  
- **Bilder**: Facecheck.ID → Pimeyes → lenso.ai → faceonlive  
- **Dateien**: Verschlüsselte Laufwerke (LUKS) → veracrypt → keepassxc

Zu Pentester: Pentester liefert gratis Ergebnisse zu Usernamen etc., aber zeitlich begrenzt – Kauf lohnt nicht, wenn man sich Notizen macht (Snapshot).

Zu keepassxc: Starkes Passwort oder YubiKey (Hardware-Schlüssel) nutzen. Evtl. zweite Datenbank mit merkbarem Passwort; die andere für sensible Dateien.

Weitere Nischentools siehe [Kuratierten Listen](#curated-lists).

Pipeline diskutiert [hier](https://github.com/airborne-commando/OPSEC-OSINT-Tools/blob/main/opsec.md#opsec-pipeline-for-secure-files)
    
## Personensuchtools (in den USA):

**HAFTUNGSAUSSCHLUSS: Die meisten Email-Infos auf diesen Seiten stammen offenbar aus älteren Datenlecks; die Betroffenen nutzen diese Emails evtl. immer noch, da die wenigsten ihre Provider wechseln (TFA + Passwortmanager), es sei denn, die Email wurde kompromittiert oder es gab Belästigung/Spam etc.**

---

| **Tool**               | **Suche nach**               | **Ergebnisse**                           | **Hinweise**                                                                |
|------------------------|-----------------------------|------------------------------------------|-----------------------------------------------------------------------------|
| **[FastPeopleSearch](https://www.fastpeoplesearch.com/)**   | Name, Telefon, Adresse        | Alter, Adresse, Telefon, Email              | Kostenlos; Daten evtl. veraltet.                                            |
| **[That's Them](https://thatsthem.com/)**        | Name, Email, IP, VIN, Telefon | IP, Adressen, Telefon, Email               | Aggregiert Daten von Intelius/Spokeo; teils kostenpflichtig.                |
| **[Nuwber](https://nuwber.com/)**            | Name, Telefon, Email, Adresse | Geburtsdatum, Adresse, Email, Telefon       | Detaillierte Berichte evtl. kostenpflichtig.                                |
| **[IDCrawl](https://idcrawl.com/)**           | Name, Benutzername, Telefon, Email | Namen, Usernamen, Telefon, Email           | Fokus auf Usernamen/Social Media.                                           |
| **[PeekYou](https://www.peekyou.com/)**           | Name, Benutzername, Bundesstaat | Alter, Social Media, Emails, Adressen     | Stark für Social Media Profiling.                                           |
| **[Webmii](https://webmii.com/)**            | Vor- + Nachname               | Social Media, Suchergebnisse               | Leichtgewichtig; scannt öffentliche Web-/Social-Profile.                    |
| **[PublicRecords](https://www.publicrecords.onlinesearches.com/)**     | Name, Adresse, Bundesstaat        | Name, Adresse, Teil-Telefon                | Kostenloses Verzeichnis; verweist für Details zu Intelius (kostenpflichtig).|
| **[ClustrMaps](https://clustrmaps.com/)**        | Name, Adresse                  | Adressen, Bewohner, Immobilien, IP-Daten   | Fokus auf Geo/Demografie; evtl. Besitzhistorie.                             |
| **[fastbackgroundcheck](https://www.fastbackgroundcheck.com)** | Name, Adresse, Telefonnummer | Name, Adresse, Telefonnummer, Emails | Durchsucht laut [Website](https://www.fastbackgroundcheck.com/about) Milliarden Datensätze |

---

### **Wichtige Beobachtungen**:
1. **Kostenlos vs. Bezahlt**: Die meisten bieten Grundinfos gratis, Details gegen Aufpreis (z.B. PublicRecords → Intelius).  
2. **Datenquellen**: Viele greifen auf dieselben Datenlecks/öffentlichen Daten zurück (Emails/Telefon oft veraltet, aber noch in Gebrauch).  
3. **Spezialisierungen**:  
   - *Social Media*: PeekYou, IDCrawl.  
   - *Geolokalisierung*: ClustrMaps.  
   - *Umfassend*: FastPeopleSearch, Nuwber, fastbackgroundcheck.  

**Haftungsausschluss**: Genauigkeit variiert; Emails werden selten gewechselt. Bitte ethisch nutzen!

- Weitere Tools siehe [Kuratierten Listen](#curated-lists)

## Graue Literatur

Nutze diese Seite; [nicht registrieren](https://vote.gov/register), prüfe eine Wählerregistrierung. Je nach Bundesstaat werden mehr oder weniger Infos benötigt.

Ein automatisches Tool von mir für [PA Voter Services](https://github.com/airborne-commando/voter-reg-status). Gern für andere Bundesstaaten forken.

## Geleakte Daten:
---

| **Tool**               | **Suche nach**      | **Ergebnisse**                           | **Einschränkungen/Kosten**                      | **Hinweise**                                                           |
|------------------------|--------------------|------------------------------------------|------------------------------------------------|------------------------------------------------------------------------|
| **[Have I Been Pwned](https://haveibeenpwned.com/)**  | Email, Telefon       | Leak-Namen, Daten, kompromittierte Infos | Kostenlos; keine Passwörter/Rohdaten           | Vertrauenswürdig; Benachrichtigung bei neuen Leaks                     |
| **[BreachDirectory](https://breachdirectory.org/)**    | Email, Username      | Teilweise Passwort-Hashes (SHA-1, erste 4 Zeichen), Länge | Kostenlos; keine kompletten Passwörter | Nützlich für Credential Stuffing-Checks                                |
| **[Breach.vip](https://Breach.vip)**         | Email, Username      | Minecraft-Leaks (Usernames, IPs)         | Kostenlos; Login nötig                         | Für Gaming-Accounts; "memig", aber funktional                         |
| **[LeakPeek](https://leakpeek.com/)**           | Email, Username      | Teilweise Leak-Snippets (Domains usw.)   | 5 kostenlose Suchanfragen; Tor möglich          | Kostenpflichtige Pläne für Volldaten; Ergebnisse verschleiert          |
| **[LOLArchiver](https://osint.lolarchiver.com/)**        | Email, Username      | Komplette Leak-Datenbanken (z.B. Emails, Passwörter) | Nur kostenpflichtig                  | Für OSINT-Profis; kuratierte hochwertige Leaks                         |
| **[Icebreaker](https://github.com/airborne-commando/ice-breaker)**         | Lokale Leakdateien   | Parst/analysiert große Leak-Datensätze    | Python/EXE; optimal für <1000GB                | Demo-Skript enthalten; z.B. [Facebook 533M Leak](https://github.com/davidfegyver/facebook-533m) |
| **[hashes.com](https://hashes.com/)**         | Hash (MD5, SHA-1 etc.)| Entschlüsselte Passwörter (falls geknackt)| Kostenlos/kostenpflichtige Cracking-Tools       | Zum Entschlüsseln von Hashes aus Leaks                                 |
| **[pentester.com](https://pentester.com/)**          | Email, Username      | Komplette Leak-Details (mehr als HIBP)    | Kostenlos; kein Tor nötig                      | Umfangreich, aber inoffiziell; kann sensible Daten enthalten           |

---

### **Wichtige Erkenntnisse**:  
1. **Kostenlos vs. Bezahlt**:  
   - *Kostenlos*: HIBP, BreachDirectory, Pentester, Hashes.com.  
   - *Begrenzt kostenlos*: LeakPeek (5 Suchen), Breach.vip (Login nötig).  
   - *Bezahlpflichtig*: LOLArchiver, LeakPeek-Pläne.  

2. **Spezialisierungen**:  
   - *Passwort-Wiederherstellung*: Hashes.com (Hash-Knacken), BreachDirectory (Teil-Hashes).  
   - *Gaming-Leaks*: Breach.vip (Minecraft).  
   - *Lokale Analyse*: Icebreaker (Python-Tool für große Datensätze).  

3. **Ethik/Legalität**:  
   - Viele Tools liefern **Teilinfos** (z.B. erste 4 Zeichen) aus ethischen Gründen.  
   - **Tor** bei LeakPeek nutzen, um Suchlimits zu umgehen.  
   - Missbrauch vermeiden: Manche Tools (z.B. Pentester) können sensible Daten zeigen.  

4. **Für große Datensätze**:  
   - [Icebreaker](https://github.com/airborne-commando/ice-breaker) + [Facebook 533M](https://github.com/davidfegyver/facebook-533m) (ohne Passwörter) für Massenanalyse.  

---

### **Zusätzliche Ressourcen**:  
- **Kuratierten Listen**: Siehe [Kuratierten Listen](#curated-lists) für weitere Nischentools.  
- **Demo-Skripte**: [Icebreaker](https://github.com/airborne-commando/ice-breaker) enthält ein Demo-Skript.  

## Soziale Medien
---

| **Plattform** | **Tool**              | **URL**                               | **Funktion**                                | **Einschränkungen/Hinweise**           |
|--------------|-----------------------|---------------------------------------|---------------------------------------------|----------------------------------------|
| **Allgemein**| Social Searcher       | [social-searcher.com](https://www.social-searcher.com/) | Sucht auf mehreren Plattformen gleichzeitig | Kostenlos begrenzt                     |
| **Snapchat** | Snapchat Map          | [map.snapchat.com](https://map.snapchat.com/) | Zeigt öffentliche Snapchat-Standort-Stories | Snapchat-Account nötig                 |
| **Instagram**| Dumpor                | [dumpor.com](https://dumpor.com/)     | Profile/Stories anonym ansehen              | Evtl. Rate-Limits                      |
| **Twitter**  | Sotwe                 | [sotwe.com](https://www.sotwe.com/)   | Anonymes Twitter-Browsing                   | Kein Login nötig                       |
|              | Xcancel               | [xcancel.com](https://xcancel.com/)   | Alternative Twitter-Ansicht                 | Leichtgewichtig                        |
|              | Nitter                | [nitter.net](https://nitter.net/)     | Datenschutzorientiertes Twitter-Frontend     | Vermeidet Twitter-Tracking             |
| **Facebook** | Facebook Suche        | [facebook.com/search](https://www.facebook.com/search/) | Native Facebook-Suche                      | Ohne Login eingeschränkt               |
|              | WhoPostedWhat         | [whopostedwhat.com](https://www.whopostedwhat.com/) | Facebook-Posts nach Datum/Keyword suchen    | Exakte Suche, öffentliche Accounts     |
| **reddit**   | r00m101.com           | [r00m101](https://r00m101.com/)       | Infos zu aktiven/deaktivierten Reddit-Accounts| Evtl. kostenpflichtig für vollen Umfang|

---

### **Pro-Tipps & Workarounds**

1. **Facebook Private Accounts**:
   - Methode 1: Fake-Account erstellen (schwierig wegen Verifikation)
   - Methode 2: Browser *Element untersuchen* → *Gerätesimulator* (oder Handy) + Direktlink
   - Immer zuerst ausgeloggt oder im privaten Modus probieren

2. **LinkedIn-Einschränkungen**:
   - Wenn Profile nicht laden:
     - 1–2 Minuten warten (Cookie/IP-Rotation)
     - Basic-Account erstellen (nicht verdächtig erscheinen)
   - HWID/IP-Tracking kann wiederholte Suchen blockieren

3. **Twitter-Alternativen**:
   - **Nitter**/**Xcancel** nutzen für weniger Limits/Tracking
   - **Sotwe** funktioniert ohne Login

4. **Instagram**:
   - **Dumpor** umgeht einige Privatsphäre-Einstellungen
   - **Schnellzugriff** https://dumpor.io/v/USERNAME (`USERNAME` ersetzen)
   - **Funktioniert nicht bei privaten Accounts**

---

### **Wichtige Erkenntnisse**
- **Anonymität**: Tools wie Nitter/Dumpor umgehen Plattform-Tracking
- **Mobile-Tricks**: Gerätesimulation hilft oft bei eingeschränkten Inhalten
- **Geduld**: Manche Plattformen (LinkedIn/Facebook) erfordern Geduld oder Account

- Weitere Tools siehe den Abschnitt Kuratierten Listen unten.


## Kuratierten Listen

- [Awesome OSINT](https://github.com/jivoi/awesome-osint) – eine kuratierte Liste von OSINT-Tools, Blogs und Videos

- [OSINT Framework](https://osintframework.com/) – größere Tool-Liste
  
- [OSINT Resources](https://sizeof.cat/post/osint-resources/) – Sammlung aktueller OSINT-Ressourcen (inkl. NSFW)

  - [Archiv](https://archive.ph/rZZf0) 

- Ein ganzes Reddit-Wiki aus der [OSINT-Community](https://www.reddit.com/r/OSINT/wiki/index/)

- Eine Liste von Social Media, Maps, Domains etc. auch [in cipher387s OSINT-Sammlung](https://github.com/cipher387/osint_stuff_tool_collection). 

**OPT OUT**

- Eine [riesige Liste](https://github.com/yaelwrites/Big-Ass-Data-Broker-Opt-Out-List) zum Abmelden und Datenvergleich.

- [inteltechniques opt out workbook](https://inteltechniques.com/workbook.html)

- [Results about you (Google-Index)](https://myactivity.google.com/results-about-you) – Prüfe, was Google über dich findet; besuche die Seiten und beantrage Opt-Out.

## Toolchain (Self-OSINT):

Google Dorks: `https://www.google.com/search?q= "first+last" "Street Address" "City state" "age"` -> [Results about you (Google-Index)](https://myactivity.google.com/results-about-you) -> [Big-Ass-Liste](https://github.com/yaelwrites/Big-Ass-Data-Broker-Opt-Out-List) -> [inteltechniques opt out workbook](https://inteltechniques.com/workbook.html) -> [Personensuchtools](https://github.com/airborne-commando/OPSEC-OSINT-Tools/tree/main?tab=readme-ov-file#people-search-tools-in-the-states)

**Hinweis** 

[Results about you (Google-Index)](https://myactivity.google.com/results-about-you) kann auch per Email zugestellt werden. Beim Vergleich beachten: Google findet Webseiten mit deinem Namen und Adresse und bietet an, diese aus dem Index zu entfernen. Vor dem Antrag sollte die Info von der Seite selbst entfernt werden. Google Dorking ist oft schneller und effektiver, nach dem Besuch der Seiten Info entfernen (falls möglich).

Manuelles Google Dorking hat den Vorteil, nicht als Bot erkannt zu werden.

## Archivtools, die ich gemacht habe
 
- [Link extractor and archive](https://github.com/airborne-commando/link-extractor-and-archive) nutzt archive.ph – nützlich für einfache Webseiten. Benötigt manuelle Nachbearbeitung (FIND+REPLACE).

Weitere Tools:

- Weitere Tools siehe oben unter kuratierten Listen



Spenden:

Wenn dir das geholfen hat, spende gern an diese Monero-Adresse:

![mon](https://github.com/user-attachments/assets/f77ce530-5a5d-479d-bb47-481674c93f4c)

    8BPdcsLtA5iWLNTWvYzUVyTWtQkM62e8r7xqAuwjXTSC4RcoSWqpmtyLsMYvz3QNZtT1rbgPUnmVpMAudhxTn6zkRxUFcZN

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---