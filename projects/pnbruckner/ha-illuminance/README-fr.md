# <img src="https://brands.home-assistant.io/illuminance/icon.png" alt="Sun2 Sensor" width="50" height="50"/> Capteur d'Illuminance  
Crée une entité `sensor` qui estime l'illuminance extérieure basée soit sur l'élévation du soleil, soit sur l'heure de la journée.  
Dans les deux cas, la valeur peut être ajustée davantage en fonction des conditions météorologiques actuelles ou de la couverture nuageuse obtenue à partir d'une autre entité existante.  


## Modes de fonctionnement  
Trois modes sont disponibles : normal, irradiance et simple.  

### Modes Normal/Irradiance - Élévation du soleil  
Ces modes utilisent un algorithme de l’Observatoire Naval des États-Unis[^1] pour estimer l’illuminance ou l’irradiance solaire en fonction de l’élévation (ou altitude) du soleil. La valeur maximale d’illuminance est d’environ 150 000 lx, et la valeur maximale d’irradiance est d’environ 1 250 Watts/m².  
Voici un exemple de ce à quoi pourrait ressembler l’illuminance sur une période de trois jours.  

<p align="center">  
  <img src=images/normal.png>  
</p>  

[^1]: Janiczek, P. M., and DeYoung, J. A. _Computer Programs for Sun and Moon Illuminance With Contingent Tables and Diagrams_. Circular No. 171. Washington, D. C.: United States Naval Observatory, 1987 [Google Scholar](https://scholar.google.com/scholar_lookup?title=Computer%20programs%20for%20sun%20and%20moon%20illuminance%20with%20contingent%20tables%20and%20diagrams&author=P.%20M.%20Janiczek&author=J.%20A.%20Deyoung&publication_year=1987&book=Computer%20programs%20for%20sun%20and%20moon%20illuminance%20with%20contingent%20tables%20and%20diagrams)  

### Mode Simple - Heure de la journée  
La nuit, la valeur est de 10 lx. Un peu avant le lever du soleil jusqu’à un peu après, la valeur est augmentée progressivement selon les conditions actuelles. Il en va de même autour du coucher du soleil, sauf que la valeur est diminuée progressivement. Pour des raisons historiques, la valeur maximale est de 10 000 lx. Voici un exemple de ce que cela pourrait donner sur une période de trois jours.  

<p align="center">  
  <img src=images/simple.png>  
</p>  

## Sources météorologiques supportées  
Toute entité météo utilisant la [liste standard des conditions](https://www.home-assistant.io/integrations/weather/#condition-mapping), ou fournissant un pourcentage de couverture nuageuse, devrait fonctionner avec cette intégration.  
Les sources de données météorologiques suivantes sont connues pour être supportées :  

Intégration | Remarques  
-|-
[AccuWeather](https://www.home-assistant.io/integrations/accuweather/) | `weather`  
[Buienradar](https://www.home-assistant.io/integrations/buienradar/) | `weather`  
[ecobee](https://www.home-assistant.io/integrations/ecobee/) |  
[Meteorologisk institutt (Met.no)](https://www.home-assistant.io/integrations/met/) | `weather`  
[OpenWeatherMap](https://www.home-assistant.io/integrations/openweathermap/) | `weather`; cap_coverage nuageuse & condition `sensor`  

## Installation  

Le logiciel d’intégration doit d’abord être installé en tant que composant personnalisé.
Vous pouvez utiliser HACS pour gérer l'installation et recevoir des notifications de mise à jour.
Ou vous pouvez installer le logiciel manuellement.

<details>
<summary>Avec HACS</summary>

[![hacs_badge](https://img.shields.io/badge/HACS-Custom-41BDF5.svg)](https://hacs.xyz/)

1. Ajoutez ce dépôt comme [dépôt personnalisé](https://hacs.xyz/docs/faq/custom_repositories/) :
   Il devrait alors apparaître comme une nouvelle intégration. Cliquez dessus. Si nécessaire, cherchez "illuminance".
   ```text
   https://github.com/pnbruckner/ha-illuminance
   ```
   Ou utilisez ce bouton :
  
   [![Ouvrez votre instance Home Assistant et ouvrez un dépôt dans le Home Assistant Community Store.](https://my.home-assistant.io/badges/hacs_repository.svg)](https://my.home-assistant.io/redirect/hacs_repository/?owner=pnbruckner&repository=ha-illuminance&category=integration)

1. Téléchargez l'intégration en utilisant le bouton approprié.

</details>

<details>
<summary>Installation manuelle</summary>

Placez une copie des fichiers de [`custom_components/illuminance`](custom_components/illuminance)
dans `<config>/custom_components/illuminance`,
où `<config>` est votre répertoire de configuration Home Assistant.

>__NOTE__ : Lors du téléchargement, assurez-vous d'utiliser le bouton `Raw` sur la page de chaque fichier.

</details>

### Après l'installation

Après le téléchargement, vous devrez redémarrer Home Assistant.

### Versions

Cette intégration personnalisée supporte les versions HomeAssistant 2024.8.3 ou plus récentes.

## Services

### `illuminance.reload`

Recharge Illuminance depuis la configuration YAML. Ajoute également `ILLUMINANCE` à la page Outils pour développeurs -> YAML.

## Variables de configuration

Une liste d'options de configuration pour un ou plusieurs capteurs. Chaque capteur est défini par les options suivantes.

> Note : Ceci définit la configuration via YAML. Cependant, les mêmes capteurs peuvent être ajoutés via l’interface utilisateur.

Clé | Optionnel | Description
-|-|-
`unique_id` | non | Identifiant unique pour le capteur. Cela permet de modifier n’importe quelle autre option sans que cela ressemble à un nouveau capteur. (Requis uniquement pour la configuration basée sur YAML.)
`entity_id` | oui | ID d'entité d'une autre entité indiquant les conditions météorologiques actuelles ou le pourcentage de couverture nuageuse
`fallback` | oui | Diviseur d'illuminance à utiliser lorsque les données météorologiques ne sont pas disponibles. Doit être compris entre 1 (clair) et 10 (obscur). Par défaut, c’est 10 si `entity_id` est utilisé, ou 1 sinon.
`mode` | oui | Mode de fonctionnement. Les choix sont `normal` (par défaut) qui utilise l'élévation du soleil, `simple` qui utilise l'heure de la journée et `irradiance` qui est identique à `normal`, sauf que la valeur est exprimée en irradiance en Watts/m².
`name` | oui | Nom du capteur. Par défaut `Illuminance`.
`scan_interval` | oui | Intervalle de mise à jour. Le minimum est de 30 secondes. Par défaut, c’est 5 minutes.

## Versions avant 2.1.0
Voir https://github.com/pnbruckner/homeassistant-config/blob/master/docs/illuminance.md.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-28

---