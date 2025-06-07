[![License: MIT](https://img.shields.io/badge/License-MIT-yellow)](https://github.com/Shihang-Wang-58/DeepSA)
[![PyPI](https://img.shields.io/badge/PyPI-cyan)](https://pypi.org/project/deepsa)

# DeepSA: Głęboko-uczący się predyktor dostępności syntezy związków chemicznych

Wraz z ciągłym rozwojem technologii sztucznej inteligencji, coraz więcej modeli generatywnych opartych na głębokim uczeniu wykorzystywanych jest do generowania cząsteczek. Jednak większość nowych cząsteczek generowanych przez te modele napotyka poważne wyzwania pod względem dostępności syntezy.

DeepSA został zaproponowany jako narzędzie do przewidywania dostępności syntezy związków chemicznych i charakteryzuje się znacznie wyższym wskaźnikiem szybkiego wzbogacania przy rozróżnianiu cząsteczek trudnych do syntezy. Pomaga to użytkownikom wybierać mniej kosztowne cząsteczki do syntezy, co skraca czas odkrywania i rozwoju leków. Możesz skorzystać z DeepSA na serwerze internetowym pod adresem https://bailab.siais.shanghaitech.edu.cn/deepsa<br/>

## Wymagania
Wymagane zależności można zainstalować za pomocą następujących poleceń:
```bash
conda create -n DeepSA python=3.12
conda activate DeepSA
# dla wersji gpu
pip3 install torch torchvision torchaudio --index-url https://download.pytorch.org/whl/cu118
pip3 install autogluon==1.2
pip3 install rdkit
```
### Aktualności 🔔 

* 2024-12, ponieważ [AutoGluon przestał wspierać wersję Pythona 3.8](https://github.com/autogluon/autogluon/pull/4512) od października 2024 roku. Zaktualizowaliśmy więc DeepSA do Pythona 3.12 oraz zaktualizowaliśmy skrypty treningowe i inferencyjne, aby dostosować je do najnowszej wersji AutoGluon. Dziękujemy za zainteresowanie DeepSA!

* 2023-7, DeepSA_v1.0 został wydany, zapraszamy do zgłaszania uwag i sugestii!

## Dane 
Rozszerzone zbiory treningowe i testowe można łatwo pobrać pod adresem: https://drive.google.com/drive/folders/1iup6T3Bqyy-uvpdFyP0Of_WQqn-9l62h?usp=sharing
## Użytkowanie dla naukowców
Jeśli chcesz wytrenować własny model, możesz uruchomić go z poziomu linii poleceń,

uruchomienie:
```
    python DeepSA_training.py <dataset.csv/training.csv:test.csv> DeepSA_model ./data/test_set.list
```
Jeśli chcesz użyć naszego gotowego modelu,

uruchomienie:
```
    python DeepSA_predict.py <input_data.csv> DeepSA_model
```

## Serwer online

Udostępniliśmy wytrenowany model na dedykowanym serwerze, dostępnym publicznie pod adresem https://bailab.siais.shanghaitech.edu.cn/deepsa, aby ułatwić naukowcom biomedycznym korzystanie z DeepSA w swojej pracy badawczej.

Użytkownicy mogą przesłać swoje pliki SMILES lub csv na serwer, a następnie szybko otrzymać przewidywane wyniki.

## <span id="citelink">Cytowanie</span>
Jeśli uznasz to repozytorium za przydatne w swoich badaniach, rozważ cytowanie naszej publikacji:

Wang, S., Wang, L., Li, F. et al. DeepSA: a deep-learning driven predictor of compound synthesis accessibility. J Cheminform 15, 103 (2023). https://doi.org/10.1186/s13321-023-00771-3

## Kontakt
W razie pytań prosimy o kontakt z Shihang Wang (Email: wangshh12022@shanghaitech.edu.cn) lub Lin Wang (Email: wanglin3@shanghaitech.edu.cn).

Pull requesty są mile widziane!

## Podziękowania
Dziękujemy za wsparcie Platformy HPC Uniwersytetu ShanghaiTech.<br/>
Dziękujemy wszystkim za zainteresowanie tą pracą.

![Star History Chart](https://api.star-history.com/svg?repos=Shihang-Wang-58/DeepSA&type=Date)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---