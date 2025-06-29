# SinGAN

[Progetto](https://tamarott.github.io/SinGAN.htm) | [Arxiv](https://arxiv.org/pdf/1905.01164.pdf) | [CVF](http://openaccess.thecvf.com/content_ICCV_2019/papers/Shaham_SinGAN_Learning_a_Generative_Model_From_a_Single_Natural_Image_ICCV_2019_paper.pdf) | [Materiali supplementari](https://openaccess.thecvf.com/content_ICCV_2019/supplemental/Shaham_SinGAN_Learning_a_ICCV_2019_supplemental.pdf) | [Talk (ICCV`19)](https://youtu.be/mdAcPe74tZI?t=3191) 
### Implementazione ufficiale in pytorch del paper: "SinGAN: Learning a Generative Model from a Single Natural Image"
#### ICCV 2019 Best paper award (Marr prize)


## Campioni casuali da una *singola* immagine
Con SinGAN, puoi addestrare un modello generativo a partire da una singola immagine naturale, e poi generare campioni casuali dall'immagine fornita, ad esempio:

![](https://raw.githubusercontent.com/tamarott/SinGAN/master/imgs/teaser.PNG)


## Applicazioni di SinGAN
SinGAN può essere utilizzato anche per una serie di compiti di manipolazione delle immagini, ad esempio:
 ![](https://raw.githubusercontent.com/tamarott/SinGAN/master/imgs/manipulation.PNG)
Questo viene fatto iniettando un'immagine nel modello già addestrato. Vedi la sezione 4 del nostro [paper](https://arxiv.org/pdf/1905.01164.pdf) per maggiori dettagli.


### Citazione
Se utilizzi questo codice per la tua ricerca, cita il nostro paper:

```
@inproceedings{rottshaham2019singan,
  title={SinGAN: Learning a Generative Model from a Single Natural Image},
  author={Rott Shaham, Tamar and Dekel, Tali and Michaeli, Tomer},
  booktitle={Computer Vision (ICCV), IEEE International Conference on},
  year={2019}
}
```

## Codice

### Installare le dipendenze

```
python -m pip install -r requirements.txt
```

Questo codice è stato testato con python 3.6, torch 1.4

Nota bene: il codice attualmente supporta solo torch 1.4 o versioni precedenti a causa dello schema di ottimizzazione.

Per versioni torch successive, puoi provare questo repository: https://github.com/kligvasser/SinGAN (i risultati non saranno necessariamente identici all'implementazione ufficiale).


###  Addestramento
Per addestrare il modello SinGAN su una tua immagine, inserisci l'immagine desiderata per l'addestramento nella cartella Input/Images, ed esegui

```
python main_train.py --input_name <input_file_name>
```

Questo utilizzerà anche il modello addestrato risultante per generare campioni casuali a partire dalla scala più grossolana (n=0).

Per eseguire questo codice su una macchina cpu, specifica `--not_cuda` quando richiami `main_train.py`

###  Campioni casuali
Per generare campioni casuali da qualsiasi scala di generazione iniziale, per prima cosa addestra il modello SinGAN sull'immagine desiderata (come descritto sopra), poi esegui 

```
python random_samples.py --input_name <training_image_file_name> --mode random_samples --gen_start_scale <generation start scale number>
```

Attenzione: per usare il modello completo, specifica che la scala di inizio generazione sia 0, per iniziare la generazione dalla seconda scala, specifica 1, e così via. 

###  Campioni casuali di dimensioni arbitrarie
Per generare campioni casuali di dimensioni arbitrarie, per prima cosa addestra il modello SinGAN sull'immagine desiderata (come descritto sopra), poi esegui 

```
python random_samples.py --input_name <training_image_file_name> --mode random_samples_arbitrary_sizes --scale_h <fattore di scala orizzontale> --scale_v <fattore di scala verticale>
```

###  Animazione da una singola immagine

Per generare una breve animazione da una singola immagine, esegui

```
python animation.py --input_name <input_file_name> 
```

Questo farà partire automaticamente una nuova fase di addestramento con la modalità padding del rumore.

###  Armonizzazione

Per armonizzare un oggetto incollato in un'immagine (vedi esempio in Fig. 13 del [nostro paper](https://arxiv.org/pdf/1905.01164.pdf)), per prima cosa addestra il modello SinGAN sull'immagine di sfondo desiderata (come descritto sopra), poi salva l'immagine di riferimento incollata naïfamente e la sua maschera binaria sotto "Input/Harmonization" (vedi immagini salvate come esempio). Esegui il comando

```
python harmonization.py --input_name <training_image_file_name> --ref_name <naively_pasted_reference_image_file_name> --harmonization_start_scale <scala da iniettare>

```

Nota che diverse scale di iniezione produrranno effetti di armonizzazione differenti. La scala di iniezione più grossolana è uguale a 1. 

###  Editing

Per modificare un'immagine, (vedi esempio in Fig. 12 del [nostro paper](https://arxiv.org/pdf/1905.01164.pdf)), per prima cosa addestra il modello SinGAN sull'immagine non modificata desiderata (come descritto sopra), poi salva la modifica naïf come immagine di riferimento sotto "Input/Editing" con una mappa binaria corrispondente (vedi immagini salvate come esempio). Esegui il comando

```
python editing.py --input_name <training_image_file_name> --ref_name <edited_image_file_name> --editing_start_scale <scala da iniettare>
```
sia l’output mascherato che quello non mascherato verranno salvati.
Anche qui, scale di iniezione differenti produrranno effetti di editing differenti. La scala di iniezione più grossolana è pari a 1.

###  Paint to Image

Per trasferire un dipinto in un’immagine realistica (vedi esempio in Fig. 11 nel [nostro articolo](https://arxiv.org/pdf/1905.01164.pdf)), si prega prima di addestrare il modello SinGAN sull’immagine desiderata (come descritto sopra), poi salvare il dipinto sotto "Input/Paint" ed eseguire il comando

```
python paint2image.py --input_name <nome_file_immagine_training> --ref_name <nome_file_immagine_paint> --paint_start_scale <scala di iniezione>
```
Anche qui, scale di iniezione differenti produrranno effetti di editing differenti. La scala di iniezione più grossolana è pari a 1.

Opzione avanzata: Specificare quantization_flag come True, per ri-addestrare *solo* il livello di iniezione del modello, per ottenere una versione color-quantized delle immagini generate upscalate dal livello precedente. Per alcune immagini, questo può portare a risultati più realistici.

### Super Resolution
Per super-risoluzione di un’immagine, eseguire:
```
python SR.py --input_name <nome_file_immagine_LR>
```
Questo addestrerà automaticamente un modello SinGAN corrispondente a un fattore di upsampling 4x (se non esiste già).
Per diversi fattori di super-risoluzione, specificarli tramite il parametro `--sr_factor` durante la chiamata della funzione.
I risultati di SinGAN sul dataset BSD100 possono essere scaricati dalla cartella 'Downloads'.

## Dati e Funzioni Addizionali

### Single Image Fréchet Inception Distance (SIFID score)
Per calcolare il SIFID tra immagini reali e i loro campioni fake corrispondenti, eseguire:
```
python SIFID/sifid_score.py --path2real <percorso immagini reali> --path2fake <percorso immagini fake>
```  
Assicurarsi che ciascun nome file delle immagini fake sia identico a quello dell’immagine reale corrispondente. Le immagini devono essere salvate in formato `.jpg`.

### Risultati di Super Resolution
I risultati di SR di SinGAN sul dataset BSD100 possono essere scaricati dalla cartella 'Downloads'.

### Studio Utenti
I dati utilizzati per lo studio utenti sono disponibili nella cartella Downloads.

cartella real: 50 immagini reali, selezionate casualmente dal [places database](http://places.csail.mit.edu/)

cartella fake_high_variance: campioni casuali a partire da n=N per ciascuna delle immagini reali

cartella fake_mid_variance: campioni casuali a partire da n=N-1 per ciascuna delle immagini reali

Per ulteriori dettagli vedere la sezione 3.1 del nostro [articolo](https://arxiv.org/pdf/1905.01164.pdf)
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-29

---