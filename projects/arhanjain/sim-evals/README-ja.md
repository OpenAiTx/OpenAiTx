# DROID Sim 評価

このリポジトリには、シンプルな ISAAC Sim 環境で DROID ポリシーを評価するためのスクリプトが含まれています。

以下は pi0-FAST-DROID ポリシーのロールアウト例です：

シーン 1

![Scene 1](https://raw.githubusercontent.com/arhanjain/sim-evals/main/./docs/scene1.gif)

シーン 2

![Scene 2](https://raw.githubusercontent.com/arhanjain/sim-evals/main/./docs/scene2.gif)

シーン 3

![Scene 3](https://raw.githubusercontent.com/arhanjain/sim-evals/main/./docs/scene3.gif)

このシミュレーションは、実世界の DROID データセットで訓練された DROID ポリシーに対して *ゼロショット* で動作するよう調整されているため、別途シミュレーションデータは不要です。

**注意：** 現在のシミュレータは、*関節位置* アクション空間（*関節速度制御ではない*）で訓練されたポリシーに最適化されています。以下に関節位置制御で訓練された pi0-FAST-DROID ポリシーの評価例を示します。


## インストール

リポジトリをクローンしてください
```bash
git clone --recurse-submodules git@github.com:arhanjain/sim-evals.git
cd sim-evals
```

uvをインストールしてください（参照：https://github.com/astral-sh/uv#installation）

例えば（Linux/macOS）：
```bash
curl -LsSf https://astral.sh/uv/install.sh | sh
```

仮想環境を作成して有効化する
```bash
uv sync
source .venv/bin/activate
```

## クイックスタート

まず、このディレクトリのルートにシミュレーション資産をダウンロードしてください。
```bash
uvx hf download owhan/DROID-sim-environments --repo-type dataset --local-dir assets
```

次に、別のターミナルで `localhost:8000` にポリシーサーバーを起動します。  
例えば、pi0-FAST-DROIDポリシー（関節位置制御付き）を起動するには、  
[openpi](https://github.com/Physical-Intelligence/openpi) をチェックアウトし、`polaris` の設定を使用します。  
```bash
XLA_PYTHON_CLIENT_MEM_FRACTION=0.5 uv run scripts/serve_policy.py policy:checkpoint --policy.config=pi05_droid_jointpos_polaris --policy.dir=gs://openpi-assets/checkpoints/pi05_droid_jointpos
```

**注意**: JAXがすべてのGPUメモリを占有しないように、`XLA_PYTHON_CLIENT_MEM_FRACTION=0.5`を設定しています（Isaac Simが同じGPUを使用している場合に備えて）。

最後に、評価スクリプトを実行します：
```bash
python run_eval.py --episodes [INT] --scene [INT] --headless
```

## 最小限の例

```python
env_cfg.set_scene(scene) # pass scene integer
env = gym.make("DROID", cfg=env_cfg)

obs, _ = env.reset()
obs, _ = env.reset() # need second render cycle to get correctly loaded materials
client = # Your policy of choice

max_steps = env.env.max_episode_length
for _ in tqdm(range(max_steps), desc=f"Episode"):
    action = client.infer(obs, INSTRUCTION) # calling inference on your policy
    action = torch.tensor(ret["action"])[None]
    obs, _, term, trunc, _ = env.step(action)
    if term or trunc:
        break
env.close()
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-21

---