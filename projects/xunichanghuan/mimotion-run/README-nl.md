# mimotion
![ Stappen teller](https://github.com/xunichanghuan/mimotion-run/actions/workflows/run.yml/badge.svg)
[![GitHub forks](https://img.shields.io/github/forks/xunichanghuan/mimotion-run?style=flat-square)](https://github.com/xunichanghuan/mimotion-run/network)
[![GitHub stars](https://img.shields.io/github/stars/xunichanghuan/mimotion-run?style=flat-square)](https://github.com/xunichanghuan/mimotion-run/stargazers)
[![GitHub issues](https://img.shields.io/github/issues/xunichanghuan/mimotion-run?style=flat-square)](https://github.com/xunichanghuan/mimotion-run/issues)

# Xiaomi Mi Fit Automatisch Stappenaantal Verhogen

> Xiaomi Mi Fit automatisch stappen bijwerken

## Github Actions Implementatiehandleiding

### 1. Fork deze repository

### 2. Stel account en wachtwoord in
# Toegevoegd op 20230224
Voeg een variabele toe genaamd **CONFIG**: Instellingen-->Secrets-->Nieuw secret. Configureer meerdere accounts met onderstaande JSON-template, ondersteunt e-mail en telefoonnummer.
```
{
  "TG_BOT_TOKEN": "telegram TG_BOT_TOKEN, laat leeg als je deze niet hebt",
  "TG_USER_ID": "telegram TG_USER_ID, laat leeg als je deze niet hebt",
  "SKEY": "Kuaipush skey, laat leeg als je deze niet hebt",
  "SCKEY": "Serverchan sckey, laat leeg als je deze niet hebt",
  "POSITION": "WeChat Work push activeren, laat leeg als je deze niet hebt",
  "CORPID": "Bedrijfs-ID, inloggen op WeChat Work, bekijken bij Mijn Bedrijf-->Bedrijfsinformatie, laat leeg als je deze niet hebt",
  "CORPSECRET": "WeChat Work zelfgemaakte app, elke app heeft een eigen secret, laat leeg als je deze niet hebt",
  "AGENTID": "Vul je WeChat Work zelfgemaakte app-ID in, zonder aanhalingstekens, een geheel getal, dat is AgentId, laat leeg als je deze niet hebt",
  "TOUSER": "Specificeer de leden die het bericht ontvangen, lijst van gebruikers-ID's (meerdere ontvangers gescheiden door '¦', max. 1000). Speciaal: '@all' om naar alle leden te sturen. Laat leeg als je deze niet hebt",
  "TOPARTY": "Specificeer de afdelingen die het bericht ontvangen, lijst van afdelings-ID's, meerdere ontvangers gescheiden door '¦', max. 100. Vul '@all' in als touser '@all' is. Laat leeg als je deze niet hebt",
  "TOTAG": "Specificeer de tags die het bericht ontvangen, lijst van tag-ID's, meerdere ontvangers gescheiden door '¦', max. 100. Vul '@all' in als touser '@all' is. Laat leeg als je deze niet hebt",
  "OPEN_GET_WEATHER": "Activeer het verlagen van stappen op basis van het weer, laat leeg als je deze niet hebt",
  "AREA": "Stel het gebied in voor het ophalen van het weer (verplicht als bovenstaande optie aanstaat), bijvoorbeeld Beijing. Laat leeg als je deze niet hebt",
  "QWEATHER": "Vul hier de HeWeather Private KEY in, aanvragen via https://console.qweather.com/#/apps, laat leeg als je deze niet hebt",
  "MIMOTION": [
    {
      "max_step": "20000",
      "min_step": "10000",
      "password": "Sitoi",
      "user": "18888xxxxxx"
    },
    {
      "max_step": "Vul het maximum aantal stappen voor meerdere accounts in, zie boven",
      "min_step": "Vul het minimum aantal stappen voor meerdere accounts in, zie boven",
      "password": "Vul het wachtwoord voor meerdere accounts in, zie boven",
      "user": "Vul het telefoonnummer voor meerdere accounts in, zie boven"
    }
  ]
}
```
> Voeg een variabele toe genaamd **PAT**: Instellingen-->Secrets-->Nieuw secret

| Secrets |  Formaat  |
| -------- | ----- |
| PAT |   Deze **PAT** moet aangevraagd worden, waarde is een github token, instructies: https://www.jianshu.com/p/bb82b3ad1d11 , vereist repo- en workflowrechten, verplicht om git push permissiefouten te voorkomen. |

**Voorbeeld van CONFIG**
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
      "max_step": "Vul het maximum aantal stappen voor meerdere accounts in, zie boven",
      "min_step": "Vul het minimum aantal stappen voor meerdere accounts in, zie boven",
      "password": "Vul het wachtwoord voor meerdere accounts in, zie boven",
      "user": "Vul het telefoonnummer voor meerdere accounts in, zie boven"
    }
  ]
}
```

### 3. Aangepaste starttijd instellen

Bewerk **random_cron.sh**
Pas de tijd in de **if**-statement aan naar UTC-tijd, dat is **Beijing-tijd -8**. Bijvoorbeeld, 8 uur Beijing-tijd is 0 uur UTC. De gewenste tijd min 8 is de UTC-tijd.



## Opmerkingen

1. Draait zeven keer per dag, geregeld door random_cron.sh, minuten zijn willekeurig.

2. Het aantal accounts en wachtwoorden moeten overeenkomen, anders werkt het niet!

3. Starttijd moet in UTC-tijd zijn!

4. Serverchan registratie: [Klik hier](https://sct.ftqq.com/)

5. Als Alipay het aantal stappen niet bijwerkt, ga naar Mi Fit->Instellingen->Account->Afmelden->Gegevens wissen, log opnieuw in en koppel de derde partij opnieuw.

6. Mi Fit zal het aantal stappen niet bijwerken, alleen gekoppelde accounts worden gesynchroniseerd!

7. Fork bij gebruik altijd de [hoofdbranch](https://github.com/xunichanghuan/mimotion-run/) om onnodige bugs te voorkomen.

8. Let op, het account is geen [Xiaomi-account], maar een [Mi Fit]-account.

## Historisch aantal sterren

[![Stargazers over time](https://starchart.cc/xunichanghuan/mimotion-run.svg)](https://starchart.cc/xunichanghuan/mimotion-run)

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx) - 2025-06-07

---