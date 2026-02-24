# Extension Guided Generations pour SillyTavern

Cette extension apporte toute la puissance du jeu de réponses rapides original "Guided Generations" à SillyTavern en tant qu’extension native. Elle fournit des outils modulaires et contextuels pour façonner, affiner et guider les réponses de l’IA — idéal pour les jeux de rôle, les histoires et les conversations centrées sur les personnages. Toutes les fonctionnalités sont accessibles via des boutons et menus intuitifs intégrés à l’interface de SillyTavern.

Voir [`JSDoc.md`](https://raw.githubusercontent.com/Samueras/GuidedGenerations-Extension/main/./JSDoc.md) pour la documentation au niveau du code.

---

## Table des Matières
- [Fonctionnalités](#features)
- [Installation](#installation)
- [Utilisation](#usage)
- [Paramètres](#settings)
- [Dépannage](#troubleshooting)
- [Licence](#license)
- [Contribution](#contributing)

---

## Fonctionnalités

### 🐕 Réponse Guidée
*Injectez des instructions avant que l’IA ne réponde.*
- Tapez des instructions et appuyez sur 🐕.
- Vos instructions guident la prochaine réponse de l’IA.
- [Exemple vidéo](https://youtube.com/shorts/yxdtbF3NxW4?feature=share)

### 👈 Glissement Guidé
*Régénérez le dernier message de l’IA avec de nouvelles instructions.*
- Entrez de nouvelles instructions et appuyez sur 👈 pour générer un nouveau glissement.
- Disponible uniquement si le dernier message provient de l’IA.
- [Exemple vidéo](https://youtube.com/shorts/GRQ9l_8K6-Y?feature=share)

### Impersonation (1ère : 👤, 2ème : 👥, 3ème : 🗣️)
*Développez des esquisses en récits riches et en personnage.*
- Entrez un bref plan, sélectionnez la perspective (basculer dans les paramètres), et appuyez sur le bouton correspondant (👤/👥/🗣️).
- Votre plan est développé en un message complet du point de vue choisi.
- Peut être affiché ou caché individuellement selon les paramètres. La 1ère personne est affichée par défaut.
- Exemples vidéo :
  - [1ère personne](https://youtube.com/shorts/FT5gv3d2kE4?feature=share)
  - [2e Personne](https://youtube.com/shorts/80l12LrtBpQ?feature=share)
  - [3e Personne](https://youtube.com/shorts/wWka-1URLPg?feature=share)

### 📖 Menu des Guides Persistants
*Gérer le contexte persistant du scénario.*
- Cliquez sur le bouton 📖 pour ouvrir le menu des guides persistants.
- Sélectionnez un type de guide (voir ci-dessous) pour générer ou gérer le contexte.

**Types de Guides :**
  - 🗺️ Situationnel : Générer le contexte à partir du chat récent ou du focus utilisateur.
  - 🧠 Pensées : Générer les pensées du personnage (déclenchement automatique optionnel).
  - 👕 Vêtements : Décrire les tenues du personnage (déclenchement automatique optionnel).
  - 🧍 État : Détaillez les positions/statuts du personnage (déclenchement automatique optionnel).
  - 📜 Règles : Définir ou mettre à jour les règles dans l’histoire.
  - ➕ Personnalisé : Injecter un contexte défini par l’utilisateur.

**Actions de Gestion :**
  - ✏️ Modifier les Guides : Modifier les injections de guides existantes via une fenêtre popup.
  - 👁️ Afficher les Guides : Afficher tous les guides actifs.
  - 🗑️ Vider les Guides : Supprimer les guides sélectionnés ou tous les guides.
- Le déclenchement automatique pour Pensées, Vêtements et État peut être activé ou désactivé dans les paramètres.

### 🔖 Menu Outils
*Accéder aux utilitaires supplémentaires*
  - **🔧 Corrections :** Modifier le dernier message de l’IA avec des instructions ciblées.
  - **✅ Correcteur Orthographique :** Polir votre saisie pour la grammaire, la ponctuation et la fluidité.
  - **✈️ Envoi Simple :** Envoyer la saisie en tant que message utilisateur sans déclencher une réponse du modèle.
  - **🖋️ Modifier les Intros :** Réécrire ou transformer les messages d’introduction sur demande.
  - **↩️ Récupération de Saisie :** Restaurer une saisie précédemment effacée.

---

## Installation

1. **Installer l’Extension :**
   - Dans le gestionnaire d’extensions, cliquez sur Installer l’Extension et entrez https://github.com/Samueras/GuidedGenerations-Extension/ comme GITHUB


---

## Utilisation

- Toutes les fonctionnalités principales apparaissent sous forme de boutons à côté du bouton d’envoi ou dans le menu en forme d’engrenage à gauche.
- Les info-bulles au survol et les menus contextuels fournissent des conseils et un accès rapide aux fonctionnalités avancées.
- Consultez les paramètres intégrés pour les basculements de fonctionnalités et la configuration du guide automatique.
- Pour les détails techniques complets, voir [`JSDoc.md`](https://raw.githubusercontent.com/Samueras/GuidedGenerations-Extension/main/./JSDoc.md).

---

## ⚙️ Paramètres

Tous les paramètres de l’extension sont gérés via le panneau Paramètres d’Extension de SillyTavern :

- **Déclenchement automatique** : activer ou désactiver l’exécution automatique de :
  - Guide de réflexion
  - Guide d’état
  - Guide des vêtements

- **Visibilité des boutons** : afficher ou masquer les boutons d’action :
  - Impersonation à la 1re personne (👤)
  - Impersonation à la 2e personne (👥)
  - Impersonation à la 3e personne (🗣️)
  - Réponse guidée (🐕)
  - Balayage guidé (👈)
  - Menu des guides persistants (📖)

- **Rôle d’injection** : sélectionner le rôle (`system`, `assistant` ou `user`) utilisé lors de l’injection des instructions.

- **Mode débogage** : lorsqu’il est activé, affiche des informations détaillées de débogage dans la console du navigateur. Utile pour le dépannage mais peut encombrer la console en usage normal.

- **Préréglages** : pour chaque guide/outils (Vêtements, État, Réflexion, Situationnel, Règles, Personnalisé, Corrections, Correcteur orthographique, Modifier les introductions, Impersonation 1re/2e/3e personne), choisissez un préréglage SillyTavern. Avant d’exécuter un guide/outils, l’extension basculera vers ce préréglage (et son API/modèle configuré), exécutera l’action, puis restaurera votre préréglage précédent—permettant différents modèles par guide.

- **Remplacements de prompt** : personnalisez le modèle brut de prompt pour chaque guide/outils. Utilisez `{{input}}` pour votre texte d’entrée et d’autres espaces réservés pris en charge. Les remplacements s’appliquent à :
  - Prompt du Guide des vêtements
  - Prompt du Guide d’état
  - Prompt du Guide de réflexion
  - Prompt du Guide situationnel
  - Prompt du Guide des règles
  - Prompt des corrections
  - Prompt du correcteur orthographique
  - Usurper des invites à la 1ère/2ème/3ème personne  
  - Invite de réponse guidée  
  - Invite de balayage guidée  

---

## Dépannage

- **Boutons manquants :** Assurez-vous que SillyTavern est à jour (v1.12.9+) et que LALib est installé/activé.  
- **Menus contextuels n’apparaissant pas :** Essayez de changer de discussion ou de réajouter l’extension dans le menu des réponses rapides.  
- **Autres problèmes :** Redémarrez SillyTavern, vérifiez les mises à jour et consultez la [documentation SillyTavern](https://github.com/SillyTavern/SillyTavern).  

---

## Licence

Ce projet est sous licence GNU General Public License v3.0. Voir le fichier [LICENSE](LICENSE) pour plus de détails.  

---

## Contribution

Les contributions sont les bienvenues ! Soumettez des pull requests ou ouvrez des issues pour des améliorations, fonctionnalités ou documentation. Pour questions ou retours, ouvrez une issue dans ce dépôt.  

---

## ❤️ Soutenez le projet

Si vous trouvez cette extension utile, merci de considérer soutenir mon travail :  

- [☕ Offrez-moi un café sur Ko-fi](https://ko-fi.com/samueras)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-24

---