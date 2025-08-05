[![Badge d'évaluation de sécurité MseeP.ai](https://mseep.net/pr/nloui-paperless-mcp-badge.png)](https://mseep.ai/app/nloui-paperless-mcp)

# Serveur MCP Paperless-NGX

[![badge smithery](https://smithery.ai/badge/@nloui/paperless-mcp)](https://smithery.ai/server/@nloui/paperless-mcp)

Un serveur MCP (Model Context Protocol) pour interagir avec un serveur API Paperless-NGX. Ce serveur fournit des outils pour gérer les documents, les tags, les correspondants et les types de documents dans votre instance Paperless-NGX.

## Démarrage rapide

### Installation via Smithery

Pour installer automatiquement le serveur Paperless NGX MCP pour Claude Desktop via [Smithery](https://smithery.ai/server/@nloui/paperless-mcp) :

```bash
npx -y @smithery/cli install @nloui/paperless-mcp --client claude
```

### Installation manuelle
1. Installer le serveur MCP :
```bash
npm install -g paperless-mcp
```

2. Ajoutez-le à la configuration MCP de votre Claude :

Pour l'extension VSCode, modifiez `~/Library/Application Support/Code/User/globalStorage/saoudrizwan.claude-dev/settings/cline_mcp_settings.json` :
```json
{
  "mcpServers": {
    "paperless": {
      "command": "npx",
      "args": ["paperless-mcp", "http://your-paperless-instance:8000", "your-api-token"]
    }
  }
}
```

Pour l'application de bureau Claude, modifiez `~/Library/Application Support/Claude/claude_desktop_config.json` :
```json
{
  "mcpServers": {
    "paperless": {
      "command": "npx",
      "args": ["paperless-mcp", "http://your-paperless-instance:8000", "your-api-token"]
    }
  }
}
```
3. Obtenez votre jeton API :  
   1. Connectez-vous à votre instance Paperless-NGX  
   2. Cliquez sur votre nom d'utilisateur en haut à droite  
   3. Sélectionnez « Mon profil »  
   4. Cliquez sur le bouton flèche circulaire pour générer un nouveau jeton  

4. Remplacez les espaces réservés dans votre configuration MCP :  
   - `http://your-paperless-instance:8000` par l’URL de votre Paperless-NGX  
   - `your-api-token` par le jeton que vous venez de générer  

C’est tout ! Vous pouvez maintenant demander à Claude de vous aider à gérer vos documents Paperless-NGX.  

## Exemple d’utilisation  

Voici quelques exemples de demandes que vous pouvez faire à Claude :  

- « Montre-moi tous les documents étiquetés ‘Facture’ »  
- « Recherche des documents contenant ‘déclaration de revenus’ »  
- « Crée une nouvelle étiquette appelée ‘Reçus’ avec la couleur #FF0000 »  
- « Télécharge le document n°123 »  
- « Liste tous les correspondants »  
- « Crée un nouveau type de document appelé ‘Relevé bancaire’ »  

## Outils disponibles  

### Opérations sur les documents  

#### list_documents  
Obtenir une liste paginée de tous les documents.  

Paramètres :  
- page (optionnel) : numéro de la page  
- page_size (optionnel) : nombre de documents par page  


```typescript
list_documents({
  page: 1,
  page_size: 25
})
```

#### get_document
Obtenir un document spécifique par ID.

Paramètres :
- id : ID du document

```typescript
get_document({
  id: 123
})
```

#### search_documents
Recherche en texte intégral dans les documents.

Paramètres :
- query : Chaîne de requête de recherche

```typescript
search_documents({
  query: "invoice 2024"
})
```

#### download_document
Télécharger un fichier de document par ID.

Paramètres :
- id : ID du document
- original (optionnel) : Si vrai, télécharge le fichier original au lieu de la version archivée

```typescript
download_document({
  id: 123,
  original: false
})
```

#### bulk_edit_documents
Effectuer des opérations groupées sur plusieurs documents.

Paramètres :
- documents : Tableau d’identifiants de documents
- method : L’un des suivants :
  - set_correspondent : Définir le correspondant pour les documents
  - set_document_type : Définir le type de document pour les documents
  - set_storage_path : Définir le chemin de stockage pour les documents
  - add_tag : Ajouter un tag aux documents
  - remove_tag : Retirer un tag des documents
  - modify_tags : Ajouter et/ou retirer plusieurs tags
  - delete : Supprimer des documents
  - reprocess : Re-traiter les documents
  - set_permissions : Définir les permissions des documents
  - merge : Fusionner plusieurs documents
  - split : Diviser un document en plusieurs documents
  - rotate : Pivoter les pages du document
  - delete_pages : Supprimer des pages spécifiques d’un document
- Paramètres supplémentaires selon la méthode :
  - correspondent : ID pour set_correspondent
  - document_type : ID pour set_document_type
  - storage_path : ID pour set_storage_path
  - tag : ID pour add_tag/remove_tag
  - add_tags : Tableau d’IDs de tags pour modify_tags
  - remove_tags : Tableau d’IDs de tags pour modify_tags
  - permissions : Objet pour set_permissions avec owner, permissions, flag merge
  - metadata_document_id : ID pour merge spécifiant la source des métadonnées
  - delete_originals : Booléen pour merge/split
  - pages : Chaîne pour split "[1,2-3,4,5-7]" ou delete_pages "[2,3,4]"
  - degrees : Nombre pour rotate (90, 180, ou 270)

Exemples :
```typescript
// Add a tag to multiple documents
bulk_edit_documents({
  documents: [1, 2, 3],
  method: "add_tag",
  tag: 5
})

// Set correspondent and document type
bulk_edit_documents({
  documents: [4, 5],
  method: "set_correspondent",
  correspondent: 2
})

// Merge documents
bulk_edit_documents({
  documents: [6, 7, 8],
  method: "merge",
  metadata_document_id: 6,
  delete_originals: true
})

// Split document into parts
bulk_edit_documents({
  documents: [9],
  method: "split",
  pages: "[1-2,3-4,5]"
})

// Modify multiple tags at once
bulk_edit_documents({
  documents: [10, 11],
  method: "modify_tags",
  add_tags: [1, 2],
  remove_tags: [3, 4]
})
```

#### post_document
Téléchargez un nouveau document sur Paperless-NGX.

Paramètres :
- file : Contenu du fichier encodé en Base64
- filename : Nom du fichier
- title (optionnel) : Titre du document
- created (optionnel) : Date et heure de création du document (ex. "2024-01-19" ou "2024-01-19 06:15:00+02:00")
- correspondent (optionnel) : ID d'un correspondant
- document_type (optionnel) : ID d'un type de document
- storage_path (optionnel) : ID d'un chemin de stockage
- tags (optionnel) : Tableau d'ID de tags
- archive_serial_number (optionnel) : Numéro de série d'archive
- custom_fields (optionnel) : Tableau d'ID de champs personnalisés

```typescript
post_document({
  file: "base64_encoded_content",
  filename: "invoice.pdf",
  title: "January Invoice",
  created: "2024-01-19",
  correspondent: 1,
  document_type: 2,
  tags: [1, 3],
  archive_serial_number: "2024-001"
})
```

### Opérations sur les tags

#### list_tags
Obtenir tous les tags.

```typescript
list_tags()
```

#### create_tag
Créer un nouveau tag.

Paramètres :
- name : Nom du tag
- color (optionnel) : Code couleur hexadécimal (ex. "#ff0000")
- match (optionnel) : Motif de texte à correspondre
- matching_algorithm (optionnel) : L'un des "any", "all", "exact", "regular expression", "fuzzy"

```typescript
create_tag({
  name: "Invoice",
  color: "#ff0000",
  match: "invoice",
  matching_algorithm: "fuzzy"
})
```

### Opérations sur les correspondants

#### list_correspondents
Obtenir tous les correspondants.

```typescript
list_correspondents()
```

#### create_correspondent
Créer un nouveau correspondant.

Paramètres :
- name : Nom du correspondant
- match (optionnel) : Motif de texte à correspondre
- matching_algorithm (optionnel) : L’un des suivants : "any", "all", "exact", "regular expression", "fuzzy"

```typescript
create_correspondent({
  name: "ACME Corp",
  match: "ACME",
  matching_algorithm: "fuzzy"
})
```

### Opérations sur les types de documents

#### list_document_types
Obtenir tous les types de documents.

```typescript
list_document_types()
```

#### create_document_type
Créer un nouveau type de document.

Paramètres :
- name : Nom du type de document
- match (optionnel) : Motif de texte à correspondre
- matching_algorithm (optionnel) : L'un des suivants "any", "all", "exact", "regular expression", "fuzzy"

```typescript
create_document_type({
  name: "Invoice",
  match: "invoice total amount due",
  matching_algorithm: "any"
})
```

## Gestion des erreurs

Le serveur affichera des messages d'erreur clairs si :
- L'URL ou le jeton API de Paperless-NGX est incorrect
- Le serveur Paperless-NGX est injoignable
- L'opération demandée échoue
- Les paramètres fournis sont invalides

## Développement

Vous souhaitez contribuer ou modifier le serveur ? Voici ce que vous devez savoir :

1. Cloner le dépôt
2. Installer les dépendances :
```bash
npm install
```
3. Apportez vos modifications à server.js  
4. Testez localement :

```bash
node server.js http://localhost:8000 your-test-token
```

Le serveur est construit avec :
- [litemcp](https://github.com/wong2/litemcp) : Un framework TypeScript pour construire des serveurs MCP
- [zod](https://github.com/colinhacks/zod) : Validation de schéma orientée TypeScript

## Documentation de l’API

Ce serveur MCP implémente des points de terminaison de l’API REST Paperless-NGX. Pour plus de détails sur l’API sous-jacente, voir la [documentation officielle](https://docs.paperless-ngx.com/api/).

## Exécution du serveur MCP

Le serveur MCP peut fonctionner en deux modes :

### 1. stdio (par défaut)

C’est le mode par défaut. Le serveur communique via stdio, adapté aux CLI et intégrations directes.

```
npm run start -- <baseUrl> <token>
```

### 2. HTTP (Transport HTTP Streamable)

Pour exécuter le serveur en tant que service HTTP, utilisez le drapeau `--http`. Vous pouvez également spécifier le port avec `--port` (par défaut : 3000). Ce mode nécessite que [Express](https://expressjs.com/) soit installé (il est inclus comme dépendance).

```
npm run start -- <baseUrl> <token> --http --port 3000
```

- L'API MCP sera disponible à `POST /mcp` sur le port spécifié.
- Chaque requête est traitée sans état, suivant le modèle [StreamableHTTPServerTransport](https://github.com/modelcontextprotocol/typescript-sdk).
- Les requêtes GET et DELETE vers `/mcp` retourneront 405 Méthode Non Autorisée.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-05

---