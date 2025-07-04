# SparkyFitness - Alternative auto-hébergée à MyFitnessPal

SparkyFitness est une application complète de suivi et de gestion de la forme physique conçue pour aider les utilisateurs à surveiller leur nutrition, leurs exercices et leurs mensurations corporelles. Elle fournit des outils pour le suivi quotidien des progrès, la définition d’objectifs et des rapports détaillés afin de soutenir un mode de vie sain.


## ✨ Fonctionnalités

### 🍎 Suivi de la Nutrition

* **Enregistrez vos repas quotidiens**
* **Créez et gérez des aliments et catégories personnalisés**
* **Consultez des résumés et analysez les tendances grâce à des graphiques interactifs**

### 💪 Journalisation des Exercices

* **Enregistrez vos séances d’entraînement**
* **Parcourez et recherchez une base de données complète d’exercices**
* **Suivez votre progression physique dans le temps**

### 💧 Suivi de l’Hydratation

* **Atteignez vos objectifs quotidiens d’hydratation**
* **Journalisation de l’eau simple et rapide**

### 📏 Mensurations Corporelles

* **Enregistrez vos mesures corporelles** (par ex. poids, taille, bras)
* **Ajoutez des types de mesures personnalisées**
* **Visualisez les progrès via des graphiques**

### 🎯 Définition d’Objectifs

* **Définissez et gérez vos objectifs de forme et de nutrition**
* **Suivez les progrès dans le temps**

### 🗓️ Suivi Quotidien

* **Surveillez votre activité quotidienne**
* **Restez constant grâce au suivi des habitudes**

### 🤖 Coach Nutrition IA (SparkyAI)

* **Enregistrez aliments, exercices, statistiques corporelles et pas via le chat**
* **Téléversez des images de repas pour un enregistrement automatique**
* **Inclut l’historique de chat et des conseils personnalisés**

### 🔒 Authentification & Profils Utilisateur

* **Système de connexion sécurisé**
* **Basculez entre différents profils utilisateur**
* **Prise en charge de l’accès et de la gestion familiale**

### 📊 Rapports Complets

* **Générez des résumés pour la nutrition et les mensurations**
* **Suivez les tendances sur plusieurs semaines ou mois**

### 🎨 Thèmes Personnalisables

* **Basculez entre le mode clair et sombre**
* **Interface minimaliste et sans distraction**

### Besoin d’aide ?
* **Rejoignez le Discord**
  https://discord.gg/vcnMT5cPEA
* **Postez dans la discussion**


![image](https://github.com/user-attachments/assets/ccc7f34e-a663-405f-a4d4-a9888c3197bc)


## 🚀 Démarrage

Pour lancer l’application SparkyFitness sur votre machine locale, suivez ces étapes :

### Prérequis

*   **Projet Supabase :** Vous aurez besoin d’un projet Supabase configuré.
    *   **Créez un nouveau projet sur Supabase :** Rendez-vous sur [Supabase](https://app.supabase.com/) et créez un nouveau projet. (Vous pouvez aussi essayer de configurer un projet Supabase local si vous le souhaitez.)
    *   Obtenez l’URL de votre projet Supabase et la clé Anon depuis les paramètres de votre projet (section API).
    *   **Note importante sur l’authentification Supabase :** Mettez à jour la configuration de l’URL dans les paramètres d’authentification Supabase pour correspondre à votre domaine. Ceci est crucial pour que votre domaine fonctionne et pour recevoir les invitations par e-mail lors de l’inscription. Supabase offre de nombreuses fonctionnalités de sécurité et des options SSO tierces ; configurez-les selon les besoins de votre projet.
    *   Le déploiement automatisé de la base de données sur Supabase ne fonctionne pas en IPV4 si vous avez la version gratuite de Supabase. Vous devez donc configurer votre réseau pour utiliser une connexion IPV6. Sinon, la migration de la base de données échouera et vous devrez effectuer le déploiement manuellement.       


    

### Installation

1.  **Configurer les variables d’environnement :**
    Créez un fichier `.env` dans le dossier privé. Si vous utilisez Portainer, créez-le directement là-bas.
    Ajoutez vos identifiants Supabase :
    ```
    VITE_SUPABASE_URL="VOTRE_URL_PROJET_SUPABASE"
    VITE_SUPABASE_ANON_KEY="VOTRE_ANON_KEY_SUPABASE"
    SUPABASE_PROJECT_REF="VOTRE_REF_PROJET_SUPABASE"    
    ```

2.  **Lancer avec Docker Compose :**
    Récupérez les images Docker et démarrez les services :
    ```sh
```markdown
    docker compose pull
    docker compose up -d
    ```

3.  **Accéder à l'application :**
    Une fois les services lancés, accédez à SparkyFitness dans votre navigateur web à l'adresse suivante :
    ```
    http://localhost:3000
    ```

4.  **Chatbot IA - Configuration optionnelle :**
    Pour activer la pleine fonctionnalité du Chatbot IA, y compris le stockage sécurisé de la clé API et l'accès à la base de données, suivez ces étapes :

    *   **Configurer `AI_API_ENCRYPTION_KEY` :** Générez un secret dans "Supabase -> Edge Functions" -> "Variables d'environnement". Cette clé est utilisée pour chiffrer vos clés IA lors de leur stockage dans Supabase.

    *   **Générer `SUPABASE_ACCESS_TOKEN` :**
        1.  Accédez à votre console Docker.
        2.  Exécutez `supabase login` et authentifiez-vous en utilisant l'URL fournie.
        3.  Récupérez le jeton d'accès en exécutant `cat ~/.supabase/access-token`.
        4.  Mettez à jour votre fichier `docker-compose.yml` ou la configuration Portainer avec ce jeton pour redéployer.
        5.  Après le redéploiement, connectez-vous à SparkyFitness et configurez le service IA avec votre fournisseur préféré.
     

### Déploiement manuel de la base de données & fonctions sur Supabase
**Méthode 1 :  
**Si vous n'avez pas de connexion réseau IPV6 activée, la migration de la base de données échouera car la version gratuite de Supabase ne prend pas en charge la connexion directe IPV4.

   1. Téléchargez la dernière version et décompressez-la sur votre ordinateur.
   2. Accédez au dossier du projet. Docker doit être lancé et en fonctionnement.
   3. Exécutez les commandes ci-dessous. (le déploiement des fonctions n'est nécessaire que pour la configuration IA. Si vous n'avez pas besoin du ChatBOT, vous pouvez l'ignorer)
``
      supabase login  
      supabase link  
      supabase db push  
      supabase functions deploy chat   
``
Relancez Docker compose. L'application front-end démarrera.

**Méthode 2 :  
   1. Téléchargez la dernière version et décompressez-la sur votre ordinateur.  
   2. Accédez au dossier du projet.  
   3. Allez dans supabase/migrations. Copiez les instructions SQL et exécutez-les dans Supabase-->Projet-->Éditeur SQL une par une dans l'ordre ASC.  
   4. [Optionnel] Faites de même pour supabase/functions/chat si vous avez besoin du ChatBOT IA. Copiez index.js et exécutez-le dans Supabase-->Projet-->Edge Function-->Déployer une nouvelle fonction.  
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-04

---