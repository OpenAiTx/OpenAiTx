![Logo](https://raw.githubusercontent.com/TA2k/ioBroker.vw-connect/master/admin/vw-connect.png)

# ioBroker.vw-connect

[![NPM version](http://img.shields.io/npm/v/iobroker.vw-connect.svg)](https://www.npmjs.com/package/iobroker.vw-connect)
[![Downloads](https://img.shields.io/npm/dm/iobroker.vw-connect.svg)](https://www.npmjs.com/package/iobroker.vw-connect)
[![Dependency Status](https://img.shields.io/david/ta2k/iobroker.vw-connect.svg)](https://david-dm.org/ta2k/iobroker.vw-connect)
[![Known Vulnerabilities](https://snyk.io/test/github/ta2k/ioBroker.vw-connect/badge.svg)](https://snyk.io/test/github/ta2k/ioBroker.vw-connect)

[![NPM](https://nodei.co/npm/iobroker.vw-connect.png?downloads=true)](https://nodei.co/npm/iobroker.vw-connect/)

**Tests:**: [![Travis-CI](http://img.shields.io/travis/ta2k/ioBroker.vw-connect/master.svg)](https://travis-ci.org/ta2k/ioBroker.vw-connect)

## Adaptateur vw-connect pour ioBroker

Adaptateur pour VW We Connect, We Connect ID, We Charge, myAudi, Skoda Connect, Seat Connect et We Connect Go

Veuillez mettre à jour votre système sur Node 10.
<https://forum.iobroker.net/topic/22867/how-to-node-js-f%C3%BCr-iobroker-richtig-updaten>

## Utilisation

Utilisez l’état sous contrôle à distance pour contrôler votre voiture à distance.
Le rafraîchissement normal est l’intervalle de sondage pour recevoir les données du Cloud VAG
Le rafraîchissement forcé est pour les voitures non électriques afin de forcer un rafraîchissement, ce nombre est limité par VAG jusqu’à ce que la voiture soit rallumée.
Les données de trajet ne sont disponibles que pour les voitures non électriques.

Vous pouvez régler la température de climatisation dans
.climater.settings.targetTemperature.content

## Discussion et questions

<https://forum.iobroker.net/topic/26438/test-adapter-vw-connect-für-vw-id-audi-seat-skoda>

## Explication des champs de statut

### Liste des entrées

```

```
## Journal des modifications

### 0.7.12 (2025-05-05)

- correction pour le token de rafraîchissement Skoda
- correction pour l'activation de la ventilation
- ajout de nouveaux points de terminaison non pris en charge

### 0.7.9 (2025-03-20)

- correction pour le chargeur mural ID

### 0.7.7 (2025-03-02)

- correction pour chauffage auxiliaire Skoda et durée
- correction pour verrouillage/déverrouillage Skoda

### 0.7.6 (2025-02-28)

- correction pour mises à jour du statut de charge uniquement au démarrage
- correction pour l'état ismoving de Skoda

### 0.7.3 (2025-02-26)

- correction pour la définition de setTemperature
- correction pour déverrouillage/verrouillage Skoda

### 0.7.0 (2025-02-25)

- correction pour Skoda et Seat
- Structure d'état complètement modifiée, veuillez supprimer les anciens états sous Objets

### 0.6.1 (2024-10-01)

- correction pour la connexion Skoda

### 0.6.0 (2024-04-11)

- ajout d'états supplémentaires pour Cupra

### 0.5.4 (2024-03-17)

- correction des états des portes et fenêtres

### 0.4.1

- Correction de la mise à jour du statut VW

### 0.0.65

- Correction de la connexion Cupra

### 0.0.63

- Correction de la connexion VW/Skoda etron

### 0.0.62

- Correction de la connexion Audi etron

### 0.0.61

- Correction de la connexion ID

### 0.0.60

- Améliorations mineures. L'intervalle minimum WeCharge est maintenant de 15 minutes

### 0.0.55

- correction de la mise à jour du statut ID

### 0.0.51

- correction de la connexion Audi etron

### 0.0.48

- correction de la connexion, correction de la mise à jour Audi, ajout d'une limite pour wallbox

### 0.0.43

- augmentation des délais d'attente du token de rafraîchissement

### 0.0.42

- correction de la connexion Skoda

### 0.0.40

- ajout de climate v3 pour voitures récentes. Ajout Powerpass et Seat Elli

### 0.0.39

- correction de la connexion ID

### 0.0.36

- ajout du support Skoda Enyaq


### 0.0.35

- ajout de la compatibilité nodeJS v10

### 0.0.34

- ajout de l’acceptation automatique du nouveau consentement à la confidentialité

### 0.0.32

- correction de la sélection des derniers trajets récents

### 0.0.31

- activation de la sélection multiple des types de trajets

### 0.0.30

- correction du problème de plusieurs voitures, ajout du mode VWv2 pour le moment il n’y a pas de différence entre VW et VWv2

### 0.0.29

- correction du refreshToken Skoda, petites améliorations

### 0.0.26

- corrections de bugs

### 0.0.25

- ajout de we charge

### 0.0.24

- ajout de la mise à jour d’état à distance

### 0.0.23

- ajout de Seat et nouvelle climatisation v2

### 0.0.22

- calcul de la température extérieure en °C aussi pour Skoda et Audi

### 0.0.21

- ajout des télécommandes pour id

### 0.0.20

- correction de la connexion audi, ajout de la connexion ID

### 0.0.19

- sauvegarde des objets d’état par id au lieu de numéros consécutifs

### 0.0.18

- correction du statut de batterie pour les modèles 2020

### 0.0.17

- ajout du support pour les modèles 2020

### 0.0.16

- correction des problèmes avec js.controller 3

### 0.0.11

- correction du bug audi avec plusieurs véhicules
- masquage de l’erreur de mise à jour de statut si la fonctionnalité n’est pas disponible

## Licence

Licence MIT

Copyright (c) 2019-2030 ta2k <tombox2020@gmail.com>

La permission est par la présente accordée, gratuitement, à toute personne obtenant une copie
de ce logiciel et des fichiers de documentation associés (le "Logiciel"), de traiter
le Logiciel sans restriction, y compris sans limitation les droits
d’utiliser, copier, modifier, fusionner, publier, distribuer, sous-licencier, et/ou vendre
des copies du Logiciel, et de permettre aux personnes à qui le Logiciel est
fournit de le faire, sous réserve des conditions suivantes :

L’avis de droit d’auteur ci-dessus et cet avis de permission doivent être inclus dans toutes
copies ou portions substantielles du Logiciel.

LE LOGICIEL EST FOURNI "TEL QUEL", SANS GARANTIE D’AUCUNE SORTE, EXPRESSE OU
IMPLICITE, Y COMPRIS MAIS SANS S’Y LIMITER AUX GARANTIES DE QUALITÉ MARCHANDE,
D’ADAPTATION À UN USAGE PARTICULIER ET DE NON-VIOLATION. EN AUCUN CAS LES
AUTEURS OU DÉTENTEURS DU COPYRIGHT NE POURRONT ÊTRE TENUS RESPONSABLES DE TOUTE RÉCLAMATION, DOMMAGE OU AUTRE
RESPONSABILITÉ, QU’IL SOIT CONTRACTUELLE, DÉLICTUELLE OU AUTRE, DÉCOULANT DE,
HORS OU EN LIEN AVEC LE LOGICIEL OU L’UTILISATION OU AUTRE TRAITEMENT DANS LE
LOGICIEL.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-01

---