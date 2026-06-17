# MCP on Rails (avec OAuth optionnel)

Un modèle d’application Rails qui intègre le [Model Context Protocol (MCP)](https://github.com/anthropics/model-context-protocol) avec Ruby on Rails. Lors de la configuration, le modèle demande s’il faut ajouter une protection OAuth 2.1 avec [Devise](https://github.com/heartcombo/devise) et [Doorkeeper](https://github.com/doorkeeper-gem/doorkeeper) — ainsi un seul modèle supporte à la fois MCP simple et les configurations entièrement authentifiées.

## Démarrage rapide

```bash
git clone https://github.com/pstrzalk/mcp-on-rails.git
rails new myapp -m mcp-on-rails/mcp
cd myapp
rails db:migrate
rails server
```
Le modèle invitera :


```
Add Devise + Doorkeeper OAuth 2.1 authentication? (y/n)
```
Répondez **n** pour un serveur MCP simple ou **y** pour une protection OAuth complète.

### Ajout du modèle MCP à une application Rails existante

Vous pouvez tout aussi facilement appliquer ce modèle à une application Rails existante.


```bash
git clone https://github.com/pstrzalk/mcp-on-rails.git
cd your-project/
rails app:template LOCATION=../mcp-on-rails/mcp
```

---

## MCP simple (répondre "n")

Crée une application Rails avec un serveur MCP ouvert — aucune authentification requise.

### Ce que vous obtenez

- **gem `mcp`** ajoutée au Gemfile
- **`McpController`** à `/mcp` — hérite de `ActionController::API`, gère le protocole MCP
- **Routes MCP** — `POST /mcp`, `GET /mcp`
- **Hook scaffold** — `rails generate scaffold` crée automatiquement des outils MCP
- **Générateur d’outil personnalisé** — `rails generate mcp_tool NomOutil champ:type`
- **Générateur de prompt personnalisé** — `rails generate mcp_prompt NomPrompt arg arg:required`
- **`to_mcp_response`** sur ApplicationRecord pour un formatage texte cohérent
- **`rake mcp:tools`** et **`rake mcp:prompts`** pour lister tous les outils et prompts enregistrés (utilisez `mcp:tools:verbose` / `mcp:prompts:verbose` pour les détails complets)

### Utilisation

```bash
rails new myapp -m mcp-on-rails/mcp   # answer n
cd myapp && rails db:migrate

rails generate scaffold Post title:string body:text
rails db:migrate
rails server
```
Testez-le :


```bash
# MCP initialize
curl -X POST http://localhost:3000/mcp \
  -H "Content-Type: application/json" \
  -d '{"jsonrpc":"2.0","id":1,"method":"initialize","params":{"protocolVersion":"2025-03-26","capabilities":{},"clientInfo":{"name":"test","version":"1.0"}}}'

# List tools
curl -X POST http://localhost:3000/mcp \
  -H "Content-Type: application/json" \
  -d '{"jsonrpc":"2.0","id":2,"method":"tools/list"}'
```

### Structure du projet (mode simple)

```
app/
├── controllers/
│   └── mcp_controller.rb              # Open MCP endpoint (no auth)
├── models/
│   └── application_record.rb          # Extended with to_mcp_response
├── prompts/                           # MCP prompts (created via generator)
└── tools/                             # MCP tools (auto-generated per scaffold)

config/
├── initializers/
│   └── mcp.rb                         # MCP tool and prompt autoloading
└── routes.rb                          # MCP routes

lib/
├── generators/                        # MCP tool and prompt generators
└── tasks/
    └── mcp.rake                       # rake mcp:tools, rake mcp:prompts (and verbose variants)
```

### Connexion des assistants IA (mode simple)

```json
{
  "name": "my-rails-app",
  "type": "StreamableHttp",
  "url": "http://localhost:3000/mcp"
}
```

Aucune authentification requise — le point de terminaison `/mcp` est ouvert.

---

## OAuth MCP (répondez "y")

Crée une application Rails avec un serveur MCP protégé par OAuth 2.1, incluant PKCE, l'enregistrement dynamique des clients, et le support des indicateurs de ressources — tout ce qui est nécessaire pour le flux d'autorisation OAuth de MCP.

### Ce que vous obtenez

Tout ce qui est inclus en mode simple, plus :

- **gems `devise` + `doorkeeper`** ajoutés au Gemfile  
- **Devise** pour l'authentification des utilisateurs (inscription, connexion, réinitialisation du mot de passe)  
- **Doorkeeper** fournisseur OAuth 2.1 avec application obligatoire de PKCE (S256)  
- **`McpController`** protégé par `doorkeeper_authorize!` avec validation de l'audience du token (RFC 8707)  
- **Enregistrement dynamique des clients** via `POST /oauth/register` (RFC 7591)  
- **Métadonnées des ressources protégées** via `GET /.well-known/oauth-protected-resource` (RFC 9728)  
- **Métadonnées du serveur d'autorisation** via `GET /.well-known/oauth-authorization-server` (RFC 8414)  
- **Indicateurs de ressources** — les tokens sont limités à la ressource `/mcp` (RFC 8707)  

### Utilisation

```bash
rails new myapp -m mcp-on-rails/mcp   # answer y
cd myapp && rails db:migrate

rails generate scaffold Post title:string body:text
rails db:migrate
rails server
```

Le point de terminaison `/mcp` nécessite désormais un jeton Bearer — les requêtes non authentifiées retournent 401.

### Flux OAuth

Le flux complet d’autorisation suit la spécification OAuth de MCP :

1. **Découverte** — Le client récupère `GET /.well-known/oauth-protected-resource` pour trouver le serveur d’autorisation
2. **Métadonnées du serveur** — Le client récupère `GET /.well-known/oauth-authorization-server` pour les points de terminaison et capacités
3. **Enregistrement du client** — `POST /oauth/register` avec les métadonnées du client (RFC 7591)
4. **Autorisation** — `GET /oauth/authorize` avec `code_challenge` PKCE (S256) et paramètre `resource`
5. **Authentification utilisateur** — Devise gère la connexion/l’inscription
6. **Échange de jeton** — `POST /oauth/token` avec `code_verifier` et paramètre `resource`
7. **Requêtes MCP** — `POST /mcp` avec `Authorization: Bearer <token>`

### RFC supportés

| RFC | Description | Point de terminaison |
|-----|-------------|---------------------|
| OAuth 2.1 + PKCE | Autorisation avec Proof Key for Code Exchange (S256) | `/oauth/authorize`, `/oauth/token` |
| RFC 7591 | Enregistrement dynamique du client | `POST /oauth/register` |
| RFC 8414 | Métadonnées du serveur d’autorisation | `GET /.well-known/oauth-authorization-server` |
| RFC 8707 | Indicateurs de ressources | paramètre `resource` dans les requêtes d’auth et de jeton |
| RFC 9728 | Métadonnées de ressource protégée | `GET /.well-known/oauth-protected-resource` |

### Structure du projet (mode OAuth)

```
app/
├── controllers/
│   ├── mcp_controller.rb                              # OAuth-protected MCP endpoint
│   ├── oauth_client_registration_controller.rb        # RFC 7591
│   └── oauth_authorization_server_metadata_controller.rb  # RFC 8414 + 9728
├── models/
│   ├── user.rb                                        # Devise user with OAuth associations
│   ├── oauth_application.rb
│   ├── oauth_access_token.rb
│   └── oauth_access_grant.rb
├── prompts/                                           # MCP prompts (created via generator)
├── tools/                                             # MCP tools (auto-generated per scaffold)
└── views/
    └── devise/                                        # Customizable auth views

config/
├── initializers/
│   ├── doorkeeper.rb                                  # OAuth + PKCE config
│   ├── devise.rb                                      # User auth config
│   └── mcp.rb                                         # MCP tool autoloading
└── routes.rb                                          # All OAuth + MCP routes

db/migrate/
├── *_devise_create_users.rb
├── *_create_doorkeeper_tables.rb
├── *_enable_pkce.rb
└── *_add_resource_to_oauth_tables.rb
```

### Connexion des assistants IA (mode OAuth)

```json
{
  "name": "my-rails-app",
  "type": "StreamableHttp",
  "url": "http://localhost:3000/mcp"
}
```

Le client doit compléter le flux OAuth PKCE avant d'effectuer des requêtes MCP — le point de terminaison `/mcp` renvoie 401 sans un jeton Bearer valide.

---

## Fonctionnalités communes (les deux modes)

### Génération de modèles avec les outils MCP

```bash
rails generate scaffold Post title:string content:text
rails db:migrate
```

Cela crée des fichiers Rails standard plus 5 outils MCP dans `app/tools/posts/` :
- `show_tool.rb` — Récupérer un seul post par ID
- `index_tool.rb` — Lister les posts avec pagination
- `create_tool.rb` — Créer de nouveaux posts
- `update_tool.rb` — Mettre à jour les posts existants
- `delete_tool.rb` — Supprimer des posts

### Création d’outils MCP personnalisés

```bash
rails generate mcp_tool WeatherCheck location:string
```

### Création de invites MCP personnalisées

```bash
rails generate mcp_prompt hotel_finder location:required check_in_date:required adults price_max
```

Cela crée `app/prompts/hotel_finder.rb` avec une classe de prompt héritant de `MCP::Prompt`. Les arguments sont facultatifs par défaut — ajoutez `:required` pour les rendre obligatoires.

Les prompts sont automatiquement chargés depuis `app/prompts/` et enregistrés auprès du serveur MCP. Contrairement aux outils, les prompts ne sont **pas** générés automatiquement lors du scaffolding — ils sont créés explicitement via le générateur.

### Liste des outils et prompts disponibles

```bash
rake mcp:tools             # compact one-line-per-tool summary
rake mcp:tools:verbose     # full details with schema
rake mcp:prompts           # compact one-line-per-prompt summary
rake mcp:prompts:verbose   # full details with arguments
```

## Licence

Licence MIT


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-17

---