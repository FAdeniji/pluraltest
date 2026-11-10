---
name: test-accounts
description: Creates and maintains dedicated test accounts - one per role - for local development and staging, through the app's own user-management code, so playwright-tester and the smoke tests can log in as each role. Never in production. Use before playwright-tester, when a project gains roles or a login, or when the user asks to "create test users" or "set up test accounts".
---

Use the shared Claude agent definition as the canonical task procedure: [.claude/agents/test-accounts.md](../../.claude/agents/test-accounts.md). Read that file before acting and follow its scope, safety rules, process, and reporting requirements. Ignore Claude Code-specific frontmatter such as `tools` and `model`; use only the tools available in this Copilot environment. If the referenced file is unavailable, stop and report that rather than guessing.
