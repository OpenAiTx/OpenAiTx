# GOT-OCR-2-GUI

## [Voir la version anglaise ici](https://raw.githubusercontent.com/XJF2332/GOT-OCR-2-GUI/main/README-en.md)

🛑 Arrêt du support, mises à jour futures aléatoires

![img.png](https://raw.githubusercontent.com/XJF2332/GOT-OCR-2-GUI/main/img.png)

## À propos de ce projet

Poids du modèle : [Miroir](https://hf-mirror.com/stepfun-ai/GOT-OCR2_0), [Site original](https://huggingface.co/stepfun-ai/GOT-OCR2_0)  
GitHub original : [GOT-OCR2.0](https://github.com/Ucas-HaoranWei/GOT-OCR2.0/)   
Ce projet a été développé sous Windows, je ne l'ai jamais utilisé ni sur Linux, je ne peux pas garantir qu'il fonctionne correctement sous Linux, si vous souhaitez déployer sous Linux  
vous pouvez consulter cette [issue](https://github.com/XJF2332/GOT-OCR-2-GUI/issues/3)  
Une partie du code provient de : [ GLM4 ](https://chatglm.cn/main/alltoolsdetail?lang=zh), [Deepseek](https://www.deepseek.com/)

Merci de mettre une étoile

## À faire

- [x] Localisation des contenus des journaux
- [ ] Support du nouveau modèle stepfun-ai/GOT-OCR-2.0-hf
- [ ] Optimiser la gestion des erreurs liées aux PDF
- [x] Support du modèle GGUF, pour accélérer l'inférence (merci pour l'aide fournie par [issue #19](https://github.com/XJF2332/GOT-OCR-2-GUI/issues/19))
- [ ] Améliorer le support du modèle GGUF
- [x] Nouveau mode de rendu : optimisation des performances, support de plus de formats de sortie
- [ ] Supprimer/cacher l'ancien moteur de rendu

## Mode d'emploi

Si vous ne possédez pas les dossiers mentionnés ici, **créez-en un nouveau**

### Choisissez une branche

#### Alpha

Branche la plus rapide pour les mises à jour, tous les derniers changements sont soumis sur cette branche.  
Le code n'est parfois pas testé.  
Très instable, parfois même inutilisable.  

#### main

Branche relativement stable, mais certaines nouvelles fonctionnalités peuvent manquer.

### Dépendances

Cet environnement a été testé pour fonctionner correctement sous **python 3.11.9**

#### torch

Choisissez la version **GPU** de torch adaptée à votre configuration depuis le [site officiel de torch](https://pytorch.org/get-started/locally/)  
J’utilisais auparavant Stable 2.4.1 + cu124  
Actuellement, j’utilise Stable 2.0.1 + cu118, ce qui permet de résoudre `1 Torch is not compiled with Flash Attention`, sans autres problèmes constatés

#### PyMuPDF

En test, si on installe directement depuis `requirements.txt`, une erreur `ModuleNotFoundError: No module named 'frontend'` survient,  
mais en installant séparément, ce problème n’apparaît pas, la cause précise est inconnue  
Par ailleurs, si l’erreur `ModuleNotFoundError` persiste, désinstallez d’abord `fitz` et `PyMuPDF`, puis réinstallez-les, cela devrait résoudre le problème ;  
il a été constaté que `pip install -U PyMuPDF` seul ne suffit pas

```commandline
pip install fitz
pip install PyMuPDF
```
#### Installation avec `pip`


```commandline
pip install -r requirements.txt
```

De plus, quelqu'un a mentionné avoir rencontré des conflits lors de l'installation des dépendances avec `requirements.txt`, mais je n'ai pas constaté de problème ici, `pipdeptree` n'affiche aucun conflit, et `requirements.txt` est directement généré par `pip freeze` de mon propre environnement virtuel, donc il ne devrait pas y avoir de problème.  
Cependant, comme ce problème est effectivement survenu, voici un fichier `requirements-noversion.txt` sans numéro de version, que vous pouvez essayer :  
Pour plus d'informations, veuillez consulter ce [issue #4](https://github.com/XJF2332/GOT-OCR-2-GUI/issues/4)


```commandline
pip install -r requirements-noversion.txt
```
#### Autres

- [Edge WebDriver](https://developer.microsoft.com/zh-cn/microsoft-edge/tools/webdriver/?form=MA13LH#downloads)  
  , téléchargez l’archive et placez-la dans le dossier `edge_driver`

> Tout le monde a Edge sur son ordinateur, non ? Normalement oui, c’est préinstallé...  
> La structure des fichiers devrait être :  
> ```
> GOT-OCR-2-GUI
> └─edge_driver
>    ├─msedgedriver.exe
>    └─...
> ```

### Télécharger les fichiers de modèle

Parmi les modèles suivants, un seul suffit pour exécuter l’OCR, mais pour activer le chargement automatique des modèles, il faut disposer d’un modèle `Safetensors`  
Le support des modèles GGUF n’est pas encore complet, vous pouvez actuellement les tester séparément dans l’onglet GGUF

#### Safetensors

1. Téléchargez dans le dossier `models`  
2. Ne téléchargez pas de fichiers manquants  
3. Si c’est un nouveau modèle `GOT-OCR-2-HF` (pas encore pris en charge), téléchargez-le dans le dossier `models-hf` (mais il n’est pas encore pris en charge)

- La structure des fichiers devrait être :


```
GOT-OCR-2-GUI
└─models
   ├─config.json
   ├─generation_config.json
   ├─got_vision_b.py
   ├─model.safetensors
   ├─modeling_GOT.py
   ├─qwen.tiktoken
   ├─render_tools.py
   ├─special_tokens_map.json
   ├─tokenization_qwen.py
   └─tokenizer_config.json
```
#### GGUF

Le modèle GGUF est pris en charge par `got.cpp`  
Téléchargez le modèle depuis le dépôt `MosRat/got.cpp`, placez `Encode.onnx` dans `gguf\Encoder.onnx`, et les autres modèles Decoder GGUF dans `gguf\decoders`

### Commencer

1. Si vous voulez utiliser la ligne de commande, utilisez `CLI.py`  
2. Si vous préférez une interface graphique, utilisez `GUI.py`  
3. Pour modifier les paramètres, utilisez `Config Manager.py`  
4. Pour exécuter des opérations de rendu automatisées, utilisez `Renderer.py`, qui rendra automatiquement toutes les images `.jpg` et `.png` dans le dossier `imgs`

> Ceux qui utilisent le GUI peuvent ignorer cela, mais pour les utilisateurs CLI, n’oubliez pas de mettre les images à OCR dans le dossier `imgs` (CLI ne détecte actuellement que les fichiers `.jpg` et `.png`)

## Support de localisation

- Vous pouvez trouver des fichiers `.json` de différentes langues dans le dossier `Locales`, les fichiers de langue pour CLI et GUI sont stockés séparément  
- Dans le sous-dossier `gui`, en plus du fichier `langue.json`, il y a un dossier `instructions` contenant les tutoriels intégrés du GUI, nommés `langue.md`  
- Pour changer la langue, modifiez simplement la valeur de `'language'` dans `config.json`. Les choix possibles correspondent aux noms des fichiers `.json` sans extension  
- Pour ajouter une langue, dans CLI, ajoutez un nouveau fichier `langue.json` (je recommande fortement de partir d’un fichier existant). Dans GUI, ajoutez aussi le fichier `langue.md` correspondant  
- Vous pouvez gérer la langue et d’autres fichiers de configuration avec `Config Manager.py`

## Remarques importantes

- Si le script plante, essayez de le lancer via `cmd` avec `python + nom_du_fichier`. J’ai aussi rencontré des plantages sans raison apparente  
- Ne supprimez pas `markdown-it.js` dans le dossier `result`, sinon l’export PDF échouera !

> Si vous l’avez supprimé par erreur, une copie de sauvegarde se trouve dans le dossier `scripts`. Copiez-la simplement à l’endroit d’origine

- Assurez-vous que la version de `torch` installée est GPU, car le script utilise `device_map='cuda'`

## FAQ

- Q : CLI.py : error : the following arguments are required: --path/-P  
- R : Utilisez PowerShell, CMD semble avoir ce bug sans raison, je n’ai pas encore trouvé pourquoi  
---  
- Q : Qu’est-ce qu’un « fichier HTML local » ? Existe-t-il des fichiers HTML non stockés localement ?  
- R : Bien que le fichier HTML généré soit stocké localement, il utilise des scripts externes, donc il nécessite une connexion internet pour s’ouvrir. J’ai donc téléchargé ces scripts externes, comme mentionné plus haut


  `mardown-it.js`. Cela est principalement fait pour éviter les échecs d’exportation PDF causés par des problèmes réseau.
---
- Q : Pourquoi mon modèle n’a-t-il pas pu être chargé ?
- R : Vérifiez si vous n’avez pas oublié un fichier. Les fichiers modèles téléchargés depuis Baidu Cloud semblent incomplets, je vous recommande de les télécharger depuis Huggingface mentionné précédemment.
---
- Q : Avez-vous des conseils pour déployer ce projet ?
- R : Consultez ce [issue #5](https://github.com/XJF2332/GOT-OCR-2-GUI/issues/5)
---
- Q : Où puis-je trouver la documentation d’aide ?
- R : Pour les utilisateurs GUI, vous pouvez trouver l’onglet `说明`, pour les utilisateurs CLI, vous pouvez utiliser `.\CLI.py --help` pour voir la documentation d’aide générée automatiquement par argparse, ou `.\CLI.py --detailed-help` pour une documentation plus détaillée.

## Historique des étoiles

[![Graphique de l’historique des étoiles](https://api.star-history.com/svg?repos=XJF2332/GOT-OCR-2-GUI&type=Date)](https://star-history.com/#XJF2332/GOT-OCR-2-GUI&Date)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-12

---