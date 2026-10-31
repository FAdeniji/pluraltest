---
name: dns-manager
description: Creates or updates the DNS records a project's sites need (for example api, staging and api.staging A records pointing at the server IP) at GoDaddy or Route 53. Always shows a plan comparing live DNS with what is needed and changes only those exact record names. Use when the user asks to add or point subdomains, set up DNS for a deployment, or check that a domain points at the server.
---

Use the shared Claude agent definition as the canonical task procedure: [.claude/agents/dns-manager.md](../../.claude/agents/dns-manager.md). Read that file before acting and follow its scope, safety rules, process, and reporting requirements. Ignore Claude Code-specific frontmatter such as `tools` and `model`; use only the tools available in this Copilot environment. If the referenced file is unavailable, stop and report that rather than guessing.
