# 🚀 MCP Assistant de Développement IA

> Outil MCP pour assister les développeurs IA dans l’analyse intelligente des besoins et la conception d’architecture

## ✨ Fonctionnalités principales

- **Clarification intelligente des besoins** : Identification automatique du type de projet, génération de questions ciblées
- **Gestion de branches contextuelle** : Suivi des objectifs du projet, conception fonctionnelle, préférences techniques, conception UI, etc.
- **Génération automatique d’architecture** : Génération de la solution d’architecture technique à partir des besoins complets
- **Stockage persistant** : Sauvegarde automatique des résultats d’analyse, exportation de documents supportée

## 📁 Configuration rapide

### Configuration ancienne version
1. **Cloner le code**
   ```bash
   git clone https://github.com/jiemobasixiangcai/ai-develop-assistant.git
   ```
2. **Environnement virtuel recommandé**
   ```bash
   python -m venv venv
   source venv/bin/activate  # Unix/Linux/MacOS
   venv\Scripts\activate  # Windows
   ```
3. **Installer les dépendances**
   ```bash
   pip install -r requirements.txt
   ```

4. **Emplacement du fichier de configuration**
   ```
   Windows : %APPDATA%\Claude\claude_desktop_config.json
   macOS : ~/Library/Application Support/Claude/claude_desktop_config.json
   ```

5. **Ajouter la configuration**
   ```json
   {
     "mcpServers": {
       "ai-develop-assistant": {
         "command": "python",
         "args": ["path/to/AIDevlopStudy.py"],
         "env": {
           "MCP_STORAGE_DIR": "./mcp_data"
         }
       }
     }
   }
   ```

3. **Redémarrer Claude Desktop**

### Configuration nouvelle version
#### 🔧 Outils principaux
1. **start_new_project** - Démarrer un nouveau projet
2. **create_requirement_blueprint** - Créer un blueprint de besoins
3. **requirement_clarifier** - Obtenir des suggestions de clarification des besoins
4. **save_clarification_tasks** - Sauvegarder les tâches de clarification
5. **update_branch_status** - Mettre à jour l’état des branches
6. **requirement_manager** - Gestionnaire de documents de besoins
7. **check_architecture_prerequisites** - Vérifier les prérequis d’architecture
8. **get_architecture_design_prompt** - Obtenir une suggestion de conception d’architecture
9. **save_generated_architecture** - Sauvegarder l’architecture générée
10. **export_final_document** - Exporter le document final complet
11. **view_requirements_status** - Voir l’état des besoins

#### Configuration (copier la connexion directe distante dans votre outil, remplacer MCP_STORAGE_DIR par votre répertoire local)
   ```json
   {
     "mcpServers": {
       "ai-develop-assistant": {
         "command": "uvx",
         "args": ["ai-develop-assistant@latest"],
         "env": {
           "MCP_STORAGE_DIR": "/path/to/your/storage"
         }
       }
     }
   }
   ```

## 🎯 Processus d’utilisation

### Étapes de base

1. **Clarification des besoins**
   ```
   requirement_clarifier("Je veux créer une plateforme d’éducation en ligne")
   ```

2. **Gestion des besoins**
   ```
   requirement_manager("Utilisateurs cibles : étudiants et enseignants", "Résumé du projet")
   ```

3. **Voir l’état**
   ```
   view_requirements_status()
   ```
4. **Conception de l’architecture**
   ```
   architecture_designer("Architecture de la plateforme d'éducation en ligne")
   ```

5. **Exporter le document**
   ```
   export_final_document()
   ```

## 🚀 Commencer à utiliser

### Prise en main rapide
1. **Configurer Claude Desktop** (voir la méthode de configuration ci-dessus)
2. **Redémarrer Claude Desktop**
3. **Commencer l’analyse intelligente des besoins** :
   ```
   requirement_clarifier("Décrivez votre idée de projet")
   ```
4. **Suivre les instructions intelligentes de l’IA** pour améliorer progressivement chaque branche des besoins
5. **Exporter le document complet** :
   ```
   export_final_document()
   ```

### Bonnes pratiques
- 💬 **Faites confiance à la gestion des branches par l’IA** : laissez l’IA vous guider pour compléter toutes les branches des besoins
- 🎯 **Exprimez clairement vos préférences** : exprimez clairement vos préférences pour le choix technologique, le style UI, etc.
- 📊 **Consultez régulièrement l’état d’avancement** : utilisez `view_requirements_status` pour suivre la progression
- 🤖 **Autorisez l’IA à prendre des décisions lorsque nécessaire** : pour les parties incertaines, vous pouvez dire « utiliser la solution conventionnelle »

---

**🎯 Vous disposez désormais d’un véritable assistant de développement IA intelligent, qui se souviendra de chaque détail et vous guidera pour réaliser une analyse complète des besoins !**

## 💬 Groupe d’échange

<div align="center">
<img src="https://raw.githubusercontent.com/jiemobasixiangcai/ai-develop-assistant/main/./assets/qr-code.jpg" width="200" alt="Groupe d’échange">
<br>
Groupe d’échange
</div>

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-02

---