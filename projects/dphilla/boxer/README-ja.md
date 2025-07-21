<translate-content># ボクサー

<p align="center">
  <p align="center">
    <a href="https://en.wikipedia.org/wiki/Mia_St._John" target="_blank">
      <img src="https://user-images.githubusercontent.com/20820229/164059786-8d082b44-59d6-431a-adf4-993116c8d492.png" alt="Mia St John" width="300"             height="400">
    </a>
  </p>
</p>

**このプロジェクトは急速に開発中です**

# ボクサー

## 概要
Boxerは、従来のコンテナ技術からWebAssembly（Wasm）ベースの配布物、通称「Boxes」または「Wasm-Boxes」への移行により、クラウドコンピューティングを再構築するためのオープンソースプロジェクトです。

## 動機
コンテナはクラウドコンピューティングの基盤としてアプリケーションの隔離環境を提供してきましたが、重要な欠点もあります。一般的に大きく非効率的なデプロイメントとなり、起動時間が遅く、セキュリティのために基盤となるOS/カーネルに大きく依存するため、脆弱性やプラットフォームのロックインを引き起こす可能性があります。

## 解決策：Boxer
Boxerは既存のコンテナ化されたワークロードと定義を、ほぼあらゆる環境に展開可能なWasm配布物に変換するためのツールを提供する新しい解決策です。これらの「Boxes」はコンテナと同様の環境を提供しますが、WebAssemblyの軽量でサンドボックス化された実行機能により、はるかに効率的です。

<p align="center">
  <p align="center">
    <a href="https://boxer.dev" target="_blank">
      <img src="https://github.com/dphilla/wasm-vfs/assets/20820229/4b0309d8-c8ae-427a-8af3-67857a8eebf3" alt="Container and Box" width="400"             height="400">
    </a>
  </p>
</p>


### WebAssemblyの主な利点：
- **オーバーヘッドの削減：** Wasmのコンパクトなバイナリ命令フォーマットにより軽量な実行が可能で、従来のコンテナで見られるオーバーヘッドを劇的に削減します。
- **性能向上：** Wasmの効率性により性能が向上し、より小さく効率的なデプロイメントが可能で、クラウドコンピューティングに最適です。
- **優れたセキュリティ：** Wasmのメモリ安全で隔離された実行環境は、OSに依存しない高いレベルのセキュリティを提供します。
- **ほぼどこでも実行可能** WasmはWebAssemblyランタイムがある場所ならどこでも動作可能で、ブラウザ、サーバー、組み込みデバイスなど幅広いアーキテクチャ向けに既存のランタイムが利用可能です。[幅広いアーキテクチャ](https://github.com/appcypher/awesome-wasm-runtimes)に対応しています。

## 例

### Dockerfile ➡ (Wasm)Box

このファイルの場合：

```Dockerfile
FROM scratch
RUN mkdir -p /app
COPY a.out /app
WORKDIR /app
CMD ["/app/a.out"]
```
run  `box build -f Dockerfile`

これにより libc インターフェース（インポートとして）が取り込まれ、必要なファイルシステムの状態が作成されます。  
これにより、宣言的に実行準備が整った Wasm バイナリが作成されます。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---