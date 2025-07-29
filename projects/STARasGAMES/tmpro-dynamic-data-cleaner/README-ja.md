## About
TextMeshProの動的フォントアセットは、動的に生成されたバイナリデータを設定データと同じテキストファイルに保存するという非常に厄介な習性があります。  
これはバージョン管理に大きな問題を引き起こします。

このパッケージのスクリプトは上記の問題に対処します。プロジェクト内のいずれかのアセットが保存される直前に実行されます。  
そのアセットがTMPの動的フォントアセットであれば、保存前に動的に生成されたデータがクリアされ、  
そのデータがバージョン管理を汚染するのを防ぎます。

この素晴らしい解決策を考案した@cxodeに感謝します:<br>  
`https://forum.unity.com/threads/tmpro-dynamic-font-asset-constantly-changes-in-source-control.1227831/#post-8934711`

私の貢献は、このスクリプトを簡単にインストール可能なupm対応パッケージにしたことです。<br>  
パフォーマンスの改善やエッジケースに対する追加チェックも行いました。<br>  
また、プロジェクトやUnityのバージョンでスクリプトが正しく動作するかを素早くテストするためのテストも作成しました。<br>

## Installation
Git URL経由でインストール:  
`https://github.com/STARasGAMES/tmpro-dynamic-data-cleaner.git#upm`

または**`manifest.json`**に新しいエントリを追加してインストールしてください。
```json
{
  "dependencies": {
    "com.starasgames.tmpro-dynamic-data-cleaner": "https://github.com/STARasGAMES/tmpro-dynamic-data-cleaner.git#upm",
    ...
  },
  "testables" : ["com.starasgames.tmpro-dynamic-data-cleaner"]
}
```
統合テストをTestRunnerウィンドウに表示するには、"testables"属性を追加する必要がありますが、これは任意です。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-29

---