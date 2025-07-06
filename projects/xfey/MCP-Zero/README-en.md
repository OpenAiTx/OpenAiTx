## MCP-Zero: Active Tool Discovery for Autonomous LLM Agents

<div style="display: flex; align-items: center; gap: 10px; margin-bottom: 10px;">
  <!-- <img src="https://raw.githubusercontent.com/xfey/MCP-Zero/master/assets/robot.png" alt="MCP-Zero Robot" width="24" height="24"> -->
  <a href="https://arxiv.org/abs/2506.01056">
    <img src="https://img.shields.io/badge/Paper-arXiv-red">
  </a>
  <a href="https://arxiv.org/abs/2506.01056">
    https://arxiv.org/abs/2506.01056
  </a>
</div>


Thank you for your attention to MCP-Zero! 🤗

We have now open-sourced the code involved in the paper. We will continue to update our work, explore its application in the industry, and continue to expand this project.


<div align="center">
  <img src="https://raw.githubusercontent.com/xfey/MCP-Zero/master/assets/fig1.png" alt="MCP-Zero workflow">
  <p> Using MCP-Zero to proactively construct toolchains for "Making a great meal"</p>
</div>


### Method: MCP-Zero

```
MCP-zero/
├── experiment_apibank.py       # experiments: APIBank
├── experiment_mcptools.py      # experiments: mcp_tools (needle test)
├── matcher.py                  # code for similarity matching
├── prompt_guide/               # prompts for our method
├── reformatter.py              # json formatter for tool description
├── sampler.py                  # sampler for selecting target tool
├── test_cases.jsonl            # testcase for the matcher
├── test_matcher.py             # unit test for the matcher
└── utils.py                    # utils: grid_search
```

We have now released our code for the paper. The code in the paper implements retrieval capabilities and achieves concrete results in experiments.

In our future work, we are committed to applying MCP-zero to the industry, so other modules still need to be involved, such as the dynamic deployment of MCP servers, the environment deployment for GAIA test, etc. We will continue to improve our work, and thank you all for your attention to this work. Leave a star🌟 to let me know you are staying updated :D



### Dataset: MCP-tools

- **Google Drive**: [Download Link](https://drive.google.com/file/d/1RjBGU-AGdHdhUABoeYSztbfQlD0hjUBn/view?usp=sharing)
- **Huggingface Link**: Coming soon
- **Put the file at**: `./MCP-tools/mcp_tools_with_embedding.json`


**Introduction**: A dataset containing all filtered tools (308 servers and 2,797 tools in total) from the MCP official repo.

**Data structure**:
```
{
  "server_name": string, // The name of the MCP server, extracted or inferred from the README
  "server_summary": string, // A summary of the server's purpose and capabilities, based on all relevant parts of the README.
  "server_description": string, // Description from metadata. 
  "description_embedding": float[3072], // The embedding of the server description from text-embedding-3-large
  "summary_embedding": float[3072], // The embedding of the server summary from text-embedding-3-large
  "tools": [
    {
      "name": string, // The function/tool name
      "description": string, // A concise description of what the tool does
      "description_embedding": float[3072], // The embedding of the tool description from text-embedding-3-large
      "parameter": { // A dictionary of input parameters, being included if explicitly defined
        "param1": "(type) description1",
        "param2": "(Optional, type) description2"
      }
    }
  ]
}
```

**Build dataset on your own**: If you want to build custom dataset for MCP servers, you may follow the code under the `MCP-tools/build_data` folder.

```
MCP-tools/
├── build_data
│   ├── get_server_summary.py       # code to extract structural data for MCP server's ReadMe file
│   ├── run_vllm.sh                 # deploy the Qwen2.5-72B-Instruct model with VLLM
│   └── server_summary.prompt       # the prompt for extracting dataset
└── download_data.md
```


### Citation

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