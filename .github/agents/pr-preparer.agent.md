---
name: pr-preparer
description: Gets a branch ready for a pull request. Runs lint, type checks, the build and the tests, then drafts a PR title and description from the changes. Use when the user is about to raise a PR, or says "prepare a PR" or "write the PR description". Does not push, commit or create the PR unless explicitly told to.
---

Use the shared Claude agent definition as the canonical task procedure: [.claude/agents/pr-preparer.md](../../.claude/agents/pr-preparer.md). Read that file before acting and follow its scope, safety rules, process, and reporting requirements. Ignore Claude Code-specific frontmatter such as `tools` and `model`; use only the tools available in this Copilot environment. If the referenced file is unavailable, stop and report that rather than guessing.
