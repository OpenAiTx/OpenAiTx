# SinGAN

[Projekt](https://tamarott.github.io/SinGAN.htm) | [Arxiv](https://arxiv.org/pdf/1905.01164.pdf) | [CVF](http://openaccess.thecvf.com/content_ICCV_2019/papers/Shaham_SinGAN_Learning_a_Generative_Model_From_a_Single_Natural_Image_ICCV_2019_paper.pdf) | [Materiały uzupełniające](https://openaccess.thecvf.com/content_ICCV_2019/supplemental/Shaham_SinGAN_Learning_a_ICCV_2019_supplemental.pdf) | [Wykład (ICCV`19)](https://youtu.be/mdAcPe74tZI?t=3191) 
### Oficjalna implementacja pytorch artykułu: "SinGAN: Learning a Generative Model from a Single Natural Image"
#### ICCV 2019 Nagroda za najlepszy artykuł (Marr prize)


## Przykładowe losowe obrazy z *pojedynczego* zdjęcia
Dzięki SinGAN możesz wytrenować generatywny model na podstawie pojedynczego naturalnego obrazu, a następnie generować losowe próbki z danego obrazu, na przykład:

![](https://raw.githubusercontent.com/tamarott/SinGAN/master/imgs/teaser.PNG)


## Zastosowania SinGAN
SinGAN może być również używany do różnych zadań związanych z manipulacją obrazem, na przykład:
 ![](https://raw.githubusercontent.com/tamarott/SinGAN/master/imgs/manipulation.PNG)
Odbywa się to poprzez wstrzyknięcie obrazu do już wytrenowanego modelu. Zobacz sekcję 4 w naszym [artykule](https://arxiv.org/pdf/1905.01164.pdf) po więcej szczegółów.


### Cytowanie
Jeśli używasz tego kodu w swoich badaniach, prosimy o cytowanie naszego artykułu:

```
@inproceedings{rottshaham2019singan,
  title={SinGAN: Learning a Generative Model from a Single Natural Image},
  author={Rott Shaham, Tamar and Dekel, Tali and Michaeli, Tomer},
  booktitle={Computer Vision (ICCV), IEEE International Conference on},
  year={2019}
}
```

## Kod

### Instalacja zależności

```
python -m pip install -r requirements.txt
```

Ten kod był testowany z python 3.6, torch 1.4

Uwaga: kod obecnie obsługuje tylko torch 1.4 lub wcześniejsze ze względu na zastosowany schemat optymalizacji.

Dla późniejszych wersji torch możesz spróbować tego repozytorium: https://github.com/kligvasser/SinGAN (wyniki nie muszą być identyczne z oficjalną implementacją).


###  Trening
Aby wytrenować model SinGAN na własnym obrazie, umieść wybrany obraz treningowy w katalogu Input/Images i uruchom

```
python main_train.py --input_name <input_file_name>
```

To również wykorzysta wytrenowany model do generowania losowych próbek zaczynając od najgrubszej skali (n=0).

Aby uruchomić ten kod na maszynie z CPU, dodaj `--not_cuda` podczas uruchamiania `main_train.py`

###  Losowe próbki
Aby wygenerować losowe próbki z dowolnej początkowej skali generacji, najpierw wytrenuj model SinGAN na wybranym obrazie (jak opisano powyżej), następnie uruchom 

```
python random_samples.py --input_name <training_image_file_name> --mode random_samples --gen_start_scale <generation start scale number>
```

Uwaga: aby użyć pełnego modelu, ustaw początkową skalę generacji na 0, aby zacząć generację od drugiej skali, ustaw 1 itd.

###  Losowe próbki o dowolnych rozmiarach
Aby wygenerować losowe próbki o dowolnych rozmiarach, najpierw wytrenuj model SinGAN na wybranym obrazie (jak opisano powyżej), następnie uruchom 

```
python random_samples.py --input_name <training_image_file_name> --mode random_samples_arbitrary_sizes --scale_h <horizontal scaling factor> --scale_v <vertical scaling factor>
```

###  Animacja z pojedynczego obrazu

Aby wygenerować krótką animację z pojedynczego obrazu, uruchom

```
python animation.py --input_name <input_file_name> 
```

To automatycznie rozpocznie nową fazę treningową z trybem noise padding.

###  Harmonizacja

Aby wtopić wklejony obiekt w obraz (zobacz przykład na rys. 13 w [naszym artykule](https://arxiv.org/pdf/1905.01164.pdf)), najpierw wytrenuj model SinGAN na wybranym obrazie tła (jak opisano powyżej), następnie zapisz naiwnie wklejony obraz referencyjny i jego binarną maskę w "Input/Harmonization" (zobacz zapisane obrazy jako przykład). Uruchom polecenie

```
python harmonization.py --input_name <training_image_file_name> --ref_name <naively_pasted_reference_image_file_name> --harmonization_start_scale <scale to inject>

```

Uwaga: różne skale wstrzyknięcia dadzą różne efekty harmonizacji. Najgrubsza skala wstrzyknięcia to 1.

###  Edycja

Aby edytować obraz (zobacz przykład na rys. 12 w [naszym artykule](https://arxiv.org/pdf/1905.01164.pdf)), najpierw wytrenuj model SinGAN na wybranym nieedytowanym obrazie (jak opisano powyżej), następnie zapisz naiwną edycję jako obraz referencyjny w "Input/Editing" wraz z odpowiadającą mu binarną mapą (zobacz zapisane obrazy jako przykład). Uruchom polecenie

```
python editing.py --input_name <training_image_file_name> --ref_name <edited_image_file_name> --editing_start_scale <scale to inject>
```
zarówno zamaskowane, jak i niezamaskowane wyjście zostanie zapisane.
Również tutaj różna skala wstrzyknięcia wywoła różne efekty edycyjne. Najgrubsza skala wstrzyknięcia to 1.

###  Paint to Image

Aby przekształcić malunek w realistyczny obraz (patrz przykład na Rys. 11 w [naszej pracy](https://arxiv.org/pdf/1905.01164.pdf)), najpierw wytrenuj model SinGAN na wybranym obrazie (jak opisano powyżej), następnie zapisz swój malunek w "Input/Paint" i uruchom polecenie

```
python paint2image.py --input_name <nazwa_pliku_obrazu_treningowego> --ref_name <nazwa_pliku_obrazu_malunku> --paint_start_scale <skala wstrzyknięcia>
```
Również tutaj różna skala wstrzyknięcia wywoła różne efekty edycyjne. Najgrubsza skala wstrzyknięcia to 1.

Opcja zaawansowana: Ustaw quantization_flag na True, aby przeuczyć *tylko* poziom wstrzyknięcia modelu, uzyskując wersję wygenerowanych obrazów z poprzedniej skali po kwantyzacji kolorów. Dla niektórych obrazów może to dać bardziej realistyczne rezultaty.

### Super Resolution
Aby uzyskać super rozdzielczość obrazu, uruchom:
```
python SR.py --input_name <nazwa_pliku_LR_obrazu>
```
Spowoduje to automatyczne wytrenowanie modelu SinGAN odpowiadającego powiększeniu 4x (jeśli jeszcze nie istnieje).
Dla innych współczynników SR określ je za pomocą parametru `--sr_factor` przy wywołaniu funkcji.
Wyniki SinGAN dla zbioru danych BSD100 można pobrać z folderu 'Downloads'.

## Dodatkowe Dane i Funkcje

### Single Image Fréchet Inception Distance (SIFID score)
Aby obliczyć SIFID pomiędzy rzeczywistymi obrazami a odpowiadającymi im próbkami generowanymi, uruchom:
```
python SIFID/sifid_score.py --path2real <ścieżka_do_obrazów_rzeczywistych> --path2fake <ścieżka_do_obrazów_syntetycznych> 
```
Upewnij się, że każda z nazw plików obrazów syntetycznych jest identyczna jak odpowiadających im obrazów rzeczywistych. Obrazy powinny być zapisane w formacie `.jpg`.

### Wyniki Super Resolution
Wyniki SR SinGAN dla zbioru danych BSD100 można pobrać z folderu 'Downloads'.

### Badanie Użytkowników
Dane użyte w badaniu użytkowników można znaleźć w folderze Downloads.

folder real: 50 prawdziwych obrazów, losowo wybranych z [bazy places](http://places.csail.mit.edu/)

folder fake_high_variance: losowe próbki rozpoczynające się od n=N dla każdego z rzeczywistych obrazów

folder fake_mid_variance: losowe próbki rozpoczynające się od n=N-1 dla każdego z rzeczywistych obrazów

Po więcej informacji patrz sekcja 3.1 w naszej [pracy](https://arxiv.org/pdf/1905.01164.pdf)
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-29

---