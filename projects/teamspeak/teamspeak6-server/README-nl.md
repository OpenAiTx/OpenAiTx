# TeamSpeak 6 Server - Beta Release README

Welkom bij de bètarelease van de TeamSpeak 6 Server! We zijn verheugd dat je meedoet terwijl je de volgende generatie van TeamSpeak verkent. Dit document helpt je op weg en wijst op belangrijke details van de huidige bèta.

Aangezien dit een bètaversie is, zijn sommige functies nog in ontwikkeling en kun je bugs tegenkomen. Jouw feedback is belangrijk en helpt ons een stabielere en completere definitieve release te realiseren.

<h2><img width="24" src="/icons/teamspeak_blue.svg">&nbsp;Over TeamSpeak</h2>

Al bijna 25 jaar beproefd en getest, bieden wij een oplossing die aan ieders wensen voldoet. TeamSpeak biedt de ideale spraakcommunicatie voor gaming, educatie en training, interne bedrijfscommunicatie en contact houden met vrienden en familie. Onze primaire focus is het leveren van een gebruiksvriendelijke oplossing, met hoge beveiligingsnormen, uitstekende spraakkwaliteit en een laag systeem- en bandbreedteverbruik.

## ℹ️ Bètastatus & Bekende Problemen
**Dit is een bètarelease. Het belangrijkste doel is om diverse feedback te verzamelen en mogelijke problemen te identificeren voordat de stabiele versie wordt uitgebracht.**

**Zelfgehoste Serverbestanden:** De speciale serversoftware voor TeamSpeak 6 is nog in actieve ontwikkeling en is nog niet volledig voorzien van alle functies. We zetten ons in om de volledige TS6-ervaring voor zelfgehoste servers te bieden.

**Functie-instabiliteit:** Sommige van de nieuwe functies kunnen instabiel zijn of nog veranderen terwijl we deze verder verfijnen.

**Feedback is essentieel:** Jouw ervaring is van onschatbare waarde en jouw input is cruciaal voor ons. Meld eventuele problemen of deel je suggesties in ons [Community Forum](https://community.teamspeak.com/c/teamspeak-6-server/45) of direct hier op [GitHub](https://github.com/teamspeak/teamspeak6-server/issues).

**Beperkingen:** Let op: **TeamSpeak 3 Server-licenties zijn niet compatibel** met TeamSpeak 6 Servers, en momenteel is er **geen migratiepad beschikbaar tussen de twee versies**.

**Preview-licentie:** Naar aanleiding van jullie feedback wordt de server nu geleverd met een **tijdelijke** preview-licentie voor 32 slots om meer flexibiliteit te bieden tijdens de evaluatieperiode. Let op: deze licentie is **slechts twee maanden geldig**.

Bovendien is het **nog niet mogelijk om een grotere licentie voor TeamSpeak 6 te verkrijgen of te upgraden**.

We waarderen je geduld en begrip terwijl we verder werken aan oplossingen om jouw behoeften in de toekomst beter te ondersteunen.

## 👇 Aan de slag met TS6
Om aan de slag te gaan met de TeamSpeak 6 Client, ga naar onze [Downloads](https://teamspeak.com/en/downloads/) pagina.

Voor informatie over zelfhosting, zie de korte handleiding hieronder. Voor de laatste updates, aankondigingen en om deel te nemen aan de TeamSpeak-community, kijk op ons [Community Forum](https://community.teamspeak.com/) en volg ons op [Twitter](https://x.com/teamspeak).

Wil je niet zelf hosten of wil je gewoon eenvoudiger starten met TeamSpeak 6? Je kunt betrouwbare en Officiële TeamSpeak 6 Servers direct bij ons huren via [TeamSpeak Communities](https://www.myteamspeak.com/communities).
## ⚙️ Configuratie
### Je kunt je server op drie hoofdmanieren configureren:

1. **Command-Line Argumenten:** Geef opties direct mee bij het starten van de server (bijvoorbeeld: ./tsserver --default-voice-port 9987). Dit is handig voor tijdelijke wijzigingen of scripting.

2. **Omgevingsvariabelen:** Stel omgevingsvariabelen in voordat je de server start. Dit is handig voor Docker of als je command-line rommel wilt vermijden.

3. **YAML-configuratiebestand:** Voor een blijvende configuratie wordt het sterk aanbevolen om een tsserver.yaml-bestand te gebruiken. Je kunt een standaardconfiguratiebestand genereren met de --write-config-file flag.

Belangrijke instellingen die je kunt beheren zijn onder andere netwerkpoorten (spraak, bestandsoverdracht), databaseverbindingen (ondersteunt SQLite en MariaDB), IP-bindings en logboekopties.

Voor een volledige lijst van beschikbare opties, start de server met de `--help` flag of raadpleeg de [CONFIG.md](https://raw.githubusercontent.com/teamspeak/teamspeak6-server/main/CONFIG.md).

### De Server draaien met Binaries
Als je geen gebruik maakt van Docker, kun je de server direct op je besturingssysteem uitvoeren.

<h2><img width="22" src="/icons/linux.svg">&nbsp;Op Linux:</h2>

Maak het serverbestand uitvoerbaar:
```sh
chmod +x tsserver
```

Start de server vanuit je terminal en accepteer de licentie:

```sh
./tsserver --accept-license
```

<h2><img width="22" src="/icons/windows.svg">&nbsp;Op Windows:</h2>

Open Opdrachtprompt of PowerShell en navigeer naar de map waar je de serverbestanden hebt uitgepakt.

Start het serverbestand en accepteer de licentie:
```powershell
tsserver.exe
```

<h2><img width="32" src="/icons/docker.svg">&nbsp;De Server draaien met Docker (Aanbevolen):</h2>
Docker is de eenvoudigste manier om de TeamSpeak 6-server in een geïsoleerde en beheerbare omgeving te draaien.

### 1. Eenvoudig docker run-commando:

Voor een snelle start kun je het docker run-commando gebruiken.

```sh
docker run -it --rm \
  -p 9987:9987/udp \
  -p 30033:30033 \
  -e TSSERVER_LICENSE_ACCEPTED=accept \
  teamspeaksystems/teamspeak6-server:latest
```

### 2. Gebruik van docker-compose.yaml (voor blijvende opstellingen):
Dit is de beste werkwijze voor een server die je langdurig wilt laten draaien. Maak een docker-compose.yaml-bestand aan:

```yaml
services:
  teamspeak:
    image: teamspeaksystems/teamspeak6-server:latest
    container_name: teamspeak-server
    restart: unless-stopped
    ports:
      - "9987:9987/udp"   # Voice Port
      - "30033:30033/tcp" # Bestandsoverdracht
      # - "10080:10080/tcp" # Web Query
    environment:
```
      - TSSERVER_LICENSE_ACCEPTED=accept
    volumes:
      - teamspeak-data:/var/tsserver/

volumes:
  teamspeak-data:
```

## 🔗 Nuttige Links
[Officiële Website](https://teamspeak.com/en/)<br>
[Community Forum](https://community.teamspeak.com)<br>
[GitHub Issues](https://github.com/teamspeak/teamspeak6-server/issues)<br>

Jouw deelname en feedback zullen ons helpen de toekomst van TeamSpeak vorm te geven! 💙<br>
Bedankt dat je deel uitmaakt van het TeamSpeak 6 Beta-programma en bijdraagt aan de vooruitgang ervan! 🫡

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-05

---