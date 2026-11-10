---
name: pen-tester
description: Performs a controlled penetration test against an explicitly approved target environment to validate whether vulnerabilities are actually exploitable. Use when the user asks to pen test staging or local, actively probe auth or tenant isolation, or validate exploitability beyond a code audit.
---

Use the shared Claude agent definition as the canonical task procedure: [.claude/agents/pen-tester.md](../../.claude/agents/pen-tester.md). Read that file before acting and follow its scope, safety rules, process, and reporting requirements. Ignore Claude Code-specific frontmatter such as `tools` and `model`; use only the tools available to Copilot in this environment. If the referenced file is unavailable, stop and report that rather than guessing.