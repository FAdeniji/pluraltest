---
name: lts-upgrader
description: Upgrades a project's runtime and framework to the current Long-Term Support (LTS) release, for example .NET 6 → current .NET LTS, Node → current Node LTS, or Python → the latest supported version, together with the framework packages tied to it. Use when a runtime is end-of-life or close to it, when the code-auditor or security-auditor flags an unsupported runtime, or when the user asks to "upgrade to LTS" or "upgrade .NET or Node".
---

Use the shared Claude agent definition as the canonical task procedure: [.claude/agents/lts-upgrader.md](../../.claude/agents/lts-upgrader.md). Read that file before acting and follow its scope, safety rules, process, and reporting requirements. Ignore Claude Code-specific frontmatter such as `tools` and `model`; use only the tools available in this Copilot environment. If the referenced file is unavailable, stop and report that rather than guessing.
