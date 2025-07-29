<div align=center>
  
# [ICCV 2025] *TaylorSeer*: 再利用から予測へ：*TaylorSeers*による拡散モデルの高速化

<p>
<a href='https://arxiv.org/abs/2503.06923'><img src='https://img.shields.io/badge/Paper-arXiv-red'></a>
<a href='https://taylorseer.github.io/TaylorSeer/'><img src='https://img.shields.io/badge/Project-Page-blue'></a>
</p>

</div>

## 🔥 ニュース

* `2025/06/26` 💥💥 TaylorSeerがICCV 2025に採択されました！

* `2025/05/03` 🚀🚀 HiDream向けTaylorSeerをリリースしました。

* `2025/03/30` 🚀🚀 Wan2.1向けTaylorSeerをリリースしました。

* `2025/03/30` 🚀🚀 TaylorSeers用のDiffusers推論スクリプトとマルチGPU並列推論に対応したxDiTスクリプトを正式に公開しました。

* `2025/03/10` 🚀🚀 最新研究「再利用から予測へ：TaylorSeersによる拡散モデルの高速化」を公開しました！コードは[TaylorSeer](https://github.com/Shenyi-Z/TaylorSeer)で入手可能です！TaylorSeerはFLUX.1-devで4.99倍の無損失圧縮（レイテンシは3.53倍高速化）とHunyuanVideoで5.00倍の高品質加速（レイテンシは4.65倍高速化）をサポートします！*TaylorSeer*が特徴キャッシュ手法のパラダイムを再利用から予測へと前進させることを期待しています。詳細は最新論文をご参照ください。
* `2025/02/19` 🚀🚀 **FLUX**向けToCaソリューションを調整後に正式公開し、最大**3.14×の無損失加速**（FLOPsベース）を達成しました！
* `2025/01/22` 💥💥 ToCaがICLR 2025に採択されました！
* `2024/12/29` 🚀🚀 拡散トランスフォーマー高速化手法[DuCa](https://arxiv.org/abs/2412.18911)を無償公開し、[OpenSora](https://github.com/hpcaitech/Open-Sora)上でほぼ無損失の2.50倍加速を達成しました！🎉 **DuCaはToCaの制限を克服し、FlashAttentionを完全サポートすることで互換性と効率性を向上させています。**
* `2024/12/24` 🤗🤗 最近の優れたトークン削減論文を収集したオープンソースリポジトリ「[Awesome-Token-Reduction-for-Model-Compression](https://github.com/xuyang-liu16/Awesome-Token-Reduction-for-Model-Compression)」を公開しました！ご意見・ご提案を歓迎します！
* `2024/12/10` 💥💥 チームの最新研究 **SiTo** (https://github.com/EvelynZhang-epiclab/SiTo) が **AAAI 2025** に採択されました。適応的な**トークンプルーニング**で拡散モデルを高速化します。
* `2024/07/15` 🤗🤗 最近の優れた生成加速論文を収集したオープンソースリポジトリ「[Awesome-Generation-Acceleration](https://github.com/xuyang-liu16/Awesome-Generation-Acceleration)」を公開しました！ご意見・ご提案を歓迎します！

<details>
  <summary><strong>概要</strong></summary>

  拡散トランスフォーマー（DiT）は高品質な画像・動画合成に革命をもたらしましたが、その計算コストはリアルタイム用途には依然として高すぎます。この問題を解決するため、特徴キャッシュが提案され、前のタイムステップの特徴をキャッシュし次のタイムステップで再利用することで拡散モデルを高速化しています。しかし、間隔の大きなタイムステップでは拡散モデルの特徴類似度が大幅に低下し、特徴キャッシュによる誤差が増大し生成品質を著しく損ないます。この問題を解決するため、TaylorSeerを提案します。これはまず拡散モデルの将来タイムステップの特徴が前のタイムステップの値から予測可能であることを示します。特徴がタイムステップ間でゆっくりかつ連続的に変化する事実に基づき、TaylorSeerは微分法を用いて特徴の高次導関数を近似し、Taylor級数展開で将来の特徴を予測します。広範な実験により画像・動画合成で特に高加速率での有効性が示されています。例えば、追加学習なしでFLUX上でほぼ無損失の4.99倍加速、HunyuanVideo上で5.00倍加速を達成します。DiTでは、従来のSOTAより$3.41$低いFIDを$4.53$倍加速で実現します。

</details>

## 🧩 コミュニティ貢献

強力なサポートをいただいたすべてのオープンソース貢献者に感謝します！ご意見もお待ちしています！

* ComfyUI-TaylorSeer-philipy1219（FLUXでのFP8推論、今後動画モデルも対応予定）：[ComfyUI-TaylorSeer-philipy1219](https://github.com/philipy1219/ComfyUI-TaylorSeer) by [philipy1219](https://github.com/philipy1219)。

## 🛠 インストール

``` cmd
git clone https://github.com/Shenyi-Z/TaylorSeer.git
```
## TaylorSeer-FLUX

TaylorSeerはFLUX.1-devにおいて、[ImageReward](https://github.com/THUDM/ImageReward)による総合品質評価で、損失なしの計算圧縮率4.99倍とレイテンシスピードアップ3.53倍を達成しました。TaylorSeer-FLUXの実行方法については、[TaylorSeer-FLUX](https://raw.githubusercontent.com/Shenyi-Z/TaylorSeer/main/TaylorSeer-FLUX.md)をご覧ください。

また、**diffusers版**の推論スクリプト例や、マルチGPU並列対応の**xDiT推論スクリプト**も提供しています。これらに基づくテストは、それぞれ[TaylorSeers-Diffusers](./TaylorSeers-Diffusers)および[TaylorSeers-xDiT](./TaylorSeers-xDiT)で可能です。

## TaylorSeer-HunyuanVideo

TaylorSeerはHunyuanVideoにおいて、[VBench](https://github.com/Vchitect/VBench)メトリクスで総合評価され、計算圧縮率5.00倍、優れたレイテンシスピードアップ4.65倍を達成しました。従来手法と比較し、加速効率と品質の両面で大幅な改善を示しています。TaylorSeer-HunyuanVideoの実行方法については、[TaylorSeer-HunyuanVideo](https://raw.githubusercontent.com/Shenyi-Z/TaylorSeer/main/TaylorSeer-HunyuanVideo.md)をご覧ください。

さらに、当該スクリプトはxDiTを用いたHunyuanVideoのマルチGPU並列加速もサポートしています。この場合、キャッシュによる加速効果とマルチGPU並列による加速効果は独立かつ乗算的に作用し、極めて高い加速効果を達成します。

## TayorSeer-DiT

TaylorSeerはベースモデルDiTにおいて、FIDなどの指標で総合評価され、損失なしの計算圧縮率2.77倍を達成しました。様々な加速比における性能は従来手法を大きく上回ります。例えば、4.53倍の極端な圧縮比では、TaylorSeerのFIDは非加速ベースラインの2.32からわずか0.33増の2.65であるのに対し、ToCaやDuCaは同条件下で6.0以上のFIDを示しました。TaylorSeer-DiTの実行方法については、[TaylorSeer-DiT](https://raw.githubusercontent.com/Shenyi-Z/TaylorSeer/main/TaylorSeer-DiT.md)をご覧ください。

## TaylorSeer-Wan2.1

Wan2.1上でTaylorSeer加速手法を実装し、マルチGPU並列推論に対応しました。TaylorSeer-Wan2.1のインストールおよび推論コマンドはWan2.1と完全互換です。TaylorSeer-Wan2.1の実行方法については、[TaylorSeer-Wan2.1](https://raw.githubusercontent.com/Shenyi-Z/TaylorSeer/main/TaylorSeer-Wan2.1.md)をご覧ください。

## TaylorSeer-HiDream

最近オープンソース化された画像生成モデル**HiDream**は、その高品質な出力にも関わらず推論時間が長く、加速のニーズが高まっています。そこで**TaylorSeer**を適用し、HiDreamの推論を**72％のランタイム削減**で加速しました。詳細は[TaylorSeer-HiDream](https://raw.githubusercontent.com/Shenyi-Z/TaylorSeer/main/TaylorSeer-HiDream.md)をご覧ください。

## 👍 謝辞

- TaylorSeer-DiTの構築にあたり素晴らしい成果とコードベースを提供してくださった[DiT](https://github.com/facebookresearch/DiT)に感謝します。
- TaylorSeer-FLUXの構築にあたり素晴らしい成果とコードベースを提供してくださった[FLUX](https://github.com/black-forest-labs/flux)に感謝します。
- TaylorSeer-HiDreamの構築にあたり素晴らしい成果とコードベースを提供してくださった[HiDream](https://github.com/HiDream-ai/HiDream-I1)に感謝します。
- TaylorSeer-HunyuanVideoの構築にあたり素晴らしい成果とコードベースを提供してくださった[HunyuanVideo](https://github.com/Tencent/HunyuanVideo)に感謝します。
- TaylorSeer-Wan2.1の構築にあたり素晴らしい成果とコードベースを提供してくださった[Wan2.1](https://github.com/Wan-Video/Wan2.1)に感謝します。
- テキストから画像への品質評価に[ImageReward](https://github.com/THUDM/ImageReward)を使用しています。
- テキストから動画への品質評価に[VBench](https://github.com/Vchitect/VBench)を使用しています。

## 📌 引用情報




```bibtex
@article{TaylorSeer2025,
  title={From Reusing to Forecasting: Accelerating Diffusion Models with TaylorSeers},
  author={Liu, Jiacheng and Zou, Chang and Lyu, Yuanhuiyi and Chen, Junjie and Zhang, Linfeng},
  journal={arXiv preprint arXiv:2503.06923},
  year={2025}
}
```

## :e-mail: お問い合わせ

ご質問がある場合は、[`shenyizou@outlook.com`](https://raw.githubusercontent.com/Shenyi-Z/TaylorSeer/main/mailto:shenyizou@outlook.com)までメールでお問い合わせください。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-29

---