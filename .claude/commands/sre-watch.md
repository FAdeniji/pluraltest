---
description: SRE sweep — check every watched project for breaking or soon-to-break issues, fix them on YYYYMMDD_HHMMSS_<summary> branches, run the PR quality gate, then ask before raising each PR
argument-hint: "[project-folder] (defaults to every project in .claude/sre-watchlist.md)"
---
Run an SRE sweep.

Projects: $ARGUMENTS. If none were given, use every project listed in `/Users/prus/Documents/GitHub/.claude/sre-watchlist.md`.

1. **Detect and fix.** Run the `sre` agent for each project, in parallel. Give each one the absolute repo path, the default branch and any deployed URLs from the watchlist.
2. **Quality gate.** For each branch the SRE produced, run the PR quality gate from `.claude/commands/orchestrate.md` inside that branch's worktree:
   1. `code-reviewer` and `security-auditor`, plus `privacy-compliance` if the project has it and the fix touches personal data
   2. `test-writer`, if it's needed
   3. `docs-writer`, if it's needed
   4. `playwright-tester`, if the project has a web frontend
   5. `pr-preparer`, using the PR title `YYYYMMDD_HHMMSS <Short summary of fix>`
3. **Ask for approval.** Show the user one table with a row per fix: project, branch, issue, severity, gate result and PR title. Ask which ones to raise. **Don't push or open any PR until the user approves that specific one.**
4. **Raise the approved PRs.** For each one:
   - push it with `git push -u origin <branch>`
   - run `gh pr create --base <default-branch> --head <branch> --title "<title>" --body-file <draft>`. End the body with "🤖 Generated with [Claude Code](https://claude.com/claude-code)".
   - report the PR links

   Leave the worktrees of rejected fixes in place, and tell the user how to remove them: `git worktree remove <path>` and `git branch -D <branch>`.
5. **Summarize the issues that were found but not fixed**, such as end-of-life runtimes or unhealthy endpoints, along with the recommended next action.

To keep this running in a local Claude Code session, use `/loop 12h /sre-watch`. It reruns the sweep every 12 hours while this Claude session is open. The central GitHub Actions workflow also runs the `sre-watch-runner` agent on each enabled project every 12 hours in read-only report mode.
