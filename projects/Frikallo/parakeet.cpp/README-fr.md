# parakeet.cpp

Reconnaissance vocale rapide avec les modèles [Parakeet](https://huggingface.co/collections/nvidia/parakeet) de NVIDIA en pur C++.

Construit sur [axiom](https://github.com/frikallo/axiom) — une bibliothèque tensorielle légère avec accélération automatique Metal GPU. Pas de runtime ONNX, pas de runtime Python, pas de dépendances lourdes. Juste du C++ et une bibliothèque tensorielle qui dépasse PyTorch MPS.

**~27ms d'inférence encodeur sur GPU Apple Silicon** pour 10s d'audio (modèle 110M) — 96x plus rapide que le CPU. Support FP16 pour une réduction mémoire d'environ 2x.

## Modèles pris en charge

| Modèle | Classe | Taille | Type | Description |
|-------|-------|------|------|-------------|
| `tdt-ctc-110m` | `ParakeetTDTCTC` | 110M | Hors ligne | Anglais, têtes décodeurs CTC/TDT doubles |
| `tdt-600m` | `ParakeetTDT` | 600M | Hors ligne | Multilingue, décodeur TDT |
| `eou-120m` | `ParakeetEOU` | 120M | En streaming | Anglais, RNNT avec détection de fin d’énoncé |
| `nemotron-600m` | `ParakeetNemotron` | 600M | En streaming | Multilingue, latence configurable (80ms–1120ms) |
| `sortformer` | `Sortformer` | 117M | En streaming | Diarisation de locuteurs (jusqu’à 4 locuteurs) |
| `diarized` | `DiarizedTranscriber` | 110M+117M | Hors ligne | ASR + diarisation → mots attribués aux locuteurs |

Tous les modèles ASR partagent le même pipeline audio : WAV mono 16kHz → spectrogramme Mel 80 bins → encodeur FastConformer.

## Démarrage rapide

```cpp
#include <parakeet/parakeet.hpp>

parakeet::Transcriber t("model.safetensors", "vocab.txt");
t.to_gpu();   // optional — Metal acceleration
t.to_half();  // optional — FP16 inference (~2x memory reduction)

auto result = t.transcribe("audio.wav");
std::cout << result.text << std::endl;
```

## Fonctionnalités

- **Décodeurs multiples** — CTC glouton, TDT glouton, recherche par faisceau CTC, recherche par faisceau TDT (changement au point d’appel)
- **Horodatage des mots** — Temps de début/fin et scores de confiance par mot sur tous les décodeurs
- **Recherche par faisceau + LM** — Recherche par faisceau CTC et TDT avec fusion optionnelle d’un modèle de langage n-gramme ARPA
- **Accentuation de phrases** — Biais contextuel via trie au niveau des tokens pour vocabulaire spécifique au domaine
- **Transcription par lots** — Plusieurs fichiers dans une seule passe avant de l’encodeur en lot
- **Prétraitement VAD** — Silero VAD supprime le silence avant ASR ; horodatages remappés automatiquement
- **Accélération GPU** — Metal via le compilateur MPSGraph d’axiom (accélération 96x sur Apple Silicon)
- **Inférence FP16** — Poids et calcul en demi-précision (~2x réduction de la mémoire)
- **Streaming** — Modèles EOU et Nemotron avec entrée audio segmentée
- **Diariation des locuteurs** — Sortformer (jusqu’à 4 locuteurs), combinable avec ASR pour mots attribués aux locuteurs
- **API C** — FFI `extern "C"` plat pour Python, Swift, Go, Rust et autres langages
- **Audio multi-format** — WAV, FLAC, MP3, OGG avec rééchantillonnage automatique

Voir [examples/](examples/) pour du code démontrant chaque fonctionnalité.

## Installation

Des binaires précompilés sont joints à chaque [release GitHub](https://github.com/Frikallo/parakeet.cpp/releases) pour macOS arm64, macOS x86_64, et Linux x86_64. Téléchargez l’archive tarball pour votre plateforme et extrayez :

```bash
tar -xzf parakeet-v0.1.0-macos-arm64.tar.gz
cd parakeet-v0.1.0-macos-arm64
# On macOS, clear the Gatekeeper quarantine attribute first:
xattr -dr com.apple.quarantine .
./bin/parakeet --help
```

L'archive contient un `bin/parakeet` autonome (et `bin/example-server`) ainsi que `lib/libaxiom` avec `@rpath`/`$ORIGIN` configurés de sorte que les binaires résolvent leurs dépendances par rapport au répertoire d'installation — déposez le dossier où vous voulez. Les en-têtes C-API sous `include/parakeet/` sont inclus pour les intégrateurs.

## Compilation à partir des sources

```bash
git clone --recursive https://github.com/frikallo/parakeet.cpp
cd parakeet.cpp
make build
make test
```

Exigences : C++20 (Clang 14+ ou GCC 12+), CMake 3.20+, macOS 13+ pour GPU Metal.

> **macOS :** la compilation nécessite l'installation **complète de Xcode** (pas seulement les outils en ligne de commande), car axiom compile ses shaders Metal avec `xcrun metal` et `xcrun metallib` — ceux-ci ne sont fournis qu'avec Xcode. Si vous souhaitez simplement exécuter parakeet, utilisez le tarball précompilé ci-dessus ; le `.metallib` est intégré dans le `libaxiom.dylib` fourni et fonctionne sans aucune installation de Xcode/CLT côté utilisateur.

## Convertir les poids

```bash
# Download from HuggingFace
huggingface-cli download nvidia/parakeet-tdt_ctc-110m --include "*.nemo" --local-dir .

# Convert to safetensors
pip install safetensors torch
python scripts/convert_nemo.py parakeet-tdt_ctc-110m.nemo -o model.safetensors
```

Le convertisseur prend en charge tous les types de modèles : `110m-tdt-ctc` (par défaut), `600m-tdt`, `eou-120m`, `nemotron-600m`, `sortformer`.

```bash
python scripts/convert_nemo.py checkpoint.nemo -o model.safetensors --model 600m-tdt
```

Poids Silero VAD :
```bash
python scripts/convert_silero_vad.py -o silero_vad_v5.safetensors
```

## Exemples

| Exemple | Description |
|---------|-------------|
| [basic](examples/basic/) | Transcription la plus simple (~20 lignes) |
| [timestamps](examples/timestamps/) | Horodatage mots/tokens avec confiance |
| [beam-search](examples/beam-search/) | Recherche en faisceau CTC/TDT avec LM ARPA optionnel |
| [phrase-boost](examples/phrase-boost/) | Biais contextuel pour vocabulaire de domaine |
| [batch](examples/batch/) | Transcription par lots de plusieurs fichiers |
| [vad](examples/vad/) | VAD autonome et prétraitement ASR+VAD |
| [gpu](examples/gpu/) | GPU Metal + FP16 avec comparaison de temps |
| [stream](examples/stream/) | Transcription en streaming EOU |
| [nemotron](examples/nemotron/) | Streaming Nemotron avec modes latence |
| [diarize](examples/diarize/) | Diarisation des locuteurs Sortformer |
| [diarized-transcription](examples/diarized-transcription/) | ASR + diarisation combinées |
| [c-api](examples/c-api/) | Utilisation FFI pure C99 |
| [cli](examples/cli/) | CLI complète avec toutes les options |

## Utilisation comme bibliothèque

### CMake `find_package`

Après installation (`make install` ou `cmake --install build`):

```cmake
find_package(Parakeet REQUIRED)
target_link_libraries(myapp PRIVATE Parakeet::parakeet)
```

### CMake `add_subdirectory`

```cmake
add_subdirectory(third_party/parakeet.cpp)
target_link_libraries(myapp PRIVATE Parakeet::parakeet)
```

### pkg-config

```bash
g++ -std=c++20 myapp.cpp $(pkg-config --cflags --libs parakeet) -o myapp
```

## Architecture

### Modèles hors ligne

Construit sur un encodeur FastConformer partagé (Conv2d avec sous-échantillonnage 8x → N blocs Conformer avec attention positionnelle relative) :

| Modèle | Classe | Décodeur | Cas d'utilisation |
|--------|--------|----------|-------------------|
| CTC | `ParakeetCTC` | Argmax glouton ou recherche par faisceau (+LM) | Rapide, uniquement anglais |
| RNNT | `ParakeetRNNT` | LSTM autorégressif | Capable de streaming |
| TDT | `ParakeetTDT` | LSTM + prédiction de durée, glouton ou recherche par faisceau (+LM) | Meilleure précision que RNNT |
| TDT-CTC | `ParakeetTDTCTC` | Têtes TDT et CTC | Changement de décodeur à l'inférence |

### Modèles en streaming

Construit sur un encodeur FastConformer en streaming conscient du cache avec convolutions causales et attention à contexte borné :

| Modèle | Classe | Décodeur | Cas d'utilisation |
|--------|--------|----------|-------------------|
| EOU | `ParakeetEOU` | RNNT en streaming | Détection de fin d'énoncé |
| Nemotron | `ParakeetNemotron` | TDT en streaming | Streaming à latence configurable |

### Diarisation

| Modèle | Classe | Architecture | Cas d'utilisation |
|--------|--------|--------------|-------------------|
| Sortformer | `Sortformer` | Encodeur NEST → Transformer → sigmoïde | Diarisation des locuteurs (jusqu'à 4 locuteurs) |

## Benchmarks

Mesuré sur Apple M3 16GB avec entrée audio simulée (`Tensor::randn`). Les temps sont par passage avant de l'encodeur (Sortformer : passage complet).

**Débit de l'encodeur — audio de 10s :**

| Modèle | Paramètres | CPU (ms) | GPU (ms) | Accélération GPU |
|--------|------------|----------|----------|------------------|
| 110m (TDT-CTC) | 110M | 2 581 | 27 | **96x** |
| tdt-600m | 600M | 10 779 | 520 | **21x** |
| rnnt-600m | 600M | 10 648 | 1 468 | **7x** |
| sortformer | 117M | 3 195 | 479 | **7x** |

**Mise à l'échelle GPU 110m selon la durée audio :**

| Audio | CPU (ms) | GPU (ms) | RTF | Débit |
|-------|----------|----------|-----|-------|
| 1s | 262 | 24 | 0,024 | 41x |
| 5s | 1 222 | 26 | 0,005 | 190x |
| 10s | 2 581 | 27 | 0,003 | 370x |
| 30s | 10 061 | 32 | 0,001 | 935x |
| 60s | 26 559 | 72 | 0,001 | 833x |

L'accélération GPU est assurée par le compilateur graphique Metal d'axiom qui fusionne l'encodeur complet en opérations MPSGraph optimisées.

```bash
make bench ARGS="--110m=models/model.safetensors --tdt-600m=models/tdt.safetensors"
```
## Feuille de route

### Niveau 1 — Impact élevé

- [x] **Scores de confiance** — Confiance par jeton et par mot à partir des log-probs des jetons
- [x] **Renforcement de phrases** — Biais contextuel trie au niveau des jetons pendant le décodage
- [x] **Recherche par faisceau** — Recherche de préfixe CTC et recherche synchrone TDT par faisceau
- [x] **Fusion LM N-gram** — Modèles de langue ARPA scorés aux frontières des mots

### Audio & E/S

- [x] **Audio multi-format** — WAV, FLAC, MP3, OGG via dr_libs + stb_vorbis
- [x] **Resampling automatique** — Interpolation sinc fenêtrée (Kaiser, 16-taps)
- [x] **Chargement depuis la mémoire** — `read_audio(bytes, len)`, buffers float/int16
- [ ] **Requête de durée audio** — Durée à partir de l’en-tête sans décodage complet
- [ ] **Rappels de progression** — Rapport d’étape pour fichiers longs
- [ ] **Streaming depuis PCM brut** — Alimentation directe du buffer micro

### Niveau 2 — Prêt pour la production

- [x] **Transcription diarizée** — ASR + Sortformer → mots attribués aux locuteurs
- [x] **VAD** — Silero VAD v5, autonome + prétraitement ASR
- [x] **Inférence par lot** — Passage avant encodeur multi-fichiers paddé
- [ ] **Découpage longue durée** — Fenêtres chevauchantes pour audio >30s
- [ ] **Re-scorage LM neural** — Reclassement N-best avec LM Transformer

### Niveau 3 — Écosystème

- [x] **API C** — Interface C plate pour FFI depuis n’importe quel langage
- [x] **Inférence FP16** — Poids et calcul en demi-précision
- [ ] **Quantification de modèle** — INT8/INT4 pour déploiement mobile
- [ ] **Détection de mot-clé** — Détection de phrase déclencheur
- [ ] **Embeddings de locuteur** — Vérification du locuteur via Sortformer/TitaNet

## Notes

- Audio : 16 kHz mono (WAV, FLAC, MP3, OGG — détection automatique et resampling)
- Les modèles hors ligne ont une limite d’environ 4-5 minutes d’audio ; utiliser les modèles streaming pour audio plus long
- L’accélération GPU nécessite un Apple Silicon avec support Metal


## License

MIT


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-20

---