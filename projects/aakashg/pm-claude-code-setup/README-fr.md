# Configuration PM Claude Code

[![Étoiles](https://img.shields.io/github/stars/aakashg/pm-claude-code-setup?style=flat-square)](https://github.com/aakashg/pm-claude-code-setup/stargazers)
[![Licence](https://img.shields.io/github/license/aakashg/pm-claude-code-setup?style=flat-square)](LICENSE)

Une configuration Claude Code prête pour la production destinée aux chefs de produit. Déposez ces fichiers dans votre projet et Claude Code comprend immédiatement le travail de PM.

Comprend un fichier de contexte `CLAUDE.md`, 6 compétences PM, et 4 modèles. Installation en 60 secondes.

**Cette configuration fonctionne de manière autonome. Le système complet PM Operating System va plus loin : 41+ compétences, 7 perspectives de sous-agents, une bibliothèque de contextes complète, des modèles de lancement et des workflows de planification de sprint affinés sur plus de 100 itérations.**

**[Obtenez le système complet PM Operating System →](https://www.news.aakashg.com/p/pm-os)**

---

## Contenu inclus

```
pm-claude-code-setup/
├── CLAUDE.md                           # Master context file — drop in your project root
├── templates/
│   ├── prd-template.md                 # Blank PRD structure
│   ├── launch-plan.md                  # Launch planning template
│   ├── okr-template.md                 # OKR scorecard
│   └── sprint-review.md               # Sprint review template
└── .claude/
    └── skills/
        ├── prd-writer/                 # "write a PRD" → structured PRD with clarifying questions
        ├── competitive-analysis/       # "analyze competitor" → smart/weak/implications framework
        ├── launch-checklist/           # "launch checklist" → risk-scaled pre/post launch plan
        ├── metrics-definer/            # "define metrics" → primary, guardrail, and anti-metrics
        ├── sprint-planner/             # "plan sprint" → capacity-checked sprint with risks
        └── user-research/              # "synthesize research" → evidence-ranked findings
```

## Installation rapide

**Étape 1 :** Copiez `CLAUDE.md` à la racine de votre projet :
```bash
cp CLAUDE.md /path/to/your/project/
```

**Étape 2 :** Copier le dossier skills :
```bash
cp -r .claude/ /path/to/your/project/
```

**Étape 3 :** Ouvrez Claude Code dans votre projet. Il se charge automatiquement.

Fait. Claude sait maintenant que vous êtes un chef de projet, suit votre style d’écriture, et rédige des PRD sur commande.

## Ce que fait le fichier CLAUDE.md

`CLAUDE.md` est un fichier de configuration léger — pas un manuel. Il indique à Claude qui vous êtes, comment écrire, et quelles règles suivre. Remplissez les champs `[FILL IN]` en haut (~2 minutes), et le reste fonctionne immédiatement :

- **Votre contexte** — rôle, produit, métriques, OKR, terminologie
- **Règles d’écriture** — ton imposé, mots interdits, standards de sortie
- **Rôles des sous-agents** — 6 relecteurs dans un tableau (ingénieur, designer, cadre, sceptique, client, analyste de données)
- **Standards de sortie** — questions de clarification avant génération, métriques avec bases, risques avec atténuations
- **Référence de compétences** — pointe vers `.claude/skills/` sans dupliquer leur logique
- **Connexions MCP** — vos intégrations (Notion, Jira, Slack, etc.)

Le fichier fait volontairement moins de 60 lignes. Claude suit mieux des instructions courtes et précises que longues.

## Ce que fait la compétence Rédacteur de PRD

Dites « écrire un PRD » ou « créer un PRD pour [fonctionnalité] » et Claude :

1. Pose d’abord 3 à 5 questions de clarification (ne génère jamais à l’aveugle)
2. Suit un format structuré : hypothèse, problème, solution, métriques, non-objectifs
3. Signale les infos manquantes avec des placeholders `[NEED: data from X]`
4. Reste sous 2 pages sauf si vous demandez plus
5. Inclut des métriques de succès avec chiffres spécifiques et garde-fous

## Comment tirer le meilleur parti de cette configuration

### Chaîner les sous-agents

Écrire un PRD → « Relire en ingénieur » → corriger les lacunes → « Relire en sceptique » → affiner les hypothèses → « Relire en client » → simplifier la proposition de valeur. Trois passes, trois minutes, une spécification nettement meilleure.

### Utiliser les références @

Ne collez pas les docs dans le chat — pointez-les :

```
Read @templates/prd-template.md and use that structure.
Summarize @meeting-notes/standup-03-04.md into action items.
Compare @competitor-notes/notion.md against @competitor-notes/monday.md.
```
Claude lit le fichier à la demande. Votre fenêtre de contexte reste propre.

### Utilisez le mode Plan (Shift+Tab)

Activez-le avant les tâches complexes. Force Claude à esquisser son approche avant d’exécuter. Vous approuvez le plan, puis il exécute. Idéal pour les PRD avec des questions ouvertes, les modifications multi-fichiers, tout ce où "annuler" est coûteux.

### Configurez les hooks

Contrairement aux instructions CLAUDE.md (consultatives), les hooks s’exécutent de manière déterministe :


```
"Write a hook that spell-checks every file after I edit it"
"Write a hook that blocks writes to /templates/"
"Write a hook that runs a word count check — block any PRD over 1500 words"
```

Configurez via `/hooks` ou `.claude/settings.json`. Code de sortie 0 = continuer, code de sortie 2 = bloquer avec retour.

### Gestion de Session

- **`/clear` entre tâches non liées.** Le chevauchement de contexte est le tueur de qualité n°1.
- **Limitez les conversations à ~50 échanges.** La qualité se dégrade au-delà.
- **Utilisez les transferts.** Avant de terminer une longue session : "Écrivez un HANDOFF.md." Session suivante : "Lisez @HANDOFF.md et continuez."
- **Exécutez des sessions parallèles.** Plusieurs terminaux, chacun avec sa propre instance Claude et fenêtre de contexte.
- **Reprenez les sessions.** `claude --continue` pour la dernière session, `claude --resume` pour choisir dans l'historique.

### Faites de CLAUDE.md un Document Auto-Améliorant

Quand Claude fait une erreur, corrigez-la, puis : "Ajoutez une règle à CLAUDE.md pour ne plus refaire cette erreur." Claude propose la règle, vous validez, il modifie le fichier. À la session suivante, la règle est chargée automatiquement. Élagage trimestriel.

### Personnalisez les Compétences

Les compétences sont livrées avec des exemples génériques. Remplacez-les par de vrais exemples de votre produit. Un planificateur de sprint qui connaît la vélocité de votre équipe surpasse toujours un générique.

### Intégrez des Artéfacts Réels

Ne décrivez pas votre fil Slack — collez-le. Ne résumez pas l’entretien utilisateur — collez la transcription. Les compétences extraient et structurent les informations désordonnées ; les entrées brutes produisent la meilleure sortie.

### Référence Rapide

```
/clear              Reset context (CLAUDE.md reloads automatically)
/hooks              Configure automation hooks
/init               Generate a starter CLAUDE.md from your project
/permissions        Set tool access rules
Shift+Tab           Toggle Plan Mode
Esc                 Cancel current generation
claude --continue   Resume last session
claude --resume     Pick a specific past session
claude -p "prompt"  Non-interactive single prompt
```

---

## Vous voulez l'installation complète ?

Cette installation couvre le flux de travail PM principal. Le système complet PM OS couvre toutes les tâches PM que j'exécute quotidiennement :

- Plus de 41 compétences personnalisées pour chaque tâche PM
- 7 perspectives de sous-agent (ingénieur, designer, cadre, sceptique, client, analyste de données, juridique)
- Bibliothèque de contexte avec vos OKR, terminologie et structure d'équipe
- Modèles pour lancements, feuilles de route, rétrospectives et planification de sprint
- Hooks pour la correction orthographique automatisée et la protection des fichiers

**[Obtenez le système complet d'exploitation PM →](https://www.news.aakashg.com/p/pm-os)**

---

Conçu par [Aakash Gupta](https://www.aakashg.com) | [Newsletter sur la croissance produit](https://www.news.aakashg.com)

---

## Dépannage

Problèmes courants et solutions.

### Claude ne semble pas suivre mes instructions CLAUDE.md

- **Vérifiez l'emplacement du fichier.** CLAUDE.md doit être à la racine de votre projet (le répertoire où vous lancez `claude`). Claude Code le charge automatiquement depuis le répertoire de travail.
- **Vérifiez la taille du fichier.** Au-delà d'environ 150 lignes, Claude commence à ignorer les instructions. Élaguez agressivement. Déplacez les connaissances spécifiques dans les compétences.
- **Vérifiez les instructions conflictuelles.** Des règles contradictoires produisent un comportement imprévisible. Auditez pour détecter les conflits.
- **Redémarrez la session.** Exécutez `/clear` ou ouvrez un nouveau terminal. Claude charge CLAUDE.md au démarrage de la session.

### Les compétences ne se déclenchent pas

- **Vérifiez le chemin.** Les compétences doivent être dans `.claude/skills/<nom-de-la-compétence>/SKILL.md` (la casse exacte compte).
- **Vérifiez le déclencheur.** Le SKILL.md doit contenir une phrase de déclenchement claire qui correspond à la manière dont vous demandez. Si votre SKILL.md indique "se déclenche quand l'utilisateur demande à écrire un PRD" mais que vous dites "rédiger une spécification", Claude peut ne pas les associer.
- **Testez avec une demande explicite.** Essayez : "Utilisez la compétence prd-writer pour écrire un PRD pour X." Si cela fonctionne mais pas le langage naturel, affinez la description du déclencheur.
- **Vérifiez que le SKILL.md n'est pas vide ou mal formé.** Ouvrez-le et vérifiez qu'il contient du contenu.

### Claude oublie le contexte en cours de conversation

- **Limites de contexte.** Les longues conversations se dégradent après environ 50 échanges. Utilisez `/clear` et recommencez avec un résumé.
- **Utilisez les transferts.** Avant de nettoyer, demandez à Claude d’écrire un HANDOFF.md résumant l’état, les décisions et les prochaines étapes. Commencez la nouvelle session par "Read @HANDOFF.md and continue."
- **Évitez de coller de gros documents.** Utilisez les références `@` au lieu de coller des documents entiers dans le chat.

### Les hooks ne s’exécutent pas

- **Vérifiez `.claude/settings.json`.** Les hooks sont configurés là, pas dans CLAUDE.md.
- **Vérifiez les codes de sortie.** Les hooks utilisent exit 0 (continuer) et exit 2 (bloquer + retour). D’autres codes de sortie peuvent causer un comportement inattendu.
- **Vérifiez les permissions.** Les scripts de hook doivent être exécutables (`chmod +x`).

### Les serveurs MCP ne se connectent pas

- **Vérifiez les identifiants.** La plupart des serveurs MCP nécessitent des clés API ou des jetons OAuth. Confirmez qu’ils sont à jour.
- **Vérifiez la config serveur.** Les connexions MCP sont configurées dans les paramètres de Claude Code, pas dans CLAUDE.md. CLAUDE.md ne fait que les documenter pour référence.
- **Redémarrez Claude Code.** Les connexions MCP s’initialisent au démarrage.

### « J’ai modifié CLAUDE.md mais rien n’a changé »

Claude lit CLAUDE.md au démarrage de la session. Les modifications en cours de session nécessitent un rechargement :
1. Exécutez `/clear` pour réinitialiser le contexte (CLAUDE.md se recharge automatiquement)
2. Ou démarrez une nouvelle session terminal


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-11

---