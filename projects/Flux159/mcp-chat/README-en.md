# mcp-chat

Open Source Generic MCP Client for testing & evaluating mcp servers and agents

<p align="center">
  <img width="600" src="https://raw.githubusercontent.com/Flux159/mcp-chat/refs/heads/main/mcpchat.svg">
</p>

## Quickstart

Make sure that you have `ANTHROPIC_API_KEY` exported in your environment or in a .env file in the root of the project. You can get an API key by signing up at the [Anthropic Console keys page](https://console.anthropic.com/settings/keys).

Simple use case that spawns an interactive chat prompt with the filesystem MCP server from CLI:

```shell
npx mcp-chat --server "npx -y @modelcontextprotocol/server-filesystem /Users/$USER/Desktop"
```

This will open up a chat prompt that you can use to interact with the servers and chat with an LLM.

## Config

You can also just specify your claude_desktop_config.json (Mac):

```shell
npx mcp-chat --config "~/Library/Application Support/Claude/claude_desktop_config.json"
```
Or (Windows):


```shell
npx mcp-chat --config "%APPDATA%\Claude\claude_desktop_config.json"
```

## Web mode

https://github.com/user-attachments/assets/b7e8a648-8084-4955-8cdf-fc6eb141572e

You can also run mcp-chat in web mode by specifying the `--web` flag (make sure to have `ANTHROPIC_API_KEY` exported in your environment):

```shell
npx mcp-chat --web
```
In web mode, you can start new chats, send messages to the model, and dynamically configure the mcp servers via the UI - no need to specify on the command line. In addition, chats created via the Web UI are saved to ~/.mcpchats/chats just like chats created via the CLI.

## Features

- [x] Run via CLI in interactive mode or directly pass prompts with `-p`
- [x] Web mode to chat with models via a web interface `--web`
- [x] Connect to any MCP server (JS, Python, Docker) in production or during development
- [x] Choose between models with `-m`
- [x] Customize system prompt with `--system`
- [x] Saves chat history with settings in `~/.mcpchat/chats` including web chats
- [x] Save and restore commands in `~/.mcpchat/history`
- [x] View tool call output and arguments directly in chat to help debug mcp servers

## CLI Usage

Run prompts via CLI with the `-p` flag:


```shell
npx mcp-chat --server "npx mcp-server-kubernetes" -p "List the pods in the default namespace"
```

This runs the prompt with the Kubernetes mcp-server & exits after the response is received on stdout.

Choose a model to chat with via CLI with the `-m` flag:

```shell
npx mcp-chat --server "npx mcp-server-kubernetes" -m "claude-3.5"
```

Uses the model `claude-3.5` to chat with. Note that currently only Anthropic models are supported.

Custom system prompt:

`--system` flag can be used to specify a system prompt:

```shell
npx mcp-chat --system "Explain the output to the user in pirate speak." --server "npx mcp-server-kubernetes" -p "List the pods in the default namespace"
```

## ENV vars

Mcp-chat supports passing through env vars to mcp servers. This is not standardized in the mcp spec though and other clients may not do this with dynamic env var values - read more [here](https://github.com/Flux159/mcp-server-kubernetes/issues/148#issuecomment-2950181666) about standard stdio mcp clients.

```shell
KUBECONFIG="~/.kube/config" npx mcp-chat --server "npx mcp-server-kubernetes"
```

## For developers of mcp-servers

You can pass in a local build of a python or node mcp-server to test it out with mcp-chat:

Node JS:

```shell
# Directly executing built script
npx mcp-chat --server "/path/to/mcp-server-kubernetes/dist/index.js"
# Using node / bun
npx mcp-chat --server "node /path/to/mcp-server-kubernetes/dist/index.js"
```

Python:

```shell
# Python: Using uv
npx mcp-chat --server "uv --directory /path/to/mcp-server-weather/ run weather.py"
# Using python / python3 - make sure to run in venv or install deps globally
npx mcp-chat --server "/path/to/mcp-server-weather/weather.py"
```

## Development

Install dependencies & run the CLI:

```shell
git clone https://github.com/Flux159/mcp-chat
bun install
bun run dev
```

To develop mcp-chat while connecting to an mcp-server, make a build & run the CLI with the server flag:

```shell
npm run build && node dist/index.js --server "npx mcp-server-kubernetes" -p "List the pods in the default namespace"
```
Testing:


```shell
bun run test
```
Building:


```shell
bun run build
```
Publishing:


```shell
bun run publish
```
Publishing Docker:


```shell
bun run dockerbuild
```

### Project Structure

```
├── src/
│   ├── index.ts            # Main client implementation & CLI params
│   ├── constants.ts        # Default constants
│   ├── interactive.ts      # Interactive chat prompt handling & logic
├── test/                   # Test files
│   ├── cli.test.ts         # Test CLI params
│   ├── config.test.ts      # Test config file parsing
```

## Publishing new release

Go to the [releases](https://github.com/Flux159/mcp-chat/releases) page, click on "Draft New Release", click "Choose a tag" and create a new tag by typing out a new version number using "v{major}.{minor}.{patch}" semver format. Then, write a release title "Release v{major}.{minor}.{patch}" and description / changelog if necessary and click "Publish Release".

This will create a new tag which will trigger a new release build via the cd.yml workflow. Once successful, the new release will be published to npm. Note that there is no need to update the package.json version manually, as the workflow will automatically update the version number in the package.json file & push a commit to main.

## License

[MIT License](https://github.com/Flux159/mcp-chat/blob/main/LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-21

---