# opencode-anthropic-oauth

OpenCode plugin for Anthropic Claude Pro/Max OAuth login — no Claude Code needed.

## What it does

Lets you authenticate with your Claude Pro/Max subscription directly in OpenCode via browser OAuth. No need to install Claude Code or manage credentials files.

## Installation

```bash
npm install -g opencode-anthropic-oauth
```

Then add to your `opencode.json`:

```json
{
  "plugin": ["opencode-anthropic-oauth"]
}
```

## Usage

1. Run `/connect` in OpenCode (or `oc auth login` from CLI)
2. Select **Anthropic** > **Claude Pro/Max**
3. Open the link in your browser and authorize
4. Paste the code back into OpenCode
5. Done — all Anthropic models are now available

## How it works

- Implements the OAuth PKCE flow directly against Anthropic's auth endpoints
- Opens your browser for authentication — you log in with your Claude account
- Exchanges the authorization code for access + refresh tokens
- **Auto-refreshes tokens** when they expire — no manual re-auth needed
- Sets the required API headers on Anthropic requests
- **Preserves prompt caching** for efficient token usage

## Changelog

### 0.4.1
- **Fixed high token consumption** — removed `cache_control` stripping that was disabling prompt caching
- Added `x-anthropic-billing-header` for proper token tracking
- Aligned beta flags with official Claude CLI plugin

### 0.4.0
- Added `?beta=true` URL parameter for OAuth compatibility
- Injected system identity prefix for claude-code beta
- Stripped `cache_control` (now removed in 0.4.1)

### 0.3.0
- Added auto token refresh via loader hook
- Background proactive refresh timer (5min intervals)

## Environment variable overrides

All OAuth parameters can be overridden via environment variables. If Anthropic changes something before we publish an update, set an env var and keep working:

| Variable | Description |
|---|---|
| `ANTHROPIC_CLIENT_ID` | OAuth client ID |
| `ANTHROPIC_CLI_VERSION` | Claude CLI version for User-Agent |
| `ANTHROPIC_USER_AGENT` | Full User-Agent string (overrides version) |
| `ANTHROPIC_AUTHORIZE_URL` | OAuth authorization endpoint |
| `ANTHROPIC_TOKEN_URL` | OAuth token endpoint |
| `ANTHROPIC_REDIRECT_URI` | OAuth redirect URI |
| `ANTHROPIC_SCOPES` | OAuth scopes |
| `ANTHROPIC_BETA_FLAGS` | Anthropic beta feature flags |

Example:

```bash
export ANTHROPIC_CLI_VERSION=2.2.0
```

## Disclaimer

This plugin uses Anthropic's public OAuth client ID to authenticate. Anthropic's Terms of Service (February 2026) state that Claude Pro/Max subscription tokens should only be used with official Anthropic clients. This plugin exists as a community workaround and may stop working if Anthropic changes their OAuth infrastructure. Use at your own discretion.

## License

MIT
