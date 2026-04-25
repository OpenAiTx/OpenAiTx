# NotebookLM Pro Tree

Une extension Chrome qui transforme NotebookLM de Google d'une simple liste en un tableau de bord robuste de gestion de projet.

Arrêtez de faire défiler des listes plates sans fin. Organisez vos sources en arbres imbriqués, gérez des projets complexes avec des tâches avancées, des flux de travail multi-fenêtres, et concentrez-vous avec le mode Zen.



## Avertissements Critiques ⚠️

La désinstallation supprime les données : Cette extension utilise le stockage local pour la confidentialité et la rapidité. Si vous supprimez/désinstallez l'extension, vos dossiers et tâches seront instantanément supprimés par Chrome.

Solution : Utilisez toujours le bouton Exporter pour sauvegarder un fichier JSON de sauvegarde avant de réinstaller ou de passer à un nouvel ordinateur.

Mises à jour Google & Fiabilité : Cette extension fonctionne en "lisant" le site NotebookLM. Si Google met à jour leur site, cette extension peut cesser de fonctionner.

Avertissement : Comme il s'agit d'un projet gratuit et open-source maintenu pendant mon temps libre, je ne peux garantir des corrections immédiates si Google modifie leur code. Utilisez cet outil comme une amélioration utile, mais gardez vos données importantes sauvegardées.

## Statut du Projet & Avertissement 🚧
Veuillez lire : Je suis chef de projet construction, pas un développeur logiciel professionnel. J'ai créé cet outil car j'en avais besoin pour mon propre flux de travail quotidien.

"Ça marche sur ma machine" : Cette mise à jour (v17.9) est stable pour mon usage personnel, mais elle n'a pas été testée dans toutes les configurations possibles de navigateurs.

Fonctionnalités expérimentales : Le système multi-fenêtres et les observateurs DOM sont complexes. Vous pouvez rencontrer des bugs que je n'ai pas vus.

Retour d’expérience : Si vous trouvez un bug, veuillez ouvrir un ticket sur GitHub !

## Nouveautés en v17.9 : La Suite Productivité 🚀
Transformation de NotebookLM en un espace de travail multi-fenêtres. Cette mise à jour (consolidant les v17.6–v17.9) apporte d’importantes améliorations de flux de travail :

Notes flottantes : Ouvrez n’importe quelle note dans une fenêtre flottante pour une référence côte à côte pendant que vous écrivez. Les fenêtres flottantes conservent la mise en forme (lecture seule) et se synchronisent avec votre thème Clair/Sombre.

Tâches intelligentes & Capture rapide : Sélectionnez du texte dans une note pour voir instantanément un bouton "Créer une tâche". Cela crée une tâche liée directement à cette note source.

Gestion avancée des tâches : Organisez les tâches en Sections personnalisées (groupes repliables), ajoutez des dates d’échéance avec des options de sélection rapide, et incluez des descriptions riches.

Stabilité élégante : Un nouveau moteur d’auto-réparation qui désactive individuellement les fonctionnalités cassées au lieu de planter toute l’extension si Google modifie son code.

## Fonctionnalités
**Productivité & Flux de travail** 📋
*   **Flux de travail multi-fenêtres** — Cliquez sur l’icône "Pop-out" sur n’importe quelle note dans le panneau Studio pour l’ouvrir dans une fenêtre séparée. Parfait pour les configurations à double écran.

*   **Gestionnaire de tâches intégré** — Un outil complet de gestion de projet intégré directement dans l’interface :
    *   **Sections :** Regroupez les tâches par phase (par exemple, "Recherche", "Rédaction", "Révision").
    *   **Liens intelligents :** Les tâches créées à partir des notes incluent une icône "Lien" qui filtre votre vue vers la source originale.
    *   **Priorités :** Marquez les tâches (Rouge/Jaune/Bleu) et triez par Priorité ou Date d’échéance.

*   **"Mode Zen"** — Activez l’interface pour masquer le chat IA et les barres latérales pour un studio de lecture/écriture sans distractions.


 **Organisation** 📂

*   **Dossiers imbriqués** — Créez des structures profondes pour les Sources, Notes et Artéfacts générés (Aperçus audio, FAQ, etc.).

*   **Épinglage** — Gardez les contrats ou spécifications critiques épinglés en haut de vos listes.

*   **Codage couleur** — Attribuez des couleurs aux dossiers pour une organisation visuelle.

*   **Sélection en masse** — Maîtrisez les cases à cocher pour sélectionner/désélectionner instantanément toutes les sources d’un dossier ou du carnet entier.


**Recherche approfondie** 🔍 

*   **Indexation du contenu** — Recherchez le texte réel à l’intérieur de vos notes, pas seulement les titres.

    > **Note :** L’indexation se fait passivement lorsque vous ouvrez une note.

*   **Compression intelligente** — Utilise la compression LZ-String pour stocker jusqu’à 5 Mo de données d’index de recherche localement sans impacter les performances.


**Fiabilité** 🛡️ 

*   **Architecture locale en priorité** — Zéro latence réseau. Toutes les données résident sur votre appareil.

*   **Dégradation progressive** — Si une fonctionnalité échoue suite à une mise à jour du site, le reste de l’extension continue de fonctionner.

*   **Dialogues stylisés** — Dialogues de confirmation fluides et thématiques (plus de popups de navigateur dérangeants).

> **Note :** Chaque carnet a ses propres données indépendantes. Les tâches et dossiers créés dans "Projet A" ne surchargeront pas "Projet B."

## Installation
### Charger l’extension non empaquetée (Mode développeur)

1.  Téléchargez ou clonez ce dépôt.
2.  Ouvrez Chrome et allez sur `chrome://extensions`.
3.  Activez le **Mode développeur** (interrupteur en haut à droite).
4.  Cliquez sur **Charger l’extension non empaquetée**.
5.  Sélectionnez le dossier contenant ces fichiers d’extension.
6.  Rendez-vous dans NotebookLM et commencez à organiser !

## Utilisation
Une fois installé, vous verrez une nouvelle interface "Tableau de bord du projet" injectée dans NotebookLM :

*   **Capture rapide :** Surlignez du texte dans une note -> cliquez sur le bouton flottant + pour en faire une tâche.

*   **Fenêtre externe :** Survolez une note dans le panneau Studio -> cliquez sur l’icône Nouvelle fenêtre.

*   **Détails de la tâche :** Cliquez sur l’icône Description d’une tâche pour ajouter des notes ou du contexte.

*   **Actions groupées :** Utilisez les cases à cocher des dossiers pour basculer plusieurs sources dans la fenêtre de contexte IA.

*   **Exporter/Importer :** Utilisez ces boutons pour sauvegarder votre structure ou la transférer sur un nouvel ordinateur.

## Guide de stockage et données 💾 
**Où vivent vos données**

Parce que la version 17.9 privilégie la rapidité et la confidentialité, vos données résident sur votre appareil :

*   **Stockage local :** Dossiers, Tâches, Paramètres et Index de recherche.

*   **Pas de synchronisation automatique :** Les dossiers ne se synchronisent pas automatiquement entre ordinateurs.

*   **Déplacer les données :** Pour transférer votre configuration vers un portable, utilisez le bouton Exporter pour obtenir un fichier JSON, puis Importez-le sur la nouvelle machine.

> **Attention :** Si vous supprimez les « Données du site » ou les « Cookies » de Chrome, vous perdrez vos dossiers. Sauvegardez régulièrement vos exports.

## Confidentialité & Sécurité



**Cette extension est Local-First :**

*   **Toutes les données sont stockées dans le stockage local de votre navigateur.**

*   **Aucune donnée d’analyse ou d’utilisation n’est envoyée au développeur.**

*   **Open Source :** Vous pouvez inspecter le code pour vérifier qu’aucune donnée ne quitte votre machine.

Voir [PRIVACY_POLICY.md](https://raw.githubusercontent.com/benju66/Notebook-Nest/main/PRIVACY_POLICY.md) pour plus de détails.

## Limitations connues

*   **Édition en fenêtre séparée :** Les fenêtres pop-out sont actuellement en lecture seule. Vous devez utiliser la fenêtre principale pour éditer le texte.

*   **Soulignement :** Le soulignement du contenu dans une note n’est pas persistant (c’est un problème de Google NotebookLM, pas de l’extension).

*   **Mode navigation privée :** Le système de mémoire de l’extension est désactivé en mode navigation privée.


## Contribution
Vous avez trouvé un bug ou une demande de fonctionnalité ? Ouvrez un ticket ou soumettez une PR.

## Auteur
Benju66

## Licence
Licence GPLv3

Ce programme est un logiciel libre : vous pouvez le redistribuer et/ou le modifier sous les termes de la Licence Publique Générale GNU telle que publiée par la Free Software Foundation, soit la version 3 de la licence, soit (à votre choix) toute version ultérieure.


Note : Cela garantit que toute amélioration apportée à ce projet doit être partagée avec la communauté.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-25

---