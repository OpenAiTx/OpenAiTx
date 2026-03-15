
<div align="right">
  <details>
    <summary >🌐 Sprache</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=en">Englisch</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=ja">Japanisch</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=ko">Koreanisch</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=hi">Hindi</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=th">Thailändisch</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=fr">Französisch</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=es">Spanisch</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=it">Italienisch</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=ru">Russisch</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=pt">Portugiesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=nl">Niederländisch</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=pl">Polnisch</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=tr">Türkisch</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=vi">Vietnamesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=id">Indonesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# SimpleLogin

Dies ist eine selbst gehostete docker-compose Konfiguration für [SimpleLogin](https://simplelogin.io).

## Voraussetzungen

- Ein Linux-Server (entweder eine VM oder ein dedizierter Server). Dieses Dokument zeigt die Einrichtung für Ubuntu 18.04 LTS, aber die Schritte können für andere gängige Linux-Distributionen angepasst werden. Da die meisten Komponenten als Docker-Container laufen und Docker etwas ressourcenintensiv sein kann, werden mindestens 2 GB RAM empfohlen. Der Server muss die Ports 25 (E-Mail), 80, 443 (für die Webanwendung), 22 (für SSH-Zugriff) offen haben.

- eine Domain, für die Sie die DNS konfigurieren können. Es kann sich um eine Subdomain handeln. Im weiteren Verlauf des Dokuments nehmen wir an, dass es sich um `mydomain.com` für die E-Mail und `app.mydomain.com` für die SimpleLogin-Webanwendung handelt. Bitte stellen Sie sicher, dass Sie diese Werte durch Ihren Domainnamen und Subdomainnamen ersetzen, wann immer sie im Dokument erscheinen. Ein Trick, den wir verwenden, besteht darin, diese README-Datei auf Ihren Computer herunterzuladen und alle Vorkommen von `mydomain.com` und `app.mydomain.com` durch Ihre Domain zu ersetzen.

Abgesehen von der DNS-Einrichtung, die in der Regel über die Benutzeroberfläche Ihres Domain-Registrars erfolgt, sind alle folgenden Schritte auf Ihrem Server durchzuführen. Die Befehle sind mit `bash` (oder einer bash-kompatiblen Shell wie `zsh`) als Shell auszuführen. Wenn Sie andere Shells wie `fish` verwenden, passen Sie die Befehle bitte entsprechend an.

- Einige Hilfspakete, die zur Überprüfung der Einrichtung verwendet werden. Installieren Sie sie mit:

```bash
sudo apt update \
  && sudo apt install -y net-tools dnsutils
```

## DNS-Konfiguration

_Siehe die [Referenzdokumentation](https://github.com/springcomp/self-hosted-simplelogin/wiki/DNS-Configuration) für weitere Details_

> **Bitte beachten Sie**, dass DNS-Änderungen bis zu 24 Stunden benötigen können, um sich zu verbreiten. In der Praxis geht es jedoch viel schneller (~1 Minute in unserem Test). Bei der DNS-Konfiguration verwenden wir üblicherweise eine Domain mit abschließendem Punkt (`.`), um die Nutzung einer absoluten Domain zu erzwingen.

Sie müssen die folgenden DNS-Einträge einrichten:

- **A**: Ordnet Ihre Domain der IPv4-Adresse Ihres Servers zu.
- **AAAA**: Ordnet Ihre Domain der IPv6-Adresse Ihres Servers zu.
- **MX**: Leitet eingehende E-Mails an Ihren Mailserver (einschließlich `*`-Wildcards).
- **PTR**: Ordnet die IP-Adresse Ihres Servers zurück zu Ihrem Domainnamen.

Richten Sie obligatorische Sicherheitsrichtlinien ein:

- **DKIM**: Signiert ausgehende E-Mails digital, um die Authentizität zu bestätigen.
- **DMARC**: Definiert, wie E-Mail-Empfänger mit Nachrichten umgehen sollen, die die Authentifizierung nicht bestehen.
- **SPF**: Autorisiert bestimmte Mailserver, E-Mails von Ihrer Domain zu senden.

Weitere Schritte:

- **CAA**: Gibt an, welche Zertifizierungsstellen SSL-Zertifikate für Ihre Domain ausstellen dürfen.
- **MTA-STS**: Erzwingt sichere, verschlüsselte Verbindungen zwischen Mailservern.
- **TLS-RPT**: Meldet TLS-Verbindungsfehler zur Verbesserung der E-Mail-Zustellungs-Sicherheit.

**Warnung**: Das Einrichten eines CAA-Eintrags schränkt ein, welche Zertifizierungsstelle SSL-Zertifikate für Ihre Domain ausstellen kann.
Dadurch wird die Ausstellung von Zertifikaten durch Let’s Encrypt-Staging-Server verhindert. Sie sollten diesen DNS-Eintrag eventuell erst nach erfolgreicher Ausstellung der SSL-Zertifikate für Ihre Domain setzen.

## Docker

Falls Docker noch nicht auf Ihrem Server installiert ist, folgen Sie bitte den Schritten auf [Docker CE für Ubuntu](https://docs.docker.com/v17.12/install/linux/docker-ce/ubuntu/), um Docker zu installieren.

Sie können Docker auch mit dem [docker-install](https://github.com/docker/docker-install)-Skript installieren, das

```bash
curl -fsSL https://get.docker.com | sh
```

Aktivieren Sie IPv6 für [das Standard-Bridge-Netzwerk](https://docs.docker.com/config/daemon/ipv6/#use-ipv6-for-the-default-bridge-network)

```json
{
  "ipv6": true,
  "fixed-cidr-v6": "2001:db8:1::/64",
  "experimental": true,
  "ip6tables": true
}
```

Dieses Verfahren führt Sie durch das Ausführen des gesamten Stacks mit Docker-Containern.
Dies umfasst:

- traefik
- Die [SimpleLogin App](https://github.com/simple-login/app) Container
- postfix

Führen Sie SimpleLogin aus Docker-Containern aus:

1. Klonen Sie dieses Repository nach `/opt/simplelogin`
1. Kopieren Sie `.env.example` nach `.env` und setzen Sie die entsprechenden Werte.

    - Setzen Sie die Variable `DOMAIN` auf Ihre Domain.
    - Setzen Sie die Variable `SUBDOMAIN` auf Ihre Domain. Der Standardwert ist `app`.
    - Setzen Sie die Variable `POSTGRES_USER` so, dass sie den Postgres-Zugangsdaten entspricht (bei Neuinstallation verwenden Sie `simplelogin`).
    - Setzen Sie das `POSTGRES_PASSWORD` so, dass es den Postgres-Zugangsdaten entspricht (bei Neuinstallation auf einen zufälligen Schlüssel setzen).
    - Setzen Sie das `FLASK_SECRET` auf einen beliebigen geheimen Schlüssel.

### Postgres SQL

Dieses Repository führt eine Postgres SQL in einem Docker-Container aus.

**Warnung**: Frühere Versionen dieses Repositories verwendeten Version `12.1`.
Bitte konsultieren Sie die [Referenzdokumentation](https://github.com/springcomp/self-hosted-simplelogin/wiki/PostgreSQL) für weitere Details und
Upgrade-Anweisungen.

### Anwendung ausführen

Führen Sie die Anwendung mit den folgenden Befehlen aus:

```sh
docker compose up --detach --remove-orphans --build && docker compose logs -f
```

Möglicherweise möchten Sie an diesem Punkt die [Certificate Authority Authorization (CAA)](https://github.com/springcomp/self-hosted-simplelogin/wiki/dns-caa) einrichten.

## Nächste Schritte

Wenn alle oben genannten Schritte erfolgreich waren, öffnen Sie <https://app.mydomain.com/> und erstellen Sie Ihr erstes Konto!

Standardmäßig sind neue Konten nicht Premium und haben daher keine unbegrenzten Aliase. Um Ihr Konto auf Premium umzustellen,
gehen Sie bitte in die Datenbank, Tabelle „users“ und setzen Sie die Spalte „lifetime“ auf „1“ oder „TRUE“:

```bash
docker compose exec -it postgres psql -U myuser simplelogin
> UPDATE users SET lifetime = TRUE;
> \q
```

Sobald Sie alle gewünschten Login-Konten erstellt haben, fügen Sie diese Zeilen zur `.env` hinzu, um weitere Registrierungen zu deaktivieren:

```env
DISABLE_REGISTRATION=1
DISABLE_ONBOARDING=true
```

Dann, um die Web-App neu zu starten, führen Sie aus: `docker compose restart app`

## Verschiedenes

### Postfix-Konfiguration - Spamhaus

Das Spamhaus-Projekt pflegt eine zuverlässige Liste von IP-Adressen, die als Quelle von SPAM bekannt sind.
Sie können überprüfen, ob eine bestimmte IP-Adresse in dieser Liste ist, indem Sie Anfragen an die DNS-Infrastruktur stellen.

Da Spamhaus Anfragen von öffentlichen (offenen) DNS-Resolvern blockiert (siehe: <https://check.spamhaus.org/returnc/pub>) und Ihr Postfix-Container
standardmäßig möglicherweise einen öffentlichen Resolver verwendet, wird empfohlen, sich für den kostenlosen
[Spamhaus Data Query Service](https://www.spamhaus.com/free-trial/sign-up-for-a-free-data-query-service-account/)
anzumelden und einen Spamhaus DQS-Schlüssel zu erhalten.

Fügen Sie diesen Schlüssel als `SPAMHAUS_DQS_KEY` in Ihre `.env` ein.

Wenn kein DQS-Schlüssel angegeben wird, prüft Ihr Postfix-Container, ob die öffentlichen Spamhaus-Spiegel seine Anfragen akzeptieren, und verwendet diese stattdessen.
Wenn Spamhaus Anfragen von Ihrem Postfix-Container an die öffentlichen Spiegel ablehnt, wird es vollständig deaktiviert.

### Postfix-Konfiguration - Virtuelle Aliase

Die Postfix-Konfiguration unterstützt virtuelle Aliase mit den Dateien `postfix/conf.d/virtual` und `postfix/conf.d/virtual-regexp`.
Diese Dateien werden beim Start automatisch erstellt, basierend auf den entsprechenden [`postfix/templates/virtual.tpl`](https://raw.githubusercontent.com/springcomp/self-hosted-simplelogin/main/./postfix/templates/virtual.tpl)
und [`postfix/templates/virtual-regexp.tpl`](https://raw.githubusercontent.com/springcomp/self-hosted-simplelogin/main/./postfix/templates/virtual-regexp.tpl) Vorlagendateien.

Die Standardkonfiguration ist wie folgt:

#### virtual.tpl

Die Datei `virtual` unterstützt die Postfix-Einstellungen für `virtual_alias_maps`.
Sie enthält eine Regel, die `unknown@mydomain.com` auf `contact@mydomain.com` abbildet, um zu demonstrieren, wie
eine E-Mail von einer bestimmten Adresse, die keinem bestehenden Alias entspricht, an eine andere weitergeleitet wird, die existiert.

```postfix-conf
unknown@mydomain.com  contact@mydomain.com
```

#### virtual-regexp.tpl

Die Datei `virtual-regexp` unterstützt die Einstellungen von postfix `virtual_alias_maps`.
Sie enthält eine Regel, die E-Mails an eine beliebige Subdomain, die keinem bestehenden Alias entspricht,
an einen neuen Alias umschreibt, der zu einem Verzeichnis gehört, dessen Name von der Subdomain übernommen wird.
Dieser Alias kann bei Bedarf dynamisch erstellt werden, falls er nicht existiert.

```postfix-conf
/^([^@]+)@([^.]+)\.mydomain.com/   $2/$1@mydomain.com
```

Beispielsweise werden E-Mails, die an `someone@directory.mydomain.com` gesendet werden, von Postfix an `directory/someone@mydomain.com` weitergeleitet.

## Anleitung zum Upgrade von 3.4.0

_Dieser Abschnitt wurde in die [Referenzdokumentation](https://github.com/springcomp/self-hosted-simplelogin/wiki/upgrade-sl) verschoben._

## Anleitung zum Upgrade von einer vorherigen NGinx-basierten Einrichtung

_Dieser Abschnitt wurde in die [Referenzdokumentation](https://github.com/springcomp/self-hosted-simplelogin/wiki/upgrade-from-nginx) verschoben._


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-15

---