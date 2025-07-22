Release : Alpha 1.0.5

<div style="display:flex; width:100%; column-gap:16px; margin-bottom:12px;">
    <span>Compatibility :</span>
    <img style="width:24px; height:24px;" src="https://github.com/ask0ldd/OsspitaUI/blob/main/Front/src/assets/windows.png">
    <img style="width:24px; height:24px;" src="https://github.com/ask0ldd/OsspitaUI/blob/main/Front/src/assets/chrome.png">
    <img style="width:24px; height:24px;" src="https://github.com/ask0ldd/OsspitaUI/blob/main/Front/src/assets/firefox.png">
    <img style="width:24px; height:24px;" src="https://github.com/ask0ldd/OsspitaUI/blob/main/Front/src/assets/brave.png">
    <span style="display:flex; height:100%;">&</span>
    <img style="width:24px; height:24px;" src="https://github.com/ask0ldd/OsspitaUI/blob/main/Front/src/assets/ubuntu.png">
    <img style="width:24px; height:24px;" src="https://github.com/ask0ldd/OsspitaUI/blob/main/Front/src/assets/chrome.png">
    <img style="width:24px; height:24px;" src="https://github.com/ask0ldd/OsspitaUI/blob/main/Front/src/assets/firefox.png">
    <img style="width:24px; height:24px;" src="https://github.com/ask0ldd/OsspitaUI/blob/main/Front/src/assets/brave.png">
</div>

# OSSPITA : Run your AI assistant locally and experience an intuitive interface that allows you to tune all your agents with just a few clicks. Enjoy guaranteed privacy at no cost.

OSSPITA is a lightweight, fully local, open-source desktop interface that enables users to interact for free and in real time with various Open-Source LLMs. Leveraging the [Ollama API](https://github.com/ollama/ollama), OSSPITA provides a user-friendly experience for engaging with cutting-edge AI technology.

![osspita main](https://github.com/ask0ldd/OsspitaUI/blob/main/Front/src/assets/screenshot2.png "osspita main")

Video demo of the alpha 1.0.1 release, more up-to-date videos coming soon :

[![OSspita Video Demo](https://img.youtube.com/vi/zKxcANYu-9I/0.jpg)](https://www.youtube.com/watch?v=zKxcANYu-9I "OSspita Video Demo")<br>
_Click the image above to watch the video on YouTube_

## I - Features

- **Real-time interactions** with most Open-Source AI models.
- Lightweight and **fully local** operations.
- **Beginner-friendly** installation process.
- Multi-context agent tuning.
- **Llama Vision** support.
- Chat functionality with various historical figures.
- **Agent chaining** for complex task resolution.
- Retrieval Augmented Generation so you can probe your own documents while **preserving your privacy**.
- Web Search functionality for the integration of more **up-to-date information**.
- Comprehensive inference stats.
- Memory allocation tracking for **context length tuning**.
- **Prompt library** with (versioning coming).
- Easy access to the most **common LLM settings**.

## II - Coming Next

- **Responsive** design.
- **Parallel processing** added to Agent chaining.
- Improved Web Search algorithm with enhanced options.
- Online domain names ranking.
- Improved RAG algorithm with enhanced options.
- Online prompt and agent sharing platform.
- Prompt versioning system.
- Dedicated coding agent.
- Code syntax highlighting.
- A **Dark mode** theme.
- Charts generation.
- Voice mode.
- Context autosizing option.
- In-depth RAG stats & data.
- In-depth Web Search stats & data.

## III - Screenshots

![osspita main](https://github.com/ask0ldd/OsspitaUI/blob/main/Front/src/assets/screenshot1.png "osspita main")

## IV - Getting Started

### Prerequisites

- Node.js (v22.11.0 or higher) : https://nodejs.org/en/
- npm (10.9.0 or higher)
- Ollama (installed and running locally) : https://ollama.com/download
- The OSspita backend running.
- At least one open source model.
- Nvidia CUDA if needed : https://developer.nvidia.com/cuda-downloads

Models Recommandations :

| GPU VRAM   | Model            | Purpose        | Link                                                                 |
| ---------- | ---------------- | -------------- | -------------------------------------------------------------------- |
| 4GB        | Llama 3.2:3b     | Conversational | [Llama 3.2 on Ollama](https://ollama.com/library/llama3.2:3b)              |
| 8GB        | Aya Expanse:8b   | Conversational | [Aya Expanse on Ollama](https://ollama.com/library/aya-expanse:8b)   |
| 12GB       | Mistral Nemo:12b | Conversational | [Mistal Nemo on Ollama](https://ollama.com/library/mistral-nemo:12b)           |
| 4GB        | starcoder2:3b    | Coding         | [StarCoder2 on Ollama](https://ollama.com/library/starcoder2)        |
| 8GB & 12GB | qwen2.5-coder:7b | Coding         | [Qwen 2.5 Coder on Ollama](https://ollama.com/library/qwen2.5-coder) |

### Installation

Clone the repository :

> git clone https://github.com/ask0ldd/OsspitaUI.git

Navigate to the project directory:

> cd OsspitaUI

#### Frontend

> cd front

Install dependencies:

> npm install

Start the development server:

> npm run dev

Open your browser and visit http://localhost:5173 so that you can be guided through the rest of the installation process.

## V - Usage

Video demo :

## VI - Technologies Used

- React 18.3.1
- Vite
- Ollama API
- ExpressJS
- LokiJS
- Zustand
- Duck-duck-scrape
- Cheerio
- React-pdftotext
- Marked 14.1.1
- Turndown
- Cors
- BodyParser

## VII - Contributing

If you face any bug or if you want me to add / improve any functionality, open an issue with your request. Thanks a lot for your help.

## VIII - Acknowledgments

- Georgi Gerganov and all associated contributors for llama.cpp.
- The Ollama team for providing the API used for inference.
- React and Vite communities for their excellent tools.
- All contributors and supporters of the project.
- Everybody producing GGUF models.
- And finally, all the people that worked on any of the libraries I used.
