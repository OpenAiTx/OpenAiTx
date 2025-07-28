# gogosseract
![Coverage](https://img.shields.io/badge/Coverage-70.4%25-brightgreen)
[![Go Report Card](https://goreportcard.com/badge/github.com/danlock/gogosseract)](https://goreportcard.com/report/github.com/danlock/gogosseract)
[![Go Reference](https://pkg.go.dev/badge/github.com/danlock/gogosseract.svg)](https://pkg.go.dev/github.com/danlock/gogosseract)


这是 https://github.com/otiai10/gosseract 的无 CGo 重新实现，通过 Wazero 运行用 Emscripten 编译成 WASM 的 Tesseract。

Tesseract 是一个用 C++ 编写的光学字符识别库。

WASM 来自我个人的 [fork](https://github.com/Danlock/tesseract-wasm) ，基于 robertknight 编写良好的 tesseract-wasm 项目。

注意 Tesseract 仅支持使用 LSTM 神经网络 OCR 引擎编译，而不支持“经典”的 Tesseract。

> [!CAUTION]
> 本库及其依赖库因 wazero 1.8.0 的不兼容变更而被破坏。此库将不再更新。如果你仍计划使用本库，
> 请确保你的依赖版本与本仓库 go.mod 文件中的版本一致。
> 此外，据我最后一次检查，使用 CGO 的 gosseract 比本库快约 6 倍。

# 训练数据

Tesseract 需要训练数据来准确识别文本。官方来源在 [这里](https://github.com/tesseract-ocr/tessdata_fast)。处理策略包括运行时下载，或者编译时使用 go:embed 将文件嵌入 Go 二进制文件中。

# 准确性

如果对输入图像进行预处理，Tesseract 的效果会更好。详情请参见此页面的建议。

https://tesseract-ocr.github.io/tessdoc/ImproveQuality.html

# 示例

使用 Tesseract 从图像中解析文本。

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
使用一组 Tesseract 工作线程实现线程安全的并发图像解析。


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