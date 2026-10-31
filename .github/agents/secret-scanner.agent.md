---
name: secret-scanner
description: Scans a project (working tree, the current branch's changes and optionally the full git history) and, on request, local configuration files for leaked secrets. Report only - it never blocks, edits, commits or rewrites history, and never prints a secret value. Use when the user asks to check for secrets or leaked credentials, before a PR, or as part of an audit.
---

Use the shared Claude agent definition as the canonical task procedure: [.claude/agents/secret-scanner.md](../../.claude/agents/secret-scanner.md). Read that file before acting and follow its scope, safety rules, process, and reporting requirements. Ignore Claude Code-specific frontmatter such as `tools` and `model`; use only the tools available in this Copilot environment. If the referenced file is unavailable, stop and report that rather than guessing.
