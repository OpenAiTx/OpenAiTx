# gogosseract
![Coverage](https://img.shields.io/badge/Coverage-70.4%25-brightgreen)
[![Go Report Card](https://goreportcard.com/badge/github.com/danlock/gogosseract)](https://goreportcard.com/report/github.com/danlock/gogosseract)
[![Go Reference](https://pkg.go.dev/badge/github.com/danlock/gogosseract.svg)](https://pkg.go.dev/github.com/danlock/gogosseract)


CGo 없이 https://github.com/otiai10/gosseract 를 재구현한 것으로, Wazero를 통해 Emscripten으로 컴파일된 WASM에서 Tesseract를 실행합니다.

Tesseract는 C++로 작성된 광학 문자 인식 라이브러리입니다.

WASM은 robertknight의 잘 작성된 tesseract-wasm 프로젝트를 포크한 제 [개인](https://github.com/Danlock/tesseract-wasm) 저장소에서 생성되었습니다.

Tesseract는 "클래식" Tesseract가 아닌 LSTM 신경망 OCR 엔진 지원만 컴파일된 점을 참고하세요.

> [!CAUTION]
> 이 라이브러리와 의존 라이브러리는 wazero 1.8.0의 하위 호환성 없는 변경으로 인해 깨졌습니다. 이 라이브러리는 더 이상 업데이트되지 않습니다.
> 만약 이 라이브러리를 계속 사용하실 계획이라면, 의존성이 이 저장소의 go.mod 파일에 명시된 버전과 동일한지 확인하세요.
> 또한, CGO gosseract는 제가 마지막으로 확인했을 때 이 라이브러리보다 약 6배 더 빠릅니다.

# 학습 데이터

Tesseract는 정확한 텍스트 인식을 위해 학습 데이터가 필요합니다. 공식 소스는 [여기](https://github.com/tesseract-ocr/tessdata_fast)입니다. 이를 처리하는 방법으로는 런타임에 다운로드하거나, 컴파일 시 go:embed를 사용하여 Go 바이너리에 파일을 포함하는 방법이 있습니다.

# 정확도

Tesseract는 입력 이미지가 전처리되면 더 잘 작동할 수 있습니다. 팁은 이 페이지를 참고하세요.

https://tesseract-ocr.github.io/tessdoc/ImproveQuality.html

# 예제

이미지에서 텍스트를 파싱하기 위해 Tesseract를 사용하는 예입니다.

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
동시 이미지 파싱을 위한 스레드 안전한 Tesseract 작업자 풀 사용.


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