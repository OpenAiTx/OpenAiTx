# Fiche de Référence

[![GitHub](https://img.shields.io/badge/github-michaelmagan/cheatsheet-blue?logo=github)](https://github.com/michaelmagan/cheatsheet)
[![License](https://img.shields.io/badge/license-MIT-green.svg)](./LICENSE)
[![Next.js](https://img.shields.io/badge/Next.js-15-black?logo=next.js)](https://nextjs.org/)
[![Tambo AI](https://img.shields.io/badge/Tambo-AI-purple)](https://tambo.co)

Un concurrent open-source de Google Sheets propulsé par l'IA, construit avec [Tambo AI](https://tambo.co).

Créez et manipulez des feuilles de calcul interactives avec le langage naturel, ainsi que des graphiques et des visualisations.

## Démo
Essayez par vous-même : **[CheatSheet](https://cheatsheet.tambo.co)**

### Aperçu
https://github.com/user-attachments/assets/da72aa8b-6bc5-468e-8f42-0da685105d22

## Fonctionnalités

- **Éditez avec l’IA** : Utilisez le langage naturel pour interagir avec une feuille de calcul.
- **Sélection des Cellules** : Sélectionnez des cellules pour que l’IA interagisse avec elles.
- **Multi-Modal** : Joignez des images avec les messages.
- **Graphiques et Diagrammes** : Créez des visualisations à partir des données de votre feuille de calcul.
- **Protocole de Contexte Modèle (MCP)** : Connectez des sources de données et des outils externes.

## Feuille de route

- **Entrée Vocale** : Utilisez la saisie vocale en plus de la saisie au clavier.
- **Support des Formules** : Formules de feuille de calcul (SOMME, MOYENNE, SI, RECHERCHEV, etc.)
- **Meilleur Formatage** : Plus d’options visuelles pour les tableaux (couleurs, bordures, polices, alignement)
- **Import/Export** : Support CSV, XLSX et JSON

## Commencer

1. Clonez ce dépôt

2. Naviguez vers le répertoire du projet :

   ```bash
   cd spreadsheet-template
   ```
3. Installer les dépendances :

   ```bash
   npm install
   ```

4. Configurez vos variables d'environnement :

   **Option A : Utilisation de Tambo CLI (Recommandé)**
   ```bash
   npx tambo init
   ```
   Ceci vous invitera de manière interactive à saisir votre clé API Tambo et créera automatiquement `.env.local`.

   **Option B : Configuration manuelle**
   ```bash
   cp example.env.local .env.local
   ```
   Ensuite, modifiez `.env.local` et ajoutez votre clé API depuis [tambo.co/dashboard](https://tambo.co/dashboard).

5. Démarrez le serveur de développement :
   ```bash
   npm run dev
   ```

6. Ouvrez [http://localhost:3000](http://localhost:3000) dans votre navigateur pour utiliser l'application !

## Vue d'ensemble de l'architecture

Ce modèle montre comment l'IA lit et met à jour la feuille de calcul de trois manières :

### Comment l'IA accède à l'état de la feuille de calcul

**Aides de contexte** (données en lecture seule)
- `spreadsheetContextHelper` - Donne à l'IA les données de l'onglet actuel sous forme de tableau markdown
- `spreadsheetSelectionContextHelper` - Indique à l'IA ce qui est actuellement sélectionné
- `tabContextHelper` - Liste tous les onglets et met en surbrillance l'onglet actif
- S'exécute automatiquement chaque fois que vous envoyez un message
- Voir : `src/lib/spreadsheet-context-helper.ts`, `src/lib/spreadsheet-selection-context.ts`, `src/lib/tab-context-helper.ts`

**Outils** (effectuer des modifications)
- Outils de feuille de calcul + onglet pour que l'IA modifie l'état ou inspecte les métadonnées
- Les aides de contexte sont en lecture seule ; les outils apportent des modifications
- Voir : `src/tools/spreadsheet-tools.ts`, `src/tools/tab-tools.ts`

### Référence des outils de feuille de calcul

| Outil | But |
|-------|-----|
| `updateCell` | Mettre à jour la valeur d'une seule cellule |
| `updateRange` | Mettre à jour plusieurs cellules à la fois |
| `addColumn` | Ajouter une nouvelle colonne |
| `removeColumn` | Supprimer une colonne |
| `addRow` | Ajouter une nouvelle ligne |
| `removeRow` | Supprimer une ligne |
| `readCell` | Lire la valeur d'une seule cellule |
| `readRange` | Lire plusieurs cellules |
| `clearRange` | Effacer les valeurs des cellules dans une plage |
| `sortByColumn` | Trier les lignes par valeurs de colonne |

### Fichiers clés

**Configuration**
- `src/lib/tambo.ts` - Enregistrement des composants et outils
- `src/app/chat/page.tsx` - Interface principale de chat avec TamboProvider

**Système de tableur**
- `src/components/ui/spreadsheet-tabs.tsx` - Enveloppe du classeur FortuneSheet + interface d’onglets
- `src/lib/fortune-sheet-store.tsx` - Stockage global en mémoire reliant l’état du classeur
- `src/lib/fortune-sheet-utils.ts` - Helpers centrés sur FortuneSheet (plages, recherches)

**Gestion d’état**
- `src/lib/canvas-storage.ts` - Gestion de l’état du canvas/onglets
- L’état du tableur circule via le fournisseur FortuneSheet et les API du classeur.

**Note sur les dépendances :** FortuneSheet (`@fortune-sheet/{core,react}`) alimente toutes les interactions du tableur.

## Personnalisation

### Ajout de composants personnalisés

Enregistrez les composants dans `src/lib/tambo.ts` que l’IA peut rendre en ligne dans le chat. Structure exemple :

```tsx
import type { TamboComponent } from "@tambo-ai/react";

const components: TamboComponent[] = [
  {
    name: "MyComponent",
    description: "When to use this component",
    component: MyComponent,
    propsSchema: myComponentSchema, // Zod schema
  },
];
```

Voir `src/components/tambo/` pour des exemples de composants et [Documentation des composants Tambo](https://docs.tambo.co/concepts/components) pour des instructions détaillées.

### Création d'outils personnalisés

Ajoutez des outils dans `src/tools/` en suivant ce modèle :

```tsx
export const myTool = {
  name: "toolName",
  description: "What this tool does",
  tool: async (param: string) => {
    // Implementation
    return { success: true, message: "Result" };
  },
  toolSchema: z.function().args(
    z.string().describe("Parameter description")
  ).returns(z.object({
    success: z.boolean(),
    message: z.string().optional(),
  })),
};
```

Enregistrez dans le tableau tools de `src/lib/tambo.ts`. Voir la [documentation des outils Tambo](https://docs.tambo.co/concepts/tools) pour plus de détails.

### Protocole de Contexte de Modèle (MCP)

Configurez les serveurs MCP via la fenêtre de paramètres pour connecter des sources de données externes. Les serveurs sont stockés dans le localStorage du navigateur et encapsulés avec `TamboMcpProvider` dans l’interface de chat.

## Documentation

En savoir plus sur Tambo :
- [Composants](https://docs.tambo.co/concepts/components)
- [Composants Interactifs](https://docs.tambo.co/concepts/components/interactable-components)
- [Outils](https://docs.tambo.co/concepts/tools)
- [Contexte Supplémentaire](https://docs.tambo.co/concepts/additional-context)

Construit avec [Tambo AI](https://tambo.co) - Un cadre pour créer des interfaces utilisateur alimentées par l’IA. Tambo est open source : [tambo-ai/tambo](https://github.com/tambo-ai/tambo).

![Démo du modèle Tambo](https://raw.githubusercontent.com/tambo-ai/tambo/main/assets/template.gif)

## Contribution

Contributions bienvenues ! Voir [CONTRIBUTING.md](https://raw.githubusercontent.com/michaelmagan/cheatsheet/main/./CONTRIBUTING.md) pour les directives.

## Licence

Licence MIT


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-16

---