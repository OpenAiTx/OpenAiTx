[![Licentie: MIT](https://img.shields.io/badge/License-MIT-yellow)](https://github.com/Shihang-Wang-58/DeepSA)
[![PyPI](https://img.shields.io/badge/PyPI-cyan)](https://pypi.org/project/deepsa)

# DeepSA: Een Deep-learning Gedreven Voorspeller van Synthese Toegankelijkheid van Verbindingen

Met de voortdurende ontwikkeling van kunstmatige intelligentie worden steeds meer deep-generatie modellen gebruikt voor molecuulgeneratie. Echter, de meeste nieuwe moleculen die door deze generatiemodellen worden gegenereerd, ondervinden vaak grote uitdagingen op het gebied van synthetische toegankelijkheid.

DeepSA is ontwikkeld om de synthese toegankelijkheid van verbindingen te voorspellen en heeft een veel hogere vroege verrijkingssnelheid bij het onderscheiden van moleculen die moeilijk te synthetiseren zijn. Dit helpt gebruikers om minder dure moleculen te selecteren voor synthese, waardoor de tijd voor geneesmiddelenontdekking en -ontwikkeling wordt verminderd. U kunt DeepSA gebruiken op een webserver via https://bailab.siais.shanghaitech.edu.cn/deepsa<br/>

## Vereisten
Afhankelijkheden kunnen worden geïnstalleerd met het volgende commando:
```bash
conda create -n DeepSA python=3.12
conda activate DeepSA
# voor gpu versie
pip3 install torch torchvision torchaudio --index-url https://download.pytorch.org/whl/cu118
pip3 install autogluon==1.2
pip3 install rdkit
```
### Nieuws 🔔

* 2024-12, omdat [AutoGluon vanaf oktober 2024 geen ondersteuning meer biedt voor python versie 3.8](https://github.com/autogluon/autogluon/pull/4512). Daarom hebben we DeepSA bijgewerkt naar Python versie 3.12 en de trainings- en inferentiescripts aangepast aan de nieuwste versie van AutoGluon, dank voor uw interesse in DeepSA!

* 2023-7, DeepSA_v1.0 is uitgebracht, feedback via issues is welkom!

## Data
De uitgebreide trainings- en testdatasets kunnen eenvoudig worden gedownload via https://drive.google.com/drive/folders/1iup6T3Bqyy-uvpdFyP0Of_WQqn-9l62h?usp=sharing

## Gebruik Voor Onderzoekers
Als u uw eigen model wilt trainen, kunt u deze vanaf de commandoregel uitvoeren,

uitvoeren:
```
    python DeepSA_training.py <dataset.csv/training.csv:test.csv> DeepSA_model ./data/test_set.list
```
Als u het door ons voorgestelde model wilt gebruiken,

uitvoeren:
```
    python DeepSA_predict.py <input_data.csv> DeepSA_model
```

## Online Server

Wij hebben een voorgetraind model geïmplementeerd op een speciale server, die openbaar beschikbaar is via https://bailab.siais.shanghaitech.edu.cn/deepsa, zodat biomedische onderzoekers DeepSA eenvoudig kunnen toepassen in hun onderzoek.

Gebruikers kunnen hun SMILES- of csv-bestanden uploaden naar de server, waarna ze snel de voorspelde resultaten kunnen verkrijgen.

## <span id="citelink">Citaat</span>
Als u deze repository nuttig vindt voor uw onderzoek, overweeg dan ons artikel te citeren:

Wang, S., Wang, L., Li, F. et al. DeepSA: a deep-learning driven predictor of compound synthesis accessibility. J Cheminform 15, 103 (2023). https://doi.org/10.1186/s13321-023-00771-3

## Contact
Als u vragen heeft, neem gerust contact op met Shihang Wang (Email: wangshh12022@shanghaitech.edu.cn) of Lin Wang (Email: wanglin3@shanghaitech.edu.cn).

Pull requests zijn zeer welkom!

## Erkenningen
Wij zijn dankbaar voor de ondersteuning van het HPC Platform van ShanghaiTech University.<br/>
Dank aan iedereen voor de aandacht voor dit werk.

![Star History Chart](https://api.star-history.com/svg?repos=Shihang-Wang-58/DeepSA&type=Date)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---