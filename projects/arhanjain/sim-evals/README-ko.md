# DROID 시뮬레이션 평가

이 저장소에는 간단한 ISAAC 시뮬레이션 환경에서 DROID 정책을 평가하기 위한 스크립트가 포함되어 있습니다.

다음은 pi0-FAST-DROID 정책의 예시 실행 결과입니다:

장면 1

![장면 1](https://raw.githubusercontent.com/arhanjain/sim-evals/main/./docs/scene1.gif)

장면 2

![장면 2](https://raw.githubusercontent.com/arhanjain/sim-evals/main/./docs/scene2.gif)

장면 3

![장면 3](https://raw.githubusercontent.com/arhanjain/sim-evals/main/./docs/scene3.gif)

이 시뮬레이션은 실제 DROID 데이터셋에서 학습된 DROID 정책과 *제로샷*으로 작동하도록 조정되어 별도의 시뮬레이션 데이터가 필요하지 않습니다.

**참고:** 현재 시뮬레이터는 *관절 위치* 행동 공간으로 학습된 정책(및 *관절 속도* 제어가 아닌)에서 가장 잘 작동합니다. 아래에는 관절 위치 제어로 학습된 pi0-FAST-DROID 정책을 평가하는 예제를 제공합니다.


## 설치

저장소를 클론하세요
```bash
git clone --recurse-submodules git@github.com:arhanjain/sim-evals.git
cd sim-evals
```

uv 설치 (참조: https://github.com/astral-sh/uv#installation)

예를 들어 (Linux/macOS):
```bash
curl -LsSf https://astral.sh/uv/install.sh | sh
```
가상 환경 생성 및 활성화

```bash
uv sync
source .venv/bin/activate
```

## 빠른 시작

먼저, 시뮬레이션 자산을 이 디렉터리의 루트에 다운로드했는지 확인하세요
```bash
uvx hf download owhan/DROID-sim-environments --repo-type dataset --local-dir assets
```

그런 다음, 별도의 터미널에서 `localhost:8000`에서 정책 서버를 실행합니다.  
예를 들어, pi0-FAST-DROID 정책(관절 위치 제어)을 실행하려면,  
[openpi](https://github.com/Physical-Intelligence/openpi)를 확인하고 `polaris` 구성을 사용하세요.  
```bash
XLA_PYTHON_CLIENT_MEM_FRACTION=0.5 uv run scripts/serve_policy.py policy:checkpoint --policy.config=pi05_droid_jointpos_polaris --policy.dir=gs://openpi-assets/checkpoints/pi05_droid_jointpos
```

**참고**: JAX가 모든 GPU 메모리를 독점하지 않도록 `XLA_PYTHON_CLIENT_MEM_FRACTION=0.5`로 설정했습니다(Isaac Sim이 동일 GPU를 사용하는 경우 대비).

마지막으로, 평가 스크립트를 실행합니다:
```bash
python run_eval.py --episodes [INT] --scene [INT] --headless
```

## 최소 예제

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