# Fondations AlphaEarth

Une implémentation PyTorch du modèle fondamental géospatial AlphaEarth de Google DeepMind, qui génère des embeddings terrestres pour la surveillance et l’analyse environnementale globale.  
Accompagnant l’article, un ensemble de données global d’embeddings de 2017 à 2024, disponible via Earth Engine. L’objectif de ces embeddings est de servir de représentation géospatiale très générale pour un grand nombre d’applications en aval, sans besoin de réentraînement.  

> [!NOTE]  
> Ce modèle est un travail en cours et n’a pas été réellement entraîné sur l’ensemble complet de données, c’est juste un cadre fournissant une base générale pour l’architecture de l’article. Le code est simplifié par rapport à l’implémentation réelle de DeepMind (en JAX).  

### Parties clés de la méthodologie

- **Support du Temps Continu** : Première approche de featurisation EO supportant le temps continu, permettant l’interpolation et l’extrapolation temporelle.  
- **Architecture Space Time Precision (STP)** : Encodeur multi-résolution avec opérateurs spatiaux (1/16L), temporels (1/8L) et de précision (1/2L) - conçu pour maintenir des représentations localisées tout en modélisant des relations longue distance dans le temps et l’espace.  
- **Embeddings von Mises-Fisher** : Embeddings de 64 octets distribués sur la sphère unité S^63, représentation très compacte.  

## Architecture

### Encodeur Space Time Precision (STP)

L’encodeur STP traite des données multi-temporelles et multi-sources via trois opérateurs simultanés :  
- **Opérateur Spatial** : Auto-attention spatiale de type ViT (résolution 1/16L)  
- **Opérateur Temporel** : Auto-attention axiale temporelle (résolution 1/8L)  
- **Opérateur de Précision** : Convolutions 3x3 (résolution 1/2L)  

### Cadre Enseignant-Étudiant-Texte

1. **Modèle d’Embedding Vidéo Enseignant** : Modèle principal avec décodeurs implicites  
2. **Modèle d’Embedding Vidéo Étudiant** : Partage les paramètres avec l’enseignant pour apprentissage contrastif  
3. **Modèle d’Alignement Texte** : Permet l’apprentissage contrastif texte-image  

## Sources de Données

Le modèle est entraîné sur de nombreuses sources de données, notamment :  
- **Optique** : Sentinel-2, Landsat 8/9. *Note : pour simplifier, mon implémentation ne supporte que Sentinel-2, mais il devrait être relativement simple d’ajouter de nouveaux jeux de données à l’entraînement*  
- **Radar** : Sentinel-1, PALSAR2  
- **LiDAR** : GEDI  
- **Environnemental** : GLO-30, ERA5-Land, GRACE  
- **Annoté/Texte** : NLCD, Wikipedia  



## Installation

```bash
# Clone the repository
git clone https://github.com/brayden-zhang/alphaearth-foundations.git
cd alphaearth-foundations

# Install dependencies
uv pip install -r requirements.txt

# Install the package 
uv pip install -e .
```
Comment exécuter une étape d'entraînement :

```
python -m alphaearth.run_train
```

## Citation de l'article

```bibtex
@misc{brown2025alphaearthfoundationsembeddingfield,
      title={AlphaEarth Foundations: An embedding field model for accurate and efficient global mapping from sparse label data}, 
      author={Christopher F. Brown and Michal R. Kazmierski and Valerie J. Pasquarella and William J. Rucklidge and Masha Samsikova and Chenhui Zhang and Evan Shelhamer and Estefania Lahera and Olivia Wiles and Simon Ilyushchenko and Noel Gorelick and Lihui Lydia Zhang and Sophia Alj and Emily Schechter and Sean Askay and Oliver Guinan and Rebecca Moore and Alexis Boukouvalas and Pushmeet Kohli},
      year={2025},
      eprint={2507.22291},
      archivePrefix={arXiv},
      primaryClass={cs.CV},
      url={https://arxiv.org/abs/2507.22291}, 
}
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-01

---