---
description: Route a project task through the shared PRUS specialist agents and orchestration workflow.
---

Follow the shared orchestration command as the source of truth: [.claude/commands/orchestrate.md](../../.claude/commands/orchestrate.md). Read it first, then follow its arguments, phases, task routing, safety rules, and quality gates. For each selected specialist, use the corresponding custom agent in `.github/agents/` (which references its canonical `.claude/agents/` definition). Run only the phases and agents required by the requested mode or task. If this Copilot environment cannot delegate to a selected custom agent, state that and carry out only work allowed by the source instructions; do not claim delegation occurred.

Task and arguments: ${input:task}
