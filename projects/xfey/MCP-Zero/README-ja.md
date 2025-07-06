## MCP-Zero: 自律型LLMエージェントのための能動的ツール探索

<div style="display: flex; align-items: center; gap: 10px; margin-bottom: 10px;">
  <!-- <img src="https://raw.githubusercontent.com/xfey/MCP-Zero/master/assets/robot.png" alt="MCP-Zero Robot" width="24" height="24"> -->
  <a href="https://arxiv.org/abs/2506.01056">
    <img src="https://img.shields.io/badge/Paper-arXiv-red">
  </a>
  <a href="https://arxiv.org/abs/2506.01056">
    https://arxiv.org/abs/2506.01056
  </a>
</div>


MCP-Zeroへのご関心ありがとうございます！🤗

本論文で使用したコードをオープンソース化しました。今後も本研究を継続的にアップデートし、産業界への応用を模索し、プロジェクトを拡張していきます。


<div align="center">
  <img src="https://raw.githubusercontent.com/xfey/MCP-Zero/master/assets/fig1.png" alt="MCP-Zero workflow">
  <p> MCP-Zeroを用いて「素晴らしい食事を作る」ためのツールチェーンを能動的に構築する</p>
</div>


### 手法: MCP-Zero

```
MCP-zero/
├── experiment_apibank.py       # 実験: APIBank
├── experiment_mcptools.py      # 実験: mcp_tools（needleテスト）
├── matcher.py                  # 類似度マッチング用コード
├── prompt_guide/               # 本手法用のプロンプト
├── reformatter.py              # ツール説明用のjsonフォーマッタ
├── sampler.py                  # ターゲットツール選択用サンプラー
├── test_cases.jsonl            # matcher用テストケース
├── test_matcher.py             # matcherのユニットテスト
└── utils.py                    # ユーティリティ: grid_search
```

論文で用いたコードを公開しました。論文中のコードは検索機能を実装し、実験で具体的な成果を上げています。

今後の研究では、MCP-zeroを産業界に応用することに注力していきます。そのため、MCPサーバの動的デプロイメントやGAIAテストの環境構築など、他のモジュールも必要となります。今後も本研究を継続的に改善していきますので、ご注目いただきありがとうございます。スター🌟を付けていただけると励みになります :D



### データセット: MCP-tools

- **Google Drive**: [ダウンロードリンク](https://drive.google.com/file/d/1RjBGU-AGdHdhUABoeYSztbfQlD0hjUBn/view?usp=sharing)
- **Huggingface Link**: 近日公開
- **ファイルの配置場所**: `./MCP-tools/mcp_tools_with_embedding.json`


**概要**: MCP公式リポジトリから抽出・フィルタリングされた全ツール（308サーバ、2,797ツール収録）を含むデータセットです。

**データ構造**:
```
{
  "server_name": string, // MCPサーバ名。READMEから抽出または推定
  "server_summary": string, // サーバの目的・機能の要約。READMEの関連部分より
  "server_description": string, // メタデータからの説明
  "description_embedding": float[3072], // server_descriptionのtext-embedding-3-largeによる埋め込み
  "summary_embedding": float[3072], // server_summaryのtext-embedding-3-largeによる埋め込み
  "tools": [
    {
      "name": string, // 関数・ツール名
      "description": string, // ツールの簡潔な説明
      "description_embedding": float[3072], // ツール説明のtext-embedding-3-largeによる埋め込み
      "parameter": { // 入力パラメータの辞書。明示的に定義されていれば含む
        "param1": "(type) description1",
        "param2": "(Optional, type) description2"
      }
    }
  ]
}
```

**独自データセットの構築方法**: MCPサーバ向けのカスタムデータセットを作りたい場合は、`MCP-tools/build_data`ディレクトリ内のコードを参考にしてください。

```
MCP-tools/
├── build_data
│   ├── get_server_summary.py       # MCPサーバのReadMeから構造化データを抽出するコード
│   ├── run_vllm.sh                 # Qwen2.5-72B-InstructモデルをVLLMでデプロイ
│   └── server_summary.prompt       # データセット抽出用プロンプト
└── download_data.md
```


### 引用

> Citation makes me happy.
> 
>   --Shakespeare
>   ~~(just for fun :D)~~

```bibtex
@article{fei2025mcp,
  title={MCP-Zero: Active Tool Discovery for Autonomous LLM Agents},
  author={Fei, Xiang and Zheng, Xiawu and Feng, Hao},
  journal={arXiv preprint arXiv:2506.01056},
```
  year={2025}
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-06

---