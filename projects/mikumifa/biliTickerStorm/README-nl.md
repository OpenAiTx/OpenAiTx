# 🎫 BiliTickerStorm

## ⚙️ Servicebeschrijving

| Servicenaam         | Beschrijving                  | Opmerking      |
| ------------------- | ---------------------------- | ------------- |
| `ticket-master`     | Hoofdservice, verantwoordelijk voor taakplanning | Enkelvoudige instantie |
| `ticket-worker`     | Ticket worker, horizontaal schaalbaar           | Ondersteunt meerdere instanties |
| `gt-python`         | Dienst voor grafische captcha-verwerking        | Enkelvoudige instantie |

---

## 🚀 Snelle installatiestappen

> Voor het opzetten van een cluster, zie [Cluster Installatiehandleiding](https://raw.githubusercontent.com/mikumifa/biliTickerStorm/main/docs/集群搭建参考.md).

<details> <summary><strong>📦 Installatie via remote repository (aanbevolen)</strong></summary>

```bash
helm repo add bili-ticker-storm https://mikumifa.github.io/biliTickerStorm/
helm repo update
```
### 2. Chart installeren

```bash
helm install bili-ticker-storm bili-ticker-storm/bili-ticker-storm \
  --set ticketMaster.hostDataPath=/your/host/data/path \
  --set ticketWorker.pushplusToken="your_token" \
  --set ticketWorker.ticketInterval="300" \
  --set ticketWorker.ticketTimeStart="2025-05-20T13:14"
  
```

> - `hostDataPath` is de directory voor het configuratiebestand van het ticketkopen, bedoeld om te worden gemount naar de `ticket-master` container. Het configuratiebestand voor het ticketkopen kan worden gegenereerd met https://github.com/mikumifa/biliTickerBuy
> - `ticketWorker.pushplusToken` is de pushplus notificatieconfiguratie. Na het instellen kun je meldingen ontvangen over de resultaten van het ticketkopen.
> - `ticketWorker.ticketInterval` is het interval (in milliseconden) tussen pogingen voor het kopen van tickets, standaard 300 milliseconden.
> - `ticketWorker.ticketTimeStart` is de geplande starttijd, in het formaat `2025-05-20T13:14`. Indien niet ingevuld, wordt standaard direct na het opstarten van de container begonnen met ticketkopen.

### 3. Chart upgraden

```bash
helm upgrade bili-ticker-storm bili-ticker-storm/bili-ticker-storm --reuse-values \
  --set ticketWorker.ticketInterval="600"
```
</details> 
<details> <summary><strong>📦 Lokale Chart-installatie</strong></summary>


### 1. Chart installeren

```bash
# Repository klonen
git clone https://github.com/mikumifa/biliTickerStorm
# Gebruik het lokale Chart-pakket
helm install bili-ticker-storm ./helm \
  --set ticketMaster.hostDataPath=/your/host/data/path \
  --set ticketWorker.pushplusToken="your_token" \
  --set ticketWorker.ticketInterval="300" \
  --set ticketWorker.ticketTimeStart="2025-05-20T13:14"
```
### 2. Chart upgraden

```bash
helm upgrade bili-ticker-storm ./helm --reuse-values
```
</details>
<details>
<summary><strong>📌 Algemene commando's</strong></summary>

### ⏹ Deïnstalleren
```bash
helm uninstall bili-ticker-storm
```
</details>


## 📩 Disclaimer

Dit project volgt de MIT License licentieovereenkomst en is uitsluitend bedoeld voor persoonlijk leren en onderzoek. Gebruik dit project niet voor commerciële doeleinden, noch voor enige vorm van geautomatiseerd kopen, illegale activiteiten of gebruik in strijd met de regels van relevante platforms. Alle gevolgen die hieruit voortvloeien zijn volledig voor rekening van de gebruiker en staan los van de auteur.

Als u dit project forked of gebruikt, dient u zich strikt te houden aan de relevante wet- en regelgeving en de regels van het doelplatform.

## 💡 Over toegangsfrequentie en gelijktijdigheidscontrole
Dit project is ontworpen volgens het principe van "niet-invasief" werken om iedere verstoring van de doelserver (zoals Bilibili) te voorkomen.

Alle tijdsintervallen van netwerkverzoeken kunnen door de gebruiker zelf worden ingesteld; de standaardwaarden simuleren de handmatige snelheid van een normale gebruiker. Het programma draait standaard op één thread, zonder gelijktijdige taken. Bij een mislukte aanvraag probeert het programma het verzoek een beperkt aantal keren opnieuw, met een geschikte vertraging tussen de pogingen, om hoge frequentie te vermijden. Het project maakt volledig gebruik van openbare platform-API's en webstructuren, zonder destructieve methoden zoals risicobeheersingsomzeiling of API-kaping.
## 🛡️ Verklaring van respect voor het platform

Dit programma is zodanig ontworpen dat het de verzoekfrequentie zoveel mogelijk beperkt, om elke merkbare belasting of invloed op de Bilibili-server te vermijden. Het project is uitsluitend bedoeld voor studie- en leerdoeleinden en beschikt niet over de mogelijkheid tot grootschalige of hoge gelijktijdigheid, noch heeft het enige kwaadaardige bedoelingen of de intentie om de dienst te verstoren.

Mocht er inhoud in dit project aanwezig zijn die de legitieme rechten en belangen van het bedrijf Bilibili schendt, neem dan contact met mij op via e-mail [1055069518@qq.com](https://raw.githubusercontent.com/mikumifa/biliTickerStorm/main/mailto:1055069518@qq.com). Ik zal dan zo spoedig mogelijk de betreffende inhoud verwijderen en deze repository wissen. Mijn excuses voor het eventuele ongemak dat hierdoor wordt veroorzaakt, en dank voor uw begrip en tolerantie.

## 📄 Licentie

[MIT License](LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-11

---