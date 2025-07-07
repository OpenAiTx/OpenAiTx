<p align="center">
  <img src="https://raw.githubusercontent.com/aadya940/autoresume/main/main_app/frontend/public/autoresume-logo.png" alt="autoResume Logo" title="autoResume Logo" width="180"/>
</p>

<h1 align="center">autoResume</h1>

<p align="center">
  <b>Générateur de CV open source : collez vos liens, éditez manuellement et laissez l’IA vous aider à améliorer, mettre à jour et adapter votre CV.</b>
</p>

---

### Comment l’utiliser ?

[Lien vers l’article Medium](https://medium.com/@aadyachinubhai/autoresume-copy-and-paste-links-its-that-simple-8e50e6d155a1)

L’article n’est plus à jour concernant l’interface utilisateur et le modèle utilisé.

## Fonctionnalités

- <b>Importation facile de liens :</b> Collez des liens de sites web et créez rapidement un CV PDF.
- <b>Éditeur manuel inclus :</b> Affinez ou créez votre CV de zéro grâce à un éditeur de code intégré.
- <b>Suggestions intelligentes :</b> Partagez des retours ou de nouveaux liens, et les « smartedits » aideront à affiner et mettre à jour votre CV.
- <b>Adapté aux emplois :</b> Collez une description de poste et obtenez des recommandations pour aligner votre CV.
- <b>Qualité LaTeX :</b> Tous les CV sont générés en LaTeX pour une présentation propre et professionnelle.
- <b>Aperçu instantané :</b> Visualisez votre CV en PDF en temps réel.
- <b>Réinitialisation facile :</b> Effacez et recommencez votre CV en un clic.
- <b>Local :</b> Fonctionne entièrement sur votre machine via Docker.

---

## Démarrage

### Prérequis
- [Docker](https://www.docker.com/get-started)
- [Docker Compose](https://docs.docker.com/compose/)

### Installation

1. Clonez le dépôt :
   ```bash
   git clone https://github.com/aadya940/autoresume.git
   cd autoresume
   ```
2. Construisez et lancez l’application :
   ```bash
   docker compose up --build
   ```
3. Accédez aux applications :
   
   [_http://localhost:5173_](http://localhost:5173)
---

## Utilisation

1. Ouvrez autoResume dans votre navigateur.
2. Cliquez sur l’icône :gear:, collez votre [CLÉ API GOOGLE](https://aistudio.google.com/) et votre email.
3. Collez les liens vers vos informations professionnelles (ex. : Github, site personnel, etc.).
4. Optionnellement, ajoutez des retours ou le lien d’une offre d’emploi pour une personnalisation supplémentaire.
5. Cliquez sur <b>Générer le CV</b> et laissez l’IA faire le reste !

---

## Licence

Ce projet est sous licence Apache 2.0.

## Guide de contribution

### Frontend
- Implémentez les composants React dans le dossier `frontend/src/components/`
- Nous utilisons Chakra UI pour les composants.
- Importez et utilisez vos composants dans `frontend/src/App.jsx`

### Backend
- Implémentez les routes API dans le dossier `backend/src/routes/`
- Ajoutez la fonctionnalité IA dans le dossier `backend/src/ai/`
- Nous utilisons le formateur de code `black` pour le code Python
- Gardez les gestionnaires de routes propres et séparez la logique

### Directives générales
- Créez une nouvelle branche pour votre fonctionnalité/correctif : `git checkout -b votre-nom-de-branche`
- Rédigez des messages de commit clairs
- Testez vos modifications avant de soumettre une PR

### Soumission des modifications
1. Créez une Pull Request
2. Dans la description de votre PR, incluez :
   - Les modifications apportées
   - Les raisons de ces modifications
   - Toute capture d’écran ou résultat de test pertinent
   - Tout changement majeur ou étape de migration nécessaire

Nous apprécions vos contributions et nous examinerons votre PR dès que possible !

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-07

---