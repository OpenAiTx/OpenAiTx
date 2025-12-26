# VSCode en tant que serveur MCP

[Marketplace](https://marketplace.visualstudio.com/items?itemName=acomagu.vscode-as-mcp-server)

Une extension VSCode qui transforme votre VSCode en serveur MCP, permettant une assistance avancée à la programmation depuis des clients MCP comme Claude Desktop.

## Fonctionnalités clés

### Support d’édition de code
- Passez en revue les modifications de code proposées par un LLM via des diff, vous permettant d’accepter, rejeter ou donner un retour.
- Messages de diagnostic en temps réel (par ex. erreurs de type) envoyés instantanément au LLM pour corrections immédiates.

![Diff d’édition de code](https://storage.googleapis.com/zenn-user-upload/778b7e9ad8c4-20250407.gif)

### Opérations terminal
- Exécutez des commandes dans le terminal intégré de VSCode (prise en charge de l’exécution en arrière-plan/avant-plan, et paramètres de délai d’attente).

### Outils de prévisualisation
- Prévisualisez des URLs directement dans le navigateur intégré de VSCode (par ex. ouverture automatique de la prévisualisation du navigateur après le démarrage d’un serveur Vite).

![Outil de prévisualisation](https://storage.googleapis.com/zenn-user-upload/8968c9ad3920-20250407.gif)

### Changement multi-instance
- Changez facilement le serveur MCP entre plusieurs fenêtres VSCode ouvertes. (Juste en cliquant sur l’élément de la barre d’état)

![Changement d’instance](https://storage.googleapis.com/zenn-user-upload/0a2bc2bee634-20250407.gif)

### Fonctionnalité de relais (expérimental)
- Relais et exposition des serveurs MCP intégrés introduits dans VSCode 1.99 vers l’extérieur.
- Permet l’accès externe aux outils fournis par d’autres extensions MCP, comme GitHub Copilot.

## Outils intégrés disponibles

- **execute_command** : Exécuter des commandes dans le terminal intégré de VSCode  
- **code_checker** : Récupérer les diagnostics actuels de votre code  
- **focus_editor** : Focaliser des emplacements spécifiques dans les fichiers  
- **list_debug_sessions** / **start_debug_session** / **restart_debug_session** / **stop_debug_session** : Gérer les sessions de débogage  
- **text_editor** : Opérations sur les fichiers (visualiser, remplacer, créer, insérer, annuler)  
- **list_directory** : Lister le contenu des répertoires sous forme d’arborescence  
- **get_terminal_output** : Récupérer la sortie d’un terminal spécifié  
- **list_vscode_commands** / **execute_vscode_command** : Lister et exécuter des commandes VSCode arbitraires  
- **preview_url** : Ouvrir des URL dans le navigateur intégré de VSCode  

## Installation & Configuration  

1. Installez l’extension depuis le [Marketplace VSCode](https://marketplace.visualstudio.com/items?itemName=acomagu.vscode-as-mcp-server).  

2. Configurez votre client MCP :  

    - **Avec mcp-installer** : Vous pouvez simplement lui demander d’"installer le serveur MCP vscode-as-mcp-server".  
    - **Autres clients comme Claude Desktop** : Ajoutez ce qui suit à votre fichier de configuration (`claude_desktop_config.json`) :

    ```json
    {
      "mcpServers": {
        "vscode": {
          "command": "npx",
          "args": ["vscode-as-mcp-server"]
        }
      }
    }
    ```
3. Vérifiez le statut du serveur MCP dans la barre d'état en bas à droite de VSCode :

    - (Icône serveur) : Le serveur fonctionne
    - ∅ : Cliquez pour démarrer le serveur

![Indicateur de statut du serveur](https://storage.googleapis.com/zenn-user-upload/321704116d4a-20250408.png)

## Motivation

Cette extension a été développée pour atténuer les coûts élevés associés aux outils de codage mesurés (comme Roo Code et Cursor). C'est une alternative abordable et auto-hébergée intégrée directement dans VSCode.

Les rapports de bugs et les retours sont les bienvenus ! 🙇

## Feuille de route future

- Possibilité de sélectionner les serveurs MCP intégrés à exposer
- Interface d'approbation basée sur WebView (similaire à Roo Code)
- Intégration avec l'historique des fichiers de VSCode (Timeline)
- Activation/désactivation instantanée des auto-approbations et des outils
- Configuration personnalisable du port du serveur



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-26

---