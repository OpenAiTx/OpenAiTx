# SinGAN

[Projekt](https://tamarott.github.io/SinGAN.htm) | [Arxiv](https://arxiv.org/pdf/1905.01164.pdf) | [CVF](http://openaccess.thecvf.com/content_ICCV_2019/papers/Shaham_SinGAN_Learning_a_Generative_Model_From_a_Single_Natural_Image_ICCV_2019_paper.pdf) | [Zusätzliche Materialien](https://openaccess.thecvf.com/content_ICCV_2019/supplemental/Shaham_SinGAN_Learning_a_ICCV_2019_supplemental.pdf) | [Vortrag (ICCV`19)](https://youtu.be/mdAcPe74tZI?t=3191) 
### Offizielle Pytorch-Implementierung des Papers: "SinGAN: Learning a Generative Model from a Single Natural Image"
#### ICCV 2019 Best Paper Award (Marr-Preis)


## Zufällige Beispiele aus einem *einzelnen* Bild
Mit SinGAN kann ein generatives Modell aus einem einzigen natürlichen Bild trainiert werden und anschließend können zufällige Beispiele aus dem gegebenen Bild generiert werden, zum Beispiel:

![](https://raw.githubusercontent.com/tamarott/SinGAN/master/imgs/teaser.PNG)


## Anwendungen von SinGAN
SinGAN kann auch für eine Reihe von Bildmanipulationsaufgaben verwendet werden, zum Beispiel:
 ![](https://raw.githubusercontent.com/tamarott/SinGAN/master/imgs/manipulation.PNG)
Dies geschieht, indem ein Bild in das bereits trainierte Modell eingespeist wird. Siehe Abschnitt 4 in unserem [Paper](https://arxiv.org/pdf/1905.01164.pdf) für weitere Details.


### Zitation
Wenn Sie diesen Code für Ihre Forschung verwenden, zitieren Sie bitte unser Paper:

```
@inproceedings{rottshaham2019singan,
  title={SinGAN: Learning a Generative Model from a Single Natural Image},
  author={Rott Shaham, Tamar und Dekel, Tali und Michaeli, Tomer},
  booktitle={Computer Vision (ICCV), IEEE International Conference on},
  year={2019}
}
```

## Code

### Abhängigkeiten installieren

```
python -m pip install -r requirements.txt
```

Dieser Code wurde mit Python 3.6, torch 1.4 getestet.

Bitte beachten: Der Code unterstützt derzeit nur torch 1.4 oder früher aufgrund des Optimierungsschemas.

Für spätere Torch-Versionen können Sie dieses Repository ausprobieren: https://github.com/kligvasser/SinGAN (die Ergebnisse sind nicht zwangsläufig identisch mit der offiziellen Implementierung).


###  Training
Um das SinGAN-Modell mit Ihrem eigenen Bild zu trainieren, legen Sie das gewünschte Trainingsbild unter Input/Images ab und führen Sie aus:

```
python main_train.py --input_name <input_file_name>
```

Das resultierende trainierte Modell wird auch verwendet, um zufällige Beispiele zu generieren, beginnend mit der gröbsten Skala (n=0).

Um diesen Code auf einer CPU-Maschine auszuführen, geben Sie `--not_cuda` an, wenn Sie `main_train.py` aufrufen.

###  Zufällige Beispiele
Um zufällige Beispiele von einer beliebigen Start-Generationsskala zu generieren, trainieren Sie bitte zuerst das SinGAN-Modell auf dem gewünschten Bild (wie oben beschrieben) und führen Sie dann aus

```
python random_samples.py --input_name <training_image_file_name> --mode random_samples --gen_start_scale <generation start scale number>
```

Achtung: Um das vollständige Modell zu verwenden, setzen Sie die Start-Generationsskala auf 0. Um die Generierung von der zweiten Skala zu starten, setzen Sie sie auf 1 usw.

###  Zufällige Beispiele beliebiger Größe
Um zufällige Beispiele beliebiger Größe zu generieren, trainieren Sie bitte zuerst das SinGAN-Modell auf dem gewünschten Bild (wie oben beschrieben) und führen Sie dann aus

```
python random_samples.py --input_name <training_image_file_name> --mode random_samples_arbitrary_sizes --scale_h <horizontaler Skalierungsfaktor> --scale_v <vertikaler Skalierungsfaktor>
```

###  Animation aus einem einzelnen Bild

Um eine kurze Animation aus einem einzelnen Bild zu generieren, führen Sie aus

```
python animation.py --input_name <input_file_name> 
```

Dadurch wird automatisch eine neue Trainingsphase mit Noise-Padding-Modus gestartet.

###  Harmonisierung

Um ein eingefügtes Objekt in ein Bild zu harmonisieren (siehe Beispiel in Abb. 13 in [unserem Paper](https://arxiv.org/pdf/1905.01164.pdf)), trainieren Sie bitte zuerst das SinGAN-Modell auf dem gewünschten Hintergrundbild (wie oben beschrieben), speichern Sie dann das naiv eingefügte Referenzbild und dessen binäre Maske unter "Input/Harmonization" (siehe gespeicherte Bilder als Beispiel). Führen Sie den Befehl aus

```
python harmonization.py --input_name <training_image_file_name> --ref_name <naively_pasted_reference_image_file_name> --harmonization_start_scale <Skala zum Injizieren>

```

Bitte beachten Sie, dass verschiedene Injektionsskalen zu unterschiedlichen Harmonisierungseffekten führen. Die gröbste Injektionsskala entspricht 1.

###  Bearbeitung

Um ein Bild zu bearbeiten (siehe Beispiel in Abb. 12 in [unserem Paper](https://arxiv.org/pdf/1905.01164.pdf)), trainieren Sie bitte zuerst das SinGAN-Modell auf dem gewünschten unbearbeiteten Bild (wie oben beschrieben), speichern Sie dann die naive Bearbeitung als Referenzbild unter "Input/Editing" mit einer entsprechenden binären Karte (siehe gespeicherte Bilder als Beispiel). Führen Sie den Befehl aus

```
python editing.py --input_name <training_image_file_name> --ref_name <edited_image_file_name> --editing_start_scale <Skala zum Injizieren>
```
sowohl die maskierten als auch die unmaskierten Ausgaben werden gespeichert.
Auch hier führt ein unterschiedlicher Injection-Scale zu verschiedenen Editiereffekten. Der gröbste Injection-Scale entspricht 1.

###  Paint to Image

Um eine Zeichnung in ein realistisches Bild zu übertragen (siehe Beispiel in Abb. 11 in [unserem Paper](https://arxiv.org/pdf/1905.01164.pdf)), trainieren Sie bitte zunächst das SinGAN-Modell auf dem gewünschten Bild (wie oben beschrieben), speichern Sie dann Ihre Zeichnung unter "Input/Paint" und führen Sie den folgenden Befehl aus:

```
python paint2image.py --input_name <Training_Bild_Dateiname> --ref_name <Zeichnungs_Bild_Dateiname> --paint_start_scale <Skala zum Injizieren>
```
Auch hier führt ein unterschiedlicher Injection-Scale zu verschiedenen Editiereffekten. Der gröbste Injection-Scale entspricht 1.

Erweiterte Option: Geben Sie quantization_flag auf True an, um *nur* die Injektionsebene des Modells erneut zu trainieren, um eine farbquantisierte Version der vom vorherigen Maßstab hochskalierten generierten Bilder zu erhalten. Für einige Bilder kann dies zu realistischeren Ergebnissen führen.

### Super Resolution
Um ein Bild superaufzulösen, führen Sie bitte aus:
```
python SR.py --input_name <LR_Bild_Dateiname>
```
Dadurch wird automatisch ein SinGAN-Modell mit entsprechendem 4x Upsampling-Faktor trainiert (falls noch nicht vorhanden).
Für andere SR-Faktoren geben Sie diesen bitte mit dem Parameter `--sr_factor` beim Aufruf der Funktion an.
SinGAN-Ergebnisse auf dem BSD100-Datensatz können im Ordner 'Downloads' heruntergeladen werden.

## Zusätzliche Daten und Funktionen

### Single Image Fréchet Inception Distance (SIFID score)
Um die SIFID zwischen echten Bildern und ihren entsprechenden Fake-Samples zu berechnen, führen Sie bitte aus:
```
python SIFID/sifid_score.py --path2real <Pfad zu echten Bildern> --path2fake <Pfad zu Fake-Bildern>
```  
Stellen Sie sicher, dass jeder Fake-Bild-Dateiname mit dem entsprechenden echten Bild-Dateinamen identisch ist. Bilder sollten im `.jpg`-Format gespeichert werden.

### Super Resolution Ergebnisse
SinGANs SR-Ergebnisse auf dem BSD100-Datensatz können aus dem Ordner 'Downloads' heruntergeladen werden.

### Benutzerstudie
Die für die Benutzerstudie verwendeten Daten finden Sie im Ordner Downloads.

real-Ordner: 50 echte Bilder, zufällig aus der [Places-Datenbank](http://places.csail.mit.edu/) ausgewählt

fake_high_variance-Ordner: Zufallsbeispiele beginnend ab n=N für jedes der echten Bilder

fake_mid_variance-Ordner: Zufallsbeispiele beginnend ab n=N-1 für jedes der echten Bilder

Für weitere Details siehe Abschnitt 3.1 in unserem [Paper](https://arxiv.org/pdf/1905.01164.pdf)
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-29

---