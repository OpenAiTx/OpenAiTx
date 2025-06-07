# mimotion
![刷步数](https://github.com/xunichanghuan/mimotion-run/actions/workflows/run.yml/badge.svg)
[![GitHub forks](https://img.shields.io/github/forks/xunichanghuan/mimotion-run?style=flat-square)](https://github.com/xunichanghuan/mimotion-run/network)
[![GitHub stars](https://img.shields.io/github/stars/xunichanghuan/mimotion-run?style=flat-square)](https://github.com/xunichanghuan/mimotion-run/stargazers)
[![GitHub issues](https://img.shields.io/github/issues/xunichanghuan/mimotion-run?style=flat-square)](https://github.com/xunichanghuan/mimotion-run/issues)

# Mise à jour automatique du nombre de pas Xiaomi Mi Fit

> Mise à jour automatique du nombre de pas Xiaomi Mi Fit

## Guide de déploiement via Github Actions

### 1. Forkez ce dépôt

### 2. Configurez votre compte et mot de passe
# Ajout du 20230224
Ajoutez une variable nommée **CONFIG** : Settings-->Secrets-->New secret. Configurez plusieurs comptes à l’aide du modèle JSON ci-dessous, prise en charge des adresses e-mail et des numéros de téléphone.
```
{
  "TG_BOT_TOKEN": "Token Telegram TG_BOT_TOKEN, si vous n'en avez pas, laissez vide",
  "TG_USER_ID": "User ID Telegram TG_USER_ID, si vous n'en avez pas, laissez vide",
  "SKEY": "Skey CoolPush, si vous n'en avez pas, laissez vide",
  "SCKEY": "Sckey Server酱, si vous n'en avez pas, laissez vide",
  "POSITION": "Activer la notification Wechat Enterprise, si vous n'en avez pas, laissez vide",
  "CORPID": "ID de l'entreprise, connectez-vous à Wechat Enterprise, puis allez dans Mon Entreprise-->Informations sur l'entreprise, si vous n'en avez pas, laissez vide",
  "CORPSECRET": "Secret de l'application auto-hébergée Wechat Enterprise, chaque application a son propre secret, si vous n'en avez pas, laissez vide",
  "AGENTID": "ID de votre application auto-hébergée Wechat Enterprise, sans guillemets, c'est un entier (AgentId), si vous n'en avez pas, laissez vide",
  "TOUSER": "Membres destinataires, liste d’ID séparés par ”&#166;”, max 1000. Spécial : ”@all” envoie à tous les membres de l’application. Si vous n'en avez pas, laissez vide",
  "TOPARTY": "Départements destinataires, liste d’ID séparés par ”&#166;”, max 100. Si touser est ”@all”, écrivez ”@all”. Si vous n'en avez pas, laissez vide",
  "TOTAG": "Tags destinataires, liste d’ID séparés par ”&#166;”, max 100. Si touser est ”@all”, écrivez ”@all”. Si vous n'en avez pas, laissez vide",
  "OPEN_GET_WEATHER": "Activer la réduction du nombre de pas selon la météo locale, si vous n'en avez pas, laissez vide",
  "AREA": "Définir la région pour la météo (obligatoire si activé ci-dessus), ex : Pékin. Si vous n'en avez pas, laissez vide",
  "QWEATHER": "Inscrivez ici la clé privée QWeather, demandez-la sur https://console.qweather.com/#/apps, si vous n'en avez pas, laissez vide",
  "MIMOTION": [
    {
      "max_step": "20000",
      "min_step": "10000",
      "password": "Sitoi",
      "user": "18888xxxxxx"
    },
    {
      "max_step": "Pour un autre compte, saisissez la valeur maximale de pas, cf. ci-dessus",
      "min_step": "Pour un autre compte, saisissez la valeur minimale de pas, cf. ci-dessus",
      "password": "Pour un autre compte, saisissez le mot de passe, cf. ci-dessus",
      "user": "Pour un autre compte, saisissez le numéro de téléphone, cf. ci-dessus"
    }
  ]
}
```
> Ajoutez une variable nommée **PAT** : Settings-->Secrets-->New secret

| Secrets |  Format  |
| ------- | ------ |
| PAT     |   Ce **PAT** doit être demandé, la valeur est un token GitHub, tutoriel ici : https://www.jianshu.com/p/bb82b3ad1d11 , nécessite les droits repo et workflow, ce champ est obligatoire pour éviter les erreurs de permission lors d’un git push. |

**Exemple de CONFIG**
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
      "max_step": "Pour un autre compte, saisissez la valeur maximale de pas, cf. ci-dessus",
      "min_step": "Pour un autre compte, saisissez la valeur minimale de pas, cf. ci-dessus",
      "password": "Pour un autre compte, saisissez le mot de passe, cf. ci-dessus",
      "user": "Pour un autre compte, saisissez le numéro de téléphone, cf. ci-dessus"
    }
  ]
}
```

### 3. Personnaliser l'heure de démarrage

Éditez **random_cron.sh**  
Modifiez l'heure vérifiée dans la condition **if** en temps UTC, c’est-à-dire **heure de Pékin - 8**. Par exemple, 8h à Pékin correspond à 0h UTC. L’heure d’exécution requise moins 8 donne l’heure UTC.



## Remarques

1. Exécution sept fois par jour, contrôlée par random_cron.sh, les minutes sont aléatoires.

2. Veillez à ce que le nombre de comptes et de mots de passe corresponde, sinon cela ne fonctionnera pas !!!

3. L'heure de démarrage doit être en UTC !

4. Inscription Server酱 [cliquez ici](https://sct.ftqq.com/)

5. Si Alipay n’a pas mis à jour le nombre de pas, allez sur Mi Fit -> Paramètres -> Compte -> Déconnexion du compte -> Vider les données, puis reconnectez-vous et reliez à nouveau les services tiers.

6. Mi Fit n’actualise pas le nombre de pas, seule l’application liée synchronisera les données !!!

7. Veuillez forker la [branche principale](https://github.com/xunichanghuan/mimotion-run/) pour éviter des bugs inutiles.

8. Attention, le compte n’est pas un [compte Xiaomi] mais un compte [Xiaomi Mi Fit].

## Historique du nombre d’étoiles

[![Stargazers over time](https://starchart.cc/xunichanghuan/mimotion-run.svg)](https://starchart.cc/xunichanghuan/mimotion-run)


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx) - 2025-06-07

---