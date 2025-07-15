![B2DVL Header](https://raw.githubusercontent.com/Thinklab-SJTU/Bench2Drive-VL/main/./assets/Bench2Drive-VL.png)

🚗 **Bench2Drive-VL** は自動運転におけるビジョン・言語モデル（VLM）のためのクローズドループ・フルスタックベンチマークです。VQAパートでは、ルールベースのエキスパートモデルDriveCommenterを用いてCARLAシミュレータ内（またはBench2Driveのような静的データセットから）でVQAの正解を生成します。計画ベンチマークには元のBench2Driveの指標を使用します。

<h2 align="center">
  <a href="https://thinklab-sjtu.github.io/Bench2Drive-VL/"> ドキュメント</a> |
  <a href="https://huggingface.co/datasets/Telkwevr/Bench2Drive-VL-base"> データセット</a>
</h2>

![B2DVL Structure](https://raw.githubusercontent.com/Thinklab-SJTU/Bench2Drive-VL/main/./assets/struct_new.png)

📚 Docker対応は現在進行中です...

![B2DVL Modules](https://raw.githubusercontent.com/Thinklab-SJTU/Bench2Drive-VL/main/./assets/modules_new.png)

## 使い方

### 環境設定

1. CARLAをインストールしてください：

    ```bash
    mkdir carla
    cd carla
    wget https://carla-releases.s3.us-east-005.backblazeb2.com/Linux/CARLA_0.9.15.tar.gz
    tar -xvf CARLA_0.9.15.tar.gz
    cd Import && wget https://carla-releases.s3.us-east-005.backblazeb2.com/Linux/AdditionalMaps_0.9.15.tar.gz
    cd .. && bash ImportAssets.sh
    export CARLA_ROOT=YOUR_CARLA_PATH
    echo "$CARLA_ROOT/PythonAPI/carla/dist/carla-0.9.15-py3.7-linux-x86_64.egg" >> YOUR_CONDA_PATH/envs/YOUR_CONDA_ENV_NAME/lib/python3.7/site-packages/carla.pth # python 3.8 also works well, please set YOUR_CONDA_PATH and YOUR_CONDA_ENV_NAME
    ```
2. CARLAをインストールした後、`env.sh`を書きます：


   ```bash
   export CARLA_ROOT=/path/to/your/carla

   export CARLA_SERVER=${CARLA_ROOT}/CarlaUE4.sh
   export PYTHONPATH=${CARLA_ROOT}/PythonAPI
   export PYTHONPATH=$PYTHONPATH:${CARLA_ROOT}/PythonAPI/carla
   export PYTHONPATH=$PYTHONPATH:$CARLA_ROOT/PythonAPI/carla/dist/carla-0.9.15-py3.7-linux-x86_64.egg

   export WORK_DIR=/path/to/this/repo
   export PYTHONPATH=$PYTHONPATH:${WORK_DIR}/scenario_runner
   export PYTHONPATH=$PYTHONPATH:${WORK_DIR}/leaderboard
   export PYTHONPATH=$PYTHONPATH:${WORK_DIR}/B2DVL_Adapter
   export SCENARIO_RUNNER_ROOT=${WORK_DIR}/scenario_runner
   export LEADERBOARD_ROOT=${WORK_DIR}/leaderboard

   export VQA_GEN=1
   export STRICT_MODE=1
   # DriveCommenter drives back the ego vehicle after circumventing obstacles if STRICT_MODE > 0,
   # must set to true if doing closed-loop eval.
   ```
3. 正しい環境変数が設定されていることを確認してください:


   ```shell
   source ./env.sh
   ```
### クローズドループ推論

1. vlm設定ファイルを作成します（例は`./vlm_config`にあります）：
   
   *これはJSONファイルなので、すべてのコメントを削除するのを忘れないでください！*
   
   *質問IDについては[ドキュメント](https://raw.githubusercontent.com/Thinklab-SJTU/Bench2Drive-VL/main/./docs/qids.md)を参照してください。*

   *アクションモジュールがその回答を必要とするため、質問50を必ず含めてください。*


    ```java
    {
        "TASK_CONFIGS": {
            "FRAME_PER_SEC": 10 // sensor saving frequency
        },
        "INFERENCE_BASICS": {
            "INPUT_WINDOW": 1, // frame count of given image input
            "CONVERSATION_WINDOW": 1, // not used anymore, to be removed
            "USE_ALL_CAMERAS": false, // true if use all cameras as input
            "USE_BEV": false, // true if use bev as input
            "NO_HISTORY_MODE": false // do not inherit context of previous VQAs
        },
        "CHAIN": { // for inference
            "NODE": [19, 15, 7, 24, 13, 47, 8, 43, 50],
            "EDGE": { // "pred": succ
                "19": [24, 13, 8],
                "15": [7, 8],
                "7": [8],
                "24": [13, 47],
                "13": [47, 8, 43],
                "47": [8],
                "8": [43],
                "43": [50],
                "50": []
            },
            "INHERIT": { // inherit context from last frame
                "19": [43, 7],
                "15": [7]
            },
            "USE_GT": [24] // questions which use ground truth as answer
        },
        "CONTROL_RATE": 2.0, // intervene freq of vlm
        "MODEL_NAME": "api", // model name
        "MODEL_PATH": "../model_zoo/your_model", // model path
        "GPU_ID": 0, // the gpu model runs on
        "PORT": 7023, // web port
        "IN_CARLA": true,
        "USE_BASE64": true, // if false, local path is used for transmitting images
        "NO_PERC_INFO": false // do not pass extra perception info to vlm via prompt
    }
    ```
2. 起動スクリプトの作成:
   
    *クイックスタートを希望する場合は、MINIMAL=1 を設定して VLM なしで Bench2Drive-VL を実行できます。*


    ```bash
    #!/bin/bash
    BASE_PORT=20082 # CARLA port
    BASE_TM_PORT=50000
    BASE_ROUTES=./leaderboard/data/bench2drive220
    TEAM_AGENT=leaderboard/team_code/data_agent.py
    BASE_CHECKPOINT_ENDPOINT=./my_checkpoint
    SAVE_PATH=./eval_v1/
    GPU_RANK=0 # the gpu carla runs on
    VLM_CONFIG=/path/to/your_vlm_config.json
    PORT=$BASE_PORT
    TM_PORT=$BASE_TM_PORT
    ROUTES="${BASE_ROUTES}.xml"
    CHECKPOINT_ENDPOINT="${BASE_CHECKPOINT_ENDPOINT}.json"
    export MINIMAL=0 # if MINIMAL > 0, DriveCommenter takes control of the ego vehicle,
    # and vlm server is not needed
    bash leaderboard/scripts/run_evaluation.sh $PORT $TM_PORT 1 $ROUTES $TEAM_AGENT "." $CHECKPOINT_ENDPOINT $SAVE_PATH "null" $GPU_RANK $VLM_CONFIG
    ```
3. VLMサーバーを起動します（`MINIMAL`の場合は不要です）


    ```shell
    python ./B2DVL_Adapter/web_interact_app.py --config /path/to/your/vlm_config.json
    ```
4. メインモジュールを開始する


    ```shell
    bash ./startup.sh
    ```
### DriveCommenterを使用して静的データセットからVQAを生成する

1. `./B2DVL-Adapter`内にスタートアップスクリプトを作成する


    ```bash
    #!/bin/bash
    export SUBSET=0 # generate from a subset of given dataset
    export STRICT_MODE=1
    # DriveCommenter drives back the ego vehicle after circumventing obstacles if STRICT_MODE > 0
    export SUBSET_PATH=./subset_0.txt # subset file
    export PROCESSED_PATH=./processed_paths_0.txt # checkpoint file
    export CACHE_PATH=./.worker_0_cache
    # DriveCommenter supports dataset in .tar.gz
    # it will unzip some of the dataset temporarily in cache dir
    python ./drive_commenter_main.py --data-directory=/path/to/Bench2Drive/dataset --output-graph-directory=./outgraph     --path-maps=${CARLA_ROOT}/CarlaUE4/Content/Carla/Maps     --worker-count=1
    # We do not recommend using multiple worker here since multi-thread in python is not very good.
    # You can run multiple DriveCommenter at the same time with different subset and checkpoint files to do the same.
    ```
2. 実行します。


    ```shell
    cd ./B2DVL-Adapter
    bash ./your_startup_script.sh
    ```
### オープンループ推論

1. コンフィグファイルを作成します。


    ```java
    {
        "TASK_CONFIGS": {
            "INFER_SUBSET": false, // inference a subset of given dataset
            "USE_CHECKPOINT": true, // record the process of inference
            "SUBSET_FILE": "./infer_configs/subset.txt", // subset file, leave blank if not used
            "CHECKPOINT_FILE": "./infer_configs/finished_scenarios.txt", // checkpoint file, leave blank if not used
            "ENTRY_EXIT_FILE": "./infer_configs/entry_exits.json", // the file which specifies entry and exit point of certain scenario, 
            // you can create a file with "{}" as content if do not specify
            "FRAME_PER_SEC": 10 // sensor frame
        },
        "INFERENCE_BASICS": {
            "INPUT_WINDOW": 1,
            "CONVERSATION_WINDOW": 2,
            "USE_ALL_CAMERAS": true,
            "NO_HISTORY_MODE": false,
            "APPEND_QUESTION": true,
            "APPENDIX_FILE": "./infer_configs/append_questions.json" // not used now, to be removed
        },
        "CHAIN": {
            "NODE": [43, 50],
            "EDGE": {
                "43": [50],
                "50": []
            },
            "INHERIT": {
                "19": [43, 7],
                "15": [7]
            },
            "USE_GT": []
        }
    }
    ```
2. 推論スクリプトを起動します:


    ```shell
    cd ./B2DVL_Adapter
    python inference.py --model Qwen2.5VL --model_path /path/to/Qwen2.5VL-3B-Instruct --config_dir /path/to/your_infer_config.json --image_dir /path/to/Bench2Drive/dataset --vqa_dir /path/to/vqa/dataset --num_workers 4 --out_dir ./infer_outputs
    ```
### 評価

1. 評価のためにあなたのllm APIを使用するには、`./B2DVL-Adapter`内に`mytoken.py`を作成してください。deepseekを例とします:


    ```python
    DEEPSEEK_TOKEN = [
        "your-token-1", # you can set multiple tokens, and they will be used in a round-robin way
        "your-token-2"...
    ]
    DEEPSEEK_URL = "https://api.deepseek.com/v1"
    ```
    それから、私たちのスクリプトは `openai` テンプレートを使用してこのAPIを呼び出します。



2. 設定ファイルを作成します：


    ```java
    {
        "EVAL_SUBSET": true, // eval a subset of given infer result folder
        "USE_CHECKPOINT": false, // use a file to record evaluation process
        "SUBSET_FILE": "./eval_configs/subset.txt", // subset file
        "CHECKPOINT_FILE": "./eval_configs/finished_scenarios.txt", // checkpoint file
        "INFERENCE_RESULT_DIR": "./infer_results", // path to inference results
        // when doing closed-loop inference, this dir is ./output/infer_results/model_name+input_mode
        "B2D_DIR": "/path/to/Bench2Drive/dataset", // evaluation script uses annotations in b2d,
        // when doing closed-loop inference, this dir is ./eval_v1(SAVE_PATH you specified)/model_name+input_mode
        "ORIGINAL_VQA_DIR": "../Carla_Chain_QA/carla_vqa_gen/vqa_dataset/outgraph",
        // when doing closed-loop inference, this dir is ./output/vqagen/model_name+input_mode
        "FRAME_PER_SEC": 10, // sensor fps
        "LOOK_FUTURE": false // not used now, to be removed
    }
    ```
2. 評価スクリプトを実行します：


    ```shell
    python eval.py --config_dir ./path/to/eval_config.json --num_workers 4 --out_dir ./eval_outputs
    ```
## ライセンス
すべてのアセットおよびコードは、特に明記がない限りCC-BY-NC-NDの下で提供されています。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-15

---