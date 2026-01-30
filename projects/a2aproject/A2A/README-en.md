# Agent2Agent (A2A) Protocol

[![PyPI - Version](https://img.shields.io/pypi/v/a2a-sdk)](https://pypi.org/project/a2a-sdk)
[![Apache License](https://img.shields.io/badge/License-Apache_2.0-blue.svg)](LICENSE)
<a href="https://codewiki.google/github.com/a2aproject/a2a">
  <img src="https://www.gstatic.com/_/boq-sdlc-agents-ui/_/r/Mvosg4klCA4.svg" alt="Ask Code Wiki" height="20">
</a>

<div style="text-align: left;">
  <details>
    <summary>🌐 Language</summary>
    <div>
      <div style="text-align: center;">
        <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=zh-CN">Simplified Chinese</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=zh-TW">Traditional Chinese</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=ja">Japanese</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=ko">Korean</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=hi">Hindi</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=th">Thai</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=fr">French</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=de">German</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=es">Spanish</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=it">Italian</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=ru">Russian</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=pt">Portuguese</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=nl">Dutch</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=pl">Polish</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=ar">Arabic</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=fa">Persian</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=tr">Turkish</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=vi">Vietnamese</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=id">Indonesian</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=as">Assamese</a>
      </div>
    </div>
  </details>
</div>

<!-- markdownlint-disable MD041 -->
<div style="text-align: center;">
  <div class="centered-logo-text-group">
    <img src="https://raw.githubusercontent.com/a2aproject/A2A/main/docs/assets/a2a-logo-black.svg" alt="Agent2Agent Protocol Logo" width="100">
    <h1>Agent2Agent (A2A) Protocol</h1>
  </div>
</div>

**An open protocol enabling communication and interoperability between opaque agentic applications.**

The Agent2Agent (A2A) protocol tackles a key challenge in the AI field: allowing gen AI agents, developed on various frameworks by different companies and running on separate servers, to communicate and collaborate efficiently—as agents, not merely as tools. A2A seeks to provide a unified language for agents, encouraging a more interconnected, capable, and innovative AI ecosystem.

With A2A, agents can:

- Discover each other's capabilities.
- Negotiate interaction modalities (text, forms, media).
- Collaborate securely on long-running tasks.
- Operate without exposing their internal state, memory, or tools.

## Intro to A2A Video

[![A2A Intro Video](https://img.youtube.com/vi/Fbr_Solax1w/hqdefault.jpg)](https://goo.gle/a2a-video)

## Why A2A?

As AI agents become more widespread, their ability to interoperate is vital for developing complex, multifunctional applications. A2A aims to:

- **Break Down Silos:** Connect agents across different ecosystems.
- **Enable Complex Collaboration:** Let specialized agents collaborate on tasks beyond the capabilities of a single agent.
- **Promote Open Standards:** Support a community-driven approach to agent communication, spurring innovation and broad adoption.
- **Preserve Opacity:** Enable agents to work together without revealing internal memory, proprietary logic, or specific tool details, strengthening security and safeguarding intellectual property.

### Key Features

- **Standardized Communication:** JSON-RPC 2.0 over HTTP(S).
- **Agent Discovery:** Through "Agent Cards" describing capabilities and connection details.
- **Flexible Interaction:** Supports synchronous request/response, streaming (SSE), and asynchronous push notifications.
- **Rich Data Exchange:** Supports text, files, and structured JSON data.
- **Enterprise-Ready:** Built with security, authentication, and observability in mind.

## Getting Started

- 📚 **Explore the Documentation:** Visit the [Agent2Agent Protocol Documentation Site](https://a2a-protocol.org) for a complete overview, the full protocol specification, tutorials, and guides.
- 📝 **View the Specification:** [A2A Protocol Specification](https://a2a-protocol.org/latest/specification/)
- Use the SDKs:
    - [🐍 A2A Python SDK](https://github.com/a2aproject/a2a-python) `pip install a2a-sdk`
    - [🐿️ A2A Go SDK](https://github.com/a2aproject/a2a-go) `go get github.com/a2aproject/a2a-go`
    - [🧑‍💻 A2A JS SDK](https://github.com/a2aproject/a2a-js) `npm install @a2a-js/sdk`
    - [☕️ A2A Java SDK](https://github.com/a2aproject/a2a-java) using maven
    - [🔷 A2A .NET SDK](https://github.com/a2aproject/a2a-dotnet) using [NuGet](https://www.nuget.org/packages/A2A) `dotnet add package A2A`
- 🎬 Use our [samples](https://github.com/a2aproject/a2a-samples) to see A2A in action

## Contributing

We welcome community contributions to enhance and evolve the A2A protocol!

- **Questions & Discussions:** Join our [GitHub Discussions](https://github.com/a2aproject/A2A/discussions).
- **Issues & Feedback:** Report issues or suggest improvements via [GitHub Issues](https://github.com/a2aproject/A2A/issues).
- **Contribution Guide:** See our [CONTRIBUTING.md](https://raw.githubusercontent.com/a2aproject/A2A/main/CONTRIBUTING.md) for details on how to contribute.
- **Private Feedback:** Use this [Google Form](https://goo.gle/a2a-feedback).
- **Partner Program:** Google Cloud customers can join our partner program via this [form](https://goo.gle/a2a-partner).

## What's next

### Protocol Enhancements

- **Agent Discovery:**
    - Formalize inclusion of authorization schemes and optional credentials directly within the `AgentCard`.
- **Agent Collaboration:**
    - Investigate a `QuerySkill()` method for dynamically checking unsupported or unanticipated skills.
- **Task Lifecycle & UX:**
    - Support for dynamic UX negotiation _within_ a task (e.g., agent adding audio/video mid-conversation).
- **Client Methods & Transport:**
    - Explore extending support to client-initiated methods (beyond task management).
    - Improvements to streaming reliability and push notification mechanisms.

## About

The A2A Protocol is an open source project under the Linux Foundation, contributed by Google. It is licensed under the [Apache License 2.0](LICENSE) and is open to contributions from the community.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-30

---