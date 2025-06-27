# Serveur MCP

Ce README a été créé à l'aide du projet modèle de serveur MCP .NET. Il démontre comment vous pouvez facilement créer un serveur MCP avec .NET puis le packager dans un package NuGet.

Voir [aka.ms/nuget/mcp/guide](https://aka.ms/nuget/mcp/guide) pour le guide complet.

## Liste de contrôle avant de publier sur NuGet.org

- Mettre à jour les métadonnées du package dans le fichier .csproj
- Mettre à jour le fichier `.mcp/server.json` pour déclarer les entrées de votre serveur MCP
- Tester le serveur MCP localement en utilisant les étapes ci-dessous

## Utilisation du serveur MCP dans VS Code

Une fois le package du serveur MCP publié sur NuGet.org, vous pouvez utiliser la configuration utilisateur suivante dans VS Code pour télécharger et installer le package du serveur MCP. Voir [Utiliser les serveurs MCP dans VS Code (Aperçu)](https://code.visualstudio.com/docs/copilot/chat/mcp-servers) pour plus d'informations sur l'utilisation des serveurs MCP dans VS Code.

```json
{
  "mcp": {
    "servers": {
      "my-custom-mcp": {
        "type": "stdio",
        "command": "dotnet",
        "args": [
          "tool",
          "exec",
          "<votre ID de package ici>",
          "--version",
          "<la version de votre package ici>",
          "--yes",
          "--",
          "start-mcp"
        ],
        "env": {
          "MAX_RANDOM_NUMBER": 100
        }
      }
    }
  }
}
```

Vous pouvez maintenant demander à Copilot chat de générer un nombre aléatoire, par exemple `Donne-moi 3 nombres aléatoires`. Il devrait proposer d'utiliser l'outil `GetRandomNumber` sur le serveur MCP `my-custom-mcp` et vous afficher les résultats.

## Développement local

Pour tester ce serveur MCP à partir du code source (localement) sans utiliser un package serveur MCP déjà construit, utilisez la configuration suivante dans VS Code :

```json
{
  "mcp": {
    "servers": {
      "my-custom-mcp": {
        "type": "stdio",
        "command": "dotnet",
        "args": [
          "run",
          "--project",
          "<CHEMIN VERS LE RÉPERTOIRE DU PROJET>",
          "--",
          "start-mcp"
        ],
        "env": {
          "MAX_RANDOM_NUMBER": 100
        }
      }
    }
  }
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---