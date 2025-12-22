# ExpeRepair

**ExpeRepair** is a novel LLM-based program repair framework that continuously accumulates and reuses historical repair experiences via a dual-memory system. It comprises two core components:
- **Program Repair Module**: Consists of a Test Agent and a Patch Agent that collaboratively handle three key tasks — test generation, patch generation, and patch validation.
- **Memory Module**: Captures repair trajectories from the Program Repair Module, extracting concrete demonstrations and summarizing high-level repair strategies. These are stored in **episodic memory** and **semantic memory**, respectively. During future repairs, ExpeRepair retrieves relevant demonstrations and insights to enhance its repair strategy for new issues.

## 🚀 Quick Start

### Installation
```bash
git clone <repository-url>
cd ExpeRepair-v1.0
pip install -r requirements.txt
```

### Environment Setup

Set your API keys as environment variables:
```bash
export PYTHONPATH=$PYTHONPATH:$(pwd)
# OpenAI key
export OPENAI_KEY="your-openai-key"
# Anthropic Key
export CLAUDE_KEY="your-anthropic-key"
```

Following [Agentless](https://arxiv.org/abs/2407.01489), ExpeRepair uses a **repository structure format** to localize suspicious files.
You can either preprocess the repositories yourself, or download the prepared data: [swebench_lite_repo_structure.zip](https://github.com/OpenAutoCoder/Agentless/releases/tag/v1.5.0).

After downloading, unzip and export its location:
```bash
export PROJECT_FILE_LOC={folder which you saved}
```

Finally, set up the testbed by following the instructions from the [auto-code-rover project](https://github.com/AutoCodeRoverSG/auto-code-rover#setting-up-testbed).

### Running ExpeRepair on the Full Benchmark
1. Run `run_reproduce_initial.sh` with **all instance IDs**.
2. Run `run_localization.sh` with **all instance IDs**.
3. For instances where reproduction succeeds (i.e., a valid `reproducer_X.py` script is generated), run `generate_initial.py`.
4. For the remaining instances, run `generate_w_memory.py`, which leverages the accumulated memory and continues updating it.
5. Finally, run `validation.py` and `obtain_predictions.py` with all instance IDs.


### Usage
```bash
# reproduce the issue
bash inference/run_reproduce_initial.sh

# localize potential bug locations
bash inference/run_localization.sh

# generate candidate patches
bash inference/run_generate.sh

# validate candidate patches and select the best one
python inference/validation.py

# obtain the prediction results
python inference/obtain_predictions.py
```

## 🙏 Acknowledgement 

* [SWE-bench](https://www.swebench.com/)
* [auto-code-rover](https://github.com/AutoCodeRoverSG/auto-code-rover)
* [Agentless](https://github.com/OpenAutoCoder/Agentless/)
