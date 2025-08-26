# Enhanced PubChem MCP Server for AI Assistants

🧪 An advanced, robust, and privacy-focused MCP server that enables AI assistants to intelligently search and access chemical compound information from PubChem.

This PubChem MCP Server acts as a powerful bridge between AI assistants (like those in AnythingLLM) and PubChem's vast chemical database. It leverages the Model Context Protocol (MCP) to allow AI models to perform smart, resilient searches for chemical compounds and retrieve their detailed properties programmatically.

---

## ✨ Core Features

This is not just another PubChem wrapper. This server has been rebuilt from the ground up to be highly robust and intelligent:

-   **🧠 Smart Fallback Search**: If a search for a common name (like "Vitamin D") fails, the server automatically performs a deeper search in the PubChem Substance database to find the correct compound. This dramatically improves success rates for ambiguous queries.
-   **🛡️ Robust Error Handling & Retries**: The server is designed to handle API errors gracefully. If it encounters a "Server Busy" error from PubChem, it will automatically wait and retry the request, ensuring your queries succeed even under heavy load.
-   **🔒 Optional Tor Proxy Support**: You have full control over your privacy. A simple `config.ini` file allows you to route all requests through the Tor network (via SOCKS5 or HTTP proxy), preventing your IP address from being exposed. The server is secure by default and will **never** leak your IP if the proxy connection fails.
-   **🔎 Single & Multiple Compound Search**: Seamlessly handles requests for one or multiple compounds in a single prompt.
-   **🧪 Detailed Property Retrieval**: Access key chemical properties like IUPAC Name, Molecular Formula, Molecular Weight, and crucially, **Monoisotopic Mass**.

---

---

### 🚀 No Installation Required: Try It Live on Smithery.ai

For those who are new to MCP servers or just want to test the capabilities of this tool without any local setup, a live, hosted version is available on Smithery.ai. This allows you to chat with the agent directly in your browser.

[**<-- Explore the Live PubChem Agent on Smithery.ai -->**](https://smithery.ai/server/@Milor123/smithery-pubchem-deploy)

**How to get started:**

1.  Click the link above to go to the server page.
2.  Sign in using your **GitHub** or **Google** account.
3.  Click the **"Explore capabilities"** button to open a chat interface and start testing!

> **✅ Recommended Models for Best Results**
>
> To get the highest accuracy, especially with long decimal numbers, we strongly recommend using powerful models. The following have been tested and work excellently with this tool:
>
> *   **Anthropic's Claude 3 Sonnet**
> *   **OpenAI's GPT-4 Turbo** (or newer versions like GPT-4o)
>
> We confirmed that both models correctly processed the full precision of the decimal numbers returned by the tool without any rounding.

---

## 🚀 Quick Start & Installation

This server is designed to be run locally, either on your desktop or within the AnythingLLM Docker environment.

### 1. Dependencies

This project relies on a few Python libraries. Make sure they are installed in your environment.

Create a `requirements.txt` file with the following content:
```txt
requests
bs4 
mcp 
pubchempy
pandas
PySocks
```

Install them using `uv` or `pip`:
```bash
uv venv
.venv\Scripts\activate
uv pip install -r requirements.txt
```
*(Note: `PySocks` is only required if you plan to use the Tor SOCKS5 proxy feature.)*

### 2. Configuration

The server is configured via a `config.ini` file that is **automatically created** the first time you run it. This file will appear in the same directory as the `pubchem_server.py` script.

**Default `config.ini`:**
```ini
[proxy]
# Change 'use_proxy' to 'true' to route all requests through a proxy.
# Essential for protecting your privacy if you use Tor.
use_proxy = false

# Defines the proxy type. Options:
#   socks5h  -> (Recommended for Tor) The native SOCKS proxy for Tor. More secure.
#   http     -> An HTTP proxy. If using Tor, requires additional configuration.
proxy_type = socks5h

# The proxy address. THIS IS A CRITICAL SETTING!
#   - If you run this script on your DESKTOP, use: 127.0.0.1
#   - If you run this script inside DOCKER, use: host.docker.internal
host = 127.0.0.1

# The proxy port.
#   9050 -> Default port for Tor's SOCKS proxy.
#   8118 -> Default port for Tor's HTTP proxy (if enabled).
port = 9050
```

### 3. Integration with AnythingLLM

Follow the official documentation to add this as a custom MCP server. The key is to point the `command` to your Python executable and the `pubchem_server.py` script.

**Example for AnythingLLM Desktop (`plugins/anythingllm_mcp_servers.json`):**
```json
{
  "mcpServers": {
    "pubchem": {
      "name": "PubChem Server (Enhanced)",
      "transport": "stdio",
      "command": "\"C:\\path\\to\\your\\.venv\\Scripts\\python.exe\" \"C:\\path\\to\\your\\project\\pubchem_server.py\"",
      "cwd": "C:\\path\\to\\your\\project"
    }
  }
}
```


### 3.1 Implementation Examples with AnythingLLM

Here are some examples of how to interact with the agent. These tests were conducted using AnythingLLM Desktop, connecting to various Large Language Models via OpenRouter.

A crucial finding from our testing is the importance of the model you choose. We **strongly recommend against using small or local models** for this task. Smaller models often struggle to correctly parse the data returned by the tool, leading to errors such as hallucinated values, incorrect formatting, or, most critically, **rounding decimal numbers**, which defeats the purpose of this high-precision tool.

To ensure the integrity of your results, it's always a good practice to verify the raw data returned by the MCP. You can learn how to do this in the next section: [3.2 How to verify MCP outputs in the logs](#32-how-to-verify-mcp-outputs-in-the-logs).

<img width="837" height="1060" alt="imagen" src="https://github.com/user-attachments/assets/5a16c7a2-d65d-4d64-98dd-f3cb4cae9b22" />

On the other hand, several models have demonstrated excellent performance. We achieved outstanding results with  **Google's `Gemini 2.5 Flash lite`**. showed remarkable precision in handling long decimal numbers and correctly formatting the final Markdown table.

Google gemini 2.5 flash lite without prompt and with prompt keep perfect decimals (in the example use 0.6 of temperature)

<img width="1089" height="1061" alt="imagen" src="https://github.com/user-attachments/assets/4574efa5-d6d9-49e3-a665-a39a427f09a1" />

For this specific task, my personal favorite is **`Gemini 2.5 Flash lite`** due to its consistent accuracy and reliability.

### 3.2 How to Verify MCP Outputs in the Logs

The best way to confirm that the agent is receiving the correct data and that the LLM is not making mistakes is to check the debug log file generated by the MCP server.

This server is configured to automatically create a log file in a subfolder within your project directory. The location will be:

```
your-project-folder/
└── logs_mcp/
    └── mcp_debug.log
```

Inside `mcp_debug.log`, you will find the exact JSON data that the tool sends back to the LLM *before* the model processes it. You can manually inspect this JSON to verify any values, especially long decimal numbers from properties like `monoisotopic_mass`, ensuring that the LLM has not introduced any rounding errors or hallucinations in its final answer.

---

## 📊 Usage

Once integrated, your AI assistant will automatically use this tool when asked about chemical information. The primary tool exposed is `search_compounds_by_name`.

### Example Prompt

This prompt demonstrates the tool's ability to handle a list of compounds with varying name types and retrieve multiple properties.

```
@agent
Please use your PubChem tool to find information on the following compounds:

- Thiamine (Vitamin B1)
- Riboflavin (Vitamin B2)
- Folic Acid
- Hydroxocobalamin

For each compound found, please retrieve the IUPAC Name, Molecular Formula, and Monoisotopic Mass.

Present all the results in a single Markdown table.
```
The agent will call the `search_compounds_by_name` tool, which will intelligently find each compound, retrieve its data, and return it to the LLM for formatting.

---

## 🛠 MCP Tool Exposed

### `search_compounds_by_name`

Searches for multiple compounds by name, one by one, using a smart fallback strategy with pauses and retries for maximum reliability.

**Parameters:**
-   `names` (List[str]): A list of compound names. Example: `["Aspirin", "Ibuprofen"]`

**Returns:** A list of dictionaries, where each dictionary contains either the found compound's information or an error message detailing why the search failed for that specific compound.

---

## 🙏 Acknowledgements

This project was heavily inspired by and built upon the foundation of the original [PubChem-MCP-Server](https://github.com/JackKuo666/PubChem-MCP-Server) created by **JackKuo666**.

While this repository is not a direct fork, the original project was the crucial starting point. This version enhances the original concept with a focus on extreme robustness, intelligent search strategies, and user privacy through optional Tor integration 🧅.

Many thanks to the original author for their fantastic work and for sharing it with the community.

---

## ⚠️ Disclaimer

This tool is intended for research and educational purposes. Please respect PubChem's terms of service and use this tool responsibly.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-26

---