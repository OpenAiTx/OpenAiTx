## Introduction

**Groupe QQ d’échange : 528735636**

Composant Home Assistant

[![hacs_badge](https://img.shields.io/badge/HACS-Custom-41BDF5.svg?style=for-the-badge)](https://github.com/hacs/integration)

Ce composant Home Assistant permet aux assistants Tmall Genie, Xiao Ai et Xiao Du de se connecter aux appareils de la plateforme HomeAssistant, pour contrôler les appareils et interroger leur état.

Attention : Ce plugin ne gère que le contrôle et la remontée des états des appareils, l’ajout d’appareils doit se faire via la plateforme [HassLife](https://hass.blear.cn).

## Installation

### 1. Installer le plugin

##### Méthode 1 : installation via hacs 【Recommandé !】
>>Barre latérale HACS -> Intégrations -> Rechercher hasslife puis cliquer sur télécharger

##### Méthode 2 : téléchargement manuel [Télécharger le plugin](https://gitee.com/blear/HassLife)
>>Téléchargez le dossier `hasslife`, placez-le dans le répertoire `<répertoire_configuration_homeassistant>/custom_components/`. Si le dossier `custom_components` n’existe pas, créez-le, puis redémarrez HomeAssistant.
- Où se trouve le répertoire de configuration homeassistant ?

>>**Utilisateurs Windows :** `%APPDATA%\.homeassistant`

>>**Utilisateurs Linux :** Vous pouvez exécuter la commande `locate .homeassistant/configuration.yaml` ; le dossier `.homeassistant` trouvé est le répertoire de configuration.

>>**Utilisateurs Docker Synology :** Allez dans Docker - Images - homeassistant - Paramètres avancés - Volumes, le chemin correspondant à `/config` est le répertoire de configuration.


### 2. Configurer le plugin
##### Méthode 1 : configuration via interface UI d’intégration
>>**Cliquez dans la barre latérale de HomeAssistant sur Configuration -> Intégrations -> Ajouter une intégration en bas à droite -> recherchez hasslife puis cliquez -> saisissez votre compte et mot de passe hasslife et validez. Le plugin mettra un certain temps à démarrer, merci de patienter.**

Si vous rencontrez un message indiquant que cette intégration ne supporte pas la configuration via UI, et que vous venez d’un lien sur le site de Home Assistant, veuillez vous assurer que vous utilisez la dernière version de Home Assistant.
Vous pouvez ajouter la configuration du compte manuellement, puis redémarrer HomeAssistant.

## Étapes d’utilisation :
	1. Inscrivez un compte HassLife en ouvrant https://hass.blear.cn, créez un compte et connectez-vous
	2. Installez le plugin : après installation, redémarrez HomeAssistant, puis allez sur la page d’ajout d’intégration, ajoutez l’intégration HassLife et connectez-vous avec votre compte HassLife.
	3. Revenez à la page du site HassLife, si la configuration de votre plugin est correcte, la page du centre personnel affichera le statut du plugin comme `en ligne`
	4. Cliquez sur le menu de gestion des appareils, puis cliquez sur le bouton vert `Ajouter un appareil Homeassistant` à droite, cochez les appareils que vous souhaitez ajouter et soumettez
	5. Dans la liste des appareils, sélectionnez l’appareil que vous souhaitez configurer, cliquez sur `Configurer`, choisissez selon vos besoins la plateforme d’enceintes intelligentes à connecter, et configurez le type d’appareil et le nom de commande vocale
	6. Allez sur la page de liaison des compétences de la plateforme correspondante, liez votre compte HassLife, normalement vous verrez alors les appareils ajoutés.

## Exemple de configuration pour Tmall Genie
* Installez la dernière version de l’APP `Tmall Genie`
* Accédez via le navigateur mobile à [HassLife https://hass.blear.cn](https://hass.blear.cn) et connectez-vous à votre compte HassLife
* Sur la page du centre personnel, cliquez pour accéder à l’`Entrée de compétence Tmall Genie`
* Cliquez sur `Lier un compte de plateforme`
* Connectez-vous à votre compte HassLife
* Confirmez l’autorisation, retournez à l’onglet Genie, vous verrez les appareils ajoutés

## Exemple de configuration pour Xiao Ai
* Accédez à la liste des appareils HassLife, ajoutez les appareils nécessaires et configurez le type et le nom correspondants
* Installez la dernière version de l’APP `Mi Home`
* Ouvrez l’APP `Mi Home`
* Cliquez sur l’onglet `Moi`
* Cliquez sur `Appareils d’autres plateformes`
* Cliquez sur le `+` en haut à droite
* Trouvez `HassLife` et cliquez dessus
* Cliquez sur `Lier un compte`
* Connectez-vous à votre compte HassLife
* Confirmez l’autorisation, synchronisez les appareils

## Exemple de configuration pour Xiao Du
* Accédez à la liste des appareils HassLife, ajoutez les appareils nécessaires et configurez le type et le nom correspondants
* Installez la dernière version de l’APP `Xiao Du`
* Ouvrez l’APP `Xiao Du`
* Cliquez sur le `+` en haut à droite
* Cliquez sur `Ajouter un appareil`
* Recherchez `HassLife` et cliquez dessus
* Connectez-vous à votre compte HassLife
* Confirmez l’autorisation, synchronisez les appareils

## Appareils et attributs supportés par Tmall Genie

Les types d’appareils actuellement supportés sont : lampe, interrupteur, séchoir à linge, rideau, télévision, chauffe-eau, ventilateur, capteur, climatiseur, sélecteur binaire.

    Les états marche/arrêt des appareils sont supportés pour : lampe, interrupteur, séchoir à linge, rideau, télévision, chauffe-eau, ventilateur, capteur, climatiseur, sélecteur binaire.
    
    Lumière prise en charge : couleur, luminosité, température de couleur
    
    Climatisation prise en charge pour changer de mode : refroidissement, chauffage, ventilation, déshumidification, automatique, réglage de la température. Vitesses prises en charge : faible, moyenne, élevée, automatique
    
    Étendoir à linge pris en charge : contrôle des barres, contrôle marche/arrêt
    
    Rideaux pris en charge : ouverture et fermeture des rideaux
    
    Ventilateur pris en charge : contrôle de l'alimentation (allumer/éteindre le ventilateur), contrôle de la vitesse (1-100 niveaux (vitesse en pourcentage), niveau maximum, résistance, niveaux moyen-bas, moyen-haut, élevé, super fort, brise légère, mode automatique), rotation gauche-droite / oscillation / balayage



## Appareils et attributs pris en charge par Xiao Ai

Types d'appareils actuellement pris en charge : lumière, interrupteur, rideau, ventilateur, climatisation.

    Appareils prenant en charge l'état marche/arrêt : lumière, interrupteur, rideau, ventilateur, climatisation.
    
    Lumière prise en charge : couleur, luminosité, température de couleur
    
    Climatisation prise en charge pour changer de mode : refroidissement, chauffage, ventilation, déshumidification, automatique, réglage de la température. Vitesses prises en charge : faible, moyenne, élevée, automatique
    
    Rideaux pris en charge : ouverture et fermeture des rideaux
    
    Ventilateur pris en charge : contrôle de l'alimentation (allumer/éteindre le ventilateur), contrôle de la vitesse (1-100 niveaux (vitesse en pourcentage)), rotation gauche-droite / oscillation / balayage
	

	
## Appareils et attributs pris en charge par l'enceinte Xiaodu

    Appareils prenant en charge l'état marche/arrêt : lumière, interrupteur, rideau, ventilateur, climatisation.
    
    Lumière prise en charge : marche/arrêt
    
    Climatisation prise en charge pour changer de mode : refroidissement, chauffage, ventilation, déshumidification, automatique, réglage de la température. Vitesses prises en charge : faible, moyenne, élevée, automatique
    
    Rideaux pris en charge : ouverture et fermeture des rideaux
    
    Ventilateur pris en charge : contrôle de l'alimentation (allumer/éteindre le ventilateur), contrôle de la vitesse (1-10 niveaux)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-03

---