# [Frontières Historiques](https://historicborders.app/)

Visualisez les frontières des pays à différentes époques de l'histoire (2000 av. J.-C. - 1994)

Tel que vu sur [r/dataisbeautiful](https://www.reddit.com/r/dataisbeautiful/comments/l52krh/an_app_i_made_for_visualizing_country_borders/).

## Capture d'écran

<img width="1023" alt="screen-shot-of-app" src="https://user-images.githubusercontent.com/10817537/175097196-e746778d-241a-4bee-b406-aac294849597.png">

## Fonctionnalités

### Sources d'information

L'application fournit des informations sur les pays via deux sources :

1. **Wikipedia** (par défaut) - Récupère les informations en temps réel depuis Wikipedia  
2. **IA** - Utilise Google Gemini IA pour générer des informations pays avec contexte historique

Vous pouvez basculer entre ces sources via le bouton toggle dans le pied de page.

### Mise en cache des réponses IA

L'application utilise **Redis** pour mettre en cache les réponses IA et améliorer les performances :

- ⚡ **Réponses instantanées** pour les pays/années déjà demandés  
- 💰 **Réduction des coûts API** - Moins d'appels à Google Gemini  
- 🔧 **Expiration intelligente** - TTL de cache d'1 heure pour garder le contenu à jour  
- 📊 **Suivi analytique** - Taux de cache hit/miss dans Google Analytics

Voir [REDIS_SETUP.md](https://raw.githubusercontent.com/nrgapple/historic-country-borders-app/main/./REDIS_SETUP.md) pour les instructions détaillées d'installation.

### Analyse des fonctionnalités IA

L'application inclut un suivi complet via Google Analytics pour la fonctionnalité IA afin de comprendre l'engagement utilisateur et les performances :

#### Événements suivis

**Utilisation du fournisseur :**  
- `toggle_provider` - Lorsque les utilisateurs changent entre Wikipedia et IA
- `enable_ai` / `disable_ai` - Activation/désactivation de la fonctionnalité IA  
- `provider_restored` - Lorsque la préférence est chargée depuis localStorage  
- `session_provider_active` - Fournisseur actif par session  

**Requêtes IA :**  
- `request_initiated` - Requête IA démarrée  
- `response_success` - Réponse IA réussie  
- `response_time_success` - Temps de réponse pour les requêtes réussies  
- `response_length` - Nombre de caractères des réponses IA  
- `response_word_count` - Nombre de mots des réponses IA  
- `request_failed` - Requêtes IA échouées  
- `api_error` - Erreurs spécifiques à l’API avec codes de statut  
- `api_key_missing` - Événements de clé API manquante  

**Performance du Cache :**  
- `cache_hit` - Réponse servie depuis le cache Redis (plus rapide)  
- `cache_miss` - Pas de réponse en cache, appel API effectué  
- `cache_error` - Redis indisponible (retour à l’API)  
- `cache_write_success` - Réponse mise en cache avec succès  
- `cache_write_error` - Échec de la mise en cache de la réponse  

**Affichage du Contenu :**  
- `popup_displayed` - Lorsque les popups affichent du contenu IA vs Wikipedia  
- `content_displayed` - Affichage réussi du contenu  
- `content_error_displayed` - Contenu d’erreur affiché aux utilisateurs  
- `content_empty_displayed` - Scénarios de contenu vide/absent  
- `popup_closed` - Utilisateur ferme les popups d’information  

**Métriques de Performance :**  
- Temps de réponse (succès/échec)  
- Indicateurs de qualité du contenu (nombre de mots, nombre de caractères)  
- Taux et types d’erreurs  
- Modes d’engagement des utilisateurs  

#### Catégories d’Analyse  

Tous les événements liés à l’IA utilisent la catégorie `"Fonctionnalité IA"` pour un filtrage facile dans Google Analytics.  

#### Confidentialité des Données

Le suivi analytique est anonymisé et se concentre sur les modèles d'utilisation des fonctionnalités plutôt que sur les informations personnelles. Aucune clé API ni donnée sensible n'est suivie.

## Configuration

### Prérequis

- Node.js 18+ et yarn
- Clé API Google Gemini (offre gratuite disponible)
- Propriété Google Analytics 4 (optionnel, pour les analyses)

### Installation

```bash
git clone https://github.com/nrgapple/historic-country-borders-app.git
cd historic-country-borders-app
yarn install
```

### Variables d'environnement

Créez un fichier `.env.local` :

```bash
# Optional for analytics
NEXT_PUBLIC_GA_FOUR=your_google_analytics_id

# Optional for map features
NEXT_PUBLIC_MAPBOX_ACCESS_TOKEN=your_mapbox_token

# Redis for AI response caching (required for caching)
REDIS_URL=your_redis_connection_string

# Required for AI features (server-side only)
GEMINI_API_KEY=your_gemini_api_key_here
```
### Obtention des clés API

#### Google Gemini API (Gratuit)

1. Visitez [Google AI Studio](https://ai.google.dev/gemini-api/docs/api-key)
2. Connectez-vous avec votre compte Google
3. Cliquez sur **"Create API Key"**
4. Copiez la clé générée dans votre fichier `.env.local`

**Avantages :**
- ✅ 60 requêtes par minute (niveau gratuit généreux)
- ✅ Pas de carte bancaire requise
- ✅ Réponses IA de haute qualité
- ✅ Excellente connaissance historique

#### Vercel Redis pour la mise en cache (Optionnel mais recommandé)

1. Configurez Redis sur Vercel ou un autre fournisseur Redis
2. Ajoutez la variable d’environnement `REDIS_URL` à votre projet
3. Consultez [REDIS_SETUP.md](https://raw.githubusercontent.com/nrgapple/historic-country-borders-app/main/./REDIS_SETUP.md) pour les instructions détaillées

**Avantages :**
- ⚡ Réponses instantanées pour le contenu mis en cache
- 💰 Réduit l’utilisation et les coûts de l’API
- 🔧 Expiration automatique du cache au bout d’1 heure
- 📊 Analyses de performance du cache

#### Google Analytics 4 (Optionnel)

1. Visitez [Google Analytics](https://analytics.google.com/)
2. Créez une nouvelle propriété GA4
3. Obtenez votre ID de mesure (format : G-XXXXXXXXXX)
4. Ajoutez-le à votre fichier `.env.local`

### Développement


```bash
yarn dev
```

Ouvrez [http://localhost:3000](http://localhost:3000) pour voir l'application.

### Tests

```bash
# Run all tests
yarn test

# Run tests in watch mode
yarn test:watch

# Run specific test files
yarn test hooks/__tests__/useAI.test.tsx
```

## Dépannage des fonctionnalités IA

### Problèmes courants

**"Les informations IA nécessitent la configuration de la clé API Gemini"**
- Ajoutez votre clé API Gemini dans `.env.local`
- Redémarrez le serveur de développement
- Voir [GEMINI_SETUP.md](https://raw.githubusercontent.com/nrgapple/historic-country-borders-app/main/./GEMINI_SETUP.md) pour la configuration détaillée

**Réponses IA lentes**
- Temps de réponse normal : 1-3 secondes
- Vérifiez votre connexion Internet
- L’API Gemini a des limites de fréquence (60 requêtes/minute)

**Réponses vides ou avec erreur**
- Essayez de basculer temporairement sur Wikipedia
- Vérifiez la console du navigateur pour des messages d’erreur détaillés
- Vérifiez que votre clé API est valide

### Tableau de bord analytique

Pour consulter les analyses des fonctionnalités IA dans Google Analytics :

1. Allez dans **Événements** → **Tous les événements**
2. Filtrez par **Catégorie d’événement** = "AI Feature"
3. Principaux indicateurs à surveiller :
   - `toggle_provider` - Adoption de la fonctionnalité
   - `response_success` vs `request_failed` - Taux de succès
   - `response_time_success` - Performance
   - `content_displayed` - Engagement des utilisateurs

### Surveillance des performances

L’application suit plusieurs indicateurs de performance :

- **Temps de réponse** : Temps moyen de réponse IA vs Wikipedia
- **Taux de réussite** : Ratios de succès/échec des requêtes IA
- **Qualité du contenu** : Nombre de mots et longueur des réponses IA
- **Engagement utilisateur** : Comment les utilisateurs interagissent avec le contenu IA vs Wikipedia

## Contribution

1. Forkez le dépôt  
2. Créez une branche de fonctionnalité  
3. Faites vos modifications  
4. Ajoutez des tests pour les nouvelles fonctionnalités  
5. Assurez-vous que tous les tests passent  
6. Soumettez une demande de tirage  

## Licence

Licence MIT - voir [LICENSE](LICENSE) pour plus de détails.

## Remerciements

- Données historiques des frontières issues de [World Historical Gazetteer](https://whgazetteer.org/)  
- IA propulsée par [Google Gemini](https://ai.google.dev/)  
- Cartes propulsées par [Mapbox](https://www.mapbox.com/)  
- Analyses par [Google Analytics 4](https://analytics.google.com/)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-07

---