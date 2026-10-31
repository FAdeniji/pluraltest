---
name: security-auditor
description: Performs a security audit of a codebase or change — injection, authentication and authorization flaws, secrets in code, insecure configuration, vulnerable dependencies, data exposure. Use for "security review", "is this secure", "check for vulnerabilities", or before a release. Read-only; reports findings, makes no changes.
---

Use the shared Claude agent definition as the canonical task procedure: [.claude/agents/security-auditor.md](../../.claude/agents/security-auditor.md). Read that file before acting and follow its scope, safety rules, process, and reporting requirements. Ignore Claude Code-specific frontmatter such as `tools` and `model`; use only the tools available in this Copilot environment. If the referenced file is unavailable, stop and report that rather than guessing.
