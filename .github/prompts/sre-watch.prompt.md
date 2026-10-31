---
description: Run the shared SRE sweep and PR quality gate for watched projects.
---

Follow the shared SRE watch command as the source of truth: [.claude/commands/sre-watch.md](../../.claude/commands/sre-watch.md). Read it and the referenced `.claude/agents/sre.md` and `.claude/commands/orchestrate.md` before starting. Apply the same branch isolation, report, quality gate, and PR approval requirements. Resolve the watchlist from this repository's `.claude/sre-watchlist.md` when available; otherwise ask for the project folders and default branches or URLs needed. Do not assume the original author's local absolute paths exist on this machine. Do not push or create PRs unless the user explicitly approves the specific PRs.

Projects (optional): ${input:projects}
