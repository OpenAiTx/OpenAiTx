# gogosseract
![Couverture](https://img.shields.io/badge/Coverage-70.4%25-brightgreen)
[![Go Report Card](https://goreportcard.com/badge/github.com/danlock/gogosseract)](https://goreportcard.com/report/github.com/danlock/gogosseract)
[![Référence Go](https://pkg.go.dev/badge/github.com/danlock/gogosseract.svg)](https://pkg.go.dev/github.com/danlock/gogosseract)


Une réimplémentation de https://github.com/otiai10/gosseract sans CGo, exécutant Tesseract compilé en WASM avec Emscripten via Wazero.

Tesseract est une bibliothèque de reconnaissance optique de caractères écrite en C++.

Le WASM est généré à partir de mon fork [personnel](https://github.com/Danlock/tesseract-wasm) du projet bien conçu tesseract-wasm de robertknight.

Notez que Tesseract est compilé uniquement avec le support du moteur OCR réseau neuronal LSTM, et non pour le Tesseract "classique".

> [!ATTENTION]
> Cette bibliothèque et ses bibliothèques dépendantes ont été cassées par un changement non compatible en arrière dans wazero 1.8.0. Cette bibliothèque ne sera pas mise à jour. Si vous prévoyez
> d'utiliser cette bibliothèque malgré tout, assurez-vous que vos dépendances sont de la même version que celles du fichier go.mod dans ce dépôt.
> De plus, la version CGO de gosseract est environ 6 fois plus rapide que cette bibliothèque la dernière fois que j'ai vérifié.

# Données d’entraînement

Tesseract nécessite des données d'entraînement pour reconnaître correctement le texte. La source officielle est [ici](https://github.com/tesseract-ocr/tessdata_fast). Les stratégies pour gérer cela incluent le téléchargement à l'exécution, ou l'intégration du fichier dans votre binaire Go à l’aide de go:embed à la compilation.

# Précision

Tesseract peut fonctionner mieux si les images d'entrée sont prétraitées. Consultez cette page pour des conseils.

https://tesseract-ocr.github.io/tessdoc/ImproveQuality.html

# Exemples

Utiliser Tesseract pour extraire du texte d'une image.

```go
    trainingDataFile, err := os.Open("eng.traineddata")
    handleErr(err)

    cfg := gogosseract.Config{
        Language: "eng",
        TrainingData: trainingDataFile,
    }
    // While Tesseract's logs are very useful for debugging, you have the option to silence or redirect it
    cfg.Stderr = io.Discard
    cfg.Stdout = io.Discard
    // Compile the Tesseract WASM and run it, loading in the TrainingData and setting any Config Variables provided
    tess, err := gogosseract.New(ctx, cfg)
    handleErr(err)

    imageFile, err := os.Open("image.png")
    handleErr(err)

    err = tess.LoadImage(ctx, imageFile, gogosseract.LoadImageOptions{})
    handleErr(err)

    text, err = tess.GetText(ctx, func(progress int32) { log.Printf("Tesseract parsing is %d%% complete.", progress) })
    handleErr(err)
    // Closing the Tesseract instance will clean up everything used by Tesseract and it's WASM module
    handleErr(tess.Close(ctx))
```
Utilisation d'un pool de travailleurs Tesseract pour un traitement concurrent sécurisé des images.


```go
    cfg := gogosseract.Config{
        Language: "eng",
        TrainingData: trainingDataFile,
    }
    // Create 10 Tesseract instances that can process image requests concurrently.
    pool, err := gogosseract.NewPool(ctx, 10, gogosseract.PoolConfig{Config: cfg})
    handleErr(err)
    // ParseImage loads the image and waits until the Tesseract worker sends back your result.
    hocr, err := pool.ParseImage(ctx, img, gogosseract.ParseImageOptions{
        IsHOCR: true,
    })
    handleErr(err)
    // Always remember to Close the pool to release resources
    handleErr(pool.Close())

```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-28

---