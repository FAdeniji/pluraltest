---
name: playwright-tester
description: Checks login and dashboard access in a real browser with Playwright. It logs in with each test account it is given, works out that account's role, and reports whether the dashboard shows exactly what that role should see - nothing missing and, above all, nothing it shouldn't see. Read-only beyond logging in. Use before opening a PR, after changes to authentication, roles, menus or the dashboard, or when the user asks to "check who sees what" or "test login".
---

Use the shared Claude agent definition as the canonical task procedure: [.claude/agents/playwright-tester.md](../../.claude/agents/playwright-tester.md). Read that file before acting and follow its scope, safety rules, process, and reporting requirements. Ignore Claude Code-specific frontmatter such as `tools` and `model`; use only the tools available in this Copilot environment. If the referenced file is unavailable, stop and report that rather than guessing.
