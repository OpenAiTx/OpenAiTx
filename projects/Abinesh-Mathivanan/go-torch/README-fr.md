# go-torch 

go-torch est un framework d'apprentissage profond open-source développé entièrement en Go pur. Il offre une API modulaire, similaire à PyTorch, pour construire et entraîner des réseaux neuronaux avec un moteur d'auto-différentiation stable.

mail - abineshmathivanan31@gmail.com 

blog - https://abinesh-mathivanan.vercel.app/en/posts/post-5/


## fonctionnalités 
- **graphe de calcul dynamique** : les tenseurs suivent leur historique, permettant le calcul automatique des gradients lors de la rétropropagation.
- système de modules extensible (nn.Layer, nn.Sequential) : construire des architectures de modèles complexes avec une API séquentielle flexible, similaire à Keras. 
- bibliothèque de couches et fonctions : inclut Conv2D, Linear, MaxPooling2D, Flatten, ReLU, CrossEntropyLoss et SGD
- **tableau de bord TUI en temps réel** : graphiques en direct pour la perte par lot et la précision de validation par époque, suivi de l'utilisation mémoire (Heap/Total Alloc), cycles GC, et goroutines actives avec un résumé type keras.
- performances optimisées : utilisation de BLAS, go-routines et autograd topologique + accumulation des gradients

<br/>

**Tableau de bord TUI**

![alt text](https://raw.githubusercontent.com/Abinesh-Mathivanan/go-torch/main/dashboard.png)


<br>

## À FAIRE
- [ ] ajouter le support pour RNN, LSTM, Transformers
- [ ] implémenter Adam avec techniques Ga-lore et LORA, RMSProp etc...
- [ ] model.load() et model.save() sans gob
- [ ] prise en charge de la construction de Transformers

<br/>

## prérequis 
- Go 1.18 ou version ultérieure.
- une bibliothèque BLAS installée sur le système est recommandée pour des performances maximales mais pas obligatoire.
- quelques tâches à faire sont écrites dans les fichiers. utilisez l'extension 'better comments' pour une meilleure expérience. 

<br/>

## utilisation 

### cloner le dépôt
```bash
git clone https://github.com/abinesh-mathivanan/go-torch.git
cd go-torch
``` 
### installer les dépendances
``` bash
go mod tidy
```

### exécuter 
exécutez le fichier d'entraînement mnist pour tester les fonctionnalités. 
```bash
go run ./cnn_benchmark/go_bench.go
```

<br>

## Benchmark

| Détail du Benchmark                      | 128x128      | 512x512     | 1024x1024    |
|:------------------------------------------|:-------------|:------------|:-------------|
| **Multiplication de Matrices**           | 510.33 µs    | 13.54 ms    | 130.50 ms    |
| Addition Élément par Élément              | 71.72 µs     | 1.29 ms     | 4.13 ms      |
| Multiplication Élément par Élément        | 47.83 µs     | 1.63 ms     | 3.91 ms      |
| Activation ReLU                           | 121.18 µs    | 1.75 ms     | 6.45 ms      |
| **Propagation Avant Couche Linéaire (B32,I128,O10)** | 71.93 µs     |             |              |
| **CrossEntropyLoss (B32,C10)**            | 11.16 µs     |             |              |
| **Propagation Avant-Arrière Complète (Net:128-256-10, B32)** | 4.02 ms      |             |              |


<br>
<br>

[![Graphique Historique des Étoiles](https://api.star-history.com/svg?repos=Abinesh-Mathivanan/go-torch&type=Date)](https://www.star-history.com/#Abinesh-Mathivanan/go-torch&Date)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-26

---