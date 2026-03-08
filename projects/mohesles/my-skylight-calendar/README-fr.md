
<div align="right">
  <details>
    <summary >🌐 Langue</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Calendrier familial DIY Smart Home (Clone Skylight)

![Calendrier Sklylight](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/assets/main_view.jpeg)
![DIY Skylight](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/assets/sky2.png)

## 📖 Introduction

Ma femme a récemment été bombardée sur les réseaux sociaux de publicités pour des calendriers familiaux connectés (Skylight, Cozyla, Hearth) et était prête à dépenser plus de 300 $ pour en acheter un. Avant de lui donner le feu vert, j'ai demandé à pouvoir les étudier.

J'ai constaté que la plupart offraient des fonctionnalités similaires mais différaient considérablement en prix. Plus important encore, je n'ai vu aucune fonctionnalité exceptionnelle que je ne pouvais pas implémenter dans **Home Assistant**.

**L'objectif :** Un calendrier tactile, esthétique pour le plan de travail et approuvé par le WAF (Wife Acceptance Factor), qui s'intègre profondément dans notre maison connectée sans frais mensuels.

## 💡 Pourquoi le DIY ?

Opter pour une solution DIY avec Home Assistant a offert plusieurs avantages par rapport à l'achat d'un écran Skylight/Hearth :

* **Pas de frais mensuels :** Évite les abonnements pour des fonctionnalités "premium".
* **Intégration transparente :** Communique avec nos lumières, corvées (Grocy) et capteurs de présence.
* **Matériel ancien :** Réutilisation d'un Mini PC et d'un moniteur standard.
* **Confidentialité :** Pas de dépendance fournisseur ni risque d'arrêt du service.

## 🛠 Sélection du matériel

Ce système est actuellement conçu pour afficher le tableau de bord sur tout écran HD (1920x1080).

Dans mon cas, il fallait que cela "ressemble à" Skylight, soit tactile, puisse être posé sur le plan de travail et déplacé dans différents endroits. J'ai donc choisi le matériel décrit ci-dessous.
Cependant, votre cas peut être différent et nécessitera des adaptations, par exemple si vous souhaitez l'afficher sur une tablette ou autre.

Le matériel que j'ai utilisé à l'origine a été choisi sur la base des critères cités plus haut, avec l'idée de pouvoir étendre les fonctionnalités grâce à la webcam, aux haut-parleurs et au microphone. Aujourd'hui, avec le recul, je le construirais probablement différemment, car je n'ai pas eu le temps de mettre en œuvre ces idées matérielles supplémentaires.

* **Moniteur :** [HP Engage 15 pouces Écran Tactile](https://computers.woot.com/offers/hp-engage-16t-fhd-monitor). Je l'ai préféré aux moniteurs portables génériques car il inclut un **haut-parleur, une webcam et un microphone** intégrés, permettant un contrôle vocal ou des appels vidéo à l'avenir.
* **Ordinateur :** Un vieux Mini PC (NUC/Tiny PC) sous Windows/Linux en mode Kiosk, ou un Raspberry Pi 4.~~

## ✨ Fonctionnalités

* **Vues famille et individuelles :** Basculez les calendriers de membres de la famille spécifiques.
* **Synchronisation bidirectionnelle :** Modifiez les événements sur l'écran ou depuis nos téléphones (Google Agenda).
* **Popup "Ajouter un événement" :** Une interface personnalisée pour ajouter des événements à des calendriers spécifiques directement depuis l'écran.
* **Météo & Date :** En-tête esthétique et lisible d'un coup d'œil.
* **Responsive :** Ajustement automatique du nombre de jours selon la largeur de l'écran (mobile vs bureau).

---

## ⚙️ Guide d'installation

*Remarque : Cette configuration utilise un **YAML Package** pour créer automatiquement tous les assistants, scripts et variables nécessaires. Vous n'avez pas besoin de les créer manuellement.*


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

*Remarque : Dans Paramètres → Appareils et services, assurez-vous que Browser Mod apparaît comme une Intégration (tuile) et pas seulement sous HACS.
S’il n’est pas présent, cliquez sur Ajouter une intégration → Browser Mod et terminez le flux, puis redémarrez HA.
L’installation via HACS ne fait que télécharger les fichiers ; vous devez ajouter l’intégration pour que HA enregistre ses actions/entités.

### 2. Le Backend (Le Cerveau)

1. Ouvrez votre fichier `configuration.yaml` dans Home Assistant.
2. Assurez-vous d’avoir ajouté cette ligne sous `homeassistant:` pour activer les packages :

   ```yaml
   homeassistant:
     packages: !include_dir_named packages
   ```
3. Créez un dossier nommé `packages` dans votre répertoire de configuration HA (si vous n’en avez pas).
4. Téléchargez [packages/family_calendar.yaml](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/packages/family_calendar.yaml) depuis ce dépôt.
5. Recherchez la chaîne [ #<--- UPDATE THIS ENTITY] et mettez à jour l’ID de l’entité calendrier pour correspondre à votre environnement. Consultez la section 3 pour plus de détails.
6. Placez le fichier dans votre dossier `packages/`.
7. **Redémarrez Home Assistant**.

### 3. Les calendriers

Vous pouvez utiliser des **calendriers Google** ou des **calendriers locaux**.

#### Option A : Réutiliser les noms de calendrier (le plus simple)


1. Allez dans **Paramètres > Appareils & Services**.
2. Ajoutez l’intégration **Calendrier local**.
3. Créez des calendriers nommés exactement : `calendar1`, `calendar2`, `calendar3`, `calendar4`, `Family`.
    * *Si vous utilisez ces noms, le code fonctionne immédiatement !*

#### Option B : Calendrier personnalisé

1. Allez dans **Paramètres > Appareils & Services**.
2. Ajoutez l’intégration **Calendrier local** ou **Google Calendar**.
3. Naviguez vers **Configuration > Intégrations > Calendrier local** ou **Google Calendar** et sélectionnez "Ajouter une entrée".
4. Pour chaque entrée créée, récupérez l’ID de l’entité pour mettre à jour le fichier dashboard.yaml.
5. Ouvrez `dashboard.yaml`.
6. Recherchez `# <--- UPDATE THIS ENTITY`.
7. Mettez à jour l’ID de l’entité pour correspondre à votre environnement.


#### Configuration des jours fériés

Depuis les mises à jour de Home Assistant, les jours fériés sont désormais ajoutés via l’interface utilisateur :

1. Allez dans **Paramètres > Appareils & Services > Ajouter une intégration > Holiday**.
2. Sélectionnez votre pays.
3. Vérifiez l’ID de l’entité (par exemple, `calendar.holidays`). S’il diffère de la valeur par défaut, mettez-le à jour dans le fichier YAML du tableau de bord.

### 4. Le tableau de bord (L’apparence)


1. Allez dans **Paramètres > Tableau de bord**
2. Cliquez sur **Ajouter un tableau de bord** (Sélectionnez l’option "Nouveau tableau de bord à partir de zéro", assurez-vous de sélectionner "Ajouter à la barre latérale").
3. Dans le menu de gauche, sélectionnez le tableau de bord nouvellement créé et cliquez sur l’icône crayon pour le modifier.
5. Sélectionnez l’icône à 3 points et choisissez "Éditeur de configuration brute".
6. Copiez et collez le code depuis [dashboard.yaml](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/dashboard.yaml).

### Étape 5 : Le thème (Optionnel)

Pour obtenir l’apparence de police spécifique (Ovo) :

1. Assurez-vous que votre `configuration.yaml` contient cette ligne sous `frontend:`

   ```yaml
   frontend:
     themes: !include_dir_merge_named themes
   ```
2. Créez un dossier nommé `themes` dans votre répertoire de configuration.
3. Téléchargez [themes/skylight.yaml](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/themes/skylight.yaml) et placez-le dans ce dossier.
4. Utilisez l’éditeur de fichiers et téléchargez calbackgrd.png dans le dossier /www/, ce qui correspond en interne à /local sur le tableau de bord.
5. Redémarrez Home Assistant.
6. Allez dans votre profil (icône utilisateur en bas à gauche) et changez le **Thème** en `Skylight`.
REMARQUE : Le thème n’est pas exhaustif, gardez cela à l’esprit

---

## 📐 Fonctionnement interne (sous le capot)

### Logique de filtrage

La `week-planner-card` ne prend pas en charge nativement la dissimulation de certains calendriers à la volée. Pour résoudre ce problème, j'ai utilisé des **Input Texts** agissant comme des filtres Regex.

* Lorsque vous cliquez sur le bouton d’une personne, cela bascule son filtre entre `.*` (tout afficher) et `^$` (ne rien afficher).
* Le `config-template-card` injecte dynamiquement ces variables dans la carte calendrier.

### Script de création d’événement

La fenêtre contextuelle "Ajouter un événement" utilise un seul script qui gère la logique pour plusieurs personnes et types d’événements (toute la journée vs horodaté).


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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-08

---