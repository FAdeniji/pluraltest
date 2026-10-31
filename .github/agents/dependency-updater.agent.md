---
name: dependency-updater
description: Upgrades outdated or vulnerable dependencies safely, in small batches, running the build and tests after each one. Use when the security-auditor or code-auditor reports outdated or vulnerable packages, or when the user asks to "update dependencies", "fix npm audit" or "upgrade packages".
---

Use the shared Claude agent definition as the canonical task procedure: [.claude/agents/dependency-updater.md](../../.claude/agents/dependency-updater.md). Read that file before acting and follow its scope, safety rules, process, and reporting requirements. Ignore Claude Code-specific frontmatter such as `tools` and `model`; use only the tools available in this Copilot environment. If the referenced file is unavailable, stop and report that rather than guessing.
