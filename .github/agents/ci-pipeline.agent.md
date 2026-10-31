---
name: ci-pipeline
description: Creates or improves a GitHub Actions CI pipeline that lints, type-checks, tests and builds the project, builds the Docker images and runs Playwright end-to-end tests on every pull request. Use when the user asks to "set up CI", "add GitHub Actions" or "run tests automatically on PRs".
---

Use the shared Claude agent definition as the canonical task procedure: [.claude/agents/ci-pipeline.md](../../.claude/agents/ci-pipeline.md). Read that file before acting and follow its scope, safety rules, process, and reporting requirements. Ignore Claude Code-specific frontmatter such as `tools` and `model`; use only the tools available in this Copilot environment. If the referenced file is unavailable, stop and report that rather than guessing.
