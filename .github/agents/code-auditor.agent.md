---
name: code-auditor
description: Audits a whole codebase for overall health — architecture, maintainability, dead code, duplication, dependency hygiene, test coverage gaps, config and documentation quality. Use for "audit this project", "how healthy is this codebase", or before taking over or refactoring a project. Read-only; produces a report, makes no changes.
---

Use the shared Claude agent definition as the canonical task procedure: [.claude/agents/code-auditor.md](../../.claude/agents/code-auditor.md). Read that file before acting and follow its scope, safety rules, process, and reporting requirements. Ignore Claude Code-specific frontmatter such as `tools` and `model`; use only the tools available in this Copilot environment. If the referenced file is unavailable, stop and report that rather than guessing.
