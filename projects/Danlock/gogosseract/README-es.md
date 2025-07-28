# gogosseract
![Cobertura](https://img.shields.io/badge/Coverage-70.4%25-brightgreen)
[![Go Report Card](https://goreportcard.com/badge/github.com/danlock/gogosseract)](https://goreportcard.com/report/github.com/danlock/gogosseract)
[![Go Reference](https://pkg.go.dev/badge/github.com/danlock/gogosseract.svg)](https://pkg.go.dev/github.com/danlock/gogosseract)


Una reimplementación de https://github.com/otiai10/gosseract sin CGo, ejecutando Tesseract compilado a WASM con Emscripten vía Wazero.

Tesseract es una biblioteca de Reconocimiento Óptico de Caracteres escrita en C++.

El WASM se genera a partir de mi fork [personal](https://github.com/Danlock/tesseract-wasm) del bien elaborado proyecto tesseract-wasm de robertknight.

Tenga en cuenta que Tesseract solo está compilado con soporte para el motor OCR de red neuronal LSTM, y no para el Tesseract "clásico".

> [!CAUTION]
> Esta biblioteca y sus bibliotecas dependientes se rompieron por un cambio incompatible hacia atrás en wazero 1.8.0. Esta biblioteca no será actualizada. Si planea
> usar esta biblioteca de todos modos, asegúrese de que sus dependencias estén en la misma versión que la que está en el archivo go.mod de este repositorio.
> Además, CGO gosseract es como 6 veces más rápido que esta biblioteca de todas formas la última vez que lo verifiqué.

# Datos de Entrenamiento

Tesseract requiere datos de entrenamiento para reconocer texto con precisión. La fuente oficial está [aquí](https://github.com/tesseract-ocr/tessdata_fast). Las estrategias para manejar esto incluyen descargarlo en tiempo de ejecución, o incrustar el archivo dentro de su binario Go usando go:embed en tiempo de compilación.

# Precisión

Tesseract puede funcionar mejor si las imágenes de entrada se preprocesan. Vea esta página para consejos.

https://tesseract-ocr.github.io/tessdoc/ImproveQuality.html

# Ejemplos

Usando Tesseract para analizar texto de una imagen.

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

Uso de un grupo de trabajadores de Tesseract para el análisis concurrente seguro de imágenes.

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