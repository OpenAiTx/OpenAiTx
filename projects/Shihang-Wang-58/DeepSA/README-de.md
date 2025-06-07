[![License: MIT](https://img.shields.io/badge/License-MIT-yellow)](https://github.com/Shihang-Wang-58/DeepSA)
[![PyPI](https://img.shields.io/badge/PyPI-cyan)](https://pypi.org/project/deepsa)

# DeepSA: Ein Deep-Learning-basierter Prädiktor für die Synthesezugänglichkeit von Verbindungen

Mit der kontinuierlichen Entwicklung der künstlichen Intelligenz werden immer mehr Deep-Generierungsmodelle für die Molekülgenerierung eingesetzt. Allerdings stehen die meisten neuen Moleküle, die von den Generierungsmodellen erzeugt werden, häufig vor großen Herausforderungen hinsichtlich ihrer Synthesezugänglichkeit.

DeepSA wurde entwickelt, um die Synthesezugänglichkeit von Verbindungen vorherzusagen und weist eine deutlich höhere Frühanreicherungsrate bei der Unterscheidung von schwer synthetisierbaren Molekülen auf. Dies hilft Nutzern, kostengünstigere Moleküle für die Synthese auszuwählen und somit die Zeit für die Wirkstoffforschung und -entwicklung zu verkürzen. Sie können DeepSA auf einem Webserver unter https://bailab.siais.shanghaitech.edu.cn/deepsa verwenden.<br/>

## Voraussetzungen
Abhängigkeiten können mit folgendem Befehl installiert werden:
```bash
conda create -n DeepSA python=3.12
conda activate DeepSA
# für GPU-Version
pip3 install torch torchvision torchaudio --index-url https://download.pytorch.org/whl/cu118
pip3 install autogluon==1.2
pip3 install rdkit
```
### Neuigkeiten 🔔

* 2024-12, da [AutoGluon ab Oktober 2024 die Python-Version 3.8 nicht mehr unterstützt](https://github.com/autogluon/autogluon/pull/4512). Daher haben wir DeepSA aktualisiert, sodass nun Python Version 3.12 verwendet wird, und die Trainings- und Inferenzskripte an die neueste Version von AutoGluon angepasst. Vielen Dank für Ihr Interesse an DeepSA!

* 2023-7, DeepSA_v1.0 wurde veröffentlicht. Feedback zu Problemen ist herzlich willkommen!

## Daten
Die erweiterten Trainings- und Testdatensätze können einfach unter https://drive.google.com/drive/folders/1iup6T3Bqyy-uvpdFyP0Of_WQqn-9l62h?usp=sharing heruntergeladen werden.
## Anwendung für Forschende
Wenn Sie Ihr eigenes Modell trainieren möchten, können Sie es über die Kommandozeile ausführen:

Ausführen:
```
    python DeepSA_training.py <dataset.csv/training.csv:test.csv> DeepSA_model ./data/test_set.list
```
Wenn Sie das von uns vorgeschlagene Modell verwenden möchten,

Ausführen:
```
    python DeepSA_predict.py <input_data.csv> DeepSA_model
```

## Online-Server

Wir haben ein vortrainiertes Modell auf einem dedizierten Server bereitgestellt, der öffentlich unter https://bailab.siais.shanghaitech.edu.cn/deepsa verfügbar ist, um biomedizinischen Forschenden die Nutzung von DeepSA in ihrer Forschungsarbeit zu erleichtern.

Nutzer können ihre SMILES oder csv-Dateien auf den Server hochladen und erhalten dann schnell die vorhergesagten Ergebnisse.

## <span id="citelink">Zitation</span>
Wenn Sie dieses Repository in Ihrer Forschung nützlich finden, zitieren Sie bitte unsere Publikation:

Wang, S., Wang, L., Li, F. et al. DeepSA: a deep-learning driven predictor of compound synthesis accessibility. J Cheminform 15, 103 (2023). https://doi.org/10.1186/s13321-023-00771-3

## Kontakt
Bei Fragen wenden Sie sich bitte an Shihang Wang (Email: wangshh12022@shanghaitech.edu.cn) oder Lin Wang (Email: wanglin3@shanghaitech.edu.cn).

Pull Requests sind sehr willkommen!

## Danksagungen
Wir danken der HPC-Plattform der ShanghaiTech University für die Unterstützung.<br/>
Vielen Dank für Ihr Interesse an dieser Arbeit.

![Star History Chart](https://api.star-history.com/svg?repos=Shihang-Wang-58/DeepSA&type=Date)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---