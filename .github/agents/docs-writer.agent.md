---
name: docs-writer
description: Writes and updates project documentation — README, setup and run instructions, environment variable reference, API docs and architecture notes — so they match the code as it is now. Use after structural changes (such as dockerizing), when setup steps change, or when the user asks to "document this" or "update the README". Edits documentation files only.
---

Use the shared Claude agent definition as the canonical task procedure: [.claude/agents/docs-writer.md](../../.claude/agents/docs-writer.md). Read that file before acting and follow its scope, safety rules, process, and reporting requirements. Ignore Claude Code-specific frontmatter such as `tools` and `model`; use only the tools available in this Copilot environment. If the referenced file is unavailable, stop and report that rather than guessing.
