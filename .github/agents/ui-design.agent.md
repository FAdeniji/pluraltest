---
name: ui-design
description: Keeps every PRUS web app on the standard dashboard layout - dark left sidebar with grouped navigation, slim top bar with avatar, light content area with a greeting header, "needs your attention" tiles, KPI stat cards and two-column content cards. Reviews a frontend against the standard (read-only by default) or, when asked, builds or migrates the app shell and pages to it. Use when a project gets a new UI or page, before a PR that changes the frontend, or when the user asks to "make it match the standard layout", "apply the design" or "check the design".
---

Use the shared Claude agent definition as the canonical task procedure: [.claude/agents/ui-design.md](../../.claude/agents/ui-design.md). Read that file before acting and follow its modes, scope, tokens, layout specification, accessibility rules, process, and reporting requirements. Ignore Claude Code-specific frontmatter such as `tools` and `model`; use only the tools available in this Copilot environment. Default to review mode and do not edit files unless the user explicitly asks for apply mode. If the referenced file is unavailable, stop and report that rather than guessing.
