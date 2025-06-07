# mimotion
![ Schritte fälschen](https://github.com/xunichanghuan/mimotion-run/actions/workflows/run.yml/badge.svg)
[![GitHub forks](https://img.shields.io/github/forks/xunichanghuan/mimotion-run?style=flat-square)](https://github.com/xunichanghuan/mimotion-run/network)
[![GitHub stars](https://img.shields.io/github/stars/xunichanghuan/mimotion-run?style=flat-square)](https://github.com/xunichanghuan/mimotion-run/stargazers)
[![GitHub issues](https://img.shields.io/github/issues/xunichanghuan/mimotion-run?style=flat-square)](https://github.com/xunichanghuan/mimotion-run/issues)

# Automatisches Schrittzählen für Xiaomi Mi Fit

> Automatisches Schrittzählen für Xiaomi Mi Fit

## Anleitung zur Bereitstellung mit Github Actions

### 1. Forke dieses Repository

### 2. Konto und Passwort festlegen
# Neu ab 20230224
Füge eine Variable mit dem Namen **CONFIG** hinzu: Einstellungen --> Secrets --> New secret. Konfiguriere mehrere Konten mit der folgenden JSON-Vorlage, unterstützt E-Mail und Telefonnummer.
```
{
  "TG_BOT_TOKEN": "Telegram TG_BOT_TOKEN, falls nicht vorhanden, bitte leer lassen",
  "TG_USER_ID": "Telegram TG_USER_ID, falls nicht vorhanden, bitte leer lassen",
  "SKEY": "CoolPush skey, falls nicht vorhanden, bitte leer lassen",
  "SCKEY": "ServerChan sckey, falls nicht vorhanden, bitte leer lassen",
  "POSITION": "WeChat-Enterprise-Benachrichtigung aktivieren, falls nicht vorhanden, bitte leer lassen",
  "CORPID": "Firmen-ID, einsehbar in WeChat-Enterprise unter Mein Unternehmen --> Unternehmensinfo, falls nicht vorhanden, bitte leer lassen",
  "CORPSECRET": "Secret des eigenen WeChat-Enterprise-Apps, jedes App hat ein eigenes Secret, falls nicht vorhanden, bitte leer lassen",
  "AGENTID": "Deine WeChat-Enterprise-App-ID, ohne Anführungszeichen, eine ganze Zahl (AgentId), falls nicht vorhanden, bitte leer lassen",
  "TOUSER": "Mitglieder, die die Nachricht erhalten (Mitglieds-ID-Liste, mehrere Empfänger durch „&#166;“ getrennt, max. 1000). Speziell: „@all“ sendet an alle Mitglieder dieser App. Falls nicht vorhanden, bitte leer lassen",
  "TOPARTY": "Abteilungen, die die Nachricht erhalten (Abteilungs-ID-Liste, mehrere durch „&#166;“ getrennt, max. 100). Bei touser=„@all“ bitte „@all“ eintragen, falls nicht vorhanden, bitte leer lassen",
  "TOTAG": "Tags für den Empfang der Nachricht (Tag-ID-Liste, mehrere durch „&#166;“ getrennt, max. 100). Bei touser=„@all“ bitte „@all“ eintragen, falls nicht vorhanden, bitte leer lassen",
  "OPEN_GET_WEATHER": "Wetterabhängige Reduktion der Schrittzahl aktivieren, falls nicht vorhanden, bitte leer lassen",
  "AREA": "Gebe das Gebiet für die Wetterabfrage an (bei Aktivierung erforderlich), z. B. Beijing. Falls nicht vorhanden, bitte leer lassen",
  "QWEATHER": "Trage hier deinen QWeather Private KEY ein, Antragsseite: https://console.qweather.com/#/apps, falls nicht vorhanden, bitte leer lassen",
  "MIMOTION": [
    {
      "max_step": "20000",
      "min_step": "10000",
      "password": "Sitoi",
      "user": "18888xxxxxx"
    },
    {
      "max_step": "Maximale Schrittzahl für mehrere Konten, siehe oben",
      "min_step": "Minimale Schrittzahl für mehrere Konten, siehe oben",
      "password": "Passwort für mehrere Konten, siehe oben",
      "user": "Telefonnummer für mehrere Konten, siehe oben"
    }
  ]
}
```
> Füge eine Variable mit dem Namen **PAT** hinzu: Einstellungen --> Secrets --> New secret

| Secrets |  Format  |
| -------- | ----- |
| PAT |   **PAT** muss beantragt werden, Wert ist ein GitHub-Token. Anleitung: https://www.jianshu.com/p/bb82b3ad1d11 , benötigt repo- und workflow-Rechte, Pflichtfeld, um git push Berechtigungsfehler zu vermeiden. |

**CONFIG**-Beispiel
```
{
  "TG_BOT_TOKEN": "",
  "TG_USER_ID": "",
  "SKEY": "",
  "SCKEY": "",
  "POSITION": "",
  "CORPID": "",
  "CORPSECRET": "",
  "AGENTID": "",
  "TOUSER": "",
  "TOPARTY": "",
  "TOTAG": "",
  "OPEN_GET_WEATHER": "",
  "AREA": "",
  "QWEATHER": "",
  "MIMOTION": [
    {
      "max_step": "20000",
      "min_step": "10000",
      "password": "Sitoi",
      "user": "18888xxxxxx"
    },
    {
      "max_step": "Maximale Schrittzahl für mehrere Konten, siehe oben",
      "min_step": "Minimale Schrittzahl für mehrere Konten, siehe oben",
      "password": "Passwort für mehrere Konten, siehe oben",
      "user": "Telefonnummer für mehrere Konten, siehe oben"
    }
  ]
}
```

### 3. Benutzerdefinierte Startzeit

Bearbeite **random_cron.sh**
Ändere die Zeit im **if**-Befehl auf UTC-Zeit, also **Peking-Zeit minus 8 Stunden**. Beispiel: Peking-Zeit 8 Uhr ist UTC 0 Uhr. Die gewünschte Zeit minus 8 ist die UTC-Zeit.



## Hinweise

1. Läuft täglich siebenmal, gesteuert durch random_cron.sh, Minutenwert ist zufällig.

2. Die Anzahl der Konten und Passwörter muss übereinstimmen, sonst funktioniert es nicht!

3. Startzeit muss in UTC angegeben werden!

4. Registrierung für ServerChan [Hier klicken](https://sct.ftqq.com/)

5. Falls die Schrittzahl in Alipay nicht aktualisiert wird: Gehe zu Mi Fit -> Einstellungen -> Konto -> Abmelden -> Daten löschen, dann erneut anmelden und Drittanbieter wieder verbinden.

6. Mi Fit selbst aktualisiert die Schrittzahl nicht, nur verknüpfte Dienste werden synchronisiert!!!!!!

7. Bitte forke beim Verwenden den [Haupt-Branch](https://github.com/xunichanghuan/mimotion-run/), um unnötige Bugs zu vermeiden.

8. Achtung: Das Konto ist **nicht** das [Xiaomi-Konto], sondern das [Mi Fit]-Konto.

## Historische Star-Anzahl

[![Stargazers over time](https://starchart.cc/xunichanghuan/mimotion-run.svg)](https://starchart.cc/xunichanghuan/mimotion-run)


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx) - 2025-06-07

---