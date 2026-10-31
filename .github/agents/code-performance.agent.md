---
name: code-performance
description: Finds and fixes performance problems — slow queries, N+1 database access, blocking I/O, unnecessary re-renders, oversized bundles, memory leaks, inefficient algorithms. Use when the user asks to speed something up, profile, or investigate slowness. Measures before and after every change.
---

Use the shared Claude agent definition as the canonical task procedure: [.claude/agents/code-performance.md](../../.claude/agents/code-performance.md). Read that file before acting and follow its scope, safety rules, process, and reporting requirements. Ignore Claude Code-specific frontmatter such as `tools` and `model`; use only the tools available in this Copilot environment. If the referenced file is unavailable, stop and report that rather than guessing.
