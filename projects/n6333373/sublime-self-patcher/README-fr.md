## Correcteur Automatique Sublime

Il s'agit d'un plugin pour Sublime Text 4 qui peut patcher Sublime Text et Sublime Merge.

🔥 Aucune dépendance tierce n'est requise. La seule chose dont vous avez besoin est Sublime Text.

## Environnements Pris en Charge

| Symbole | Signification                                                          |
| ------- | --------------------------------------------------------------------- |
| ✅      | Pris en charge.                                                       |
| ⚠️      | Modèles de patch instables. Vous devrez peut-être mettre à jour ce plugin fréquemment. |
| ☠️      | Désolé, mais je ne l'utilise pas.                                    |

|                   | Linux x64 | Windows x32 | Windows x64 | Autres |
| ----------------- | --------- | ----------- | ----------- | ------ |
| **Sublime Text**  | ✅        | ✅          | ✅          | ☠️     |
| **Sublime Merge** | ✅⚠️      |             | ✅          | ☠️     |

Si vous êtes sous Windows 7, alors [Service Pack 2](https://answers.microsoft.com/en-us/windows/forum/all/how-to-obtain-and-install-windows-7-sp2/c2c7009f-3a10-4199-9c89-48e1e883051e) est requis.

## Téléchargement

https://github.com/n6333373/sublime-self-patcher/archive/refs/heads/main.zip

## Installation

Tout d'abord, vous devez localiser le répertoire `Packages`.

- Si vous utilisez une version portable de Sublime Text, c'est `Data/Packages`.
- Si vous utilisez une version installée de Sublime Text,
  - Sous Windows, c'est `%appdata%\Sublime Text\Packages`.
  - Sous Linux, c'est `$HOME/.config/sublime_text/Packages`.

Maintenant, (décompressez si nécessaire) placez le répertoire téléchargé dans le répertoire `Packages`
de sorte que la structure des répertoires ressemble à ce qui suit :

```text
Packages/
└── SelfPatcher/
    ├── boot.py
    ├── ...
```
  
Puis redémarrez Sublime Text s'il est en cours d'exécution.

## Utilisation

### Patch Self (Le Sublime Text Actuel)

- Si vous utilisez une version dev non enregistrée, ce plugin devrait afficher une fenêtre contextuelle pour le patch au démarrage.
- Si vous utilisez une version stable, vous pouvez patcher depuis le menu : `Aide ⇒ Patch de cette application`

### Patch Sublime Text/Merge Externe

Si votre application est installée dans un emplacement nécessitant des permissions admin/root pour écrire,
vous pouvez utiliser ce plugin pour créer un exécutable patché dans un répertoire temporaire.

Cliquez sur le menu : `Aide ⇒ Patch Sublime Text/Merge Externe` puis sélectionnez l’exécutable de Sublime Text/Merge.

## Q&R

### Comment désactiver la mise à jour automatique de Sublime Text/Merge ?

Ce plugin continue généralement de fonctionner pour les futures versions de Sublime Text/Merge.
Mais si vous souhaitez désactiver la mise à jour automatique de l’application, vous pouvez définir les paramètres suivants :

```jsonc
{
    "update_check": false, // this works only if you have registered
}
```

### Ce plugin est suspect

Je ne pense pas faire quoi que ce soit de malveillant, mais vous n’êtes pas obligé de me faire confiance. Vous pouvez

- Faire le patch dans une machine virtuelle et extraire l’exécutable patché.
- Le faire vous-même. Voir https://gist.github.com/maboloshi/feaa63c35f4c2baab24c9aaf9b3f4e47


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-24

---