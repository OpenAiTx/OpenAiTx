[![License: MIT](https://img.shields.io/badge/License-MIT-yellow)](https://github.com/Shihang-Wang-58/DeepSA)
[![PyPI](https://img.shields.io/badge/PyPI-cyan)](https://pypi.org/project/deepsa)

# DeepSA : Un Prédicteur de l’Accessibilité de Synthèse des Composés, Basé sur l’Apprentissage Profond

Avec le développement continu des technologies d’intelligence artificielle, de plus en plus de modèles génératifs profonds sont utilisés pour la génération de molécules. Cependant, la plupart des nouvelles molécules générées par ces modèles rencontrent souvent de grandes difficultés en termes d’accessibilité de synthèse.

DeepSA est proposé pour prédire l’accessibilité de synthèse des composés, et présente un taux d’enrichissement précoce bien supérieur pour discriminer les molécules difficiles à synthétiser. Cela aide les utilisateurs à sélectionner des molécules moins coûteuses pour la synthèse, réduisant ainsi le temps nécessaire à la découverte et au développement de médicaments. Vous pouvez utiliser DeepSA sur un serveur web à l’adresse https://bailab.siais.shanghaitech.edu.cn/deepsa<br/>

## Prérequis
Les dépendances peuvent être installées avec la commande suivante :
```bash
conda create -n DeepSA python=3.12
conda activate DeepSA
# pour la version GPU
pip3 install torch torchvision torchaudio --index-url https://download.pytorch.org/whl/cu118
pip3 install autogluon==1.2
pip3 install rdkit
```
### Actualités 🔔 

* 12/2024, car [AutoGluon a cessé de prendre en charge la version Python 3.8](https://github.com/autogluon/autogluon/pull/4512) à partir d’octobre 2024. Par conséquent, nous avons mis à jour DeepSA pour utiliser la version Python 3.12 et adapté les scripts d’entraînement et d’inférence à la dernière version d’AutoGluon. Merci de votre intérêt pour DeepSA !

* 07/2023, DeepSA_v1.0 a été publié, n’hésitez pas à nous faire part de vos retours via les issues !

## Données 
Les ensembles de données d’entraînement et de test étendus peuvent être facilement téléchargés à l’adresse suivante : https://drive.google.com/drive/folders/1iup6T3Bqyy-uvpdFyP0Of_WQqn-9l62h?usp=sharing
## Utilisation pour les Chercheurs
Si vous souhaitez entraîner votre propre modèle, vous pouvez l’exécuter depuis la ligne de commande,

Exécution :
```
    python DeepSA_training.py <dataset.csv/training.csv:test.csv> DeepSA_model ./data/test_set.list
```
Si vous souhaitez utiliser le modèle que nous proposons,

Exécution :
```
    python DeepSA_predict.py <input_data.csv> DeepSA_model
```

## Serveur en Ligne

Nous avons déployé un modèle pré-entraîné sur un serveur dédié, accessible publiquement à l’adresse https://bailab.siais.shanghaitech.edu.cn/deepsa, afin de faciliter l’utilisation de DeepSA par les chercheurs en biomédecine.

Les utilisateurs peuvent téléverser leurs fichiers SMILES ou csv sur le serveur, puis obtenir rapidement les résultats prédits.

## <span id="citelink">Citation</span>
Si ce dépôt vous est utile dans vos recherches, merci de citer notre article : 

Wang, S., Wang, L., Li, F. et al. DeepSA: a deep-learning driven predictor of compound synthesis accessibility. J Cheminform 15, 103 (2023). https://doi.org/10.1186/s13321-023-00771-3

## Contact
Si vous avez des questions, n’hésitez pas à contacter Shihang Wang (Email : wangshh12022@shanghaitech.edu.cn) ou Lin Wang (Email : wanglin3@shanghaitech.edu.cn).

Les pull requests sont les bienvenues !

## Remerciements
Nous remercions la plateforme HPC de l’Université ShanghaiTech pour son soutien.<br/>
Merci à tous pour votre attention portée à ce travail.

![Star History Chart](https://api.star-history.com/svg?repos=Shihang-Wang-58/DeepSA&type=Date)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---