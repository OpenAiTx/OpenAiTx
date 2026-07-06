# SQLite en ligne

<div align="center">
  <a href="https://yzua.github.io/sqlite-online/">
    <img
      src="https://github.com/user-attachments/assets/aef749bf-df08-4a84-8148-d34b796449d8"
      alt="Logo SQLite en ligne"
      width="128"
    />
  </a>
</div>

Un éditeur SQLite côté client construit avec React, TypeScript, Vite, et `sql.js`.
Il fonctionne dans le navigateur, initialise une base de données de démonstration par défaut, et peut ouvrir
des fichiers SQLite locaux sans serveur backend.

## Aperçu

- **Ouvrir des fichiers locaux `.db`, `.sqlite` et `.sqlite3`**
- **Créer et modifier des tables, vues et index avec SQL**
- **Parcourir, filtrer, trier, paginer, ajouter, modifier et supprimer des lignes**
- **Exécuter des requêtes SQL personnalisées et exporter les résultats au format CSV**

La plupart des opérations sur la base de données s'exécutent localement dans le navigateur via WebAssembly et un web
worker. Des fonctionnalités optionnelles telles que le chargement via URL, le proxy CORS de secours, Google
Fonts, et la génération de requêtes pilotée par Gemini utilisent des requêtes réseau.

## Fonctionnalités

- **Édition de base de données locale en priorité :** ouvrir des fichiers depuis le disque, glisser-déposer une
  base de données sur la page, et télécharger la base de données actuelle sous
  le nom `database.sqlite`.
- **Flux de travail sur schéma et données :** inspecter le schéma, parcourir les données des tables, modifier les lignes,
  insérer de nouvelles lignes, supprimer des lignes, et exécuter des instructions SQL personnalisées.
- **Chemins d'exportation CSV :** exporter une table entière, la page courante de la table, ou le
  résultat de la requête personnalisée actuelle au format CSV.
- **Fonctionnalités UX supplémentaires :** mode sombre, mode contraste élevé, raccourcis clavier,
  liens de saut, et régions dynamiques pour l’accessibilité.
- **Intégrations optionnelles :** charger une base de données à partir d’un paramètre de requête `?url=` et
  générer du SQL à partir de commandes `/ai ...` après configuration d’une clé API Gemini.

## Développement

```bash
npm install
npm run dev
```

Commandes utiles du projet :

- `npm run build`
- `npm run build:pages`
- `npm run typecheck`
- `npm run check`
- `npm run check:fix`
- `npm run doctor`
- `npm run preview`
- `npm run preview:pages`
- `npm run lint`
- `npm run lint:fix`
- `npm run format`
- `npm run format:check`
- `npm test`
- `npm run test:watch`
- `npm run knip`
- `npm run deploy`

## Raccourcis clavier (Touches rapides)

Optimisez votre flux de travail avec ces raccourcis intégrés :

| Raccourci             | Action                      |
| --------------------- | --------------------------- |
| **Ctrl + s**          | Télécharger la base de données |
| **Ctrl + FlècheDroite** | Aller à la page suivante     |
| **Ctrl + FlècheHaut** | Aller à la première page     |
| **Ctrl + FlècheBas**  | Aller à la dernière page     |
| **Ctrl + FlècheGauche** | Aller à la page précédente   |
| **Ctrl + \`**         | Fermer le panneau d’édition  |
| **Ctrl + i**          | Mode insertion / valider l’insertion |
| **Ctrl + u**          | Valider une modification    |
| **Ctrl + d**          | Valider une suppression     |
| **Ctrl + q**          | Exécuter la requête SQL     |

## Licence

SQLite Online est publié sous la [GNU GPL v3.0](https://github.com/yzua/sqlite-online/blob/main/LICENSE).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-06

---