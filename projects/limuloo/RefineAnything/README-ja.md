# RefineAnything

**完璧な局所ディテールのためのマルチモーダル領域特化型リファインメント**

<a href="https://limuloo.github.io/RefineAnything/"><img src="https://img.shields.io/badge/Project-Page-blue" /></a>
<a href="https://arxiv.org/abs/2604.06870"><img src="https://img.shields.io/badge/arXiv-2604.06870-b31b1b" /></a>
<a href="https://github.com/limuloo/RefineAnything"><img src="https://img.shields.io/badge/GitHub-Code-black?logo=github" /></a>
<a href="https://huggingface.co/limuloo1999/RefineAnything"><img src="https://img.shields.io/badge/HuggingFace-Checkpoint-yellow?logo=huggingface" /></a>
<a href="https://huggingface.co/spaces/limuloo1999/RefineAnything"><img src="https://img.shields.io/badge/HuggingFace-Space-orange?logo=huggingface" /></a>
<a href="https://github.com/smthemex/ComfyUI_RefineAnything"><img src="https://img.shields.io/badge/ComfyUI-Plugin-green?logo=github" /></a>

RefineAnythingは**領域特化型画像リファインメント**をターゲットにしています：入力画像とユーザー指定の領域（例：スクリブルマスクやバウンディングボックス）を与えると、テキスト、ロゴ、細い構造などの細かいディテールを復元し、**編集されていないピクセルはすべて保持**します。**参照画像あり**・**参照画像なし**の両方のリファインメントをサポートします。

![Teaser](https://raw.githubusercontent.com/limuloo/RefineAnything/main/docs/static/teaser.png)
---

## ニュース
- **2026-04-21** — **環境固定アップデート。** 最良の結果（および色ズレ回避）のために、`requirement.txt`で固定されたバージョンを**正確に**使用してください：`diffusers==0.36.0`、`transformers==4.55.0`、`safetensors==0.5.3`、`peft==0.17.0`。ビジュアル比較は以下の[環境注意](#environment-notice)を参照。
- **2026-04-21** — **Hugging Face Space環境修正。** オンラインデモが正しい依存関係バージョンで動作するようになり、リファインメント結果が明らかに向上しました：<https://huggingface.co/spaces/limuloo1999/RefineAnything>。
- **2026-04-14** — コミュニティによるComfyUI統合が[@smthemex](https://github.com/smthemex)により公開：[ComfyUI_RefineAnything](https://github.com/smthemex/ComfyUI_RefineAnything)。素晴らしい仕事に感謝！
- **2026-04-14** — 対話型テスト用のローカルGradioデモ（`app.py`）を公開。
- **2026-04-12** — Hugging Face Spaceデモ公開：<https://huggingface.co/spaces/limuloo1999/RefineAnything>。
- **2026-04-09** — Hugging Faceにチェックポイント公開：<https://huggingface.co/limuloo1999/RefineAnything>。
- **2026-04-09** — 推論スクリプトを公開。
- **2026-04-08** — ドキュメントの骨格を追加；**今月中にコード公開予定**（推論スクリプト、環境、チェックポイントをここにリンク予定）。
- **未定** — チェックポイントおよび訓練/評価リソースは確定次第発表。

---

## ハイライト

- **領域精度の高いリファインメント** — 明示的な領域指示（スクリブルやボックス）が編集を対象領域に誘導。
- **参照あり/なし両対応** — ガイド付き局所ディテール復元用の任意の参照画像。
- **厳密な背景保持** — 編集は対象領域内に限定；訓練は継ぎ目のない境界を重視。

---

## 比較

![参照なし定性的比較](https://raw.githubusercontent.com/limuloo/RefineAnything/main/docs/static/qualitative_free.png)

![Reference-based qualitative comparisons](https://raw.githubusercontent.com/limuloo/RefineAnything/main/docs/static/qualitative_reference.png)

---

## Installation

```bash
pip install -r requirement.txt
```
> **重要 — これらのバージョンを正確に固定してください。** RefineAnythingは基盤となるライブラリのわずかな数値の違いに敏感です。以下のバージョンを**正確に**インストールしてください。新しいバージョンや古いバージョンを使うと、補正された領域に色のずれなどの目に見えるアーティファクトが発生することがあります。
>
> ```
> diffusers==0.36.0
> transformers==4.55.0
> safetensors==0.5.3
> peft==0.17.0
> ```

---

## 環境に関する注意

`diffusers` / `transformers` / `safetensors` / `peft` のバージョンが一致しないと、他の条件が同じでも補正領域に**色のずれ**が生じることを確認しています。以下の例はプロンプト「手を消す」を使用しています：

<table>
<tr>
<td align="center"><b>入力（マスク領域 = 手）</b></td>
<td align="center"><b>正しい環境</b></td>
<td align="center"><b>誤った環境（色ずれ）</b></td>
</tr>
<tr>
<td><img src="https://raw.githubusercontent.com/limuloo/RefineAnything/main/docs/static/env_check_input.png" width="100%"></td>
<td><img src="https://raw.githubusercontent.com/limuloo/RefineAnything/main/docs/static/correct_env_result.png" width="100%"></td>
<td><img src="https://raw.githubusercontent.com/limuloo/RefineAnything/main/docs/static/wrong_env_result.png" width="100%"></td>
</tr>
</table>

マスク内部にわずかな色やトーンの不一致が見られ、その他の部分は問題ない場合、まずはパッケージのバージョンを確認してください。

---

## クイックスタート

RefineAnythingを動かすには**3つ**の引数だけが必要です：

| 引数 | 説明 |
|----------|-------------|
| `--input` | 元画像 |

| `--mask` | バイナリマスク（白＝修正する領域） |
| `--prompt` | 修正内容 |
| `--ref` | *(オプション)* ガイド付き修正のための参照画像 |

---

### デモ1 — 参照画像を用いたロゴ修正

参照画像を使って、枕のぼやけたロゴを修正します。

```bash
python scripts/fast_inference.py \
    --input  src/input1.png \
    --mask   src/mask1.png \
    --prompt "Refine the LOGO." \
    --ref    src/ref1.png \
    --output output/demo1.png
```
<table>
<tr>
<td align="center"><b>入力</b></td>
<td align="center"><b>参照</b></td>
<td align="center"><b>プロンプト</b></td>
</tr>
<tr>
<td><img src="https://raw.githubusercontent.com/limuloo/RefineAnything/main/docs/static/demo1_input_zoom.jpg" width="100%"></td>
<td><img src="https://raw.githubusercontent.com/limuloo/RefineAnything/main/src/ref1.png" width="100%"></td>
<td><i>「ロゴを洗練してください。」</i></td>
</tr>
<tr>
<td align="center" colspan="3"><b>出力</b></td>
</tr>
<tr>
<td colspan="3"><img src="https://raw.githubusercontent.com/limuloo/RefineAnything/main/docs/static/demo1_output_zoom.jpg" width="100%"></td>
</tr>
</table>

---

### デモ 2 — 参照なしテキスト洗練

建物の看板のぼやけた中国語テキストを洗練する — 参照画像は不要。


```bash
python scripts/fast_inference.py \
    --input  src/input2.png \
    --mask   src/mask2.png \
    --prompt "refine the text '鼎好商城'" \
    --output output/demo2.png
```
<table>
<tr>
<td align="center"><b>入力</b></td>
<td align="center"><b>プロンプト</b></td>
</tr>
<tr>
<td><img src="https://raw.githubusercontent.com/limuloo/RefineAnything/main/docs/static/demo2_input_zoom.jpg" width="100%"></td>
<td><i>「テキスト '鼎好商城' をリファインしてください」</i></td>
</tr>
<tr>
<td align="center" colspan="2"><b>出力</b></td>
</tr>
<tr>
<td colspan="2"><img src="https://raw.githubusercontent.com/limuloo/RefineAnything/main/docs/static/demo2_output_zoom.jpg" width="100%"></td>
</tr>
</table>

---

## ローカルGradioデモ

インタラクティブなテストのためのGradioベースのウェブUIも提供しています。ブラシで領域をなぞり、参照画像をアップロードし、すべての推論パラメータをブラウザ上で調整できます。


```bash
python app.py
```

次に、ブラウザで `http://localhost:7860` を開きます。アプリは初回起動時にベースモデル（`Qwen/Qwen-Image-Edit-2511`）とRefineAnything LoRAをHugging Faceから自動的にダウンロードします。

`MODEL_DIR` 環境変数を使ってカスタムベースモデルのパスを指定できます：

```bash
MODEL_DIR=/path/to/local/Qwen-Image-Edit-2511 python app.py
```

**Gradioデモの特徴：**
- **ブラシで選択**：元画像に直接ペイントしてリファインメント領域を定義します。
- **オプションの参照画像**：2枚目の画像をアップロードし、必要に応じてブラシで特定の参照領域を切り取れます。
- **フォーカスクロップ**：編集領域を自動でクロップおよびズームし、高精細で処理後にシームレスに合成します。
- **Lightning LoRA**：ステップ数を減らした高速推論をワンクリックで切り替え可能。
- **ビフォー／アフタースライダー**：入力と出力を即座に比較可能。

---

## 引用

このリポジトリを使用する場合は、以下を引用してください：

```bibtex
@article{zhou2026refineanything,
  title={RefineAnything: Multimodal Region-Specific Refinement for Perfect Local Details},
  author={Zhou, Dewei and Li, You and Yang, Zongxin and Yang, Yi},
  journal={arXiv preprint arXiv:2604.06870},
  year={2026}
}
```

---

## 謝辞とライセンス

RefineAnythingは、より広範な拡散およびマルチモーダルエコシステムのアイデアとコンポーネント（**Qwen2.5-VL**、**Qwen-Image**、および**VAE** + **MMDiT**を用いた潜在拡散を含む）に基づいて構築されています。ベースモデルの重みおよびAPIの利用規約はそれぞれのライセンスに従います—**チェックポイントや派生重みを再配布する前に遵守状況を確認してください**。

リポジトリの**コードライセンス**：*未定*（例：Apache-2.0またはMIT）—実装をオープンソース化する際に`LICENSE`を設定してください。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-29

---