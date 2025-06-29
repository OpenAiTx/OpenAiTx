# SinGAN

[Project](https://tamarott.github.io/SinGAN.htm) | [Arxiv](https://arxiv.org/pdf/1905.01164.pdf) | [CVF](http://openaccess.thecvf.com/content_ICCV_2019/papers/Shaham_SinGAN_Learning_a_Generative_Model_From_a_Single_Natural_Image_ICCV_2019_paper.pdf) | [Supplementary materials](https://openaccess.thecvf.com/content_ICCV_2019/supplemental/Shaham_SinGAN_Learning_a_ICCV_2019_supplemental.pdf) | [Talk (ICCV`19)](https://youtu.be/mdAcPe74tZI?t=3191) 
### Officiële PyTorch-implementatie van het artikel: "SinGAN: Learning a Generative Model from a Single Natural Image"
#### ICCV 2019 Best paper award (Marr prijs)


## Willekeurige samples van een *enkele* afbeelding
Met SinGAN kun je een generatief model trainen op basis van één enkele natuurlijke afbeelding, en vervolgens willekeurige samples genereren van de gegeven afbeelding, bijvoorbeeld:

![](https://raw.githubusercontent.com/tamarott/SinGAN/master/imgs/teaser.PNG)


## Toepassingen van SinGAN
SinGAN kan ook worden gebruikt voor verschillende beeldbewerkingsdoeleinden, bijvoorbeeld:
 ![](https://raw.githubusercontent.com/tamarott/SinGAN/master/imgs/manipulation.PNG)
Dit wordt gedaan door een afbeelding te injecteren in het reeds getrainde model. Zie sectie 4 in ons [artikel](https://arxiv.org/pdf/1905.01164.pdf) voor meer details.


### Referentie
Als je deze code gebruikt voor je onderzoek, citeer dan ons artikel:

```
@inproceedings{rottshaham2019singan,
  title={SinGAN: Learning a Generative Model from a Single Natural Image},
  author={Rott Shaham, Tamar and Dekel, Tali and Michaeli, Tomer},
  booktitle={Computer Vision (ICCV), IEEE International Conference on},
  year={2019}
}
```

## Code

### Afhankelijkheden installeren

```
python -m pip install -r requirements.txt
```

Deze code is getest met python 3.6, torch 1.4

Let op: de code ondersteunt momenteel alleen torch 1.4 of ouder vanwege het optimalisatieschema.

Voor latere torch-versies kun je deze repository proberen: https://github.com/kligvasser/SinGAN (de resultaten zullen niet noodzakelijk identiek zijn aan de officiële implementatie).


###  Trainen
Om een SinGAN-model te trainen op je eigen afbeelding, plaats je de gewenste trainingsafbeelding onder Input/Images en voer je uit

```
python main_train.py --input_name <input_file_name>
```

Dit gebruikt ook het resulterende getrainde model om willekeurige samples te genereren vanaf de grofste schaal (n=0).

Om deze code op een CPU-machine uit te voeren, geef je `--not_cuda` op bij het aanroepen van `main_train.py`

###  Willekeurige samples
Om willekeurige samples te genereren vanaf elke gewenste generatieschaal, train eerst het SinGAN-model op de gewenste afbeelding (zoals hierboven beschreven), voer vervolgens uit 

```
python random_samples.py --input_name <training_image_file_name> --mode random_samples --gen_start_scale <generation start scale number>
```

Let op: om het volledige model te gebruiken, stel je de generation start scale in op 0, om te starten vanaf de tweede schaal stel je hem in op 1, enzovoort. 

###  Willekeurige samples van willekeurige grootte
Om willekeurige samples van willekeurige grootte te genereren, train eerst het SinGAN-model op de gewenste afbeelding (zoals hierboven beschreven), voer vervolgens uit 

```
python random_samples.py --input_name <training_image_file_name> --mode random_samples_arbitrary_sizes --scale_h <horizontal scaling factor> --scale_v <vertical scaling factor>
```

###  Animatie uit één enkele afbeelding

Om een korte animatie te genereren uit een enkele afbeelding, voer uit

```
python animation.py --input_name <input_file_name> 
```

Dit zal automatisch een nieuwe trainingsfase starten met noise padding-modus.

###  Harmonisatie

Om een geplakt object te harmoniseren in een afbeelding (Zie voorbeeld in Fig. 13 in [ons artikel](https://arxiv.org/pdf/1905.01164.pdf)), train eerst het SinGAN-model op de gewenste achtergrondafbeelding (zoals hierboven beschreven), sla vervolgens de simpelweg geplakte referentieafbeelding en het bijbehorende binaire masker op onder "Input/Harmonization" (zie opgeslagen afbeeldingen voor een voorbeeld). Voer het commando uit

```
python harmonization.py --input_name <training_image_file_name> --ref_name <naively_pasted_reference_image_file_name> --harmonization_start_scale <scale to inject>

```

Let op dat verschillende injectieschalen verschillende harmonisatie-effecten opleveren. De grofste injectieschaal is gelijk aan 1. 

###  Bewerken

Om een afbeelding te bewerken, (Zie voorbeeld in Fig. 12 in [ons artikel](https://arxiv.org/pdf/1905.01164.pdf)), train eerst het SinGAN-model op de gewenste onbewerkte afbeelding (zoals hierboven beschreven), sla vervolgens de simpele bewerking op als referentieafbeelding onder "Input/Editing" met een bijbehorende binaire map (zie opgeslagen afbeeldingen voor een voorbeeld). Voer het commando uit

```
python editing.py --input_name <training_image_file_name> --ref_name <edited_image_file_name> --editing_start_scale <scale to inject>
```
```
zowel de gemaskeerde als ongemaskeerde output zullen worden opgeslagen.
Ook hier zal een andere injectieschaal verschillende bewerkingseffecten opleveren. De grofste injectieschaal is gelijk aan 1.

###  Paint to Image

Om een schilderij om te zetten in een realistisch beeld (zie voorbeeld in Fig. 11 in [onze paper](https://arxiv.org/pdf/1905.01164.pdf)), train eerst het SinGAN-model op het gewenste beeld (zoals hierboven beschreven), sla vervolgens je schilderij op onder "Input/Paint", en voer het volgende commando uit

```
python paint2image.py --input_name <training_image_file_name> --ref_name <paint_image_file_name> --paint_start_scale <scale to inject>

```
Ook hier zal een andere injectieschaal verschillende bewerkingseffecten opleveren. De grofste injectieschaal is gelijk aan 1.

Geavanceerde optie: Specificeer quantization_flag als True, om *alleen* het injectieniveau van het model opnieuw te trainen, om een kleur-gekwantiseerde versie te krijgen van de opgeëxtrapoleerde gegenereerde beelden van de vorige schaal. Voor sommige beelden kan dit tot realistischere resultaten leiden.

### Superresolutie
Om een beeld te vergroten (superresolutie), voer het volgende uit:
```
python SR.py --input_name <LR_image_file_name>
```
Dit traint automatisch een SinGAN-model dat overeenkomt met een 4x upsampling factor (indien nog niet aanwezig).
Voor andere SR-factoren kun je deze specificeren met de parameter `--sr_factor` bij het aanroepen van de functie.
SinGAN's resultaten op de BSD100 dataset kunnen worden gedownload uit de map 'Downloads'.

## Extra Data en Functies

### Single Image Fréchet Inception Distance (SIFID-score)
Om de SIFID tussen echte beelden en hun corresponderende nep-samples te berekenen, voer:
```
python SIFID/sifid_score.py --path2real <real images path> --path2fake <fake images path> 
```  
Zorg ervoor dat elk nepbeeld exact dezelfde bestandsnaam heeft als het corresponderende echte beeld. Afbeeldingen moeten worden opgeslagen in `.jpg`-formaat.

### Superresolutie Resultaten
SinGAN's SR-resultaten op de BSD100 dataset kunnen worden gedownload uit de map 'Downloads'.

### Gebruikersstudie
De data die is gebruikt voor de gebruikersstudie is te vinden in de map Downloads.

real folder: 50 echte afbeeldingen, willekeurig geselecteerd uit de [places database](http://places.csail.mit.edu/)

fake_high_variance folder: willekeurige samples startend vanaf n=N voor elk van de echte beelden

fake_mid_variance folder: willekeurige samples startend vanaf n=N-1 voor elk van de echte beelden

Voor meer details, zie sectie 3.1 in onze [paper](https://arxiv.org/pdf/1905.01164.pdf)
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-29

---