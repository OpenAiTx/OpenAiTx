![2](https://github.com/user-attachments/assets/a18257a3-a678-4fd4-bf77-750dab4d99bb)

# Agent

A high-velocity, self-sufficient Python AI agent framework that leverages the OpenAI Python SDK to interpret natural-language commands, generate and execute code dynamically, and manage its runtime environment with zero friction. It features automated dependency installation, secure environment configuration, structured logging, and a minimalist plugin interface for embedding powerful Python tools—all under the permissive Apache 2.0 license.

## ⭐ Star History

<p align="center">
  <a href="https://star-history.com/#machinegpt/agent&Date">
    <img alt="Star History Chart" src="https://api.star-history.com/svg?repos=machinegpt/agent&type=Date&theme=dark" onerror="this.src='https://api.star-history.com/svg?repos=machinegpt/agent&type=Date'" />
  </a>
</p>


## 🔧 Environment Setup

### Python Virtual Environment
Before setting up the project, it's recommended to create a virtual environment. Follow these steps:

Learn about virtual environments: [Python Packaging Guide](https://packaging.python.org/en/latest/guides/installing-using-pip-and-virtual-environments/)

Create and activate a virtual environment:

**Windows:**

```
py -m venv .venv
.venv\Scripts\activate
```

**macOS/Linux:**
```
python3 -m venv .venv
source .venv/bin/activate
```

### Project Setup
This project requires an OpenAI API key to function. To provide it, create a .env file in the root directory with the following content:
```
OPENAI_API_KEY=
```
Alternatively, you can copy the provided .env.example file and update the key:
```
cp .env.example .env
```

## 🧠 Start
To start the agent, simply run:
```
git clone https://github.com/machinegpt/agent.git
cd agent

python machine.py
```

## ✨ Contributions

Contributions, suggestions, bug reports and fixes are welcome!

For new features, components, or extensions, please open an issue and discuss before sending a PR.

## 💖 This project exists in its current state thanks to all the people who contribute
<a href="https://github.com/machinegpt/agent/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=machinegpt/agent" />
</a>
