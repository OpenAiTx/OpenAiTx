
<div align="right">
  <details>
    <summary >🌐 Taal</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=en">Engels</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=zh-CN">Vereenvoudigd Chinees</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=zh-TW">Traditioneel Chinees</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=ja">Japans</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=ko">Koreaans</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=hi">Hindi</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=th">Thais</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=fr">Frans</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=de">Duits</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=es">Spaans</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=it">Italiaans</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=ru">Russisch</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=pt">Portugees</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=pl">Pools</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=ar">Arabisch</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=fa">Perzisch</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=tr">Turks</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=vi">Vietnamees</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=as">Assamees</
      </div>
    </div>
  </details>
</div>

# SimpleLogin

Dit is een zelf-gehoste docker-compose configuratie voor [SimpleLogin](https://simplelogin.io).

## Vereisten

- een Linux server (ofwel een VM of een dedicated server). Dit document toont de installatie voor Ubuntu 18.04 LTS maar de stappen kunnen worden aangepast voor andere populaire Linux distributies. Omdat de meeste componenten als Docker container draaien en Docker enigszins zwaar kan zijn, wordt minimaal 2 GB RAM aanbevolen. De server moet poort 25 (e-mail), 80, 443 (voor de webapp), 22 (zodat je kunt ssh-en) open hebben staan.

- een domein waarvoor je de DNS kunt configureren. Dit kan een subdomein zijn. In de rest van dit document nemen we `mydomain.com` voor de e-mail en `app.mydomain.com` voor de SimpleLogin webapp als voorbeeld. Vervang deze waarden altijd door jouw domeinnaam en subdomeinnaam wanneer ze in het document voorkomen. Een truc die wij gebruiken is om dit README-bestand op je computer te downloaden en alle vermeldingen van `mydomain.com` en `app.mydomain.com` te vervangen door jouw domein.

Behalve voor het instellen van de DNS, wat meestal gebeurt via de interface van je domeinregistrar, moeten alle onderstaande stappen op je server worden uitgevoerd. De commando's moeten worden uitgevoerd met `bash` (of een andere bash-compatibele shell zoals `zsh`) als shell. Als je andere shells zoals `fish` gebruikt, zorg er dan voor dat je de commando's aanpast.

- Enkele hulppakketten die worden gebruikt om de setup te verifiëren. Installeer ze door:

```bash
sudo apt update \
  && sudo apt install -y net-tools dnsutils
```

## DNS-configuratie

_Raadpleeg de [referentiedocumentatie](https://github.com/springcomp/self-hosted-simplelogin/wiki/DNS-Configuration) voor meer details_

> **Let op** dat DNS-wijzigingen tot 24 uur kunnen duren om door te voeren. In de praktijk gaat het echter veel sneller (~1 minuut in onze test). Bij DNS-configuratie gebruiken we meestal een domeinnaam met een punt (`.`) aan het einde om het gebruik van een absolute domeinnaam af te dwingen.

U moet de volgende DNS-records instellen:

- **A**: Koppelt uw domein aan het IPv4-adres van uw server.
- **AAAA**: Koppelt uw domein aan het IPv6-adres van uw server.
- **MX**: Stuurt inkomende e-mails naar uw mailserver (inclusief `*` wildcards).
- **PTR**: Koppelt het IP-adres van uw server terug aan uw domeinnaam.

Stel verplichte beveiligingsbeleid in:

- **DKIM**: Ondertekent uitgaande e-mails digitaal om authenticiteit te verifiëren.
- **DMARC**: Bepaalt hoe e-mailontvangers berichten moeten behandelen die niet geauthenticeerd zijn.
- **SPF**: Autoriseert specifieke mailservers om e-mails vanaf uw domein te verzenden.

Aanvullende stappen:

- **CAA**: Geeft aan welke certificaatautoriteiten SSL-certificaten voor uw domein mogen uitgeven.
- **MTA-STS**: Dwingt veilige, versleutelde verbindingen tussen mailservers af.
- **TLS-RPT**: Rapporteert TLS-verbindingsfouten om e-mailbeveiliging te verbeteren.

**Waarschuwing**: het instellen van een CAA-record beperkt welke certificaatautoriteit SSL-certificaten voor uw domein kan uitgeven.
Dit voorkomt certificaatuitgifte door Let’s Encrypt staging servers. U kunt deze DNS-record beter uitstellen tot na succesvolle uitgifte van SSL-certificaten voor uw domein.

## Docker

Als u Docker nog niet op uw server hebt geïnstalleerd, volg dan de stappen op [Docker CE voor Ubuntu](https://docs.docker.com/v17.12/install/linux/docker-ce/ubuntu/) om Docker te installeren.

U kunt Docker ook installeren met het [docker-install](https://github.com/docker/docker-install) script dat is

```bash
curl -fsSL https://get.docker.com | sh
```

Schakel IPv6 in voor [het standaard bridge-netwerk](https://docs.docker.com/config/daemon/ipv6/#use-ipv6-for-the-default-bridge-network)

```json
{
  "ipv6": true,
  "fixed-cidr-v6": "2001:db8:1::/64",
  "experimental": true,
  "ip6tables": true
}
```

Deze procedure begeleidt je bij het uitvoeren van de volledige stack met Docker containers.
Dit omvat:

- traefik
- De [SimpleLogin app](https://github.com/simple-login/app) containers
- postfix

SimpleLogin uitvoeren vanuit Docker containers:

1. Clone deze repository naar `/opt/simplelogin`
1. Kopieer `.env.example` naar `.env` en stel de juiste waarden in.

    - stel de `DOMAIN` variabele in op jouw domein.
    - stel de `SUBDOMAIN` variabele in op jouw domein. De standaardwaarde is `app`.
    - stel de `POSTGRES_USER` variabele in zodat deze overeenkomt met de postgres-inloggegevens (bij een nieuwe installatie gebruik `simplelogin`).
    - stel de `POSTGRES_PASSWORD` in zodat deze overeenkomt met de postgres-inloggegevens (bij een nieuwe installatie kies een willekeurige sleutel).
    - stel de `FLASK_SECRET` in op een willekeurige geheime sleutel.

### Postgres SQL

Deze repository draait een postgres SQL in een Docker container.

**Waarschuwing**: eerdere versies van deze repository draaiden versie `12.1`.
Raadpleeg de [referentiedocumentatie](https://github.com/springcomp/self-hosted-simplelogin/wiki/PostgreSQL) voor meer details en
upgrade-instructies.

### De applicatie uitvoeren

Voer de applicatie uit met de volgende commando's:

```sh
docker compose up --detach --remove-orphans --build && docker compose logs -f
```

Je wilt op dit punt mogelijk [Certificate Authority Authorization (CAA)](https://github.com/springcomp/self-hosted-simplelogin/wiki/dns-caa) instellen.

## Volgende stappen

Als alle bovenstaande stappen succesvol zijn, open dan <https://app.mijndomein.com/> en maak je eerste account aan!

Standaard zijn nieuwe accounts niet premium en hebben ze dus geen onbeperkt aantal aliassen. Om je account premium te maken,
ga naar de database, tabel "users" en zet de kolom "lifetime" op "1" of "TRUE":

```bash
docker compose exec -it postgres psql -U myuser simplelogin
> UPDATE users SET lifetime = TRUE;
> \q
```

Zodra je alle gewenste loginaccounts hebt aangemaakt, voeg deze regels toe aan `.env` om verdere registraties uit te schakelen:

```env
DISABLE_REGISTRATION=1
DISABLE_ONBOARDING=true
```
Vervolgens, om de webapp opnieuw te starten, voer uit: `docker compose restart app`

## Diversen

### Postfix-configuratie - Spamhaus

Het Spamhaus Project onderhoudt een betrouwbare lijst van IP-adressen waarvan bekend is dat ze de bron zijn van SPAM.
Je kunt controleren of een bepaald IP-adres in die lijst staat door queries naar de DNS-infrastructuur te sturen.

Aangezien Spamhaus verzoeken blokkeert die afkomstig zijn van openbare (open) DNS-resolvers (zie: <https://check.spamhaus.org/returnc/pub>) en je postfix-container mogelijk
standaard een openbare resolver gebruikt, wordt aanbevolen je aan te melden voor de gratis
[Spamhaus Data Query Service](https://www.spamhaus.com/free-trial/sign-up-for-a-free-data-query-service-account/)
en een Spamhaus DQS-sleutel te verkrijgen.

Plak deze sleutel als `SPAMHAUS_DQS_KEY` in je `.env`

Als er geen DQS-sleutel wordt opgegeven, controleert je postfix-container of de openbare mirrors van Spamhaus zijn queries accepteren en zal ze anders gebruiken.
Als Spamhaus verzoeken van je postfix-container naar de openbare mirrors afwijst, wordt het geheel uitgeschakeld.

### Postfix-configuratie - Virtuele aliassen

De postfix-configuratie ondersteunt virtuele aliassen met behulp van de bestanden `postfix/conf.d/virtual` en `postfix/conf.d/virtual-regexp`.
Die bestanden worden automatisch aangemaakt bij het opstarten op basis van de bijbehorende [`postfix/templates/virtual.tpl`](https://raw.githubusercontent.com/springcomp/self-hosted-simplelogin/main/./postfix/templates/virtual.tpl)
en [`postfix/templates/virtual-regexp.tpl`](https://raw.githubusercontent.com/springcomp/self-hosted-simplelogin/main/./postfix/templates/virtual-regexp.tpl) templatebestanden.

De standaardconfiguratie is als volgt:

#### virtual.tpl

Het bestand `virtual` ondersteunt de postfix-instelling `virtual_alias_maps`.
Het bevat een regel die `unknown@mydomain.com` naar `contact@mydomain.com` doorstuurt als voorbeeld van het ontvangen
van e-mail van een specifiek adres dat niet overeenkomt met een bestaande alias, naar een ander adres dat dat wel doet.


```postfix-conf
unknown@mydomain.com  contact@mydomain.com
```

#### virtual-regexp.tpl

Het bestand `virtual-regexp` ondersteunt postfix `virtual_alias_maps` instellingen.
Het bevat een regel die e-mails herschrijft die gericht zijn aan een willekeurig subdomein, dat niet overeenkomt
met een bestaande alias, naar een nieuwe alias die behoort tot een map waarvan de naam is afgeleid van het subdomein.
Die alias kan direct worden aangemaakt als deze nog niet bestaat.

```postfix-conf
/^([^@]+)@([^.]+)\.mydomain.com/   $2/$1@mydomain.com
```

Bijvoorbeeld, e-mails verzonden naar `someone@directory.mydomain.com` worden door postfix doorgestuurd naar `directory/someone@mydomain.com`.

## Handleiding voor upgrade vanaf 3.4.0

_Deze sectie is verplaatst naar de [referentiedocumentatie](https://github.com/springcomp/self-hosted-simplelogin/wiki/upgrade-sl)_

## Handleiding voor upgrade vanaf eerdere NGinx-gebaseerde installatie

_Deze sectie is verplaatst naar de [referentiedocumentatie](https://github.com/springcomp/self-hosted-simplelogin/wiki/upgrade-from-nginx)_


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-15

---