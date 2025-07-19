# DreamO Comfyui
[DreamO](https://github.com/bytedance/DreamO) ComfyUI ネイティブ実装。

[![arXiv](https://img.shields.io/badge/arXiv-Paper-<COLOR>.svg)](https://arxiv.org/abs/2504.16915) [![demo](https://img.shields.io/badge/🤗-HuggingFace_Demo-orange)](https://huggingface.co/spaces/ByteDance/DreamO) <br>

<img width="1485" alt="Image" src="https://github.com/user-attachments/assets/0954b0bf-63db-463f-ae25-9cd983b462db" />


> [!Important]  
> **2025.06.24** - 画像品質の大幅な向上、人体構図エラーの減少、審美性の強化を特徴とする **DreamO v1.1** をリリースしました。 [このモデルの詳細はこちら](https://github.com/bytedance/DreamO/blob/main/dreamo_v1.1.md)


## インストール
この実装は ComfyUI 2025.5.19 バージョン（コミットID: e930a38）に基づいています。古いバージョンを使用している場合は互換性の問題が発生する可能性があります。
```shell
# manual install
cd custom_nodes
git clone https://github.com/ToTheBeginning/ComfyUI-DreamO.git
# Please make sure that you have installed the forked version of facexlib, not the original facexlib. Otherwise, you may encounter face parsing errors.
pip install -r requirements.txt
# restart comfyui
```
## モデル
### FLUXモデル
マシンにすでにFLUXモデルがダウンロードされている場合は、スキップできます。
- オリジナルbf16モデル: [dit](https://huggingface.co/black-forest-labs/FLUX.1-dev/blob/main/flux1-dev.safetensors), [t5](https://huggingface.co/comfyanonymous/flux_text_encoders/blob/main/t5xxl_fp16.safetensors)
- 8ビットFP8: [dit](https://huggingface.co/Comfy-Org/flux1-dev/blob/main/flux1-dev-fp8.safetensors), [t5](https://huggingface.co/comfyanonymous/flux_text_encoders/blob/main/t5xxl_fp8_e4m3fn.safetensors)
- ClipとVAE（全モデル共通）: [clip](https://huggingface.co/comfyanonymous/flux_text_encoders/blob/main/clip_l.safetensors), [vae](https://huggingface.co/black-forest-labs/FLUX.1-schnell/blob/main/ae.safetensors)

### DreamOモデル
- https://huggingface.co/ByteDance/DreamO/tree/main/comfyui の `.safetensors` で終わるすべてのファイルをダウンロードし => `ComfyUI/models/loras` に保存。
- 🔥🔥**v1.1**: https://huggingface.co/ByteDance/DreamO/tree/main/v1.1 の `.safetensors` で終わるすべてのファイルをダウンロードし => `ComfyUI/models/loras` に保存。
- （自動ダウンロード対応）[dreamo-embedding](https://huggingface.co/ByteDance/DreamO/blob/main/embedding.safetensors) をダウンロード => `ComfyUI/models/dreamo`
- （自動ダウンロード対応）[ben2](https://huggingface.co/PramaLLC/BEN2/blob/main/model.safetensors) をダウンロード => `ComfyUI/models/dreamo`
- [flux-turbo](https://huggingface.co/alimama-creative/FLUX.1-Turbo-Alpha/blob/main/diffusion_pytorch_model.safetensors) をダウンロード => `ComfyUI/models/loras` に保存し、`flux-turbo.safetensors` にリネーム

## ワークフロー
[workflows](workflows) フォルダにワークフローがあります。[このv1.1ワークフロー](https://raw.githubusercontent.com/ToTheBeginning/ComfyUI-DreamO/main/workflows/dreamo_comfyui_v1.1.json) が最新バージョンです。

v1.1モデルは、[Super-Realism LoRA](https://huggingface.co/strangerzonehf/Flux-Super-Realism-LoRA) と組み合わせることでさらにリアリズムを強化できます。ただし、リアリズム特化型LoRAのため、スタイル転送に影響を与える可能性があります。必要に応じて使用してください。

## ノード
- DreamOProcessorLoader
  - このノードは、背景除去用のBEN2モデルと、顔の整列検出用のfacexlibモデルという2つの画像前処理モデルをロードします。
- DreamORefEncode
  - このノードは、選択したタスクタイプに基づいて参照画像を潜在表現にエンコードします。3つのタスクタイプがあります: ip、id、style。
    - ip: 参照画像の背景を除去します
    - id: 参照画像から顔を整列＆クロップします。PuLIDに似ています
    - style: 参照画像の背景を保持します。スタイル転送タスクを有効にするにはトリガーメタプロンプトが必要です
- ApplyDreamO
  - このノードはFluxモデルにフックを追加し、参照潜在表現とノイズ潜在表現の連結をサポートします。

## 注意事項
- 現在のコードは真のCFGロジックを実装していないため、サンプラーノードでcfg=1に設定する必要があります
- 先述の通り、ComfyUIは初心者です。より良いワークフローや提案があればぜひ教えてください。

ご協力歓迎します！

    
## 謝辞
ComfyUIプラグインの実装は[ComfyUI_PuLID_Flux_ll](https://github.com/lldacing/ComfyUI_PuLID_Flux_ll)を参照しています。

## 今後の予定
✅ 基盤リポジトリ[DreamO](https://github.com/bytedance/DreamO)をフォローしてください — 今後数週間でモデルのアップデートをリリース予定です。


## :e-mail: 連絡先
ご意見やご質問があれば、[新しいIssueを作成](https://github.com/xxx/xxx/issues/new/choose)するか、[Yanze Wu](https://tothebeginning.github.io/) および [Chong Mou](https://raw.githubusercontent.com/ToTheBeginning/ComfyUI-DreamO/main/mailto:eechongm@gmail.com) にご連絡ください。




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-19

---