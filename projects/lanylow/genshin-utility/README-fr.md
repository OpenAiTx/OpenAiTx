# Genshin Utility [![License](https://img.shields.io/badge/License-GPL3.0-green.svg)](https://github.com/lanylow/genshin-utility/blob/main/LICENSE) ![OS](https://img.shields.io/badge/OS-Windows-yellow.svg) [![Discord](https://img.shields.io/badge/chat-discord-informational)](https://discord.gg/MrtJvV5tKv)

Outil libre et open-source pour Genshin Impact et Honkai : Star Rail qui inclut quelques fonctionnalités améliorant la qualité de vie. Compatible uniquement avec la version OS du jeu.

## FAQ

### Comment charger le mod ?
1. Téléchargez et extrayez les binaires depuis la [dernière version](https://github.com/lanylow/genshin-utility/releases).
2. Ouvrez `loader.exe` **en tant qu’administrateur**, une fenêtre devrait apparaître indiquant qu’elle attend le jeu.
3. Maintenant que cela fonctionne, lancez Genshin Impact ou Honkai : Star Rail.
4. Le jeu s’ouvrira et le mod sera chargé.

### Comment ouvrir et fermer le menu ?
Par défaut, la touche utilisée pour basculer le menu est <kbd>INSERT</kbd>, cependant vous pouvez la modifier en changeant le fichier de configuration.

### Où est sauvegardée ma configuration ?
Le dossier `genshin-utility` dans votre répertoire Documents contient le fichier de configuration sauvegardé au format `.ini`. Après certaines mises à jour, il peut être nécessaire de supprimer et recréer le fichier de configuration.

### Que faire si le menu Genshin Utility n’apparaît pas ?
La cause la plus fréquente de ce problème est la présence de superpositions tierces. Assurez-vous que des programmes tels que MSI Afterburner (RTSS) ou l’overlay de Discord ne soient pas attachés au jeu, car ils peuvent interférer avec le menu de cet outil. Une autre cause possible est que vous ne lancez pas le jeu via le lanceur, ce programme ne fonctionnera pas si vous ouvrez directement l’exécutable du jeu.

## Captures d’écran

![image](https://github.com/lanylow/genshin-utility/assets/31806776/88492fe8-4016-447a-80ec-b8c4d9225cc9)

## Bibliothèques tierces utilisées

* [imgui](https://github.com/ocornut/imgui) - Interface utilisateur graphique pour C++
* [minhook](https://github.com/TsudaKageyu/minhook) - Bibliothèque de hook API pour Windows
* [mini](https://github.com/metayeti/mINI) - Lecteur et écrivain de fichiers INI

## Licence

Ce projet est sous licence GPL-3.0 - voir le fichier [LICENSE](https://github.com/lanylow/genshin-utility/blob/main/LICENSE) pour plus de détails.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-03

---