# gogosseract
![Coverage](https://img.shields.io/badge/Coverage-70.4%25-brightgreen)
[![Go Report Card](https://goreportcard.com/badge/github.com/danlock/gogosseract)](https://goreportcard.com/report/github.com/danlock/gogosseract)
[![Go Reference](https://pkg.go.dev/badge/github.com/danlock/gogosseract.svg)](https://pkg.go.dev/github.com/danlock/gogosseract)


https://github.com/otiai10/gosseract を CGo なしで再実装し、Wazero 経由で Emscripten によって WASM にコンパイルされた Tesseract を実行します。

Tesseract は C++ で書かれた光学文字認識ライブラリです。

WASM は、robertknight の優れた tesseract-wasm プロジェクトの [個人フォーク](https://github.com/Danlock/tesseract-wasm) から生成されています。

Tesseract は LSTM ニューラルネットワーク OCR エンジンのサポートのみでコンパイルされており、「クラシック」Tesseract はサポートされていないことに注意してください。

> [!CAUTION]
> このライブラリと依存ライブラリは、wazero 1.8.0 の後方互換性のない変更により動作しなくなりました。このライブラリは更新されません。
> それでもこのライブラリを使用する場合は、依存関係がこのリポジトリの go.mod ファイルにあるバージョンと同じであることを確認してください。
> また、CGO 版の gosseract は、私が最後に確認したとき、このライブラリより約6倍高速です。

# 学習データ

Tesseract は正確にテキストを認識するために学習データを必要とします。公式ソースは[こちら](https://github.com/tesseract-ocr/tessdata_fast)です。対処法としては、実行時にダウンロードするか、go:embed を使用してコンパイル時に Go バイナリ内に埋め込む方法があります。

# 精度

Tesseract は入力画像を前処理すると精度が向上します。ヒントは以下のページを参照してください。

https://tesseract-ocr.github.io/tessdoc/ImproveQuality.html

# 例

画像からテキストを解析するために Tesseract を使用する例です。

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
Tesseractワーカーのプールを使用して、スレッドセーフな同時画像解析を行います。


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