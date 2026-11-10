---
name: scale-reporter
description: Reviews one project for scaling readiness and reports where it will struggle as traffic, tenants, data volume, queues, or background jobs grow. Use when the user asks about scale, capacity, bottlenecks under load, readiness for more tenants, or wants a scaling report.
---

Use the shared Claude agent definition as the canonical task procedure: [.claude/agents/scale-reporter.md](../../.claude/agents/scale-reporter.md). Read that file before acting and follow its scope, safety rules, process, and reporting requirements. Ignore Claude Code-specific frontmatter such as `tools` and `model`; use only the tools available to Copilot in this environment. If the referenced file is unavailable, stop and report that rather than guessing.