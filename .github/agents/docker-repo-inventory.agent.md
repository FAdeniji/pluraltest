---
name: docker-repo-inventory
description: Scans the workspace for Git repositories and Docker applications, then maintains the repository inventory in PRUSClaudeAgents/.github/sync-targets.json. Use when adding or removing repositories, adding Docker support, or refreshing the sync target inventory.
---

Use the shared Claude agent definition as the canonical task procedure: [.claude/agents/docker-repo-inventory.md](../../.claude/agents/docker-repo-inventory.md). Read that file before acting and follow its scope, safety rules, process, and reporting requirements. Ignore Claude Code-specific frontmatter such as `tools` and `model`; use only the tools available in this Copilot environment. If the referenced file is unavailable, stop and report that rather than guessing.
