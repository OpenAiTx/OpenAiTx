# gogosseract
![Coverage](https://img.shields.io/badge/Coverage-70.4%25-brightgreen)
[![Go Report Card](https://goreportcard.com/badge/github.com/danlock/gogosseract)](https://goreportcard.com/report/github.com/danlock/gogosseract)
[![Go Reference](https://pkg.go.dev/badge/github.com/danlock/gogosseract.svg)](https://pkg.go.dev/github.com/danlock/gogosseract)


A reimplementation of https://github.com/otiai10/gosseract without CGo, running Tesseract compiled to WASM with Emscripten via Wazero.

Tesseract is an Optical Character Recognition library written in C++.

The WASM is generated from my [personal](https://github.com/Danlock/tesseract-wasm) fork of robertknight's well written tesseract-wasm project.

Note that Tesseract is only compiled with support for the LSTM neural network OCR engine, and not for "classic" Tesseract.

> [!CAUTION]
> This library and its dependent libraries was broken by a backwards incompatible change in wazero 1.8.0. This library will not be updated. If you plan on
> using this library regardless, make sure your dependencies are the same version as what's in the go.mod file in this repo.
> Also, CGO gosseract is like 6 times faster than this library anyway the last time I checked.

# Training Data

Tesseract requires training data in order to accurately recognize text. The official source is [here](https://github.com/tesseract-ocr/tessdata_fast). Strategies for dealing with this include downloading it at runtime, or embedding the file within your Go binary using go:embed at compile time.

# Accuracy

Tesseract can work better if the input images are preprocessed. See this page for tips.

https://tesseract-ocr.github.io/tessdoc/ImproveQuality.html

# Examples

Using Tesseract to parse text from an image.

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
Using a Pool of Tesseract workers for thread-safe concurrent image parsing.


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