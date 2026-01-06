# Calendrier Familial Domotique DIY (Clone Skylight)

![Calendrier Sklylight](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/assets/main_view.jpeg)
![DIY Skylight](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/assets/sky2.png)

## 📖 Introduction

Ma femme a récemment été bombardée sur les réseaux sociaux par des publicités pour des calendriers domotiques (Skylight, Cozyla, Hearth) et était prête à dépenser plus de 300 $ pour en acheter un. Avant de lui donner le feu vert, j'ai demandé une chance de les étudier.

J'ai réalisé que la plupart offraient des fonctionnalités similaires mais différaient significativement en prix. Plus important encore, je n'ai vu aucune fonctionnalité remarquable que je ne pourrais pas implémenter dans **Home Assistant**.

**L’objectif :** Un calendrier tactile, approuvé par la femme (WAF - Wife Acceptance Factor), adapté au plan de travail et s’intégrant profondément dans notre maison intelligente sans frais mensuels.

## 💡 Pourquoi DIY ?

Choisir la voie DIY avec Home Assistant a apporté plusieurs avantages par rapport à l’achat d’un écran Skylight/Hearth :

* **Pas de frais mensuels :** Évite les abonnements pour les fonctionnalités « premium ».
* **Intégration transparente :** Il communique avec nos lumières, tâches (Grocy) et capteurs de présence.
* **Matériel ancien :** Réutilisation d’un Mini PC et d’un moniteur standard.
* **Confidentialité :** Pas de verrouillage fournisseur ni risque de fermeture de la société.

## 🛠 Sélection du matériel

Cela est actuellement conçu pour afficher le tableau de bord sur n’importe quel écran HD (1920x1080).

Dans mon cas, la contrainte était qu’il « ressemble » à Skylight, soit tactile, adapté au plan de travail, avec la possibilité de le déplacer à différents endroits. J’ai donc opté pour le matériel décrit ci-dessous.
Néanmoins, votre cas peut être différent et vous devrez l’ajuster selon vos besoins, par exemple si vous souhaitez l’afficher sur une tablette ou autre.

Le matériel que j’ai initialement utilisé a été choisi sur la base de ce que j’ai mentionné ci-dessus, avec l’espoir de pouvoir étendre les fonctionnalités en utilisant la webcam, le haut-parleur et le microphone. Actuellement, je le construirais probablement différemment avec le recul, car je n’ai pas eu le temps d’exploiter ces idées matérielles supplémentaires.

* **Moniteur :** [HP Engage 15 pouces Tactile](https://computers.woot.com/offers/hp-engage-16t-fhd-monitor). Je l’ai choisi plutôt que des moniteurs portables génériques car il inclut un **haut-parleur, une webcam et un microphone intégrés**, permettant un contrôle vocal futur ou des appels vidéo.
* **Ordinateur :** Un ancien Mini PC (NUC/Tiny PC) fonctionnant sous Windows/Linux en mode Kiosque, ou un Raspberry Pi 4.~~

## ✨ Fonctionnalités

* **Vues familiales et individuelles :** Activer/désactiver les calendriers de membres spécifiques de la famille.
* **Synchronisation bidirectionnelle :** Modifier les événements sur l’écran ou sur nos téléphones (Google Calendar).
* **Popup « Ajouter un événement » :** Une interface personnalisée pour ajouter des événements à des calendriers spécifiques directement depuis l’écran.

* **Météo & Date :** En-tête beau et facile à lire.  
* **Adaptatif :** Ajuste automatiquement le nombre de jours en fonction de la largeur de l’écran (Mobile vs Bureau).  

---  

## ⚙️ Guide d'installation  

*Note : Cette configuration utilise un **package YAML** pour créer automatiquement tous les assistants, scripts et variables nécessaires. Vous n’avez pas besoin de les créer manuellement.*  

### 1. Prérequis (HACS)  

Vous devez avoir [HACS](https://hacs.xyz/) installé. Veuillez installer les intégrations **Frontend** suivantes :  

* `week-planner-card`  
* `bubble-card`  
* `config-template-card`  
* `card-mod`  
* `better-moment-card`  
* `weather-card`  
* `browser_mod` (Nécessaire pour le fonctionnement des popups)  
* `layout-card` (Nécessaire pour la vue Sections)  
* `button-card` (Nécessaire pour le popup d’ajout d’événement)  

### 2. Le Backend (Le Cerveau)  

1. Ouvrez votre fichier `configuration.yaml` dans Home Assistant.  
2. Assurez-vous d’avoir cette ligne ajoutée sous `homeassistant:` pour activer les packages :

   ```yaml
   homeassistant:
     packages: !include_dir_named packages
   ```
3. Créez un dossier nommé `packages` dans votre répertoire de configuration HA (si vous n'en avez pas).
4. Téléchargez [packages/family_calendar.yaml](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/packages/family_calendar.yaml) depuis ce dépôt.
5. Placez le fichier dans votre dossier `packages/`.
6. **Redémarrez Home Assistant**.

### 3. Les Calendriers

Vous pouvez utiliser **Google Calendars** ou **Local Calendars**.

#### Option A : Calendrier local (le plus simple)

Notez que cela n'a pas été testé puisque j'utilise exclusivement Google Calendars

1. Allez dans **Paramètres > Appareils & Services**.
2. Ajoutez l'intégration **Local Calendar**.
3. Créez des calendriers nommés exactement : `Alice`, `Bob`, `Charlie`, `Daisy`, `Family`.
    * *Si vous utilisez ces noms, le code fonctionne immédiatement !*

#### Option B : Google Calendar

1. Ouvrez `packages/family_calendar.yaml`.
2. Faites défiler jusqu'au script `add_google_calendar_event`.
3. Mettez à jour le `calendar_map` pour pointer vers vos vraies entités Google :


    ```yaml
    calendar_map:
      "Alice": "calendar.alice_gmail_com"
      "Bob": "calendar.bob_work_account"
    ```

#### Configuration des jours fériés

Depuis les mises à jour de Home Assistant, les jours fériés sont désormais ajoutés via l'interface utilisateur :

1. Allez dans **Paramètres > Appareils et services > Ajouter une intégration > Jour férié**.
2. Sélectionnez votre pays.
3. Vérifiez l'ID de l'entité (par exemple, `calendar.holidays`). S'il diffère de la valeur par défaut, mettez-le à jour dans le YAML du tableau de bord.

### 4. Le tableau de bord (L'aspect)

1. Créez une nouvelle vue du tableau de bord (Réglez le type de vue sur **Sections**).
2. Copiez le code depuis [dashboard.yaml](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/dashboard.yaml).
3. **Personnalisez :**
   * **Rechercher et remplacer :** Remplacez `person.alice` par vos entités réelles des membres de la famille.
   * **Météo :** Remplacez `weather.home` par votre fournisseur météo.
   * **Arrière-plan :** Mettez à jour l'URL de l'image en bas du yaml.

### Étape 5 : Le thème (Optionnel)

Pour obtenir le style de police spécifique (Ovo) :

1. Assurez-vous que votre `configuration.yaml` contient cette ligne sous `frontend:`

   ```yaml
   frontend:
     themes: !include_dir_merge_named themes
   ```
2. Créez un dossier nommé `themes` dans votre répertoire de configuration.  
3. Téléchargez [themes/skylight.yaml](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/themes/skylight.yaml) et placez-le dans ce dossier.  
4. Redémarrez Home Assistant.  
5. Allez dans votre Profil (Icône Utilisateur en bas à gauche) et changez le **Thème** pour `Skylight`.  
NOTE : Le thème n’est pas complet, gardez cela à l’esprit  

---

## 📐 Comment ça fonctionne (dans les coulisses)  

### Logique du filtre  

La `week-planner-card` ne supporte pas nativement la possibilité de masquer des calendriers spécifiques à la volée. Pour résoudre cela, j’ai utilisé des **Input Texts** agissant comme des filtres Regex.  

* Lorsque vous cliquez sur le bouton d’une personne, cela bascule son filtre entre `.*` (Tout afficher) et `^$` (Ne rien afficher).  
* `config-template-card` injecte ces variables dans la carte calendrier de façon dynamique.  

### Script de création d’événement  

La fenêtre contextuelle "Ajouter un événement" utilise un seul script qui gère la logique pour plusieurs personnes et types d’événements (Toute la journée vs Horaires).


```yaml
# Simplified Logic Example
target_calendar: "{{ calendar_map.get(states('input_select.calendar_select')) }}"

choose:
  - conditions: "All Day Event is ON"
    action: calendar.create_event (start_date, end_date)
  - conditions: "All Day Event is OFF"
    action: calendar.create_event (start_date_time, end_date_time)
```
## NOTES

Mon post original avait juste pour but de donner un aperçu général de la façon de le faire et de permettre aux gens d'ajuster le code pour le faire fonctionner dans leurs scénarios spécifiques.

En particulier, je l'ai fait parce que chaque écran et besoin est différent. Je ne peux pas développer pour toutes les tailles potentielles d'écrans, tableaux de bord, etc. Donc il est conçu pour fonctionner sur l'écran que j'ai mentionné ou tout autre (1920x1080) mais devrait être modifiable pour d'autres.

En parlant d'écran, j'ai initialement suggéré celui-ci parce qu'il était en promotion chez Woot et c'était un moyen très économique d'obtenir un écran tactile à l'époque. Ce n'est peut-être plus le cas maintenant, alors utilisez l'écran qui vous convient. Tablette, écran tactile, téléphone, peu importe. La principale chose que vous devrez modifier est le tableau de bord.




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-06

---