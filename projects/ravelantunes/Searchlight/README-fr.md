# Searchlight - Client Postgres macOS

![Capture d'écran de Searchlight](https://raw.githubusercontent.com/ravelantunes/Searchlight/main/./docs/screenshot1.png)

Searchlight est un client PostgreSQL natif pour macOS, open-source, conçu pour être simple, léger et convivial pour les développeurs. Il offre une interface propre et intuitive pour gérer les bases de données et exécuter des requêtes sans la complexité des outils de gestion de bases de données complets. Searchlight se concentre sur la fourniture d'une expérience fluide et efficace pour les développeurs qui ont besoin d'un accès rapide et facile à leurs bases de données PostgreSQL.

## Installation

Téléchargez la dernière version depuis la [page des Releases](https://github.com/ravelantunes/Searchlight/releases).

> J’utilise mon compte développeur Apple personnel, donc je ne peux pas notariser l’application auprès d’Apple. Si vous essayez d’installer depuis la page des releases GitHub, macOS vous avertira qu’il ne peut pas vérifier l’identité du développeur, vous devrez donc approuver l’installation dans Réglages > Confidentialité, ou compiler à partir des sources.

## Fonctionnalités actuelles

### Gestion des connexions

- Enregistrer et gérer les connexions favorites
- Support du tunnel SSH avec authentification par clé
- Support des connexions SSL/TLS

### Explorateur de base de données

- Parcourir les bases de données, schémas et tables
- Recherche rapide et filtrage sur les données des tables
- Liaison des relations de clés étrangères — cliquez pour naviguer vers les enregistrements liés
- Popover des statistiques des colonnes — afficher les valeurs uniques, le nombre de null, et les graphiques de répartition des valeurs

### Manipulation des données

- Insérer de nouvelles lignes directement dans la table
- Copier la valeur d’une cellule, une ligne, des colonnes dans différents formats
- Auto-complétion/recherche de données à partir des références de clés étrangères lors de l’insertion de données
- Formats d’export : texte brut, CSV, instructions SQL INSERT

### Éditeur de requêtes

- Exécution de requêtes SQL libres
- Support SQL LSP pour l’autocomplétion, le diagnostic et la documentation au survol

## Compilation à partir des sources
1. Cloner le dépôt  
2. Ouvrir `Searchlight.xcodeproj` dans Xcode  
3. Compiler deux fois (⌘B, ⌘B) — la première compilation télécharge les dépendances, la seconde les inclut  
4. Exécuter (⌘R)  

La première compilation télécharge automatiquement le binaire du [Postgres Language Server](https://github.com/supabase-community/postgres-language-server) (~16Mo) pour l'autocomplétion SQL, la vérification de syntaxe et la documentation au survol. Une seconde compilation est nécessaire pour l'intégrer à l'application.  

> **Note :** Le binaire LSP est uniquement pour Apple Silicon (arm64).  

## Stack technique  

- **Swift & SwiftUI** — Application native macOS avec intégration AppKit pour des vues tableaux avancées  
- **PostgresKit / PostgresNIO** — Driver PostgreSQL avec gestion de pool de connexions  
- **SwiftNIO** — Fondations réseau asynchrones  
- **System SSH** — Support natif des tunnels SSH via les outils système macOS  
- **Postgres Language Server** — Intelligence SQL (autocomplétion, diagnostics, documentation au survol)  

## Contribution  

Les contributions sont les bienvenues ! N’hésitez pas à ouvrir des issues ou soumettre des pull requests.  

## Licence  

Voir [LICENSE](LICENSE) pour plus de détails.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-09

---