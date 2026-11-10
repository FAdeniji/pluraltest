---
name: code-reviewer
description: Reviews recent code changes (uncommitted diff, a branch, or specific files) for bugs, logic errors, edge cases, readability, and consistency with the surrounding code. Use proactively after writing or modifying code, or when the user asks for a code review. Read-only.
---

Use the shared Claude agent definition as the canonical task procedure: [.claude/agents/code-reviewer.md](../../.claude/agents/code-reviewer.md). Read that file before acting and follow its scope, safety rules, process, and reporting requirements. Ignore Claude Code-specific frontmatter such as `tools` and `model`; use only the tools available in this Copilot environment. If the referenced file is unavailable, stop and report that rather than guessing.
